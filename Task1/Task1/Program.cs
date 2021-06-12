using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int count = (new DateTime(DateTime.Now.Year, month, day) - DateTime.Now).Days;
            if (count < 0)
            {
                Console.WriteLine($"Left until the birthday {365+count}");
            }
            else
            {
                Console.WriteLine($"Left until the birthday {count}");
            }
        }
    }
}