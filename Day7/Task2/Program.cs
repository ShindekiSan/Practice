using static System.Console;
using System.Text.RegularExpressions;

Write("Введите текст: ");
string text = ReadLine();

WriteLine((Regex.IsMatch(text, @"\w*(\w)(?=\w*\1)\w*")) ? "Текст содержит слова с двумя одинаковыми буквами." : "Текст не содержит слова с двумя одинаковыми буквами.");