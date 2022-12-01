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
        public int Value { get; set; }
        public decimal Valuedec { get; set; }
        public string Valuestr { get; set; }

        public int Math1(NewInt one)
        {
            return one.Value+10;
        }

        public decimal Math2(NewInt one)
        {
            return Convert.ToInt32(one.Valuedec + 1.2M);
        }

        public string Math3(NewInt one)
        {
            Convert.ToInt32(one.Valuestr);
            return one.Valuestr + 1;
        }


    }

}
