using System;

namespace MethodExercise2
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public static int Multiply(int x, int y)
        {
            return x * y;
        }


        static void Main(string[] args)

        {
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine("Give me a number to multiply");


            int randomNumber = 19238936;

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
           num2 = int.Parse(Console.ReadLine());

            int product = Multiply(121, randomNumber);
            Console.WriteLine($"The product is: {product}");

        }
    }
}
