using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_exp
{
    class Program
    {
        private static void LambdaExpression()
        {
            Func<int, int> Cube = a => a * a * a;//for single variable
            Console.WriteLine("Enter any Number");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }
        private static void LambdaLinqOrdr()
        {
            int[] nos = { 45, 23, 12, 87, 78, 65 };
            var sort = nos.OrderBy(x => x);//sort all the ele in the array
            Console.WriteLine(string.Join(" ", sort));
        }
        private static void LambdaLinqOrd()
        {
            int[] numbers = { 2,3,7,1};
            var sqn = numbers.Select(x => x*x);//select takes input array and perform square
            Console.WriteLine(string.Join(" ", sqn));
        }
        private static void LambaExp()
        {
            int[] sc = { 78, 98, 56, 44,12, 11 };
            int exelent = sc.Where(n => n >= 65).Count();
            int a = sc.Where(x => x >= 75).Count() - exelent;
            Console.WriteLine(exelent);
            Console.WriteLine(a);
        }
         public static void Main(string[] args)
        {
            Func<int, double, double> Calc = (x, y) => x * y;//for 2 variables
            Console.WriteLine(Calc(12, 10.0));
            LambdaExpression();
            LambdaLinqOrdr();
            LambdaLinqOrd();
            LambaExp();
            Console.ReadKey();
        }
    }
}
