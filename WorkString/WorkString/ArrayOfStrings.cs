using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class ArrayOfStrings
    {
        public static string SumInWords(string str)
        {
            string output = "";
            string[] ar1 = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            foreach (char ch in str)
            {
                string s = ch.ToString();
                output += ar1[(int.Parse(s))] + " ";
            }
            return output + "Рублей";
        }
    }
}
