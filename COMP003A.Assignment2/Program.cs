//Author: Roman
//Course: comp003a
//Faculty: Jonathan
//Purpose: assignment
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userFirstName;
            string userLastName;
            int userAge;
            double productPrice;
            bool isStudent;

           
 
            
            Console.Write("Enter your first name");
            userFirstName = Console.ReadLine();

            Console.Write("Enter your last name");
            userLastName = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine());

            
            Console.Write("Enter the price of a product");
            productPrice = double.Parse(Console.ReadLine());

            
            Console.Write(" Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = userAge + 5;
            double studentPrice = productPrice * 0.9;
            double seniorPrice = productPrice * 0.8;


            Console.WriteLine($"\nHello, {userFirstName} {userLastName}!");
            Console.WriteLine($"Your current age is {userAge}.");
            Console.WriteLine($"In 5 years, you will be {futureAge}");
            Console.WriteLine($"The original price of the item is ${productPrice}.");
            Console.WriteLine($"As a Student, your discounted price is ${studentPrice}.");
            Console.WriteLine($"As a senior citizen, your dicounted price would be ${seniorPrice}.");


        }
    }
}
