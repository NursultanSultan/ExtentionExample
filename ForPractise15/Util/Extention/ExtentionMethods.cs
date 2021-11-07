using System;
using System.Collections.Generic;
using System.Text;

namespace ForPractise15.Util.Extention
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int number)
        {
            if(number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsContainsDigit(this string str)
        {
            bool check = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 48 && str[i] < 57)
                {
                    check = true;
                }
            }

            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public static string IsCaptalize(this string str)
        {

            return char.ToUpper(str[0]) + str.Substring(1);

            
        }


        public static int[] GetValueIndex(this string str , char charackter)
        {
            int count = 0;
            int[] arr = new int[0];
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == charackter)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    
                    arr[count] = i;
                    count++;
                }
            }
            
            return arr;

        }

    }
}
