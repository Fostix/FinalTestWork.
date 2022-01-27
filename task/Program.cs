Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()),
maxLengthArray = 10000,
wordNoLongerThanThree = 3;


if (number == 1)
{
    Console.Write("Enter array length: ");
    int arrayLength = int.Parse(Console.ReadLine());
    if (arrayLength > 0 && arrayLength < maxLengthArray)
    {
        string[] array = new string[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter word(s) through space: ");
            array[i] = Console.ReadLine();
        }
        string[] newArray = Method(array);
        Console.Write("Old array: ");
        PrintArray(array);
        Console.WriteLine();
        Console.Write("New array: ");
        PrintArray(newArray);
    }
    else
    {
        Console.WriteLine("you entered too large a value or less than one value");
    }
}

else if (number == 2)
{
    string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
    string[] newArray = Method(array);
    Console.Write("Old array: ");
    PrintArray(array);
    Console.WriteLine();
    Console.Write("New array: ");
    PrintArray(newArray);
}
else
{
    Console.WriteLine("incorrect");
}



string[] Method(string[] array)
{
    string sizeWord;
    int sizeNewArray = 0;

    string[] newArray = new string[array.Length];

    for (int row = 0; row < array.Length; row++)
    {
        sizeWord = array[row];
        if (sizeWord.Length <= wordNoLongerThanThree)
        {
            newArray[sizeNewArray] = array[row];
            sizeNewArray++;
        }
    }
    Array.Resize(ref newArray, sizeNewArray);
    return newArray;
}






void PrintArray(string[] print)
{
    for (int row = 0; row < print.Length; row++)
    {
        Console.Write(print[row] + " ");
    }
}