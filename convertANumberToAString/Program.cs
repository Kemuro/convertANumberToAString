using System;

namespace convertANumberToAString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We need a function that can transform a number into a string.
             * What ways of achieving this do you know?
             * 
             * Examples:
             * 123 --> "123"
             * 999 --> "999"  */

        }
        public class Kata
        {
            public static string NumberToString(int num)
            {
                //code here
                string numToString = num.ToString();

                return numToString;

                //passed codewars test

                //could have also used:
                //return num.ToString();
            }
        }
    }
}
