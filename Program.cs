using System;

namespace demo05.whileLoopCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            double total = 0.0;
            double summa = 0.0;
            Boolean check = true;

            while (check)
            {

                Console.WriteLine("\nHow many rounds");
                int round = int.Parse(Console.ReadLine());  // convert str 2 int

                while (add < round)
                {
                    add++;
                    Console.Write("Please enter your " + add + " value : ");
                    summa = double.Parse(Console.ReadLine());
                    total = total + summa;
                }
                Console.WriteLine("\nYour answer is : " + total + ".");

                Console.Write("\nDo you want to continue ? (y/n) : ");
                string get_check = Console.ReadLine();
                

                if (get_check == "y")
                {
                    check = true;
                    round = 0;
                    total = 0.0;
                    summa = 0.0;
                    add = 0;
                }
                else
                {
                    check = false;
                }

            }

        }

    }
}