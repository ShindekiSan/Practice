using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
var line = ReadLine();

Regex regex = new Regex(@"\b([1-9]|[1-9][0-9])\b");
MatchCollection matches = regex.Matches(line);

if (matches.Count > 0)
{
    foreach (var i in matches)
        WriteLine(i);
}
else
{
    WriteLine("Текст не содержит цифр от 1 до 99");
}