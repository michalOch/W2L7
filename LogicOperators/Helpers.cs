using System;
using System.Collections.Generic;
using System.Text;

namespace LogicOperators
{
    public static class Helpers
    {
        public static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        public static int FindMin(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
    }

    public enum WeekDay
    {
        Unassigned = 0,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

}
