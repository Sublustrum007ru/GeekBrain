## Синтаксис и команды для работы с языком программирования C#

* **dotnet new** -  Команда создаетпроект в папке в которой мы находимся. Этой команде мы передаем какой проект мы создаем, самое частое это "console". Получается такая команда "dotnet new console" мы говорим что создаваемый проект будет представлять консольное приложение.

* **dotnet run** - эта команда запускает проект. Вводим ее в командной строке/терминале.

<br>

* **Console.Write();** - Инструкция которая выводит данные в консоль/терминал.
* **Console.WriteLine();** - Инструкция которая выводит данные в консоль/терминал, с последующим переходм на новую строку.
* **Console.ReadLine();** - Инструкция которая принимает данные из консоли/терминала.

<br>

* **while** - Инструкция **while** выполняет оператор или блок операторов, пока определенное логическое выражение равно значению **true**. Так как это выражение оценивается перед каждым выполнением уикла, цикл **while** выполняется ноль или несколько раз. 
   * while (условие)
     {
         Тело цикла
     }
     * условие - раздел в котором определяется, следует ли выполнять следующую итерацию в цикле. Если значение **true** равно или нет, выполняется следующая итерация; в противном случае цикл завершается. Раздел условие должен быть логическим выражением.
     * тело цикла - должно быть оператором или блоком операторов.

<br>

* **for** - Инструкция **for** выполняет оператор или блок операторов, пока определенное логическое выражение равно значению **true**. 
  
  * for (инициализатор; условие; итератор){
    тело цикла
  }
    * инициализатор - выполняется только один раз при входе в цикл. Как правило, в этом раделе обьявляется и инициализируется локальная переменная цикла. Доступ к объявленной переменной извне оператор **for** невозможен.
    * условие - раздел в котором определяется, следует ли выполнять следующую итерацию в цикле. Если значение **true** равно или нет, выполняется следующая итерация; в противном случае цикл завершается. Раздел условие должен быть логическим выражением.
    * итератор - раздел который определяет, что происходит после каждого выполнения тела цикла.
    * тело цикла - должно быть оператором или блоком операторов.

<br>

* **if if/else и switch** - Операторы **if if/else и switch** выбирают операторы для выполнения из множества возможных путей на основе значения выражения. Оператор **if** выполняет оператор только в том случае, если предствленное логическое выражение имеет значение **true**. Оператор **if-else** позволяет выбрать, какой из двух путей кода следует использовать на основе логического выражения. Инструкиция **switch** выбирает список инструкций для выполнения на основе сопоставления шаблона с выражением.

<br>

* **int** - оператор указывает что пепеменная является целочисленным типом. Тип **int** это диапозон числе от - 2 147 483 648 до 2 147 483 648, 32-разрядное целое число со знаком.

<br>

* **string** - С точки зрения регулярного программирования строковый тип данных **string** относится к числу самых важных в **C#**. Этот тип определяет и поддерживает символьные строки. В целом ряде других языков программирования строка представляет собой массив символов. А в **C#** строки являются объектами. Следовательно, тип **string** относится к числу ссылочных.
