namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {   // write a method that will print to the console
        //all numbers 1000 through -1000.
        static void Main(string[] args)
        {
            PrintThousand();
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // write a method that 
        // will print to the console numers 3 through 999 by 3 each time.
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);

            }
        }
        // write a method tp accept two integers as parameters and check whether they are equal or not
        public static void CheckIfEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is NOT equal to {num2}");
            }

        }
        // write method to check whether even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Please enter a number. we will check if its even or odd");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)

            {
                Console.WriteLine($"{userInput} is even");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd");
            }
        }
        // write a method to check whether a given number is positive or negative

        public static void IsPositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else
            {
                Console.WriteLine($"{num}) is negative");
            }
        }
        public static void CheckIfInRange()
        {
            Console.WriteLine("Enter in a number, and I will tell you if its in range");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {
               Console.WriteLine("Yes! number is in range");
            }
            else
            {
                Console.WriteLine(" your number is not in range");
            }
        }
        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {i}) x {num} = {num * i} ");
            }
        
        
        
        
        
        
        }

     }
 }      
               













