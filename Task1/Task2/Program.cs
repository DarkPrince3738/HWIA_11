using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter.Print("Red flower", ConsolePrinter.OutputColors.Red);
            ConsolePrinter.Print("Green flower", ConsolePrinter.OutputColors.Green);
            ConsolePrinter.Print("Blue flower", ConsolePrinter.OutputColors.Blue);
            ConsolePrinter.Print("Black flower", ConsolePrinter.OutputColors.Black);
            ConsolePrinter.Print("Yellow flower", ConsolePrinter.OutputColors.Yellow);
            ConsolePrinter.Print("White flower", ConsolePrinter.OutputColors.White);

            Console.ReadKey(true);
        }
    }
    static class ConsolePrinter
    {
        public enum OutputColors 
        { 
            
            Red = 4, 
            Green = 2, 
            Blue = 1,
            Black = 0,
            Yellow = 6,
            White = 7
        }

        public static void Print(string text, OutputColors outputColor)
        {
            Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(outputColor);
            Console.WriteLine(text);
        }
    }
}
