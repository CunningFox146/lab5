using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    static class Logger
    {
        public static void Log(string type, string msg)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}] ({type}): {msg}");
        }

        public static void LogWarning(string msg)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            ConsoleColor consoleColorBG = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Log("WARNING", msg);
            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = consoleColorBG;
        }

        public static void LogError(string msg)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            ConsoleColor consoleColorBG = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Log("ERROR", msg);
            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = consoleColorBG;
        }
    }
}
