using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q4_百元買百雞
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            for (int cock = 0; cock <=20 ; cock++)
            {
                for (int hen = 0; hen <=100-5*cock; hen++)
                {
                    int chicken = 100 -cock -hen;

                    int price = 5 * cock + 3 * hen + chicken / 3;

                    if ( price == 100 && chicken % 3 == 0)
                    {
                        Console.WriteLine($"公雞{cock}隻，母雞{hen}隻，小雞{chicken}隻");
                    }
                   

                }
            }
            

        }
    }
}
