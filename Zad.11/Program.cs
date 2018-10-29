using System;


namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Вашата възраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" След 10 години ще сте на: {0}", age + 10);
        }
    }
}
