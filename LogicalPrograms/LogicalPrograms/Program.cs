using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select Number\n1)LogicalPrograms");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.fibonacci();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}