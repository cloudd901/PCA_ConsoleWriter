using PCAFFINITY;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = 'x';
            while (ans == 'x')
            {
                ans = RunTest();
            }
        }

        private static char RunTest()
        {
            Console.Clear();

            ConsoleWriter cw = new ConsoleWriter();

            string test = "".PadRight(Console.BufferWidth - 1, '+');

            cw.WriteLineAnimated("".PadRight(Console.BufferWidth - 1, '+'), 20, null, ConsoleColor.Red, AnimationType.GarbledRandom);

            string welcome = "This is my Console Writer script.";
            int padding = ((Console.BufferWidth - 1) / 2) + (welcome.Length / 2);
            welcome = welcome.PadLeft(padding);

            cw.WriteLineAnimated(welcome, 150, null, ConsoleColor.Red, AnimationType.GarbledRandom);
            cw.WriteLineAnimated("");
            Thread.Sleep(500);

            cw.TextColorExplicit = ConsoleColor.Black;
            cw.BackgroundColor = ConsoleColor.Gray;

            cw.WriteLineAnimated("Written by Derrick Ducote for PC Affinity.", 40);
            Thread.Sleep(500);

            cw.GarbledCharacterString = "#";
            cw.BackgroundColor = ConsoleColor.Blue;

            cw.WriteLineAnimated("These are a few examples of it's usage.", 80, null, null, AnimationType.GarbledLinear)
                .WriteLineAnimated("Please use it responsibly.", 90, null, null, AnimationType.GarbledRandom);
            Thread.Sleep(500);

            cw.BackgroundColor = ConsoleColor.Black;
            cw.WriteLineAnimated("");

            cw.WriteAnimated("Stacking animations/colors: ", 1, ConsoleColor.White, ConsoleColor.Red, AnimationType.SlideIn)
                .WriteAnimated("1", 100, ConsoleColor.Blue)
                .WriteAnimated("2", 100, ConsoleColor.Green)
                .WriteAnimated("3", 100, ConsoleColor.Yellow)
                .WriteAnimated("4", 100, ConsoleColor.Magenta)
                .WriteAnimated("5", 100, ConsoleColor.Red)
                .WriteAnimated("6", 100, ConsoleColor.Blue)
                .WriteAnimated("7", 100, ConsoleColor.Green)
                .WriteAnimated("8", 100, ConsoleColor.Yellow)
                .WriteAnimated("9", 100, ConsoleColor.Magenta)
                .WriteLineAnimated("0", 100, ConsoleColor.Red);
            Thread.Sleep(500);

            cw.WriteLineAnimated("");

            cw.WriteAnimated("Press ", 10, ConsoleColor.Green, ConsoleColor.Blue)
                .WriteAnimated("Any Key", 10, ConsoleColor.White, ConsoleColor.Blue)
                .WriteLineAnimated(" to exit.", 10, ConsoleColor.Green, ConsoleColor.Blue);
            cw.WriteAnimated("Press ", 10, ConsoleColor.Green, ConsoleColor.Blue)
                .WriteAnimated("'x'", 10, ConsoleColor.White, ConsoleColor.Blue)
                .WriteLineAnimated(" to repeat.", 10, ConsoleColor.Green, ConsoleColor.Blue);

            return Console.ReadKey().KeyChar;
        }
    }
}
