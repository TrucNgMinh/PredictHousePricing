Requirement:
•	Windows 10 64-bit: Pro, Enterprise, or Education (Build 15063 or later).
•	Visual Studio 2019: Pro, Enterprise, or Education (Version 16.11.0 or later).
Part 1: Install ML.NET
•	Open the Visual Studio Installer and Modify the instance of Visual Studio that you'd like to use with Model Builder.
•	Select the optional ML.NET Model Builder (Preview) component in any of the .NET workloads (such as .NET cross-platform development).
 
•	In Visual Studio, go to Tools > Options > Environment > Preview Features.
•	Select Enable ML.NET Model Builder.
 

Part 2: Install Node.js
•	Go to Download | Node.js (nodejs.org) and choose version 14.17.6 (includes npm 6.14.15).
•	Follow the instructions on the installation wizard to accept the license, authorize the installer, and proceed with the install.
•	Open a window terminal and type ‘node -v’ to check whether Node.js is installed on your system or not.

Part 3: Install the Angular CLI
•	To install the Angular CLI, open a terminal window and run the following command:
-	npm install -g @angular/cli@11.2.3
•	Open a window terminal and type ‘ng --version’ to check whether Angular CLI is installed on your system or not.

Part 4: Build the application
1.	Copy folder “SOURCE” from cd to computer. 
2.	Use Visual Studio 2019 to open the server-side project.
3.	Press build button on Visual Studio 2019.
4.	The website is running at https://localhost:44306/.
5.	Open a window terminal and navigate to the client-side project. (~\HousePricePrediction\PricePredictClient)
6.	Type “ng serve --open” to build the front-end project.
7.	The website is running at https://localhost:4200/.