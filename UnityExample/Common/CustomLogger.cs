using System;

namespace UnityExample.Common
{
    public static class CustomLogger
    {
        public static void Information(string msg)
        {
            Console.WriteLine($"{DateTime.Now}:[Information]:{msg}");
        }

        public static void Verbose(string msg)
        {
            Console.WriteLine($"{DateTime.Now}:[Verbose]:{msg}");
        }

        public static void Warning(string msg)
        {
            Console.WriteLine($"{DateTime.Now}:[Warning]:{msg}");
        }

        public static void Error(string msg)
        {
            Console.WriteLine($"{DateTime.Now}:[Error]:{msg}");
        }

        public static void Exception(Exception ex, string msg = "")
        {
            if (!string.IsNullOrEmpty(msg))
            {
                Console.WriteLine($"{DateTime.Now}:[Exception]:{msg}");
            }

            Console.WriteLine(ex);
        }
    }
}
