using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture04
{
    class Task02Encap
    {
        private int num1, num2;
        public void setNumbers(int no1, int no2)
        {
            num1 = no1;
            num2 = no2;
        }
        public int getNum1()
        {
            return num1;
        }
        public int getNum2()
        {
            return num2;
        }
        public void findSum()
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of the two numbers is "+sum);
        }
        
    }
}
