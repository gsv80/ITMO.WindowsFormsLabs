using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3C_2
{
    public class User : IComparable
    {
        protected string name;
        protected bool registered;
        public User(string name)
        {
            this.name = name;
        }
        public User()
        {
            registered = false;
        }
        public void Registered ()
        {
            registered = true;
        }

        public override string ToString()
        {
            return "User: "+name+"\n"+base.ToString();
        }
        public int CompareTo(object obj)
        {
            User user = (User)obj;
            if (this.name == user.name)
            {
                return 0;
            } 
            else return -1;
            //throw new NotImplementedException();
        }
    }
}
