using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] a = new int[3, 4] { {1,2,3,11},{4,5,6,12},{7,8,9,10} };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
