using System;

namespace pulsee.engine.Utils
{
    static class xConsole
    {
        //TODO
        //Faire un check sur l'environement, pour savoir si on affiche les infos ou quoi

        public static void Write(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
            return;
        }

        public static void Write(string text, MessageType mt)
        {
            Write(text, ColorMessageType(mt));
            return;
        }

        public static void WriteLine(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
            return;
        }

        public static void WriteLine(string text, MessageType mt)
        {
            WriteLine(text, ColorMessageType(mt));
            return;
        }

        public static int Read()
        {
            return Console.Read();
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void ClearLine(int num = 1)
        {
            Console.Write(new string('\r', num));
            return;
        }

        private static ConsoleColor ColorMessageType(MessageType mt)
        {
            switch (mt)
            {
                case MessageType.Warning:
                    return ConsoleColor.Yellow;
                case MessageType.Error:
                    return ConsoleColor.Red;
                case MessageType.Info:
                    return ConsoleColor.Cyan;
                default:
                    return ConsoleColor.White;
            }
        }
    }

    public enum MessageType
    {
        Warning,
        Error,
        Info
    }
}
