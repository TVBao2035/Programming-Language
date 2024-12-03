using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_6
{
    public class ArrayCalculator
    {
        public static int sumOfArray(int[] array, int length){
            if(length-1 == 0){
                return array[0];
            }
            return array[length-1] + sumOfArray(array, --length);
        }

        public static double sumOfArray(double[] array, int length){
            if(length - 1 == 0){
                return array[0];
            }
            return array[length-1] + sumOfArray(array, --length);
        }
    }
}