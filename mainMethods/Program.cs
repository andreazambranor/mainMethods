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
            int one = 19;
            NewInt One = new NewInt();

            decimal two = 29.1M;
            NewInt Two =  new NewInt ();

            string three = "39";
            NewInt Three = new NewInt();

            

            Console.WriteLine("In 10 years, I will be "+ One.Math1(one));
            Console.WriteLine("This must add decimals and return an integer: " + Two.Math1(two));
            Console.WriteLine("This must take a string, convert to int and return the result of a math operation: " + Three.Math1(three));
            Console.ReadLine();


        }
    }
}
