using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException();
            }
            else
            {
                return age >= 18;
            }
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsDivisible(int a, int b)
        { 
            return (a / b) % 1 == 0;
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2 || a == 3)
                return true;

            if (a <= 1 || a % 2 == 0 || a % 3 == 0)
                return false;

            for (int i = 5; i * i <= a; i += 6)
            {
                if (a % i == 0 || a % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primeNumbersList = new List<int>();
            for(int i = 0; i < a; i++)
            {
                if(IsPrimary(i))
                primeNumbersList.Add(i);
            }
            return primeNumbersList;
        }

        public static int Power2(int a)
        {
            return a*a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for(int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b) return 1;
            else if (a > b) return -1;
            else if (a == b) return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static object Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }

        public static object GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }
    }
}
