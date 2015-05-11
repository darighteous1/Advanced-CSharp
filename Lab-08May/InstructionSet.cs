using System;
using System.Numerics;

class InstructionSet
{
    static void Main()
    {
        string opCode = Console.ReadLine();
      
        while (opCode != "END") // FIXED: according to instructions command should be UPPER CASE
        {
            string[] codeArgs = opCode.Split(' ');
            BigInteger result = 0; 
            // changed result type to BigInteger in order to calculate properly 
            // large integer operations (e.g. Int32.MaxValue * Int32.MaxValue)
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            opCode = Console.ReadLine(); 
            // FIXED: added new line of code 
            // at the end of the loop we need to read the input again 
            // to avoid infinite loop */
            Console.WriteLine(result);
     
        }
    }
}