using System;

class Program
{
    static void Main()
    {
        // Ввод первоначального массива строк
        string[] initialArray = { "Hello", "2", "world", ":-)" };
        // Либо можно использовать ввод с клавиатуры:
        // Console.WriteLine("Введите строки через пробел:");
        // string input = Console.ReadLine();
        // string[] initialArray = input.Split(' ');

        // Подсчет количества строк, длина которых меньше или равна 3 символам
        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] resultArray = new string[count];

        // Заполнение нового массива строками, удовлетворяющими условию
        int index = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("[" + string.Join(", ", initialArray) + "] → [" + string.Join(", ", resultArray) + "]");
    }
}