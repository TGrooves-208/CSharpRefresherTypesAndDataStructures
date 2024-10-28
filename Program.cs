using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Byte example ASCII
            Console.WriteLine("Byte Example:");
            Console.WriteLine("Bits: [0 0 0 0 0 0 0 0] represents 0");
            Console.WriteLine("Bits: [1 1 1 1 1 1 1 1] represents 255");
            byte myByte = 255;
            Console.WriteLine("Byte Value: " + myByte);
            Console.WriteLine();

            // Signed byte example ASCII
            Console.WriteLine("Signed Byte (sbyte) Example:");
            Console.WriteLine("Bits: [0 1 1 1 1 1 1 1] represents +127");
            Console.WriteLine("Bits: [1 0 0 0 0 0 0 0] represents -128");
            sbyte mySbyte = 127;
            sbyte mySecondSbyte = -128;
            Console.WriteLine("sbyte Max: " + mySbyte);
            Console.WriteLine("sbyte Min: " + mySecondSbyte);
            Console.WriteLine();

            // Unsigned short example ASCII
            Console.WriteLine("Unsigned Short (ushort) Example:");
            Console.WriteLine("Max value: 65535");
            ushort myUshort = 65535;
            Console.WriteLine("ushort Max Value: " + myUshort);
            Console.WriteLine();

            // Short example ASCII
            Console.WriteLine("Signed Short (short) Example:");
            Console.WriteLine("Range: -32768 to +32767");
            short myShort = -32768;
            Console.WriteLine("short Min Value: " + myShort);
            Console.WriteLine();

            // Integer example ASCII
            Console.WriteLine("Integer (int) Example:");
            Console.WriteLine("Range: -2147483648 to +2147483647");
            int myInt = 2147483647;
            int mySecondInt = -2147483648;
            Console.WriteLine("int Max Value: " + myInt);
            Console.WriteLine("int Min Value: " + mySecondInt);
            Console.WriteLine();

            // Long example ASCII
            Console.WriteLine("Long (long) Example:");
            Console.WriteLine("Range: -9223372036854775808 to +9223372036854775807");
            long myLong = -9223372036854775808;
            Console.WriteLine("long Min Value: " + myLong);
            Console.WriteLine();

            // Float example ASCII
            Console.WriteLine("Float (float) Example:");
            Console.WriteLine("Example values: 0.751, 0.75");
            float myFloat = 0.751f;
            float mySecondFloat = 0.75f;
            Console.WriteLine("Float Value 1: " + myFloat);
            Console.WriteLine("Float Value 2: " + mySecondFloat);
            Console.WriteLine("Float Difference: " + (myFloat - mySecondFloat));
            Console.WriteLine();

            // Double example ASCII
            Console.WriteLine("Double (double) Example:");
            Console.WriteLine("Example values: 0.751, 0.75");
            double myDouble = 0.751;
            double mySecondDouble = 0.75;
            Console.WriteLine("Double Value 1: " + myDouble);
            Console.WriteLine("Double Value 2: " + mySecondDouble);
            Console.WriteLine("Double Difference: " + (myDouble - mySecondDouble));
            Console.WriteLine();

            // Decimal example ASCII
            Console.WriteLine("Decimal (decimal) Example:");
            decimal myDecimal = 0.751m;
            decimal mySecondDecimal = 0.75m;
            Console.WriteLine("Decimal Value 1: " + myDecimal);
            Console.WriteLine("Decimal Value 2: " + mySecondDecimal);
            Console.WriteLine("Decimal Difference: " + (myDecimal - mySecondDecimal));
            Console.WriteLine();

            // String example
            Console.WriteLine("String Example:");
            string myString = "Hello World";
            Console.WriteLine("String: " + myString);
            Console.WriteLine();

            string myStringWithSymbols =
                "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            Console.WriteLine("String with Symbols: " + myStringWithSymbols);
            Console.WriteLine();

            // Boolean example
            Console.WriteLine("Boolean Example:");
            bool myBool = true;
            Console.WriteLine("Boolean Value: " + myBool);
            Console.WriteLine();

            // Array example ASCII illustration
            Console.WriteLine("1D Array (Grocery List) Visualization:");
            string[] myGroceryArray = { "Coffee", "Coffee Cake" };
            Console.WriteLine("    +------------+------------+");
            Console.WriteLine("    |   Coffee   | Coffee Cake|");
            Console.WriteLine("    +------------+------------+");
            Console.WriteLine("Accessing element at index 0: " + myGroceryArray[0]);
            Console.WriteLine("Accessing element at index 1: " + myGroceryArray[1]);
            Console.WriteLine();

            // List example
            Console.WriteLine("List Example (Grocery List):");
            List<string> myGroceryList = new List<string>() { "Leche", "Crema", "Cafecito" };
            myGroceryList.Add("Soda");
            Console.WriteLine("    +--------+--------+--------+--------+");
            Console.WriteLine("    | Leche  | Crema  | Cafecito | Soda |");
            Console.WriteLine("    +--------+--------+--------+--------+");
            Console.WriteLine("List Access Examples:");
            Console.WriteLine(myGroceryList[0]);
            Console.WriteLine(myGroceryList[1]);
            Console.WriteLine(myGroceryList[2]);
            Console.WriteLine(myGroceryList[3]);
            Console.WriteLine();

            // IEnumerable example
            Console.WriteLine("IEnumerable Example (Grocery List):");
            IEnumerable<string> myGroceryIEnumerable = myGroceryList;
            Console.WriteLine(
                "Cannot access by index, so using First(): " + myGroceryIEnumerable.First()
            );
            Console.WriteLine();

            // Two dimensional array ASCII illustration
            string[,] myTwoDimensionalArray = new string[,]
            {
                { "Apples", "Eggs" },
                { "Milk", "Cheese" },
            };

            Console.WriteLine("2D Array Visualization:");
            Console.WriteLine();
            Console.WriteLine("    +--------+--------+");
            Console.WriteLine("    | Apples |  Eggs  |");
            Console.WriteLine("    +--------+--------+");
            Console.WriteLine("    |  Milk  | Cheese |");
            Console.WriteLine("    +--------+--------+");
            Console.WriteLine();

            Console.WriteLine("Accessing 2D Array Elements:");
            Console.WriteLine("Element at (0, 1): " + myTwoDimensionalArray[0, 1]); // Eggs
            Console.WriteLine("Element at (1, 0): " + myTwoDimensionalArray[1, 0]); // Milk
            Console.WriteLine();

            // Dictionary is a class that takes in two parameters
            // Difference each item has to be declared
            Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>()
            {
                { "Espresso", "GilsRoasteryHouse" },
            };

            // Print dictionary visualization in ASCII format
            Console.WriteLine("    Dictionary Visualization:\n");
            Console.WriteLine("    +-----------+---------------------+");
            Console.WriteLine("    |   Key     |       Value         |");
            Console.WriteLine("    +-----------+---------------------+");
            Console.WriteLine($"    | Espresso  | {myGroceryDictionary["Espresso"], -18} |");
            Console.WriteLine("    +-----------+---------------------+\n");

            // Accessing and printing a specific value using the key
            Console.WriteLine(myGroceryDictionary["Espresso"]);

             // Step 1: Create a dictionary with string keys and decimal values
            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
            
            // Step 2: Set the price for "cheese" and "carrots"
            itemPrices["cheese"] = 5.99m;
            itemPrices["carrots"] = 2.99m;
            
            // Displaying the dictionary values
            Console.WriteLine(itemPrices["cheese"].GetType()); // This will display the type of "cheese" price, which is decimal
            Console.WriteLine(itemPrices["cheese"]); // This displays 5.99
            Console.WriteLine(itemPrices["carrots"]); // This displays 2.99
        }
    }
}
