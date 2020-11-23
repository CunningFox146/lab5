using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreLab5
{
    static class Logger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"LOGGER: {msg}");
        }

        public static void LogWarning(string msg)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            ConsoleColor consoleColorBG = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"LOGGER WARNING: {msg}");
            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = consoleColorBG;
        }

        public static void LogError(string msg)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            ConsoleColor consoleColorBG = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"LOGGER ERROR: {msg}");
            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = consoleColorBG;
        }
    }
}
