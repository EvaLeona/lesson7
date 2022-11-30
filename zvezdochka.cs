

int RomeToAracbic(char sumbol)
{   
    string romeNumeric = "IVXLCDM";
    int[] arabicNumeric = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };
    int index = romeNumeric.IndexOf(sumbol);
    if (index >= 0) return arabicNumeric[index];
    return 0;
}

int RomeNumberParse(string romeNumber)
{
    int result = 0;
    for (int i = 0; i < romeNumber.Length; i++)
    {
        int currentNumber = RomeToAracbic(romeNumber[i]);
        if (currentNumber == 0)
        {   
            throw new Exception("Invalid character in the Roman notation of the number.");
        }
        if (i + 1 < romeNumber.Length)
        {
            /
            if (currentNumber < RomeToAracbic(romeNumber[i + 1]))
            {
                result -= currentNumber;
            }
            else
            {
                result += currentNumber;
            }
        }
        else
        
        {
            result += currentNumber;
        }
    }
    return result;
}


string[] exampleRome = { "III", "LVIII", "MCMXCIV" };
foreach (var item in exampleRome)
{
    int arabicNumber = RomeNumberParse(item);
    Console.WriteLine($"{item} = {arabicNumber}");
}

