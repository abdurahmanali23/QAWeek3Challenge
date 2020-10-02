using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToStringConverter
{
    class Converter
    {


        public static void intToString(int x)
        {

            String result = "";
            String[] zeroToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };
            String[] twentyToNinenty = { "", "", " twenty", " thirty", " fourty", " fifty", " sixty", " seventy", " eighty", " ninety" };

            if (x > 9999)
            {
                Console.WriteLine("Number cannot be greater than 9999");
            }

            if (x == 0)
            {
                result += "zero";
            }
            if (x >= 20000 && x <= 9999)
            {
                result = zeroToNineteen[x / 10000] + " thousand";
                x %= 10000;

            }

            if (x>= 1000)
            {
                result = zeroToNineteen[x / 1000] + " thousand";
                x %= 1000;
            }

            if (x>= 100)
            {
                result += zeroToNineteen[x / 100] + " hundred";
                x %= 100;
            }

            if (x >= 20)
            {
                result += "" + twentyToNinenty[x / 10];
                x %= 10;
            }

            if (x >= 1)
            {
                result += zeroToNineteen[x];
            }

            
            Console.WriteLine(result);

        }

    }

}







       
