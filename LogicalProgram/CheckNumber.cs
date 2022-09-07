using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CheckNumber
    {
       public void NumberCheck()
        {
            Console.WriteLine("Enter Numbers");
            int Number = int.Parse(Console.ReadLine());
            if (Number == 0)
            {
                Console.WriteLine("zero is Neutral");
            }
            else if (Number > 0)
            {
                Console.WriteLine("{0} is Positive",Number);
            }
            else { Console.WriteLine("{0} is Negative", Number); }
        }
    }
}
