using System.Collections;

//  ------------ Linear Search
static Boolean LinearSearch(int[] input, int n) {
    foreach(int current in input) {
        if (n == current) {
            return true;
        }
    }
    return false;
}

int[] arr = {1, 2, 3, 4, 5, 6};
// LinearSearch(arr, 4);
// Console.WriteLine(LinearSearch(arr, 4));
// Console.WriteLine(LinearSearch(arr, 8));

int item = Array.Find(arr, element => element == 3);
// Console.WriteLine(item);

int[] items = Array.FindAll(arr, element => element >= 5);
// Array.ForEach(items, Console.WriteLine);

//  ------------ Binary Search
static Boolean BinarySearch(int[] inputArray, int item) {
    int min = 0;
    int max = inputArray.Length -1;

    while (min <= max) {
        int mid = (min + max) / 2;
        if(item == inputArray[mid]) {
            return true;
        } else if (item < inputArray[mid]) {
            max = mid - 1;
        } else {
            min = mid + 1;
        }
    }
    return false;
}

// int[] array = {1, 2, 3, 4, 5, 6};
// Console.WriteLine(BinarySearch(array, 5));

//  ------------ Aggregating Valid Contents from two arrays
static int[] FindEvenNums(int[] arr1, int[] arr2) {
    ArrayList result = new ArrayList();

    foreach(int num in arr1) {
        if (num % 2 == 0) {
            result.Add(num);
        }
    }
    foreach(int num in arr2) {
        if (num % 2 == 0) {
            result.Add(num);
        }
    }
    return (int[])result.ToArray(typeof(int));
}

// int[] arr1 = {-8, 2, 3, -9, 11, -20};
// int[] arr2 = {0, -2, -9, -39, 39, 10, 7};

// int[] evenArr = FindEvenNums(arr1, arr2);
// Array.ForEach(evenArr, Console.WriteLine);

//  ------------ Reverse Array
static int[] Reverse(int[] input) {
    int[] reversed = new int[input.Length];

    for (int i = 0; i < reversed.Length; i++) {
        reversed[i] = input[input.Length - i - 1];
    }
    return reversed;
}

static void ReverseInPlace(int[] input) {
    for (int i = 0; i < input.Length / 2; i++) {
        int temp = input[i];
        input[i] = input[input.Length - i - 1];
        input[input.Length -i - 1] = temp;
    }
}

int[] array1 = {1,2,3,4,5,6};
// Array.ForEach(Reverse(array1), Console.WriteLine);
ReverseInPlace(array1);
Array.ForEach(array1, Console.WriteLine);