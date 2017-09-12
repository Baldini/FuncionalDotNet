using System;

namespace FuncionalConsole
{
    public static class Fibo
    {
        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Run()
        {
            Console.WriteLine("Starting...");
            var f30 = Fibonacci(30);
            var f35 = Fibonacci(35);
            var f40 = Fibonacci(40);
            var f45 = Fibonacci(45);
            Console.WriteLine("Results: {0}, {1}, {2}, {3}", f30, f35, f40, f45);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        public static void Run2()
        {
            Func<int, int> fibonacci = Fibonacci;
            Console.WriteLine("Starting...");
            var f30 = fibonacci(30);
            var f35 = fibonacci(35);
            var f40 = fibonacci(40);
            var f45 = fibonacci(45);
            Console.WriteLine("Results: {0}, {1}, {2}, {3}", f30, f35, f40, f45);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        public static void Run3()
        {
            Func<int, int> fibonacci = Fibonacci;
            Console.WriteLine("Starting...");
            var f30 = fibonacci(30);
            Console.WriteLine("Input: {0} Result: {1}", 30, f30);
            var f35 = fibonacci(35);
            Console.WriteLine("Input: {0} Result: {1}", 35, f35);
            var f40 = fibonacci(40);
            Console.WriteLine("Input: {0} Result: {1}", 40, f40);
            var f45 = fibonacci(45);
            Console.WriteLine("Input: {0} Result: {1}", 45, f45);
            Console.WriteLine("Results: {0}, {1}, {2}, {3}", f30, f35, f40, f45);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        public static void Run4()
        {
            Console.WriteLine("Starting...");
            var fibonacci = ((Func<int, int>)Fibonacci)
                .PrintingResult()
                .MeasuringTime();

            var f30 = fibonacci(30);
            var f35 = fibonacci(35);
            var f40 = fibonacci(40);
            var f45 = fibonacci(45);
            Console.WriteLine("Results: {0}, {1}, {2}, {3}", f30, f35, f40, f45);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
