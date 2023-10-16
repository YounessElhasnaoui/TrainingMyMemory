using System;

namespace Training_My_Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. I/O training");
                Console.WriteLine("2. Variable casting");
                Console.WriteLine("3. String cheat sheets");
                Console.WriteLine("4. Conditions");
                Console.WriteLine("5. Loops");
                Console.WriteLine("6. Array stuff");
                Console.WriteLine("7. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            IO();
                            break;
                        case 2:
                            variableCasting();
                            break;
                        case 3:
                            stringstuff();
                            break;
                        case 4:
                            conditions();
                            break;
                        case 5:
                            loops();
                            break;
                        case 6:
                            arraystuff();
                            break;
                        case 7:
                            Console.WriteLine("Exiting the program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        // Input/output
        static void IO()
        {
            Console.Write("I/O training\nEnter input text : ");
            string inputText = Console.ReadLine();
            Console.WriteLine("Your input is : " + inputText);
        }

        // Variable casting
        static void variableCasting()
        {
            Console.WriteLine("Casting :");
            Console.Write("Enter your age : ");
            string stringAge = Console.ReadLine();
            int intAge = Int32.Parse(stringAge);
            Console.WriteLine("Your integer age is : " + intAge);
        }

        // String cheat sheets
        static void stringstuff()
        {
            Console.WriteLine("Some string Cheat sheets :");
            String str1 = "first string";
            string str2 = "second string";
            string container = $"str 1 = {str1} \nstr 2 = {str2}";
            Console.WriteLine(container);
            Console.WriteLine("The first char in str1 is (" + str1[0] + ")");
            string specialString = "My name is \"Youness\"";
            Console.WriteLine(specialString);
        }

        // Conditions
        static void conditions()
        {
            Console.Write("Enter a number : ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Your number is NULL");
            }
            else if (x > 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else
            {
                Console.WriteLine("Your number is negative");
            }
        }

        // Loops
        static void loops()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                else if (i == 2)
                    continue;
                Console.WriteLine($"This is the instruction N{i}");
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"i = {j}");
                j++;
            }
        }

        // Array stuff
        static void arraystuff()
        {
            Console.Write("List size (int) : ");
            int len = int.Parse(Console.ReadLine());

            string[] objs = new string[len];

            int indx = 0;
            while (indx < len)
            {
                Console.Write($"{indx + 1}: Obj = ");
                objs[indx] = Console.ReadLine();
                indx++;
            }

            Console.Write("The list is = ");
            foreach (string obj in objs)
                Console.Write(obj + "\t");
        }
    }
}
