using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar
{
    public class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Shrimp_Burger();
            Console.WriteLine("Bill no.1: " + order1.CountCost());

            var order2 = new Onion(new Cheese(new Shrimp_Burger()));
            Console.WriteLine("Bill no.2: " + order2.CountCost());

            var order3 = new Tomato(
                            new Chilli(
                                new Cucumber(
                                    new Onion(
                                        new Cheese(
                                            new Chicken_Burger())))));
            Console.WriteLine("Bill no.3: " + order3.CountCost());
        }
    }
}
