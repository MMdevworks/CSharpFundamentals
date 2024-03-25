string inputStr = "";

// // TODO: basic while loop executes while the gate condition is true, condition is checked at top
Console.WriteLine("---- Basic while loop ----");
while (inputStr != "exit") {
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered {0}", inputStr);
}

// TODO: the do-while loop always executes at least one time, condition is checked at end
Console.WriteLine("---- The do-while loop ----");
do {
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered {0}", inputStr);
} while(inputStr != "exit");
