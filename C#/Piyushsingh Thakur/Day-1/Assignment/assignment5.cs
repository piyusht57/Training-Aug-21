using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class assignment5
    {
        public static void Main(string[] args)
        {
            int age;

            Console.Write("Enter age to check eligibility : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((age > 18) ? "Eligible for voting" : "Not eligible for voting");
        }
    }
}
