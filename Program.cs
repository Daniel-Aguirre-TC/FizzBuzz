using System;
using System.Linq;

namespace FizzBuzzChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzLinqTwo(new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15});
            Console.ReadKey();
        }

        static void FizzBuzzLinqTwo(int[] array)
        {
            array.ToList().ForEach(x => {Console.WriteLine(x % 5 != 0 && x % 3 != 0 ? x.ToString() : x % 5 == 0 && x % 3 == 0 ? "Fizzbuzz" : x % 5 == 0 ? "Buzz" : "Fizz");});
        }


        static void FizzBuzzLinq(int[] array)
        {
            (from num in array 
             let msg = num % 5 != 0 && num % 3 != 0 ? num.ToString() : num % 5 == 0 && num % 3 == 0 ? "Fizzbuzz" : num % 5 == 0 ? "Buzz" : "Fizz" 
             select msg).ToList().ForEach(Console.WriteLine);         
        }



        static void FizzBuzz(int[] array)
        {
            foreach (var number in array)
            {
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 3 != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }



        static void FizzBuzzSwitch(int[] array)
        {
            foreach (int item in array)
            {
                switch (item)
                {
                    case int number when number % 3 == 0 && number % 5 == 0:
                        Console.WriteLine("Fizz Buzz");
                        break;
                    case int number when number % 3 == 0:
                        Console.WriteLine("Fizz");
                        break;
                    case int number when number % 5 == 0:
                        Console.WriteLine("Buzz");
                        break;
                    default:
                        Console.WriteLine(item);
                        break;
                }
            }
        }

        /*
            We accept an array of integers
            if the number we get is divisible by 3 then say fizz
            if the number we get is divisible by 5 then say buzz
            if the number we get is divisible by 3 and by 5 then say fizzbuzz
            if it's not divisible by 3 or by 5 then we will write the number
        */

    }
}
