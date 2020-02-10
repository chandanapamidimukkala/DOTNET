using System;
namespace sample
{
	public class sample
	{
		public static void Main(String[] args){

		int h;
                string ename;
                Console.WriteLine("Enter your name");
                ename = Console.ReadLine();
                Console.WriteLine("Enter your age");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("Congratualtions Mr/Ms {0} on your {1} birthday ",ename,h);
                Console.ReadKey();
}
}
}