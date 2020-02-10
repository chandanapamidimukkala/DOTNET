using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList\n"); 
            ArrayList al = new ArrayList() { "Chandana", "sai", "Munna", "Vamsi", "Sony" };
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("Mohana");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);
            Console.WriteLine();
            Console.WriteLine("Hash Table\n");
            Hashtable hs = new Hashtable();
            hs.Add("Raju", "165267");
            hs.Add("Ravi", "163533");
            hs.Add("Ram", "164464");
            foreach(string k in hs.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string h in hs.Values)
            {
                Console.WriteLine(h);
            }
            hs.Remove("Ravi");
            Console.WriteLine("stack\n");
            Stack stk = new Stack();
            stk.Push("Mango");
            stk.Push("Apple");
            stk.Push("Banana");
            stk.Push("Grapes");
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }

            stk.Pop();
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Queue\n");
            Queue q = new Queue();
            q.Enqueue("Dairy Milk");
            q.Enqueue("Snickers");
            q.Enqueue("Milky Bar");
            q.Enqueue("5 star");
            foreach (string qt in q)
            {
                Console.WriteLine(qt);
            }

            q.Dequeue();
            foreach (string qt in q)
            {
                Console.WriteLine(qt);
            }
            Console.WriteLine("sorted list\n");
            SortedList sk = new SortedList();
            sk.Add("Raju", "165267");
            sk.Add("Ravi", "163533");
            sk.Add("Ram", "164464");
            foreach (string sl in sk.Keys)
            {
                Console.WriteLine(sl);
            }
            foreach (string sl in sk.Values)
            {
                Console.WriteLine(sl);
            }
            Console.ReadKey();
        }
    }
}
