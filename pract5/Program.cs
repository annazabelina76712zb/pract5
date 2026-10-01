using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            int add = 0;
            while(true)
            {
                add = add + 1;
                int chislo = n + add;
                int sum = 0;        

                while(chislo>0)
                {
                    sum = sum + chislo;
                   


                }
                if(sum%7==0)
                {

                    break;
                }

            }
            Console.WriteLine("Минимальное число: "+add);
            Console.ReadKey();
           
        }
    }
}
