using lesson7;
using Microsoft.Win32.SafeHandles;
using static System.Runtime.InteropServices.JavaScript.JSType;
var clsMethod = new lesson7.math();
var clsArray = new lesson7.math();
while (true)
{
    Console.WriteLine("Введите количество элементов в массиве и сами элементы:");
    double[] array = { };
    array = clsArray.GetArray(array);
    Console.WriteLine("Введите функцию ( max min  count sum factorial):\nИли оператор (+ - / * %:");
    string oper = Console.ReadLine();
    if (oper == "sum")
    {

        Console.WriteLine($"Результат сложения: {clsMethod.sum(array)}");
    }

   
    else if (oper == "count")
    {

        Console.WriteLine($"Длинна вашего массива: {clsMethod.count(array)}");
    }
    else if (oper == "max")
    {

        Console.WriteLine($"Максимальный элемент вашего массива: {clsMethod.max(array)}");
    }
    else if (oper == "min")
    {

        Console.WriteLine($"Минимальный элемент вашего массива: {clsMethod.min(array)}");
    }
    else if (oper == "factorial")
    {
        Console.WriteLine($"Фвкториал вашего числа в массиве : {clsMethod.factorial(array)}");

    }

    else
    {
        Console.WriteLine("Введите оператор из списка!");
    }
    if (oper == "exit")
    {
        break;
    }
}
    

