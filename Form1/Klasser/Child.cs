using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Klasser
{
    class Child : Person
    {
        public Child(string newprefix, string firstName, string lastName) : base(newprefix, firstName, lastName)
        { }
        
        public override string ReturnName()
        {
            return Prefix + " " + NewFirstName + " " + NewLastname;
        }
    }
    
}
