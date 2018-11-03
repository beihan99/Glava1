
// Направете програма, която прочита от конзолата вашата възраст и изписва (също на конзолата) каква ще бъде вашата възраст след 10 години.

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
