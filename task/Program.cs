Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());


if (number == 1)
{
    Console.Write("Enter array length: ");
    int lengthArray = int.Parse(Console.ReadLine());
    Console.Write("Enter word(s) through space: ");
    string[] array = new string[lengthArray];
}
else if (number == 2)
{
    string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
    string[] newArray = Method(array);
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
    for (int i = 0; i < array.Length; i++)
    {
        sizeWord = array[i];
        if (sizeWord.Length <= 3)
        {
            sizeNewArray++;
        }
    }

    string[] newArray = new string[sizeNewArray];
    int index = 0;

    for (int row = 0; row < array.Length; row++)
    {
        sizeWord = array[row];
        if (sizeWord.Length <= 3)
        {
            newArray[index] = array[row];
            index++;
        }
    }
    return newArray;
}






void PrintArray(string[] print)
{
    for (int row = 0; row < print.Length; row++)
    {
        Console.Write(print[row] + " ");
    }
}