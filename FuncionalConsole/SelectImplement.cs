using System;
using System.Collections.Generic;

namespace FuncionalConsole
{
    public static class SelectImplement
    {
        public static string[] GetTextFromFoo(Foo[] employees)
        {
            var result = new string[employees.Length];
            for (var i = 0; i < employees.Length; i++)
            {
                result[i] = employees[i].Text;
            }
            return result;
        }

        public static List<string> GetTextFromFoo1(List<Foo> employees)
        {
            var result = new List<string>(employees.Count);
            foreach (var employee in employees)
            {
                result.Add(employee.Text);
            }
            return result;
        }

        public static List<string> GetTextFromFoo2(List<Foo> employees)
        {
            var result = new List<string>(employees.Count);
            foreach (var employee in employees)
            {
                result.Add(employee.Text);
            }
            return result;
        }

        public static IList<string> GetTextFromFoo3(IList<Foo> employees)
        {
            var result = new List<string>(employees.Count);
            foreach (var employee in employees)
            {
                result.Add(employee.Text);
            }
            return result;
        }

        public static IEnumerable<string> GetTextFromFoo4(IEnumerable<Foo> employees)
        {
            foreach (var employee in employees)
            {
                yield return employee.Text;
            }
        }

        public static IEnumerable<string> GetText(IEnumerable<Foo> employees)
        {
            foreach (var employee in employees)
            {
                yield return employee.Text;
            }
        }

        public static IEnumerable<string> GetNames(
            this IEnumerable<Foo> employees
        )
        {
            foreach (var employee in employees)
            {
                yield return employee.Text;
            }
        }

        public static IEnumerable<TResult> Get<TResult>(
            this IEnumerable<Foo> foos,
            Func<Foo, TResult> selector
        )
        {
            foreach (var foo in foos)
            {
                yield return selector(foo);
            }
        }

        public static IEnumerable<TResult> Select<T, TResult>(
            this IEnumerable<T> elements,
            Func<T, TResult> selector
        )
        {
            foreach (var element in elements)
            {
                yield return selector(element);
            }
        }


    }


}
