using System.Linq;
using System.Text;


// ------------- Validate Strings
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

// Console.WriteLine(isUpperCase("hello"));
// Console.WriteLine(isLowerCase("hello"));

// Console.WriteLine(isPasswordComplex("Hell0"));
// Console.WriteLine(isPasswordComplex("HelLo"));
// Console.WriteLine(isPasswordComplex("hello"));
// Console.WriteLine(isPasswordComplex(""));

// ------------- Normalize Strings, one line
static string NormalizeString(String input) {
    return input.ToLower().Trim().Replace(",","");
}

// Console.WriteLine(NormalizeString(" Make lowercase, TRIM End spaces and remove ,     "));

// ------------- Parse and Search Strings
static void ParseContents(string s) {
    Console.WriteLine("Option 1");

    foreach(char c in s) {
        Console.WriteLine(c);
    }

    Console.WriteLine("Option 2");

    for(int i = 0; i < s.Length; i++) {
        char c = s[i];
        Console.WriteLine(c);
    }
}

static Boolean IsAtEvenIndex(string s, char item){
    if (string.IsNullOrEmpty(s)){
        return false;
    }

    for(int i = 0; i < s.Length / 2 + 1; i=i+2) {
        if(s[i] == item) {
            return true;
        }
    }
    return false;
}

// Console.WriteLine("Hello World".ToLower().Contains("ll"));
// ParseContents("Hello World");
// String input = "HeLLo";
// Console.WriteLine(IsAtEvenIndex(input, 'H'));
// Console.WriteLine(IsAtEvenIndex(input, 'T'));
// Console.WriteLine(IsAtEvenIndex(input, 'L'));
// Console.WriteLine(IsAtEvenIndex(input, 'l'));
// Console.WriteLine(IsAtEvenIndex("", 'H'));
// Console.WriteLine(IsAtEvenIndex(null, 'H'));

// ------------- Create algorithm driven strings
static string Reverse(string input) {
    if(string.IsNullOrEmpty(input)) {
        return input;
    }
    StringBuilder reversed = new StringBuilder(input.Length);

    for (int i = input.Length - 1; i >= 0; i--) {
        reversed.Append(input[i]);
    }
    return reversed.ToString();
}

// Console.WriteLine(Reverse("Hello World"));
// Console.WriteLine(Reverse(""));
// Console.WriteLine(Reverse(null));

// Option 2, using array and array method .Reverse()
static string Reverse2(string input) {
    if(string.IsNullOrEmpty(input)) {
        return input;
    }

    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

// Console.WriteLine(Reverse2("Hello World"));
// Console.WriteLine(Reverse2(""));
// Console.WriteLine(Reverse2(null));

// ------------- Reverse each word
static string ReverseEachWord(string sentence) {
        string[] words = sentence.Split(" ");
        string[] reversedWords = words.Select(Reverse).ToArray();
        string reversedSentance = string.Join(" ", reversedWords);
        return reversedSentance;
    }
Console.WriteLine(ReverseEachWord("hello world"));
