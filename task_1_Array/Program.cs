string[] arrayOriginal = {"hello", "2", "world", ":-)"};
string[] arrayNew = new string[arrayOriginal.Length];
 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(arrayOriginal);

for (int i = 0; i < arrayOriginal.Length; i++)
{
    if(arrayOriginal[i].Length <= 3)
    {
        arrayNew[i] = arrayOriginal[i];
    }
}

Console.WriteLine();
PrintArray(arrayNew);