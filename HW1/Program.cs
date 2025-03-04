
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