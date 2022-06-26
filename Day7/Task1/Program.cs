using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
string line = ReadLine();

Regex regex = new Regex(@"^(?i:[йбвгджзклмнпрстфхцчшщ]\w*){3}");
MatchCollection matches = regex.Matches(line);

if(matches.Count > 0)
{
    foreach(Match match in matches)
    {
        WriteLine($"Слово {match.Value} начинается с трех или более согласных.");
    }
}
else
{
    WriteLine("В тексте нет слов с тремя или более согласными.");
}