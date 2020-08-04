using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {
        public static List<IComparable> Sort(List<IComparable> source)
        {
            return SortRecur(source);
        }

        private static List<IComparable> SortRecur(List<IComparable> source)
        {
            if (source.Count <= 1)
                return source;
            var left = SortRecur(source.Take(source.Count / 2).ToList());
            var right = SortRecur(source.Skip(source.Count / 2).Take(source.Count).ToList());
            return Merge(left, right);
        }

        public static List<IComparable> Merge(List<IComparable> lhs, List<IComparable> rhs)
        {
            int lhsIndex = 0, rhsIndex = 0;
            List<IComparable> result = new List<IComparable>();
            while (lhsIndex <= lhs.Count || rhsIndex <= rhs.Count)
            {
                IComparable left = lhs[lhsIndex];
                IComparable right = rhs[rhsIndex];
                if (lhs[lhsIndex].CompareTo(rhs[rhsIndex]) <= 0)
                {
                    result.Add(lhs[lhsIndex]);
                    lhsIndex++;
                }
                else
                {
                    result.Add(rhs[rhsIndex]);
                    rhsIndex++;
                }
                if (lhsIndex >= lhs.Count)
                {
                    result.AddRange(rhs.Skip(rhsIndex).Take(rhs.Count));
                    return result;
                }
                if (rhsIndex >= rhs.Count)
                {
                    result.AddRange(lhs.Skip(lhsIndex).Take(lhs.Count));
                    return result;
                }
            }
            return result;
        }
    }
}
