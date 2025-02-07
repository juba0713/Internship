using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class CalculatorMethods
    {
        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        public static float Multiply(float x, float y)
        {
            return x * y;

        }

        public static float Divide(float x, float y)
        {
            if (y == 0)
            {
                return 0;
            }

            return x / y;
        }
    }
}
