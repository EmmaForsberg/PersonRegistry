namespace PersonRegistryLibrary.Classes
{
    public class Child : Person
    {
        public Child(string newprefix, string firstName, string lastName) : base(newprefix, firstName, lastName)
        { }

        public override string ReturnName()
        {
            return Prefix + " " + NewFirstName + " " + NewLastname;
        }
    }
}