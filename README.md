# MBED Logic Analyzer

## Install
  Use an MBED toolchain to compile the MBED code for your board. Clone the repo and use Visual Studio 2019 with at least .NET Framework 4.7.2 to compile the desktop app. 
  If the MBED code does not compile, the code can be imported into the compiler from the following link:
  https://os.mbed.com/users/EricGlunn/code/4180Project_All_Features/
## Demo and Presentation videos
  Demo: https://youtu.be/PdgsSM5gjTE 
  
  Presentation: 
  
## Repo administration info  
The desktop app is written in C# with the MBED app written in C++. The repo is licensed under the MIT license, and contributions are welcomed and encouraged. Please either use a pull request or the issues tab as needed for features or bugs. 

## What the program does 
A technical document describing program functionality and design is the Overleaf Software Explanation.pdf file on this repo.
The program has four different options:

### Analog
The analog screen allows the viewing of an analog value from 0-3.3 V in both test and bargraph form.

### Digital
The digital screen allows the viewing of digital status of circuits.

### Scope
The scope screen provides the interface to view an analog signal, from 0 to 3.3V, over different time scales up to 1 s.

### I2C
The I2C screen provides an interface to view an I2C SDA line. Tooltips are added to view hexadecimal information for the appropriate data chunks.

## Compatibility
The program has been tested on Windows 10, .NET framework 4.7.2, with a MBED NXP LPC1768. However, other MBED platforms and other OSes that support .NET could work, but they have not been tested.
