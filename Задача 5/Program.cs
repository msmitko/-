using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    class Program
    {
        public static string ConvertNumberToWords(int Number)
        {
            StringBuilder word = new StringBuilder();
            var ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var units = new[] { "hundred" };

            if (Number >= 100 && Number < 1000)
            {
                word.Append(ones[Number / 100]);
                word.Append(" ");
                word.Append(units[0]);
                if ((Number % 100 / 10 == 0 ^ Number % 10 == 0) || (Number % 100 > 0 && Number % 100 < 20))
                {
                    word.Append(" and");
                }
            }

            if (Number % 100 > 0 && Number % 100 < 20)
            {
                if (Number >= 100)
                {
                    word.Append(" ");
                }
                word.Append(ones[Number % 100]);
            }
            else if (Number % 100 >= 20)
            {
                if (Number >= 100)
                {
                    word.Append(" ");
                }
                word.Append(tens[Number % 100 / 10]);

                if (Number % 10 > 0)
                {
                    word.Append("-");
                    word.Append(ones[Number % 10]);
                }
            }

            return word.ToString();
        }
    }
}

