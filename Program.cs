using System;

namespace Fluent_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            c1.FirstName("DC").LastName("Morrison").Sex("Man").Address("Greenford").Print();
        }
    }
}
