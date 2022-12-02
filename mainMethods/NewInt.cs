using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mainMethods
{
    public class NewInt
    {

        public int Math1(int one)
        {
            return one + 10;
        }

        public int Math1(decimal two)
        {
            return Convert.ToInt32(two + 9.9M);
        }

        public int Math1(string three)
        {
            int Three = Convert.ToInt32(three);
            return Three + 10;
        }


    }

}
