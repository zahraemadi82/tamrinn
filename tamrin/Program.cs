using System;
namespace Project {
    class Test
    {
       public static void Main()
        {
            Console.WriteLine("Enter two numbers to find their GCD and LCM:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2, gcd);
            PrintResult(gcd, lcm);
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            return a;
        }

        static int CalculateLCM(int a, int b, int gcd)
        {
            return (a * b) / gcd;
        }

        static void PrintResult(int gcd, int lcm)
        {
            Console.WriteLine("The GCD of the two numbers is: " + gcd);
            Console.WriteLine("The LCM of the two numbers is: " + lcm);
        }
    }
}
