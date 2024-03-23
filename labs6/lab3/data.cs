using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class data
    {
        Random randomValue;
        public data() 
        {
            randomValue = new Random();
        }
        public data(int t)
        {
            randomValue= new Random(t);
        }
        public int random(int t)
        {
            int res = randomValue.Next(t);
            return res;
        }

    }
}
