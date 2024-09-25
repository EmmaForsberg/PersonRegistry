using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Classes
{
    public class Male : Person
    {
        public Male(string newprefix, string firstName, string lastName) : base(newprefix, firstName, lastName)
        {
        }

        public override string ReturnName()
        {
            return Prefix + " " + NewFirstName + " " + NewLastname;
        }     
    
    }
}
