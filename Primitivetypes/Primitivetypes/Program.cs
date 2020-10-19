using System;
using System.Net.Http.Headers;

namespace Primitivetypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES

            // Declaring variables start with type then variable name
            // Variable names should be camelCase, can not start with a number, can not include whitespace
            // can not be reserved keyword such as int, float, etc.

            int newVariable1;

            string newVariable2 = "Hello World";

            // Float variables need to have "f" after the value to specify float instead of double

            float newVariable3 = 2.56f;

            // assigning a previously declared variable

            newVariable1 = 22;

            Console.WriteLine(newVariable1);
            Console.WriteLine(newVariable2);
            Console.WriteLine(newVariable3);
            Console.WriteLine();

            // CONSTANTS

            // Constants should be declared with "const" declaration
            // Should use PascalCase

            const int NewVariable4 = 66;

            const float NewVariable5 = 9.456f;

            // Constants can not be changed.

            Console.WriteLine(NewVariable4);
            Console.WriteLine(NewVariable5);
            Console.WriteLine();

            // OVERFLOW

            // If a variable value exceeds the limit of its type it will 'overflow'

            // TYPE CONVERSION

            // Variable types can be changed to other compatible types with a type cast
            // By putting the new type in parenthesis in front of the variable
            // similar types that hold more data do not need a cast if a smaller type is assigned

            float testVar1 = 3.56f;

            int testVar2 = (int)testVar1;

            double testVar3 = testVar1;

            // Incompatible types can not by type cast and will need to use the convert class

            string testVar4 = "5";

            int testVar5 = Convert.ToInt32(testVar4);

            // A try catch block can be used to test conversion cases

            testVar5 = testVar5 + 300;
            byte testVar6;

            try
            {
                testVar6 = Convert.ToByte(testVar5);
                Console.WriteLine(testVar6);
            }
            catch
            {
                Console.WriteLine("If the try block throws an exception, the catch block is executed.");
                Console.WriteLine("In this case, the testVar5 is too big to be converted to a byte.");
            }

            Console.WriteLine();

            // OPERATORS

            // This section is a quick overview of the different types of operators and how they work

            int opVar1 = 1 + 1;

            Console.WriteLine(opVar1);

            int opVar2 = 1 - 1;

            Console.WriteLine(opVar2);

            int opVar3 = 10 * 10;

            Console.WriteLine(opVar3);

            int opVar4 = 100 / 10;

            Console.WriteLine(opVar4);

            Console.WriteLine();

            // The modulo operator returns the remainder from division

            int opVar5 = 100 % 10;

            int opVar6 = 9 % 4;

            Console.WriteLine(opVar5 + ", " + opVar6);

            Console.WriteLine();

            // shortened increment operator

            opVar1++;

            opVar2--;

            Console.WriteLine(opVar1);
            Console.WriteLine(opVar2);

            Console.WriteLine();

            // Comparison operators return a boolean

            bool compVar1 = 2 == 2;

            Console.WriteLine(compVar1);

            compVar1 = 2 >= 3;

            Console.WriteLine(compVar1);

            compVar1 = 2 <= 3;

            Console.WriteLine(compVar1);

            compVar1 = 2 != 3;

            Console.WriteLine(compVar1);

            compVar1 = 2 > 3;

            Console.WriteLine(compVar1);

            compVar1 = 2 < 3;

            Console.WriteLine(compVar1);

            Console.WriteLine();

            // Assignment operators are also shortened versions of a = a + 1

            int assOp1 = 55;

            assOp1 += 5;

            Console.WriteLine(assOp1);

            assOp1 -= 3;

            Console.WriteLine(assOp1);

            assOp1 *= 4;

            Console.WriteLine(assOp1);

            assOp1 /= 3;

            Console.WriteLine(assOp1);

            Console.WriteLine();

            // Logical operators also return a boolean
            // && is the 'and' operator
            // || is the 'or' operator
            // ! is the 'not' operator

            bool logVar1 = true && true;

            Console.WriteLine(logVar1);

            logVar1 = true || false;

            Console.WriteLine(logVar1);

            logVar1 = !true;

            Console.WriteLine(logVar1);
        }
    }
}
