// Copying an Array

using HW2;

Console.WriteLine("Copying an array");

int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int [] arrayCopy = new int[array.Length];

// copying
for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
}

//printing
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < arrayCopy.Length; i++)
{
    Console.Write($"{arrayCopy[i]} ");
}

Console.WriteLine();

// Manage list of elements 
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Manage list of elements");

List<String> toDoList = new List<String>();
toDoList.Add("Buy groceries");
toDoList.Add("Complete project report");
toDoList.Add("Workout");
toDoList.Add("File taxes");


while (true)
{
    Console.WriteLine("Enter command (+ item, - item, -- to clear, or q to quit)):");
    string command = Console.ReadLine().Trim();
    if (command == "q")
    {
        Console.WriteLine("Quitting...");
        break;
    }

    if (command == "--")
    {
        toDoList.Clear();
        Console.WriteLine("List has been cleared.");
    }
    
    else if (command.StartsWith("+ "))
    {
        string item = command.Substring(2).Trim();
        if (!string.IsNullOrEmpty(item))
        {
            toDoList.Add(item);
            Console.WriteLine($"Added: {item}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an item name after '+'.");
        }
    }
    
    else if (command.StartsWith("- "))
    {
        string item = command.Substring(2).Trim();
        if (toDoList.Remove(item))
        {
            Console.WriteLine($"Removed: {item}");
        }
        else
        {
            Console.WriteLine($"Item '{item}' not found in the list.");
        }
    }

    else
    {
        Console.WriteLine("Invalid input. Please enter a valid command.");
    }
    
    Console.WriteLine("\nCurrent List:");
    if (toDoList.Count == 0)
    {
        Console.WriteLine("[Empty]");
    }
    else
    {
        foreach (string item in toDoList)
        {
            Console.WriteLine($"- {item}");
        }
    }
}

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Calculate prime numbers");

static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    for (int i = startNum; i <= endNum; i++)
    {
        if (IsPrime(i))
        {
            primes.Add(i);
        }
    }
    return primes.ToArray();
}

static bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    
    for (int i = 2; i * i <= number; i++) 
    {
        if (number % i == 0)
            return false;
    }

    return true;
}

int[] primeNumbers = FindPrimesInRange(2, 50);
Console.WriteLine("Print prime numbers from 2 to 50");
Console.WriteLine(string.Join(", ", primeNumbers));

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Read an array of integers");

Console.Write("Enter array elements (space-separated): ");
int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.Write("Enter the number of rotations: ");
int k = int.Parse(Console.ReadLine());

ArrayRotation ar = new ArrayRotation();

int[] sumArray = ar.rotateSum(array1, k);
Console.WriteLine(string.Join(" ", sumArray));

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Longest sequence of equal elements");

Console.Write("Enter array elements (space-separated): ");
int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

LongestSequence ls= new LongestSequence();
int[] longestSequence = ls.FindLongestSequence(array2);
Console.WriteLine(string.Join(" ", longestSequence));

Console.Write("Enter array elements (space-separated): ");
int[] array3 = Console.ReadLine().Split().Select(int.Parse).ToArray();

MostFrequentNumber mf = new MostFrequentNumber();
mf.FindMostFrequentNumber(array3);

// Practice String
PracticeString ps = new PracticeString();
//1.
Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Reverse the string sample");
Console.WriteLine($"The string in reverse is {ps.ReverseString("sample")}");
Console.Write("The string in reverse is ");
ps.ReverseString2("sample");
Console.WriteLine();

//2. Reverse a word
Console.WriteLine("--------------------------------------------------");
string sentence = "C# is not C++, and PHP is not Delphi!";
Console.WriteLine($"Reverse the sentence: {sentence}");
Console.WriteLine($"The sentence in reverse is {ps.ReverseWord(sentence)}");

//3. 
Console.WriteLine("--------------------------------------------------");
string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
List<string> palindromes = ps.Palindromes(input);

Console.WriteLine("\nUnique palindromes (sorted):");
Console.WriteLine(string.Join(", ", palindromes));

//4. 
Console.WriteLine("--------------------------------------------------");
string url = "https://www.apple.com/iphone";
ps.ParseUrl(url);