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

        if (a == c || b == c) 
        {
            Console.WriteLine("такая цифра есть");
        }
        else 
        {
            Console.WriteLine("такой цифры нет");
        }
    }
}