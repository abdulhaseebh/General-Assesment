using System;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Question 1----------");
            Console.WriteLine("Enter first number: ");
            int fNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int sNum = int.Parse(Console.ReadLine());  
            Console.WriteLine("Enter third number: ");
            int tNum = int.Parse(Console.ReadLine()); 
            int sum = fNum + sNum + tNum;
            Console.WriteLine($"The sum of the numbers is {sum}");

            Console.WriteLine("--------Question 2----------");
            Console.WriteLine("Enter your radius: ");
            int radius = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The perimeter is {perimeter}");
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("---------Question 3----------");
            Console.WriteLine("Enter company's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter company's address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter company's phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company's fax number: ");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company's website: ");
            string website = Console.ReadLine();
            Console.WriteLine("Enter manager's name: ");
            string names = Console.ReadLine();
            Console.WriteLine("Enter manager's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter manager's phone number: ");
            int phoneNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine($"The name of my company is {name},it is located at {address},their phone number is {phoneNumber},their fax number is {faxNumber},if you want to visit their website {website}.The managers name is {names},his/her surname is {surname},if you want to contact the manager call {phoneNumbers}");

            Console.WriteLine("-------Question 6-------");
            Console.WriteLine("Enter first number: ");
            int            






        }
    }
}
