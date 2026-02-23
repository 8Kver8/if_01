using System;

namespace FirstApp
{
    public class Logic
    {
        public static string CheckDigit(int num, int c)
        {
            int a = num / 10;
            int b = num % 10;

            if (a == c || b == c)
            {
                return "такая цифра есть";
            }
            else
            {
                return "такой цифры нет";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("введите двузначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите цифру: ");
            int c = Convert.ToInt32(Console.ReadLine());

            string result = Logic.CheckDigit(num, c);

            Console.WriteLine(result);
        }
    }
}