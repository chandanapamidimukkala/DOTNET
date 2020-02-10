using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static double getAvg(int[] marks)
            {
                double sum=0;
                double avg;
                for(int j=0;j<marks.Length;j++)
                {
                    sum+=marks[j];
                }
                avg=sum/marks.Length;
                return avg;
            }
        static void Main(string[] args)
        {

            int[] marks ={12,9,24,32,56};
                for (int i = 0; i <marks.Length; i++) 
                {
                     Console.WriteLine(marks[i]);
                }
               var avgm=getAvg(marks);
            Console.WriteLine("avg is {0}",avgm);
                Console.ReadKey();
        }
    }
}
