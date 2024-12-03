using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_5
{
    public class Math
    {
        public static int abs(int number)
        {
            return  number < 0 ? number * -1 : number;
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int min(int num1, int num2)
        {
            return num1 < num2 ? num1 : num2;
        }

        public static int max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public static int pow(int num1, int num2)
        {
            if(num2 == 1)
            {
                return num1;
            }
            return num1 * pow(num1, --num2);
        }

    }

}