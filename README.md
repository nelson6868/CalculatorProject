# CalculatorProject:is a class library for simple mathematical operations.

##Installation
Install Visual Studio 2022 for Windows with a .NET Core-related workload.
You can install the 2022 Community edition for free from visualstudio.microsoft.com, or use the Professional or Enterprise edition.
##Prerequisites
An understanding of C# and NuGet Packages
Visual Studio
##Usage
You can install this NuGet package into any .NET project if that package supports the same target framework as the project. To use CalculatorProject in your project, kindly follow these steps:

Installation using Visual Studio
In the Solutions Explorer of your project, Right-click on project dependencies

Select manage Nuget packages

From the Browse tab, search for SmartCalc, select it in the list, and then select Install.

To install our package using the .NET CLI, run: dotnet add package CalculatorProject --version 1.0.1
In your project, simply instantiate the operations class before usage.
Sample
This is a sample of a mathematical operation in the package:

```public int Addition(int a, int b)
        {
            return a + b;
        } ```     
Each method takes in two (2) parameters of type int and returns a value of type int too.

##Demonstration
