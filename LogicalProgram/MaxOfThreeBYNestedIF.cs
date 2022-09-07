using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class MaxOfThreeBYNestedIF
    {
        internal void MaxOfThreeNum()
        {
            Console.WriteLine("Enter First Numbers");
            int FNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Numbers");
            int SNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Numbers");
            int TNumber = int.Parse(Console.ReadLine());
            if (FNumber > SNumber)
            {
                if(FNumber > TNumber)
                {
                    Console.WriteLine("{0} is maximum",FNumber);
                }
                else
                {
                    Console.WriteLine("{0} is maximum", TNumber);
                }
            }else if(SNumber > TNumber)
            {
                Console.WriteLine("{0} is maximum", SNumber);
            }
            else { Console.WriteLine("{0} is maximum", TNumber); }
        }
        
    }
}
