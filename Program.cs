namespace Operators_shepardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTIGERS");
            //intializes an intger that multipies two integers
            int intMult = 6 * 45;
            // Initialized an integer that adds to integers
            int intAdd = 55 + 66;
             // prints the maxium and minimum of the two integer variables
            Console.WriteLine($"the max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"the min of two is {Math.Max(intMult, intAdd)}");
                // initalizes boolen to see if inMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // prints is inMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");
            Console.WriteLine("SHORT");
            //intializes an short that multipies two short
            short shortMult = 6 * 45;
            // Initialized an short that adds to short
            short shortAdd = 55 + 66;
            // prints the maxium and minimum of the two short variables
            Console.WriteLine($"the max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"the min of two is {Math.Max(shortMult, shortAdd)}");
            // initalizes boolen to see if shotMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // prshorts is inMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            Console.WriteLine("LONG");
            //initalizes an long that multipies two long
            long longMult = 6 * 45;
            // Initialized an long that adds to long
            long longAdd = 55 + 66;
            // prints the maxium and minimum of the two longeger variables
            Console.WriteLine($"the max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"the min of two is {Math.Max(longMult, longAdd)}");
            // initalizes boolen to see if inMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // printa is longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");

            Console.WriteLine("MULTIBLES");
            //intializes an intger that multipies two floategers
            float floatMult = 6.5f * 45.2f;
            // Initialized an floateger that adds to doubleegers
            float floatAdd = 55.35f + 66.15f;
            // prdoubles the maxium and minimum of the two floateger variables
            Console.WriteLine($"the max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"the min of two is {Math.Max(floatMult, floatAdd)}");
            // initalizes boolen to see if inMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // prdoubles is inMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");





            Console.WriteLine("DOUBLES");
            //initalizes an double that multipies two double
            double doubleMult = 6.69 * 45.58;
            // Initialized an double that adds to double
            double doubleAdd = 55.48 + 66.15;
            // print the maxium and minimum of the two double variables
            Console.WriteLine($"the max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, floatAdd)}." +
                $"the min of two is {Math.Max(doubleMult, doubleAdd)}");
            // initalizes boolen to see if inMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // prints is inMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");
            
            Console.WriteLine("DECIMALS");
            //intializes an decimal that multipies two decimal
            decimal decimalMult = 6 * 45;
            // Initialized an decimal that adds to decimals
            decimal decimalAdd = 55 + 66;
            // prints the maxium and minimum of the two decimal variables
            Console.WriteLine($"the max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"the min of two is {Math.Max(decimalMult, decimalAdd)}");
            // initalizes boolen to see if inMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // prints is inMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");












        }
    }      
             
}