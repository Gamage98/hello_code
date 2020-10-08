using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture04
{
    class Program
    {
        static void Main(string[] args)
        {
            EncapClass obj2 = new EncapClass();
            Console.Write("\n\nEnter your year : ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Enter your name : ");
            string n = Console.ReadLine();
            obj2.setValue(g,n);
            Console.WriteLine("Hello  "+ obj2.getName());
            

            Task02Encap obj3 = new Task02Encap();
            Console.Write("\nEnter first subject marks : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second subject marks : ");
            int number2 = int.Parse(Console.ReadLine());
            obj3.setNumbers(number1, number2);
            obj3.findSum();

            Console.ReadKey();
        }
    }
}
