using System;

namespace MyFirstProject.LoopTest
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckTriomorphicNumber(num))
            {
                Console.WriteLine("Triomorphic Number");
            }
            else
            {
                Console.WriteLine("Not Triomorphic Number");
            }
            Console.ReadLine();
        }
        public static bool CheckTriomorphicNumber(int num)
        {
            int cube = num * num * num;
            while (num > 0)
            {
                if (num % 10 != cube % 10)
                {
                    return false;
                }
                num = num / 10;
                cube = cube / 10;
            }
            return true;
        }
    }
}
