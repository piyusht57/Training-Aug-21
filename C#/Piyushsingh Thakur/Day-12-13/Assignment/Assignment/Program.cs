using EFAssignment_Day12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Toy{
        //adding customer
        public void Add()
        {
            DisplayState displayState = new DisplayState();

            Console.WriteLine();

            // Enter new data from user
            Console.Write("Enter First Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            string lname = Console.ReadLine();
            Console.Write("Enter Gender : ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter DOB : ");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            long phone = Convert.ToInt64(Console.ReadLine());

            using (var context = new ToyManufacturingContext())
            {
                // Add data in Table
                var cust = new Customers() { FirstName = fname, LastName = lname, Gender = gender, DOB = dt, Email = email, PhoneNumber = phone };
                context.Add(cust);

                // Displays State of Entity
                displayState.State(context.ChangeTracker.Entries());

                context.SaveChanges();
            }

            Console.WriteLine();
        }

        //deleting customer
        public void Delete()
        {
            Console.WriteLine();

            DisplayState displayState = new DisplayState();

            int id;

            // User input for which data to delete
            Console.Write("Enter ID to be deleted : ");
            id = Convert.ToInt32(Console.ReadLine());

            using (var context = new ToyManufacturingContext())
            {
                // Deleting the specified data 
                var del = context.Customers.Single(c => c.CustId == id);
                context.Remove(del);

                // Displays State of Entity
                displayState.State(context.ChangeTracker.Entries());

                context.SaveChanges();
            }

            Console.WriteLine();
        }

        //displaying customer
        public void Display()
        {
            using (var context = new ToyManufacturingContext())
            {
                Console.WriteLine();

                var dis = context.Customers.FromSqlRaw("Select * from Customers");

                Console.WriteLine("\tId\tName\t\tGender\tDOB\t\tPhone Number\tEmail");
                foreach (var item in dis)
                {
                    Console.WriteLine($"\t{item.CustId}\t{item.FirstName + " " + item.LastName}\t{item.Gender}\t{item.DOB.ToShortDateString()}\t{item.PhoneNumber}\t{item.Email}");
                }

                Console.WriteLine();
            }
        }

        //updateing customer
        public void Update()
        {
            DisplayState displayState = new DisplayState();

            Console.WriteLine();

            Console.Write("Enter id for which id to update : ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Enter new data from user for updating
            Console.Write("Enter First Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            string lname = Console.ReadLine();
            Console.Write("Enter Gender : ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter DOB : ");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            using (var context = new ToyManufacturingContext())
            {
                // Update data in table
                var update = context.Customers.Single(c => c.CustId == id);
                update.FirstName = fname;
                update.LastName = lname;
                update.PhoneNumber = phoneNumber;
                update.Gender = gender;
                update.DOB = dt;
                update.Email = email;

                // Displays State of Entity
                displayState.State(context.ChangeTracker.Entries());

                context.SaveChanges();
            }

            Console.WriteLine();
        }

        //placeing order
        public void Order()
        {
            DisplayState displayState = new DisplayState();

            Console.WriteLine();

            Console.WriteLine("Toy Table : ");
            DisplayToys displayToys = new DisplayToys();
            displayToys.Display();

            //Console.WriteLine("Customer Table : ");
            //DisplayCustomer displayCustomer = new DisplayCustomer();
            //displayCustomer.Display();

            //Console.WriteLine("Address Table : ");
            //DisplayAddress displayAddress = new DisplayAddress();
            //displayAddress.Display();

            List<int> idList = new List<int>();
            int id;

            Console.Write("Number of Toys to order : ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Toy Id {i + 1} : ");
                id = Convert.ToInt32(Console.ReadLine());
                idList.Add(id);
            }

            Console.Write("Enter Customer Id : ");
            int custId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address Id : ");
            int addId = Convert.ToInt32(Console.ReadLine());

            using (var context = new ToyManufacturingContext())
            {
                double totalPrice = 0.00;

                // Adding Price
                foreach (var item in idList)
                {
                    var price = context.Toys.Where(t => t.ToyId == item).Select(t => t.Amount);
                    foreach (double item2 in price)
                    {
                        Console.WriteLine(item2);
                        totalPrice += item2;
                    }
                }

                var add = new Orders() { OrderDate = System.DateTime.Now, Items = count, Price = totalPrice, CustId = custId, AdId = addId };
                context.Orders.Add(add);

                // Displays State of Entity
                displayState.State(context.ChangeTracker.Entries());

                context.SaveChanges();

                var scheme = context.Orders.FromSqlRaw($"exec Scheme {totalPrice}").ToList();
                Console.WriteLine("Scheme on order : ");
                foreach (var item in scheme)
                {
                    Console.WriteLine($"Order Id : {item.OrderId}, Price : {item.Price}");
                }

                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
              int ch;
            bool endApp = false;

            while (endApp == false)
            {
                Console.WriteLine("Enter 1 for Adding new Customer");
                Console.WriteLine("Enter 2 for Updating a particular Customer");
                Console.WriteLine("Enter 3 for Deleting a particular Customer");
                Console.WriteLine("Enter 4 to view all Customers");
                Console.WriteLine("Enter 5 to place an order");
                Console.WriteLine("Enter 6 to exit");
                Console.Write("Enter your choice : ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Toy addCustomer = new Toy();
                        addCustomer.Add();

                        break;
                    case 2:
                        Toy updateCustomer = new Toy();
                        updateCustomer.Update();
                        break;
                    case 3:
                        Toy deleteCustomer = new Toy();
                        deleteCustomer.Delete();
                        break;
                    case 4:
                        Toy displayCustomer = new Toy();
                        displayCustomer.Display();
                        break;
                    case 5:
                        Toy placeOrder = new Toy();
                        placeOrder.Order();
                        break;
                    case 6:
                        endApp = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
