//using EFAssignment_Day12.Models;
//using Microsoft.EntityFrameworkCore;
//using System;

//namespace Assignment
//{
//    public class DisplayAddress
//    {
//        public void Display()
//        {
//            Console.WriteLine();

//            using (var context = new ToyManufacturingContext())
//            {
//                var dis = context.Addresses.FromSqlRaw("Select * from Addresses");

//                Console.WriteLine("\tId\tAddress\t\tCity\t\t\tPincode\t\tCustomer Id");
//                foreach (var item in dis)
//                {
//                    Console.WriteLine($"\t{item.AdId}\t{item.Address}\t{item.City + ", " + item.State}\t{item.Pincode}\t\t{item.CustId}");
//                }
//            }

//            Console.WriteLine();
//        }
//    }
//}