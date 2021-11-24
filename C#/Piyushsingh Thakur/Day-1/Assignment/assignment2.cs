/*Store your name in one string and find out how many vowel
  characters are there in your name.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class assignment2
    {
        static void Main(string[] args)
        {
            string name = "piyush";
            name = name.ToLower();
            int vowel = 0;

            for (int i = 0; i < name.Length; i++)
            {
                // Console.Write(name[i] + " ");
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    vowel++;
                }
            }

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Total Vowels : " + vowel);
        }
    }
}
