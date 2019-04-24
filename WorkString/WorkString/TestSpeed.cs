using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkString
{
    class TestSpeed
    {
        public static void AddCharInString()
        {
            int i = 0;
            int z = 50000;
            string s = "";
            StringBuilder s1 = new StringBuilder();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (i < z)
            {
                s += " ";
                i++;
            }
            // the code that you want to measure comes here
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            Console.WriteLine("Время выполнения добавления символа в строку " + z + " раз "+ elapsedMs / 1000f+ " ms");

            i = 0;
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            while (i < z)
            {
                s1.Append(" ");
                i++;
            }
            // the code that you want to measure comes here
            watch.Stop();
            elapsedMs = watch1.ElapsedMilliseconds;
            Console.WriteLine("Время выполнения добавления символа в строку " + z + " раз " + elapsedMs / 1000f + " ms");
        }
    }
}
