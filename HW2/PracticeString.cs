using System.Text;
using System.Text.RegularExpressions;

namespace HW2;

public class PracticeString
{
    // Reverse String
    // Convert to char array
    public string ReverseString(string input)
    {
        char[] ca = input.ToCharArray();
        Array.Reverse(ca);
        return new string(ca);
    }
    
    //Print letters backwards
    public void ReverseString2(string input)
    {
        char[] ca = input.ToCharArray();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(ca[i]);
        }
    }
    
    // Reverse a word
    public string ReverseWord(string input)
    {
        string separators = @"[\s.,:;=()\[\]""'\\/!?]+";
        
        string[] words = Regex.Split(input, separators);
        MatchCollection matches = Regex.Matches(input, separators);
        
        List<string> output = new List<string>();
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                output.Add(word);
            }
        }
        output.Reverse();
        
        StringBuilder sb = new StringBuilder();
        int wordIndex = 0, matchIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetterOrDigit(input[i]))
            {
                if (wordIndex < output.Count)
                {
                    sb.Append(output[wordIndex]);
                    i += output[wordIndex].Length;
                    wordIndex++;
                }
            }
            else
            {
                if (matchIndex < matches.Count) 
                {
                    sb.Append(matches[matchIndex].Value);
                    i += matches[matchIndex].Value.Length; 
                    matchIndex++;
                }
            }
        }
        return sb.ToString();
    }
    
    // Palindromes
    public List<string> Palindromes(string input)
    {
        string pattern = @"\b\w+\b";
        MatchCollection matches = Regex.Matches(input, pattern);
        
        HashSet<string> uniquePalindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        
        foreach (Match match in matches)
        {
            string word = match.Value;
            if (IsPalindrome(word))
            {
                uniquePalindromes.Add(word); 
            }
        }
        
        return uniquePalindromes.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToList();
    }
    
    static bool IsPalindrome(string word)
    {
        string reversed = new string(word.Reverse().ToArray());
        return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
    
    // Parse URL
    public void ParseUrl(string url)
    {
        string protocol = "";
        string server = "";
        string resource = "";
        
        int protocolEndIndex = url.IndexOf("://");

        if (protocolEndIndex != -1) // If protocol exists
        {
            protocol = url.Substring(0, protocolEndIndex); 
            url = url.Substring(protocolEndIndex + 3); // Remove protocol part
        }

      
        int resourceStartIndex = url.IndexOf('/');

        if (resourceStartIndex != -1) // If resource exists
        {
            server = url.Substring(0, resourceStartIndex); 
            resource = url.Substring(resourceStartIndex + 1); // Extract resource
        }
        else
        {
            server = url; // If no resource, the remaining part is the server
        }

        // Print the extracted parts
        Console.WriteLine("\nParsed URL:");
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}