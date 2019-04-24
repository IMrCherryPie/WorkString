using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class StringExample
    {
        private static string str1 = "test gonvdls fdlg;k;  dgf";
        private static string str2 = new string('s',5);
        private static char[] charray = {'t','e','s','t'};
        private static string str3 = new string(charray);

        public static void Task1()
        {
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 != str2);
            Console.WriteLine(str1 == str3);
            Console.WriteLine(str2);
            Console.WriteLine(str1 + ' ' + str2);
            Console.WriteLine(str2 += ' ' + Regex.Replace(str1, "test ", String.Empty));
        }
    }
}
