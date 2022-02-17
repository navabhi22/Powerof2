using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{
    public class PowerOfTwo
    {
        public static void PowerOf2(int N)
        {
            if (N <31 )
            {
                for (int i = 0; i < N; i++)
                {
                    double PowOf2 = Math.Pow(2, i);

                    Console.WriteLine(PowOf2);
                }
            }
            else
            {
                Console.WriteLine("Enter the value within 0 and 30");
            }
            
        }
    }
}
