using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_cs.easy
{
    internal class Maximum69Number
    {
        public static int GetMaximum69Number(int num)
        {
            string text = num.ToString();
            int maxNumber = num;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                string remove = text.Remove(i, 1);

                string add = (c == '9') ? remove.Insert(i, "6") : remove.Insert(i, "9");

                if (int.Parse(add) > maxNumber)
                {
                    maxNumber = int.Parse(add);
                }
            }

            return maxNumber;
        }

        public static void main()
        {
            int num = 9669;

            Console.WriteLine(GetMaximum69Number(num));
        }
    }
}
