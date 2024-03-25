int theVal = 50;

// TODO: The switch statement, used when if elses become too numerous 
// conditions followed by break if condition is met
switch (theVal) {  //the switch can use any non null expression: int, str, char, bool ect
case 50:
    Console.WriteLine("theVal is 50");
    break;
case 51:
    Console.WriteLine("theVal is 51");
    break;
case 52: //cases can also be grouped as such
case 53:
case 54:
    Console.WriteLine("theVal is between 52 and 54");
    break;
default: //default is like an else catchall
    Console.WriteLine("theVal is something else");
    break;
}