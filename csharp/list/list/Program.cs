using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<course> courselist = new List<course>();
            courselist.Add(new course

            {
                cid = 1,
                cname = "C#",
                startDate = DateTime.Today,
                fees = 6000,
            });
            courselist.Add(new course

            {
                cid = 2,
                cname = ".NET",
                startDate = DateTime.Today,
                fees = 8000,
            });
            foreach(course s in courselist)
            {
                Console.WriteLine( "{0}\t{1}\t{2}\t{3}",s.cid,s.cname,s.startDate,s.fees);
            }
            Console.ReadKey();
        }
    }
}
