using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Exam
    {
        private string sname, subject;
        private int rollno, marks;
        public void getData(string sn, int id, string sub, int marks)
        {
            sname = sn;
            subject = sub;
            rollno = id;
            this.marks = marks;
        }
        public void showData()

        {
            Console.WriteLine(sname +" "+ rollno +" "+ subject +" "+marks ); 
        }
    }
}
