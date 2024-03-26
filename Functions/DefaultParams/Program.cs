// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string str, string prefix="")
{
    Console.WriteLine($"{prefix} {str}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello There!");
PrintWithPrefix("Hello There!", ">: ");

// TODO: Call with named params, in any order
PrintWithPrefix(prefix: "% ", str: "Hello There!");
