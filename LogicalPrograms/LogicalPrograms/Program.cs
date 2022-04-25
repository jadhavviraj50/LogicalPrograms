using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select Number\n1)LogicalPrograms\n2)PerfectNumber");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.number();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}