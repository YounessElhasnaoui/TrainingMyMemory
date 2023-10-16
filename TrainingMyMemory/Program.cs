using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_My_Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("I/O training\nEnter input text : ");
            string inputText = Console.ReadLine();
            Console.WriteLine("your input is : " + inputText);
            Console.WriteLine("Casting :");
            Console.Write("Enter your age : ");
            string stringAge = Console.ReadLine();
            int intAge = Int32.Parse(stringAge);
            Console.WriteLine("Your integer age is : " + intAge);
            Console.WriteLine("Some string Cheat sheets :");
            String str1 = "first string";
            string str2 = "second string";
            string conatainer = $"str 1 = {str1} \n str 2 = {str2}";
            //Console.WriteLine()



        }
    }
}