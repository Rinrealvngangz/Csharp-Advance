
using System.Collections.Generic;

namespace NullableType
{
    public static  class PartialComparer
    {
        public static  int? Compare<T>(T first, T second)
        {
            return Compare(Comparer<T>.Default, first, second);
        }
        public static  int? Compare<T>(IComparer<T> comparer , T first, T second)
        {
            int ret = comparer.Compare(first, second);
            return ret == 0 ? new int?() : ret;
        }

        public static int? ReferenceCompare<T>(T first, T second) where T : List<int>
        {
            return first.Count == second.Count ? 0
                : first == null ? -1
                : second == null ? 1
                : new int?() ;
        }
    }
}