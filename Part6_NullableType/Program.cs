using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int avaiableTickets;
            // To make nullable type
            int? ticketOnSale = null;

            // Coalesce operator
            avaiableTickets = ticketOnSale ?? 0;

            Console.WriteLine($"Available tickets = {avaiableTickets}");
        }
    }
}
