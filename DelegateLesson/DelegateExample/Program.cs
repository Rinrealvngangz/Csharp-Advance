using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void Operator(int number);
    class Program
    {

       
        static int number = 10;
        static int AddNumber(int changeNumber)
        {
            return  number += changeNumber;
        }

        static void MultiplyNumber(int changeNumber)
        {
            number *= changeNumber;
        }

        static void Result(int result)
        {
            //op1(number);
            Console.WriteLine("Value of result {0}", result);
        }
        static void Main(string[] args)
        {
            Action<int> action = new Action<int>(Result);
        
            Func<int, int> func  = new Func<int,int>(AddNumber);
            action(func(number));
            //Operator op1 = new Operator(AddNumber);
            //op1(number);
       
            Operator op2 = new Operator(MultiplyNumber);
            op2(number);
            Console.WriteLine("Value of multiply number {0}", number);
            Console.ReadKey();
        }
    }
}
