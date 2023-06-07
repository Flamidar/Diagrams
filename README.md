# Diagrams
The created program can be used to build and visualize columnar, piecewise linear, pie charts.

## Tools used
The software is implemented in the Microsoft Visual Studio 2019 programming environment in the C# programming language using the Windows platform Forms.NET Framework.

## Description of algorithms and functions: 
### button1_Click:
Creates points in the graph array. Reads and interprets the data entered in the textBox, from Text to Double. After the iteration, it displays the entered data in the form of a diagram on the program interface. Initializes and shows an error when no data is entered.
### Add a filetoolstripmenuitem_click
Adds data to the program from the selected text file with the extension.txt and UTF-8 encoding.
### textBox_X_KeyPress
A check that allows you to enter into the textbox, X coordinates, only numbers, commas, cons and backspace.
### textBox_Y_KeyPress
A check that allows you to enter into the textbox, Y coordinates, only numbers, commas, cons and backspace.
### textBox1_KeyPress
A check that allows you to enter into the textbox, numbers, only numbers, commas, cons and backspace.
### checkText
The function checks the data being entered for compliance with the correct data for error-free operation.
### circulatoolstripmenuitem_click
Opens a circular form of the builder program type.
### Piecewise straighttoolstripmenuitem_click
Opens the form of the piecewise linear type of the builder program.
### Columnar toolstripmenuitem_click
Opens a column-type form of the builder program.
### cleartoolstripmenuitem_click
Clears the current interface of the builder program from all diagrams, allowing you to create a new diagram.
### logouttoolstripmenuitem_click
Displays the message "Exit?", giving the option to choose Yes or No. After selecting “Yes” – closes the program. After selecting “No”, it allows you to continue working in the builder.
### main:
Generates the first application window. A form for creating histograms is launched.



## Annotation
The Diagram Builder program is intended for use on a home PC in order to study the construction and appearance of diagrams. To use the program, basic skills of working with a personal computer are required.

## Using the app
1) Running the program
In order to start the program, you need to make a quick double-click with the left mouse button on the application icon.
2) Changing the type of chart builder
If the user wants to build a different type of charts, he needs to click on the “Change chart type” button, select the desired type and click on the button with it. Each button is responsible for opening the corresponding builder form.
3) Data recording
In the “Create ...” fields, the user can enter their numerical values to create their chart. These fields are located in the upper right part of the user interface.
4) Data entry via file
To enter data for the chart, the user needs to click on the “Menu” button, then click “Add from file". This action takes data from a text file with an extension .txt and UTF-8 encoding, allowing you to create a diagram with a large number of points.
5) Clearing the chart
To clear the chart, the user needs to click on the “Menu” button, then click “Clear". This action clears the current interface of the builder program from all diagrams, allowing you to create a new diagram.
6) Closing the program
After working in the program, the user can close it in two ways. First, through a separate “Exit” button, after pressing which the message "Exit?" is displayed, giving the option to choose “Yes” or “No". After selecting “Yes” – closes the program. After selecting “No”, it allows you to continue working in the builder. And the second way is by clicking on the button in the upper right corner of the screen.
