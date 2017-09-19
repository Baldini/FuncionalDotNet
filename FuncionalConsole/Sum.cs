using System;
using System.Linq;
using System.Threading.Tasks;


namespace FuncionalConsole
{
    public class Sum
    {
        public static void Run1()
        {
            var numbers = Enumerable.Range(start: -10000, count: 20001)
                .Reverse()
                .ToList(); // 10000 ... 0 ... -10000
            Console.WriteLine(numbers.Sum());
            numbers.Sort();
            Console.WriteLine(numbers.Sum());
        }

        public static void Run2()
        {
            var numbers = Enumerable.Range(start: -10000, count: 20001)
                .Reverse()
                .ToList(); // 10000 ... -10000
            void Task1() => Console.WriteLine(numbers.Sum());

            void Task2()
            {
                numbers.Sort();
                Console.WriteLine(numbers.Sum());
            }

            Parallel.Invoke(Task1, Task2);

        }

        public static void Run3()
        {
            var numbers = Enumerable.Range(start: -10000, count: 20001)
                .Reverse()
                .ToList(); // 10000 ... -10000
            void Task1() => Console.WriteLine(numbers.Sum());

            void Task2()
            {
                var ordered = numbers.OrderBy(n => n);
                Console.WriteLine(ordered.Sum());
            }

            Parallel.Invoke(Task1, Task2);
        }
    }
}
