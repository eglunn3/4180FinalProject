#include "mbed.h"
 
#define reset       0b00000000      //Define function masks
#define digital     0b00100000
#define analog      0b01000000
#define I2C         0b01100000
#define oScope      0b10000000
 
#define stateMask   0b11100000      //general masks
#define pinMask     0b00011111
#define FULL        0b11111111
 
#define pin1        0b00010000      //digital and analog masks
#define pin2        0b00001000
#define pin3        0b00000100
#define pin4        0b00000010
#define pin5        0b00000001
 
#define ms1         0b00000000      //Oscope masks
#define ms5         0b00000001
#define ms10        0b00000010
#define ms50        0b00000011
#define ms100       0b00000100
#define ms250       0b00000101
#define ms500       0b00000110
#define ms1000      0b00000111
#define rise        0b00010000
#define fall        0b00000000
#define timeMask    0b00000111
#define triggerType 0b00010000
#define triggerVolt 0b00001000
#define volt11      0b00000000
#define volt22      0b00001000
 
DigitalOut myled(LED1);
DigitalOut DigitalStatus(LED2);         //Led for when Digital read is running
DigitalOut AnalogStatus(LED3);          //LED for when Analog read is running
DigitalOut oScopeStatus(LED4);          //LED for Oscilloscope
 
DigitalIn  d1(p21);                     //Always set these pins for digital in
DigitalIn  d2(p22);
DigitalIn  d3(p23);
DigitalIn  d4(p24);
DigitalIn  d5(p25);
 
 
AnalogIn   a1(p16);                     //Always set these pins for analog in
AnalogIn   a2(p17);
AnalogIn   a3(p18);
AnalogIn   a4(p19);
AnalogIn   a5(p20);
 
 
Serial PC(USBTX,USBRX);
Ticker tickerboi;                   //Initialize the ticker for Sampling
 
Ticker oScopeTicker;
Ticker oScopeCut;
 
volatile unsigned char DigitalSample;
volatile unsigned char AnalogSample[5];
 
volatile unsigned char command;
volatile unsigned char state;
 
volatile bool newDigital=false;
volatile bool newAnalog=false;
 
volatile unsigned char oScopeTime;
volatile bool oScope_poll;
volatile bool newoScope=false;
volatile unsigned char oScopeArray[20000];
volatile int oScopeCount=0;
volatile unsigned char oScopeTriggerType;
volatile unsigned char oScopeTriggerVoltageBit;
volatile unsigned char oScopeTriggerVoltageVal;
 
volatile bool analogRunning;
volatile bool oScopeRunning;
volatile bool digitalRunning;
 
 
void digital_sample_func(void)          //sampling function, samples each pin specified and Ors it
{
    DigitalSample = digital;
 
    if( (command & pin1) == pin1) {
        DigitalSample=DigitalSample + d1*pin1;
    }
    if( (command & pin2) == pin2) {
        DigitalSample=DigitalSample + d2*pin2;
    }
    if( (command & pin3) == pin3) {
        DigitalSample=DigitalSample + d3*pin3;
    }
    if( (command & pin4) == pin4) {
        DigitalSample=DigitalSample + d4*pin4;
    }
    if( (command & pin5) == pin5) {
        DigitalSample=DigitalSample + d5*pin5;
    }
    newDigital=true;
}
 
 
void analog_sample_func(void)
{
    for(int i=0; i<5; i++) {
        AnalogSample[i]=0;
    }
    if( (command & pin1) == pin1) {
        AnalogSample[0]=a1*254;
    }
    if( (command & pin2) == pin2) {
        AnalogSample[1]=a2 * 254;
    }
    if( (command & pin3) == pin3) {
        AnalogSample[2]=a3*254;
    }
    if( (command & pin4) == pin4) {
        AnalogSample[3]=a4*254;
    }
    if( (command & pin5) == pin5) {
        AnalogSample[4]=a5*254;
    }
    newAnalog=true;
}
 
 
void oScope_kill_func(void)
{
    oScopeTicker.detach();
    oScopeCut.detach();
    newoScope=true;
    oScopeRunning=0;
}
 
