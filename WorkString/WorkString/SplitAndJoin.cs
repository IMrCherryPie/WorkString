using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class SplitAndJoin
    {
        public static void Split(string str)
        {
            string[] simplesentences = str.Split('.');
            Console.WriteLine("Строка полученная при помощи Split");
            foreach (string s in simplesentences){
                Console.WriteLine(s);
            }
            
            string[] words = { "lorem", "exercitation", "adipiscing" };
            string str1 = String.Join("->", words, 0, words.Length);
            Console.WriteLine("Строка полученная при помощи Join");
            Console.WriteLine(str1);
        }
    }
}
