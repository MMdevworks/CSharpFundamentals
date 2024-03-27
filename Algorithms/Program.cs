using System.Linq;


// Validate strings
static Boolean isUpperCase(string s) {
    return s.All(char.IsUpper);
}

static Boolean isLowerCase(string s) {
    return s.All(char.IsLower);
}

static Boolean isPasswordComplex(string s) {
    return s.Any(char.IsUpper) && s.Any(char.IsLower)
    && s.Any(char.IsDigit);
}


Console.WriteLine(isUpperCase("hello"));
Console.WriteLine(isLowerCase("hello"));

Console.WriteLine(isPasswordComplex("Hell0"));
Console.WriteLine(isPasswordComplex("HelLo"));
Console.WriteLine(isPasswordComplex("hello"));
Console.WriteLine(isPasswordComplex(""));