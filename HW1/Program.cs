
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

//2. Century Conversion
Console.Write("Enter number of centuries: ");
int century = int.Parse(Console.ReadLine());
ns.PrintCenturyConversion(century);

//3. Practice loops and operators
// Fizzbuzz:

