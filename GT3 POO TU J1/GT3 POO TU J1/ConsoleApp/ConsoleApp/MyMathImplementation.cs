using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int i, int i1) => i + i1;

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
                throw new ArgumentException();
            
            return age >= 18;
        }

        public static bool IsEven(int i)
        {
            return i % 2 == 0;
        }

        public static bool IsDivisible(int i, int i1)
        {
            return i % i1 == 0;
        }

        public static bool IsPrimary(int i)
        {
            if(i <= 1)
                return false;


            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                    return false;
            }

            return true;
        }

        public static List<int> GetAllPrimary(int i)
        {
            List<int> list = new List<int>();

            
            for (int j = 0; j <= i; j++)
            {
                if (IsPrimary(j))
                    list.Add(j);
            }

            return list;
        }

        public static int Power2(int i)
        {
            return i * i;
        }

        public static int Power(int n, int n1)
        {
            int result = n;
            for (int i = 1; i < n1; i++)
            {
                result *= n;
            }

            return result;
        }

        public static int IsInOrder(int i, int i1)
        {
            return i<i1 ? 1 : i>i1 ? -1 : 0;
        }

        public static bool IsListInOrder(List<int> p0)
        {
            for (int i = 0; i < p0.Count - 1; i++)
            {
                if (p0[i] > p0[i + 1])
                    return false;
            }

            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            for (int i = 1; i < toSort.Count; i++)
            {
                int j = i;
                while (j >= 1)
                {
                    if (toSort[j] > toSort[j - 1])
                        break;

                    else
                    {
                        (toSort[j], toSort[j - 1]) = (toSort[j - 1], toSort[j]);
                        j--;
                    }
                }
            }
            return toSort;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            for (int i = 1; i < toSort.Count; i++)
            {
                int j = i;
                while (j >= 1)
                {
                    if (isInOrder.Invoke(toSort[j-1], toSort[j]) == 1)
                        break;

                    else
                    {
                        (toSort[j], toSort[j - 1]) = (toSort[j - 1], toSort[j]);
                        j--;
                    }
                }
            }
            return toSort;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            return arg1 > arg2 ? 1 : arg1 < arg2 ? -1 : 0;
        }
    }
}
