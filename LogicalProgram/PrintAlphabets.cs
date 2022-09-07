using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrintAlphabets
    {
        public void AlphabetPrint()
        {

            char Alphabet = 'A';
            while(Alphabet <= 'Z')
            {
                Console.Write(Alphabet+" ");
                Alphabet++;
            }
        }
    }
}
