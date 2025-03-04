
// Playing With The Console App

/* Too many characters in character literal
Console.WriteLine('Hello');
*/

/* The name HelloWorld does not exist in the current context
Console.WriteLine(HelloWorld);
*/

string str = "Hello World";
Console.WriteLine(str);

// Using ReadLine and WriteLine
Console.Write("Enter favorite color: ");
string favColor = Console.ReadLine();
Console.Write("Enter astrology sign: ");
string astrology = Console.ReadLine();
Console.Write("Enter address number: ");
string addr = Console.ReadLine();

Console.WriteLine($"Your hacker name is {favColor}{astrology}{addr}");

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "Type", "Bytes", "Min Value", "Max Value");
Console.WriteLine(new string('-', 90));

//1. Number of Bytes
NumberSizeAndRanges ns = new NumberSizeAndRanges();
ns.PrintTypeInfo<sbyte>("sbyte");
ns.PrintTypeInfo<byte>("byte");
ns.PrintTypeInfo<short>("short");
ns.PrintTypeInfo<ushort>("ushort");
ns.PrintTypeInfo<int>("int");
ns.PrintTypeInfo<uint>("uint");
ns.PrintTypeInfo<long>("long");
ns.PrintTypeInfo<ulong>("ulong");
ns.PrintTypeInfo<float>("float");
ns.PrintTypeInfo<double>("double");
ns.PrintTypeInfo<decimal>("decimal");

Console.WriteLine("---------------------------------------------------------");

//2. Century Conversion
Console.Write("Enter number of centuries: ");
int century = int.Parse(Console.ReadLine());
ns.PrintCenturyConversion(century);


Console.WriteLine("---------------------------------------------------------");
//3. Practice loops and operators
// Fizzbuzz:
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    
    else if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("fizz");
    }
    
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine("buzz");
    }

    else
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Guess the number");

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Enter your guess: ");
int guess = int.Parse(Console.ReadLine());

switch (guess)
{
    case 1:
        if (guess == correctNumber)
        {
            Console.WriteLine("You got the correct number");
        }
        break;
    case 2:
        if (guess < correctNumber)
        {
            Console.WriteLine("Your guess is low");
        }
        break;
    case 3:
        if (guess > correctNumber)
        {
            Console.WriteLine("Your guess is high");
        }
        break;
    default:
        Console.WriteLine("Your guess is outside the range");
        break;
}

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Pyramid");

// Print a pyramid
int rows = 5; 

for (int i = 1; i <= rows; i++) 
{
    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine(); 
}

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Birthdate");

DateTime birthday = new DateTime(2014, 3, 26);
int age = DateTime.Today.Year - birthday.Year;
int days = (age * 365) + (age / 4);
Console.WriteLine($"The birthday is {birthday}");
Console.WriteLine($"The age in days {days}");

int daysToNextAnniversary = 10000 - (days % 10000);
Console.WriteLine($"Days of next 10,000 days anniversary {daysToNextAnniversary}");

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Greeting");

DateTime currentTime = DateTime.Now; 
        
int hour = currentTime.Hour; 

Console.WriteLine("Current Time: " + currentTime.ToString("hh:mm tt"));

if (hour >= 5 && hour < 12) 
{
    Console.WriteLine("Good Morning!");
}

if (hour >= 12 && hour < 17) 
{
    Console.WriteLine("Good Afternoon!");
}

if (hour >= 17 && hour < 21) 
{
    Console.WriteLine("Good Evening!");
}

if ((hour >= 21 && hour <= 23) || (hour >= 0 && hour < 5)) 
{
    Console.WriteLine("Good Night!");
}

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Counting");

for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write($"{j},");
    }
    Console.WriteLine();
}