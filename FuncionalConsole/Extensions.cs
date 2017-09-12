using System;
using System.Collections.Generic;
using System.Text;

namespace FuncionalConsole
{
    public static class Extensions
    {
        public static Func<T, TResult> MeasuringTime<T, TResult>(this Func<T, TResult> func)
        {
            return (input) =>
            {
                var before = DateTime.Now;
                var result = func(input);
                Console.WriteLine("Time to this input: {0}", DateTime.Now - before);
                return result;
            };
        }

        public static Func<T, TResult> PrintingResult<T, TResult>(this Func<T, TResult> func)
        {
            return (input) =>
            {
                var result = func(input);
                Console.WriteLine("Input: {0} Result: {1}", input, result);
                return result;
            };
        }
    }
}
