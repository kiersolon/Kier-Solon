using System;

namespace Activity1
{
    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
                  
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Math math = new Math();

                int num1, num2;

                Console.WriteLine("Enter a first Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second Number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Addition: " + (num1 + num2));
                Console.WriteLine("Substraction: " + (num1 - num2));
                Console.WriteLine("Multiplication: " + (num1 * num2));
                Console.WriteLine("Division: " + (num1 / num2));

                Console.Beep();
                Console.ReadKey();
            }



        }
    }
}