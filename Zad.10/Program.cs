using System;


namespace Zad._10
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("{0}", -i);
                }
            }
        }
    }
}
