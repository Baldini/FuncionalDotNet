using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncionalConsole
{
    class TupleSample
    {
        public int FindMinMax(List<int> list, out int min)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            min = minimum;
            return maximum;
        }

        public void Run()
        {
            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();
            int minimum = 0, maximum = 0;

            maximum = FindMinMax(numbers, out minimum);
            Console.Write($"{minimum} is min and {maximum} is max in {String.Join(",", numbers)}");
            Console.Read();
        }


        public CalculateData FindMinMax1(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            CalculateData data = new CalculateData
            {
                Minimum = minimum,
                Maximum = maximum
            };
            return data;
        }


        public void Run1()
        {
            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();


            var result = FindMinMax1(numbers);
            Console.Write($"{result.Minimum} is min and {result.Maximum} is max in {String.Join(",", numbers)}");
            Console.Read();
        }

        public (int, int) FindMinMax2(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            return (minimum, maximum);
        }

        public void Run2()
        {
            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();


            var result = FindMinMax2(numbers);
            Console.Write($"{result.Item1} is min and {result.Item2} is max in {String.Join(",", numbers)}");
            Console.Read();
        }

        public Tuple<int, int> FindMinMax3(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            return new Tuple<int, int>(minimum, maximum);
        }

        public void Run3()
        {
            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();


            var result = FindMinMax3(numbers);
            Console.Write($"{result.Item1} is min and {result.Item2} is max in {String.Join(",", numbers)}");
            Console.Read();
        }


        public (int Minimum, int Maximum) FindMinMax4(List<int> list)
        {
            int maximum = int.MinValue, minimum = int.MaxValue;
            list.ForEach(n =>
            {
                minimum = n < minimum ? n : minimum;
                maximum = n > maximum ? n : maximum;
            });
            return (minimum, maximum);
        }

        public void Run4()
        {
            List<int> numbers = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).Take(10).ToList();


            var result = FindMinMax4(numbers);
            Console.Write($"{result.Minimum} is min and {result.Maximum} is max in {String.Join(",", numbers)}");
            Console.Read();
        }
    }

    struct CalculateData
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}
