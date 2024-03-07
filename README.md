# Using-Coroutines-in-the-UI-Test-task-

Test task during an interview:

Do in version 2021.3.21f1
In the assembly for android
Draw the interface. Start button, also known as stop button
Two indicators that can be either red, green or yellow. The original color is yellow.
Two text fields with an initial value of zero.
Given two coroutines.
After clicking Start, both coroutines are launched. The indicators turn red. The button is renamed Stop. One of the coroutines becomes the leader. Its indicator turns green. A timer is started with an arbitrary number of seconds from 10 to 20. The timer counts down to zero and writes the current value into the text field. The timer counts down to zero and writes the current value into the text field.
As soon as the timer reaches zero, the coroutine indicator turns red and control is transferred to another coroutine.
And so on in a cycle until the Stop button is pressed. When you click the Stop button, the indicators turn yellow, the values ​​in the text fields are 0, the button is renamed Start.

_____________________________________________________________________
Тестовое задание на собеседование: 

Делать в версии 2021.3.21f1
В сборке для android
Нарисовать интерфейс. Кнопка старт, она же стоп
Два индикатора, которые могут быть либо красными, либо зелеными, либо желтыми. Первоначальный цвет желтый.
Два текстовых поля с первоначальным значением ноль.
Дано две корутины. 
После нажатия Старт запускаются обе корутины. Индикаторы становятся красными. Кнопка переименовывается в Стоп. Одна из корутин становится ведущей. Ее индикатор становится зеленым. Запускается таймер с произвольным числом секунд от 10 до 20. Таймер отсчитывает к нулю и записывает текущее значение в текстовое поле.
Как только таймер доходит до нуля, индикатор корутины становится красным, управление передается другой корутине.
И так по циклу, пока не будет нажата кнопка Стоп. При нажатии кнопки Стоп, индикаторы становятся желтыми, значения в текстовых полях 0, кнопка переименовывается в Старт.
