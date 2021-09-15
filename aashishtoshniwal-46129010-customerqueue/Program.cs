using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aashishtoshniwal_46129010_customerqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentDone;
            string name;
            string email;
            long phone;
            bool entryDone=false;
            Queue<CustomerDetails> customerlist = new Queue<CustomerDetails>();
            do
            {
                Console.WriteLine("Enter Customer Details");
                Console.Write("Name: ");
                name = Console.ReadLine();
                if (name == "done")
                {
                    break;
                }
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Phone: ");
                phone = long.Parse(Console.ReadLine());
                CustomerDetails cust = new CustomerDetails(name, email, phone);
                if (customerlist.Contains(cust))
                {
                    Console.WriteLine("Customer Already Exists");
                }
                else
                {
                    customerlist.Enqueue(cust);
                    Console.WriteLine("Customer Queued");
                }
            } while (entryDone!=true);

           /* CustomerDetails customer1 = new CustomerDetails("aashish", "aashish@gmail.com", 8790485829);
            CustomerDetails customer2 = new CustomerDetails("max", "max@gmail.com", 9701005621);
            CustomerDetails customer3 = new CustomerDetails("bill", "bill@gmail.com", 879053453);
            customerlist.Enqueue(customer1);
            customerlist.Enqueue(customer2);
            customerlist.Enqueue(customer3);
            CustomerDetails newcustomer = new CustomerDetails("bill", "bill@gmail.com", 879053453);

            if (customerlist.Contains(newcustomer))
            {
                Console.WriteLine("Customer Already Exists");
            }
            else
            {
                customerlist.Enqueue(newcustomer);
                Console.WriteLine("Customer Added to the Queue");
            }

            */


            //Check Appointment
            do
            {
                    Console.WriteLine(customerlist.Peek());
                Console.WriteLine("Appointment Completed?");
                    appointmentDone = Console.ReadLine();
                    if (appointmentDone == "Yes")
                    {
                        customerlist.Dequeue();
                    }
            } while (customerlist.Count != 0);
            Console.WriteLine("All Appointments done");
            

        }
    }
}
