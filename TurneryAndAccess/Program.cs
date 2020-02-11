using System;

namespace TurneryAndAccess {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine($"Cube is {Cubed(17)}");
            Console.WriteLine($"Next Id is {Customer.PrintNextId()}");

            var cust1 = new Customer ("Max Techincal Training");
            Console.WriteLine(cust1);
            //ToString done behind the scenes. cust1.ToString
            
            var cust2 = new Customer("Amazon");
            Console.WriteLine(cust2);
            var cust3 = new Customer("Google");

            cust1.NationalAccount("yes");

            var order1 = new Order { Amount = 1000, Customer = cust1 };
            var order2 = new Order { Amount = 150, Customer = cust2 };
            var order3 = new Order { Amount = 500, Customer = cust3 };
            
            
        }

   
        static int Cubed(int nbr) {
            return nbr * nbr * nbr;
        }
    }
}
