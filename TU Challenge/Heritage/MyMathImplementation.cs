using System.Diagnostics;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            List<int> sorted = new();
            while(toSort.Count > 0)
            {
                int value = toSort[0];
                foreach(int valueToCompare in toSort)
                {
                    if(isInOrder.Invoke(value, valueToCompare) == -1)
                    {
                        value = valueToCompare;
                    }
                }
                sorted.Add(value);
                toSort.Remove(value);
            }
            return sorted;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primaryList = new();
            for(int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    primaryList.Add(i);
                }
            }
            return primaryList;
        }

        public static bool IsDivisible(int a, int b)
        {
            return a%b == 0;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static int IsInOrder(int a, int b)
        {
            return a <= b ? (a == b ? 0 : 1) : -1;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            return -IsInOrder(arg1, arg2);
        }

        public static bool IsListInOrder(List<int> list)
        {
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i-1] > list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
                throw new ArgumentException();
            return age >= 18;
        }

        public static bool IsPrimary(int el)
        {
            for(int i = 2; i<el; i++)
            {
                if (el % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int pow = a;
            for(int i = 1; i<b; i++)
            {
                a *= pow;
            }
            return a;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            while (!IsListInOrder(toSort))
            {
                for(int i = 0; i<toSort.Count-1; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        int temp = toSort[i + 1];
                        toSort[i + 1] = toSort[i];
                        toSort[i] = temp;
                    }
                }
            }
            return toSort;
        }
    }
}
