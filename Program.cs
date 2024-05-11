using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Формирование нового массива строк
        string[] newArray = FilterArray(originalArray);

        // Вывод нового массива на экран
        Console.WriteLine("Новый массив строк:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] array)
    {
        // Подсчет количества элементов, удовлетворяющих условию
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] result = new string[count];
        int index = 0;

        // Заполнение нового массива строками, удовлетворяющими условию
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}

