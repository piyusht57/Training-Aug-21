//Print sum of all the even numbers

using System;

namespace Assignment
{
    class assignment1
    {
       public static void Main(string[] args)
        {
            int i, num, sum = 0;

            // Reading number
            Console.Write("Enter the range of even number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num; i += 2)
            {
                //Adding current even number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);

            Console.ReadLine();
        }
    }
}
