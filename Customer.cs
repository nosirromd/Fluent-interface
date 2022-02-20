using System;
namespace Fluent_interface
{
    class Customer
    {
        private Context _context = new Context();

        public Customer FirstName(string firstName)
        {
            _context.FirstName = firstName;
            return this;
        }

        public Customer LastName(string lastName)
        {
            _context.LastName = lastName;
            return this;
        }

        public Customer Sex(string sex)
        {
            _context.Sex = sex;
            return this;
        }
        public Customer Address(string address)
        {
            _context.Address = address;
            return this;
        }

        public void Print()
        {
            Console.WriteLine($"First name: {_context.FirstName} \nLast name: {_context.LastName} \nSex: {_context.Sex} \nAddress: {_context.Address}");
        }
    }
}