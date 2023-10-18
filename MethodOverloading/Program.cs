using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace MethodOverloading
{
    public class Program
    {
        
        static int Add(int x, int y)
        {
            return x + y;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static string Add(int x, int y, bool isTrue)
        {
            var sum = 15;
            var response = "";

            if (isTrue)
            {
                sum = x + y;

                if (sum == 1 || sum == -1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));

            Console.WriteLine(Add(1.345m, 3.537m));

            Console.WriteLine(Add(7, 8, true));

            Console.WriteLine(Add(45, -107, true));

            Console.WriteLine(Add(-2, 1, true));

            Console.WriteLine(Add(0, 1, true));

        }
    }
}
