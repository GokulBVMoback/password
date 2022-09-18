using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordThreeWrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t\tCheck Username and Password\n");
            Console.WriteLine("\t\t\tBy Default Username is \"Gokul\" and Password is \"1234\"");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string username, password;
            Console.Write("Enter User Name:");
            username = Console.ReadLine();
            Console.Write("Enter Your Password:");
            password = Console.ReadLine();
            if (username == "Gokul" && password == "1234")
            {
                Console.WriteLine("LogIn successfully."); //if username and password correct at first attempt
            }
            else    // else enter into the loop
            {
                for (int i = 1; i <=3; i++) //i intex start from 1 and i value increased by +1 for each failed attempt
                {
                    Console.WriteLine("Username Password doesn`t match. Please Re-Enter your Username and Password");
                    Console.Write("\nUsername:");
                    username = Console.ReadLine();
                    Console.Write("Password:");
                    password = Console.ReadLine();
                    if (username == "Gokul" && password == "1234")
                    {
                        Console.WriteLine("LogIn successfully.");
                        break;
                    }
                    else if (i == 3) //if i = 2 you can`t try any more. else it re-enter to the for loop
                    {
                        Console.WriteLine("Login attemp more than three times. Try later!");
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
