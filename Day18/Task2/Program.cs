using System.Text;
using System.Text.RegularExpressions;

Regex numberRegex = @"\d";

Queue<int> numbersGroup = new Queue<int>();
Queue<int> symbolsGroup = new Queue<int>();

using (StreamReader reader = new StreamReader(@"file.txt", Encoding.UTF8))
{
    while (!reader.EndOfStream)
    {
        symbol = 5;
        
        if (numberRegex.Matches(symbol))
            numbersGroup.Enqueue(number);
        else
            symbolsGroup.Enqueue(number);
    }
}

Console.WriteLine(string.Join(" ", symbolsGroup));
Console.WriteLine(string.Join(" ", numbersGroup));