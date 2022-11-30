
bool SearchNumberInArray(int[,] array, int findNumber)
{

    bool isFound = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNumber)
            {
                Console.Write((isFound ? "" : "Найдено:\n"));
                Console.WriteLine($"[{i},{j}]");
                isFound = true;
            }
        }
    }
    return isFound;
}




int[,] myTestArray = { { 1, 4, 7, 2 },
                       { 5, 9, 2, 3 },
                       { 8, 4, 2, 4}};

Console.WriteLine("Введите число для поиска: ");
int findNum = int.Parse(Console.ReadLine());
bool resultSearch = SearchNumberInArray(myTestArray, findNum);
if (!resultSearch)
{
    Console.WriteLine($"Элемент со значением {findNum} не найдены");
}
