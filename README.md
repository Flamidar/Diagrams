# Диаграммы
Созданная программа может быть использована для построения и визуализации столбчатых, кусочно-линейных, круговых диаграмм.

## Используемые инструменты
ПО реализовано в среде программирования Microsoft Visual Studio 2019 на языке программирования C# с использованием платформы Windows Forms.NET Framework.

## Описание алгоритмов и функций:
### button1_Click:
Создаёт точки в массиве графика. Читает и интерпретирует данные введенные в textBox, из Text в Double. После итерации отображает на интерфейсе программы введенные данные в виде диаграммы. Инициализирует и показывает ошибку при не введенных данных.
### добавитьИзФайлаToolStripMenuItem_Click
Добавляет данные в программу из выбранного текстового файла с расширением .txt и кодировкой UTF-8. 
### textBox_X_KeyPress
Проверка, позволяющая вводить в текстбокс, координат X, только цифры, запятые, минусы и бэкспейс.
### textBox_Y_KeyPress
Проверка, позволяющая вводить в текстбокс, координат Y, только цифры, запятые, минусы и бэкспейс.
### textBox1_KeyPress
Проверка, позволяющая вводить в текстбокс, чисел, только цифры, запятые, минусы и бэкспейс.
### checkText
Функция проверяет, вбиваемые данные на соответствование верным данным для безошибочной работы.
### круговаяToolStripMenuItem_Click
Открывает форму кругового типа программы построителя.
### кусочнолинейнаяToolStripMenuItem_Click
Открывает форму кусочно-линейного типа программы построителя.
### столбчатаяToolStripMenuItem_Click
Открывает форму столбчатого типа программы построителя.
### очиститьToolStripMenuItem_Click
Очищает текущий интерфейс программы построителя от всех диаграмм, позволяя создать новую диаграмму.
### выходToolStripMenuItem_Click
Высвечивает сообщение "Выйти?", предоставляя возможность выбора Да или Нет. После выбора “Да” – закрывает программу. После выбора “Нет” позволяет дальше работать в построителе. 
###main:
Генерирует первое окно приложения. Запускается форма для создания гистограмм.



## Аннотация
Программа Построитель диаграмм предназначена для использования на домашнем ПК с целью изучения построения и внешнего вида диаграмм. Для использования программы требуются базовые навыки работы с персональным компьютером.
## Использование приложения
1) Запуск программы
Для того чтобы запустить программу, требуется совершить быстрое двойное нажатие левой кнопкой мыши по значку приложения.
2) Смена типа построителя диаграмм
Если пользователь хочет построить другой вид диаграмм, ему нужно нажать на кнопку “Сменить тип диаграмм”, выбрать нужный тип и нажать на кнопку с ним. Каждая кнопка отвечает за открытие соответствующей формы построителя. 
3) Запись данных
В полях “Создание …” пользователь может вписать свои численные значения для создания своей диаграммы. Эти поля расположены в правой верхней части пользовательского интерфейса.
4) Ввод данных через файл
Для  ввода данных для диаграммы пользователю нужно нажать на кнопку “Меню”, затем нажать “Добавить из файла”. Это действие берет данные из текстового файла с расширением .txt и кодировкой UTF-8, позволяя создавать диаграмму с большим количеством точек.
5) Очистка диаграммы
Для очистки диаграммы пользователю нужно нажать на кнопку “Меню”, затем нажать “Очистить”. Это действие очищает текущий интерфейс программы построителя от всех диаграмм, позволяя создать новую диаграмму.
6) Закрытие программы
После работы в программе, пользователь может закрыть ее двумя способами. Первым, через отдельную кнопку “Выход”, после зажатия на которую высвечивается сообщение "Выйти?", предоставляя возможность выбора “Да” или “Нет”. После выбора “Да” – закрывает программу. После выбора “Нет” позволяет дальше работать в построителе. И вторым способом – по кнопке в верхнем правом углу экрана.

ENG---

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
