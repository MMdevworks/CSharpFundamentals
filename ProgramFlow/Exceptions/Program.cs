int x = 1030;
int y = 0;
int result;

// TODO: try-catch expressions make error checking easier
try {
    if (x > 1000) {
        throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
    }
    result = x / y;
    Console.WriteLine("The result is: {0}", result);
}
catch (DivideByZeroException e) {
    Console.WriteLine("Can't divide by 0!");
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e) {
    Console.WriteLine("1000 is the limit!");
    Console.WriteLine(e.Message);
}
finally {
    Console.WriteLine("finally code always runs");
}
