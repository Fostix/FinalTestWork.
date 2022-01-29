Console.Write("Enter number: ");
int number;
do
{
    string stringNumber = Console.ReadLine();
    try
    {
        number = Convert.ToInt32(stringNumber);
        if (number > 2 | number < 1)
        {
            number = 3;
            Console.Write("Insert a nubmer more than 1: ");

        }
    }
    catch (Exception)
    {

        number = 3;
        Console.Write("Insert a nubmer: ");
    }
} while (number != 1 & number != 2);
int maxLengthArray = 10000,
wordNoLongerThanThree = 3;


if (number == 1)
{
    Console.Write("Enter array length: ");
    //int arrayLength = int.Parse(Console.ReadLine());
    int arrayLength;
    do
    {
        string stringArrayLength = Console.ReadLine();
        try
        {
            arrayLength = Convert.ToInt32(stringArrayLength);
            if (arrayLength < 1 && arrayLength == 0)
            {
                Console.Write("Renter number: ");
            }
        }
        catch (Exception)
        {
            arrayLength = -1;
            Console.Write("incorrect: ");
        }
    } while (number < 1 & number != 1);


    if (arrayLength > 0 && arrayLength < maxLengthArray)
    {
        string[] array = new string[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter word {i + 1}: ");
            array[i] = Console.ReadLine();
        }
        string[] newArray = Method(array);
        Console.Write("Old array: ");
        PrintArray(array);
        Console.WriteLine();
        Console.Write("New array: ");
        PrintArray(newArray);
    }
    // else
    // {
    //     Console.WriteLine("you entered too large a value or less than one value");
    // }
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