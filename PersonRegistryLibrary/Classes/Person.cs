using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegistryLibrary.Classes
{
        public abstract class Person : IComparable<Person>
        {
            protected string NewFirstName { get; set; }
            protected string NewLastname { get; set; }
            protected string Prefix { get; set; }

            public Person(string newprefix, string firstName, string lastName)
            {
                NewFirstName = firstName;
                NewLastname = lastName;
                Prefix = newprefix;
            }

            public virtual string GetFirstName()
            {
                return NewFirstName;
            }

            public virtual string GetLastName()
            {
                return NewLastname;
            }

            public virtual string GetPrefix()
            {
                return Prefix;
            }

            public abstract string ReturnName();

            int IComparable<Person>.CompareTo(Person other)
            {
                if (this.NewLastname == other.NewLastname)
                {
                    return this.NewFirstName.CompareTo(other.NewFirstName);
                }
                return this.NewLastname.CompareTo(other.NewLastname);
            }

            public static Person operator +(Person female, Person male)
            {
                return new Child("Child", female.NewFirstName, male.NewLastname);
            }
        }
    }
}
