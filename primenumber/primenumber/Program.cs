using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting value");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending value");
            int e = Convert.ToInt32(Console.ReadLine());
            int count;
            int i;
            for(i=s;i<=e;i++)
            {
                count = 0;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0 && i!=1)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
