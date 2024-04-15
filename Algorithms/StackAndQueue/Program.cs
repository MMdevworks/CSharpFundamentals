using System.Collections.Generic;


// ------------- Queue

Queue<int> queue = new Queue<int>();

queue.Enqueue(2);
queue.Enqueue(5);
queue.Enqueue(52);
queue.Enqueue(17);
queue.Enqueue(10);

// int removedItem = queue.Dequeue();
// Console.WriteLine(removedItem);
// Console.WriteLine(queue.Dequeue());
// Console.WriteLine(queue.Peek());

// int current;
// while(queue.TryDequeue(out current)) {
//     Console.WriteLine(current);
// }

// Print first N binary numbers
static void printBinary(int n) {
    if (n <=0) {
        return;
    }

    Queue<int> queue = new Queue<int>();
    queue.Enqueue(1);
    for (int i = 0; i < n; i++) {
        int current = queue.Dequeue();
        Console.WriteLine(current);
        queue.Enqueue(current);
        queue.Enqueue(current * 10);
        queue.Enqueue(current * 10 + 1);
    }
    Console.WriteLine();
}

// printBinary(5);
// printBinary(-2);
// printBinary(0);
// printBinary(9);

// ------------- Stack

Stack<string> stack = new Stack<string>();

// Console.WriteLine("Start Main");
// stack.Push("Main");
// Console.WriteLine("Start ResponseBuilder");
// stack.Push("ResponseBuilder");
// Console.WriteLine("Start CallExternalService");
// stack.Push("CallExternalService");
// Console.WriteLine("End " + stack.Pop());
// Console.WriteLine("Start ParseExternalData");
// stack.Push("ParseExternalData");
// Console.WriteLine("End " + stack.Pop());
// Console.WriteLine("End " + stack.Pop());
// Console.WriteLine("End " + stack.Pop());

// // .Peek(), .TryPeek()
// string item;
// Console.WriteLine(stack.TryPeek(out item));

// Print next greater element for every element in the array
static void printNextGreater(int[] arr) {
    if (arr.Length <= 0) {
        Console.WriteLine();
        return;
    }
    Stack<int> stack = new Stack<int>();
    stack.Push(arr[0]);

    for (int i = 1; i < arr.Length; i++) {
        int next = arr[i];
        if (stack.Count > 0) {
            int popped = stack.Pop();

            while (popped < next) {
                Console.WriteLine(popped + "--> " + next);
                if (stack.Count == 0) {
                    break;
                }
                popped = stack.Pop();
            }
            if (popped > next) {
                stack.Push(popped);
            }
        }
        stack.Push(next);
    }
    while(stack.Count > 0) {
        Console.WriteLine(stack.Pop() + "--> " + -1);
    }
}

int[] arr = new int[] {15,8,4,10};
printNextGreater(arr);

