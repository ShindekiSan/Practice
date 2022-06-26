using static System.Console;

try
{
    Random rand = new Random();
    int Randomizer()
    {
        return rand.Next(1, 10);
    }
    Number[] numArr = new Number[5];
    for (int i = 0; i < numArr.Length; i++)
    {
        numArr[i] = Randomizer;
    }

    MediumCalc mediumCalc = delegate (Number[] arrayX)
    {
        var arrayT = new int[5];
        int sum = 0;
        for (int i = 0; i < arrayX.Length; i++)
        {
            arrayT[i] = arrayX[i]();
            sum += arrayT[i];
            Console.Write(arrayT[i] + " ");
        }
        return ((double)(sum) / (arrayX.Length));
    };

    Console.WriteLine($"\nResult = {mediumCalc(numArr)}");

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
public delegate int Number();
public delegate double MediumCalc(Number[] arrayX);