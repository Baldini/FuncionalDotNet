using System;
using System.Collections.Generic;

namespace FuncionalConsole
{
    public static class SelectImplement
    {
        #region .: Get :.
        public static IEnumerable<Foo> Get()
        {
            return new List<Foo>();
        }
        #endregion

        #region .: GetResult :.
        public static IEnumerable<TResult> GetResult<TResult>()
        {
            return new List<TResult>();
        }
        #endregion

        #region .: GetResultsExtensions :.
        public static IEnumerable<TResult> GetResultsExtension<TResult>(this IEnumerable<TResult> source)
        {
            foreach (var item in source)
            {
                yield return item;
            }
        }
        #endregion

        #region .: Select :.
        public static IEnumerable<TResult> MySelect<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (selector == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            return SelectImpl(source, selector);
        }
        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }
        #endregion
    }
}
