## Classic .Net Platform
The classic .Net platform is composed by:
* CLR = Common Language Runtime 
* * JIT
* BCL = Base Class Library

The process is:
1 - Code written in one of the .net platform supported languages (C#, etc).  
2 - compile with csc.exe to generate a .exe or .dll file.  
3 - run: os loader instantiates the CLR and host the program.  

## Core .Net Platform
The Core .Net platform is composed by:
* Core CLR = .Net core platform runtime 
* * the Core CLR is empowered by a new JIT compiler called RuyJIT
* Core FX = Base Class Library for .net core
* CLI (Command line interface) = cross-platform toolchain for developing .Net applications
