using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nSelect Number\n1)LogicalPrograms\n2)PerfectNumber\n3)PrimeNumber\n4)ReverseNumber\n5)CouponNumber");
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
                    case 3:
                        PrimeNumber number = new PrimeNumber();
                        number.prime();
                        break;
                    case 4:
                        ReverseNumber num = new ReverseNumber();
                        num.reverseNumber();
                        break;
                    case 5:
                        CouponNumber test = new CouponNumber();
                        test.coupon();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}