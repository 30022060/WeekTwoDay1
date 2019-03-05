using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter Your First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Your Home Address");
            string addrs = Console.ReadLine();

            Console.WriteLine("\nUser Details: \nName: {0} {1} \nAge: {2} \nGender: {3} \nAddress: {4}", fname, lname, age, gender, addrs);
            Console.ReadLine();
        } 
    }
}
