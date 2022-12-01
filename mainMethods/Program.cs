using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NewInt one = new NewInt() { Value = 29, Valuedec = 29.9M, Valuestr = "30"};


            Console.WriteLine("In 10 years, I will be "+ one.Math1(one));
            Console.WriteLine("This must add decimals and return an integer: " + one.Math2(one));
            Console.WriteLine("This must take a string, convert to int and return the result of a math operation: " + one.Math3(one));
            Console.ReadLine();


        }
    }
}
