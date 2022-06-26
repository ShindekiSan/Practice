using static System.Console;

try
{
    Write("Введите строку: ");
    string str = ReadLine();

    Message msg = ChangeReg;
    msg += Substr;
    msg += Separate;

    msg(str);
}

catch (Exception ex)
{
    WriteLine(ex.Message);
}

void ChangeReg(string str)
{
    WriteLine(str.ToUpper());
}

void Substr(string str)
{
    WriteLine(str.Substring(2));
}

void Separate(string str)
{
    string[] words = str.Split(' ');

    foreach (string word in words)
        WriteLine(word);
}

delegate void Message(string str);