void oScope_sample_func(void){
    oScopeArray[oScopeCount++]=a1*254;
}
 
void oScope_poll_trig(){
    bool nTriggered = true;
    myled=1;
    unsigned char trig;
    int state =0;
    if(oScopeTriggerVoltageBit == volt11){oScopeTriggerVoltageVal=85;}
    else{oScopeTriggerVoltageVal=169;}
    
    while(nTriggered){
        
        trig=a1*254;
        switch(state){
            
            case 0:
                if((trig < oScopeTriggerVoltageVal) & (oScopeTriggerType == rise)  ){state = 1;}
                else if((trig > oScopeTriggerVoltageVal) & (oScopeTriggerType == fall) ){state = 2;}
                else { state = 0;}
                break;
            case 1:
                if(trig < oScopeTriggerVoltageVal){state=1;}
                if(trig > oScopeTriggerVoltageVal){state=3;}
                break;
            case 2:
                if(trig > oScopeTriggerVoltageVal){state = 2;}
                if(trig < oScopeTriggerVoltageVal){state = 3;}
                break;
            case 3:
                nTriggered=false;
                break;
        }        
        wait(.01);
    } 
    myled=0;
    switch(oScopeTime) {
    
    case ms1:
        oScopeCut.attach(oScope_kill_func, .001);
        break;
    
    case ms5:
        oScopeCut.attach(oScope_kill_func, .005);
        break;
    
    case ms10:
        oScopeCut.attach(oScope_kill_func, .01);
        break;
    
    case ms50:
        oScopeCut.attach(oScope_kill_func, .05);
        break;
    
    case ms100:
        oScopeCut.attach(oScope_kill_func, .1);
        break;
    
    case ms250:
        oScopeCut.attach(oScope_kill_func, .25);
        break;
    
    case ms500:
        oScopeCut.attach(oScope_kill_func, .5);
        break;
    
    case ms1000:
        oScopeCut.attach(oScope_kill_func, 1);
        break;
    default:
        oScopeCut.attach(oScope_kill_func, .01);
        break;
    }   
    
    oScopeTicker.attach_us(oScope_sample_func, 50);
    
}
 
 
void SerialInterrupt(void)
{
    command=PC.getc();
    state= command & stateMask;
    
    switch(state) {
        case reset:
            tickerboi.detach();             //detach Ticker
            digitalRunning=0;                //turn off status LED
            analogRunning=0;
            
            if(oScopeRunning){
                oScope_kill_func();
            }
            
            break;
 
        case digital:
            tickerboi.attach(&digital_sample_func, .5);
            digitalRunning=1;               // turn on status LED
            break;
 
        case analog:
            tickerboi.attach(&analog_sample_func, .5);
            analogRunning=1;
            break;
 
        case oScope:
            oScopeTime=command & timeMask;
            oScope_poll=true;
            oScopeRunning=1;
            oScopeTriggerType= command & triggerType;
            oScopeTriggerVoltageBit = command & triggerVolt;
            break;
    }
}
 
int main()
{
    PC.attach(&SerialInterrupt, Serial::RxIrq);
    
 
    while(1) {
 
        DigitalStatus=digitalRunning;
        AnalogStatus=analogRunning;
        oScopeStatus=oScopeRunning;
 
        if(newDigital) {                           //if digital sampling was run
            PC.putc(DigitalSample);
            newDigital=false;
        }
 
        if(newAnalog) {                        //if analog sampling was run
            PC.putc(FULL);                     //First bit is 0b01000000
            for(int i=0; i<5; i++) {           //Send all of the analog bits
                PC.putc(AnalogSample[i]);
            }
            PC.putc(command);                     //Last bit is command from PC
            newAnalog=false;
        }
        
        if(oScope_poll){ 
            oScope_poll=false;
            oScope_poll_trig(); }
        
        if(newoScope){
            PC.putc(FULL);
            for(int j=0; j<oScopeCount; j++){
                PC.putc(oScopeArray[j]);
            }
            oScopeCount=0;
            newoScope=false;    
        }
        
 
        myled = 1;                             //indicate main loop is running
        wait(0.2);
        myled = 0;
        wait(0.2);
    }
}
