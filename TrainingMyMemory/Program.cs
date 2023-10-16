using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_My_Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input/output
            Console.Write("I/O training\nEnter input text : ");
            string inputText = Console.ReadLine();
            Console.WriteLine("your input is : " + inputText);

            // Variable casting
            Console.WriteLine("Casting :");
            Console.Write("Enter your age : ");
            string stringAge = Console.ReadLine();
            int intAge = Int32.Parse(stringAge);
            Console.WriteLine("Your integer age is : " + intAge);

            //String stuff
            Console.WriteLine("Some string Cheat sheets :");
            String str1 = "first string";
            string str2 = "second string";
            string conatainer = $"str 1 = {str1} \nstr 2 = {str2}";
            Console.WriteLine(conatainer);
            Console.WriteLine("the first char in str1 is (" + str1[0] + ")");
            string specialString = "My name is \"Youness\"";
            Console.WriteLine(specialString);

            //Conditions 

            Console.Write("Enter a number : ");
            int x = Console.Read();
            if (x < 0)
            {
                Console.WriteLine("Your number is negative");

            }
            else if(x > 0)
            {
                Console.WriteLine("Your number is positive");

            }
            else
            {
                Console.WriteLine("Your number is NULL");
            }
        }
    }
}