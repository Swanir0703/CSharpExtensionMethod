using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello WorLd";
            string changeCase = input.ChangeCase();
            string chnageWordCase = input.ChangeWordCase();
            Console.WriteLine(chnageWordCase);
            Console.WriteLine(changeCase);
            //Console.WriteLine("Enter number");
            //long number = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Enter Digit to count its occurrence. ");
            //int digit = Convert.ToInt32(Console.ReadLine());
            //int ocurrence = CountOcurrences(number, digit);
            //Console.WriteLine("The digit "+digit +"Ocurred "+ocurrence +" time.");
            //int reverse = ReverseDigits(digit);
            //int fact = factorial(digit);
            //Console.WriteLine(fact);
        }

        public static int CalculateSum(int number)
        {
            int sum = 0, modulus, n = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                modulus = n % 10;
                sum = sum + modulus;
                n = n / 10;

            }
            Console.WriteLine("Sum is " + sum);
            return sum;
        }

        public static int CountOcurrences(long number,int findDigit)
        {
            int count = 0, modulus;
            while(number>0)
            {
                modulus =Convert.ToInt32( number % 10);
                if (modulus == findDigit)
                    count++;
                number = number / 10;
            }
            return count;

        }
        public static int ReverseDigits(int number)
        {
            int modulus; int reverse = 0;
            while(number>0)
            {
                modulus = number % 10;
                reverse = reverse*10 + modulus;
                number = number / 10;
            }
            return reverse;
        }

        public static int factorial(int num)
        {
            int fact = 1;
            while(num !=0)
            {
                fact = fact * num;
                num = num - 1;
            }
            return fact;
        }
    }
}
