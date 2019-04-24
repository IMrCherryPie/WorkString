using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class ExampleCharArray
    {
        static char[] str1 = new char[] {'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!'};
        static string str2 = "Здравствуй, Мир!";
        static char[] str3 = new char[] {'l'};

        public static void Start()
        {
            PrintCharAr(str1);
            Console.WriteLine("Получаем индекс вхождения подстроки в строку");
            Console.WriteLine(IndexOfStr(str1,str3));

            Console.WriteLine("Получаем индекс Последнего вхождения подстроки в строку");
            Console.WriteLine(LastIndexOfStr(str1, str3));

            Console.WriteLine("Получение индексов вхождения подстроки в строку");
                Console.WriteLine((TestIndexSym("dffghfdslmlskgmsonv","f") == "") ? "Нет совпадений": TestIndexSym("dffghfdslmlskgmsonv", "f"));
        }

        private static void PrintCharAr(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]);
            }
            Console.WriteLine();
        }

        private static string CharArrayToString(char[] ch)
        {
            string s = "";
            for (int i = 0; i < ch.Length ; i++)
            {
                s += ch[i];
            }
            return s;
        }

        private static int IndexOfStr(char[] ch1, char[] ch2)
        {
            string s1 = CharArrayToString(ch1);
            string s2 = CharArrayToString(ch2);
            return s1.IndexOf(s2);
        }

        private static int LastIndexOfStr(char[] ch1, char[] ch2)
        {
            string s1 = CharArrayToString(ch1);
            string s2 = CharArrayToString(ch2);
            return s1.LastIndexOf(s2);
        }

        private static string TestIndexSym(string s1, string s2)
        {
            string sym = "";
            int find = s1.IndexOf(s2);
            while (find != -1)
            {
                sym += find + " ";
                find = s1.IndexOf(s2, find + 1);
            }
            return sym;
        }
    }
}
