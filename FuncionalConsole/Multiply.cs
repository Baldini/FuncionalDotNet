using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionalConsole
{
    public static class ExtensionsMultiply
    {
        public static int MultiplyBy2(this int value)
        {
            return value * 2;
        }

        public static class MultpilicationFormatter
        {
            static int counter;

            static string Counter(int val) => $"{++counter} x 2 = {val}";

            public static List<string> Format(List<int> list)
                => list
                 .Select(ExtensionsMultiply.MultiplyBy2)
                 .Select(Counter)
                 .ToList();
        }

        public static class MultpilicationFormatterParallel
        {
            static int counter;

            static string Counter(int val) => $"{++counter} x 2 = {val}";

            public static List<string> Format(List<int> list)
            => list.AsParallel()
                     .Select(ExtensionsMultiply.MultiplyBy2)
                     .Select(Counter)
                     .ToList();
        }
        public static void Run()
        {
            var list = MultpilicationFormatter.Format(Enumerable.Range(1, 10).ToList());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void RunParallel()
        {
            var list = MultpilicationFormatterParallel.Format(Enumerable.Range(1, 10).ToList());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
