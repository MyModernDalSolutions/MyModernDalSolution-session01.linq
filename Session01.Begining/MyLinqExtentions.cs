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
    }
}
