using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class ExampleStringBuilder
    {
        public static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String – example of StringBuilder");
            StringBuilder str2 = new StringBuilder("String – example two of StringBuilder");
            Console.WriteLine("Test StringBuilder");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("Добавим в первую строку \"This new object\"");
            Console.WriteLine(str1.Append(" This new object"));
            Console.WriteLine(str2.Insert(0, "Test Function Insert "));
            Console.WriteLine(str2.Remove(0, 4));
            Console.WriteLine(str1.Replace("This new object", "Test Function Replase"));
            Console.WriteLine(str2.AppendFormat("","Test AppendFormat"));
        }
    }
}
