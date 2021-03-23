using Fitness.BL.Controller;
using System;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fitness app");

            Console.WriteLine("Enter the user name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter your birth date");
            var birthDate = DateTime.Parse(Console.ReadLine()); // TODO: rewrite

            Console.WriteLine("Enter your weight");
            var weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height");
            var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
