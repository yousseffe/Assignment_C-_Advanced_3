using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Assignment_C__Advanced_3
{
    internal class ListFunctions
    {
        public static bool Exists<T>(List<T> list , Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");
            foreach (var item in list)
            {
                if (predicate(item)) return true;

            }
            return false;
        }

        public static T? Find<T>(List<T> list, Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");
            foreach(var item in list)
            {
                if (predicate(item)) return item;
            }
            //throw new ArgumentException("No Item Match");
            return default(T);
        }

        public static List<T> FindAll<T>(List<T> list, Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");

            List<T> result = new List<T>();
            for (var i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    result.Add(list[i]);

                }
            }
            return result;
        }

        public static int FindIndex<T>(List<T> list, Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");

            for (var i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static T? FindLast<T>(List<T> list, Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");
            for (var i = list.Count - 1; i >= 0; i++)
            {
                if (predicate(list[i]))
                {
                    return list[i];
                }
            }
            //throw new ArgumentException("No Item Match");
            return default(T);
        }

        public static int FindLastIndex<T>(List<T> list, Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("delegate can not be null");

            for (var i = list.Count-1; i >= 0; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static void ForEach<T>(List<T> list, Action<T> action)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (action == null) throw new NullReferenceException("Action can not be null");

            foreach (var item in list)
            {
                action(item);
            }
        }
        public static bool TrueForAll<T>(List<T> list , Predicate<T> predicate)
        {
            if (list == null) throw new NullReferenceException("List can not be null");

            if (predicate == null) throw new NullReferenceException("Predicate can not be null");

            foreach (var item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
