using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            int[] vals = new int[5];  //array of length 5
            string[] strs = {"one","two","three"};

            // TODO: Print the values using a Formatting String
            // Composite formatting is useful for creating a single string out of multiple values, including variables, literals, or expressions, formatted in a specific way
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,c,b,str,f,d,x,z);

            // TODO: "null" means "no value"


            // TODO: Implicit conversion between types


            // TODO: Explicit conversions

        }
    }
}
