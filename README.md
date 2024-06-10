# XML Document Processor :gear:

This repository contains a C# console application demonstrating the use of the Strategy design pattern for flexible XML document processing. 

## Features :sparkles:

The program provides two concrete strategies:

* **LibraryAnalysisStrategy :books::** Analyzes library information such as authors, titles, keywords, etc. 
* **HtmlTransformationStrategy :computer::** Transforms an XML document into HTML format.

Users can choose the desired strategy and process an XML file with data. The program also ensures correct processing of Ukrainian characters :ukraine:.

## Usage :rocket:

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Change the path to your XML file in the `Main` method of the `Program` class.
4. Run the program.

## Technologies :computer:

* C#
* .NET Framework
* System.Xml.Linq

## Design Patterns :triangular_ruler:

* Strategy
