using System;
namespace ConsoleApp7
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address
        {
            get;
            set;
        }
    }
}
