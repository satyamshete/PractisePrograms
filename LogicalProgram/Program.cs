namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programming");
            Console.WriteLine("Press 1 for Alphabet Check Vowel or Consonent");
            Console.WriteLine("Press 2 for Check numbers Positive or Negative");
            Console.WriteLine("Press 3 To find Maximum of three numbers by nested if condition");
            Console.WriteLine("Press 4 To find Maximum of three numbers by Terney operator");
            Console.WriteLine("Press 5 To Print Alphabets");
            int Number = int.Parse(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    CheckAlphabets checkAlphabets = new CheckAlphabets();
                    checkAlphabets.CheckVowel();
                    break;
                case 2:
                    CheckNumber checkNumber = new CheckNumber();
                    checkNumber.NumberCheck();
                    break;
                case 3:
                    MaxOfThreeBYNestedIF maxOfThreeBYNestedIF = new MaxOfThreeBYNestedIF();
                    maxOfThreeBYNestedIF.MaxOfThreeNum();
                    break;
                case 4:
                    MaxOfThreeNumByTerneryCondition maxOfThreeNumByTerneryCondition = new MaxOfThreeNumByTerneryCondition();
                    maxOfThreeNumByTerneryCondition.CheckMaxNumber();
                    break;
                case 5:
                    PrintAlphabets printAlphabets = new PrintAlphabets();
                    printAlphabets.AlphabetPrint();
                    break;
                default:
                    Console.WriteLine("Make Proper selection");
                    break;
            }

        }
    }
}