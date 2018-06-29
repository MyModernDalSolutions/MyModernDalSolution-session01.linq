using System;
using System.Collections.Generic;

namespace Session01.Begining
{
    public static class MyLinqExtentions
    {
        public static IEnumerable<T> Where2<T>(this IEnumerable<T> input,Func<T, bool> func)
        {
            List<T> list = new List<T>();
            foreach (var item in input)
            {
                if (func(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// this method used Deffered execution-
        /// dont use it-
        /// harder error exception-
        /// and ....
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> MyWhere2<T>(this IEnumerable<T> input, Func<T, bool> func)
        {
            
            foreach (var item in input)
            {
                if (func(item))
                {
                   yield return item;
                }
            }
            
        }
    }
}
