using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "c# is Object Oriented Program";
            Console.WriteLine("Enter second number");
            int num2_int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter decimal number");
            double num2_double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter additional sentence");
            string second_str = Console.ReadLine();
            Console.WriteLine(i + num2_int);
            Console.WriteLine(d + num2_double);
            Console.WriteLine(s + second_str);
            Console.ReadLine();
            
        }
    }
}
