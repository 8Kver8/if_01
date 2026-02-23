using System;

class Program
{
    static void Main()
    {
        Console.Write("введите двузначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("введите цифру: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int a = num / 10;
        int b = num % 10;
        string result;

        if (a == c || b == c)
        {
            result = "такая цифра есть";
        }
        else
        {
            result = "такой цифры нет";
        }

        Console.WriteLine(result);
    }
}