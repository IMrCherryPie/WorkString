using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringExample.Task1();
            Console.WriteLine(ArrayOfStrings.SumInWords("1234567890"));
            SplitAndJoin.Split("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            ExampleStringBuilder.TestStringBuilder();
            StringBuilder str = new StringBuilder ("1 Start string.");
            str.Append(" 2 Use Append.");
            Console.WriteLine(str.Insert(0 , "3 Use Insert. "));
            var str1 = str; 
            string sub = "new string ";
            for (int num = 0;num < 2; num++)
            {
                str1.AppendFormat(" {0}-> {1} ", num, sub);
            }
            Console.WriteLine(str1);
            Console.WriteLine("\nПросмотр текущей ёмкости и изменение ёмкости, последовательно начиная с str и заканчивая str1"); // Несмотря на то что мин размер 92
            Console.WriteLine("Текущая ёмкость: " + str.Capacity);
            Console.WriteLine("Максимальня ёмкость: " + str.MaxCapacity);
            Console.WriteLine("Пробуем сократить ёмкость до 5 и сразу видим текущую ёмкость: " + str.EnsureCapacity(5));
            Console.WriteLine("Ёмкость после попытки ужатия: " + str.Capacity);
            
            Console.WriteLine("\nТекущая ёмкость: " + str1.Capacity);
            Console.WriteLine("Максимальня ёмкость: " + str1.MaxCapacity);
            Console.WriteLine("Пробуем сократить ёмкость до 5 и сразу видим текущую ёмкость: " + str1.EnsureCapacity(5));
            Console.WriteLine("Ёмкость после попытки ужатия: " + str1.Capacity+"\n");
            ExampleCharArray.Start();

            TestSpeed.AddCharInString();

        }
    }
}
