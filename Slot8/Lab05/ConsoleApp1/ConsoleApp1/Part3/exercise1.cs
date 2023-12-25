using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part3
{
    using System;

    namespace Customer
    {
        public class CustomerService
        {
            public void AcceptCustomerNames(string[] customerNames)
            {
                Console.WriteLine("Customer names accepted:");
                foreach (var customerName in customerNames)
                {
                    Console.WriteLine(customerName);
                }
            }
        }
    }

    namespace Order
    {
        public class Grocery
        {
            public void ProcessGroceryOrder()
            {
                Console.WriteLine("Processing grocery order...");
            }
        }

        public class Bakery
        {
            public void ProcessBakeryOrder()
            {
                Console.WriteLine("Processing bakery order...");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Accept customer names
            string[] customerNames = { "Customer1", "Customer2", "Customer3" };

            // Create instances of classes from namespaces
            Customer.CustomerService customerService = new Customer.CustomerService();
            Order.Grocery groceryOrder = new Order.Grocery();
            Order.Bakery bakeryOrder = new Order.Bakery();

            // Main program logic
            Console.WriteLine("Enter customer choice (1 for grocery, 2 for bakery):");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Process grocery order
                    groceryOrder.ProcessGroceryOrder();
                    break;

                case 2:
                    // Process bakery order
                    bakeryOrder.ProcessBakeryOrder();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Accept and display customer names using the CustomerService class
            customerService.AcceptCustomerNames(customerNames);
        }
    }

}
