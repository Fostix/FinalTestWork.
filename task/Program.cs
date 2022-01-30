
string[] array = new string[0];

int number = ChoiceEnterNumber();
if (number == 1)
{
    array = EnterYourselfMethod();
}
else if (number == 2)
{

    array = ScriptMethod();
}

string[] newArray = NewArrayMethod(array);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);




int ChoiceEnterNumber()
{
    int number = 0;
    do
    {
        Console.Write("Enter 1 if you wont enter yourself\n2 for skript\nnumber:  ");
        string stringNumber = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(stringNumber);
            if (number < 1 | number > 2)
            {
                Console.Write("Insert a number 1 or 2: ");
            }
        }
        catch (System.Exception)
        {
            Console.Write("Insert a number: ");
        }

    } while (number != 1 && number != 2);
    return number;
}


string[] EnterYourselfMethod()
{
    Console.Write("Enter array length: ");
    int arrayLength;
    do
    {
        string stringArrayLength = Console.ReadLine();
        try
        {
            arrayLength = Convert.ToInt32(stringArrayLength);
            if (arrayLength < 1)
            {
                Console.Write("Array length cannot be negative number, enter natural number: ");
            }
        }
        catch (System.Exception)
        {
            arrayLength = -1;
            Console.Write("Enter number: ");
        }
    } while (arrayLength < 1);

    string[] array = new string[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter word {i + 1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ScriptMethod()
{
    string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
    return array;
}


string[] NewArrayMethod(string[] oldArray)
{
    string sizeWord;
    int sizeNewArray = 0,
    wordCannotLongerThanThree = 3;

    string[] newArray = new string[oldArray.Length];
    for (int row = 0; row < oldArray.Length; row++)
    {
        sizeWord = oldArray[row];
        if (sizeWord.Length <= wordCannotLongerThanThree)
        {
            newArray[sizeNewArray] = oldArray[row];
            sizeNewArray++;
        }
    }
    Array.Resize(ref newArray, sizeNewArray);
    return newArray;
}


void PrintArray(string[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.WriteLine($" word {i + 1}: {print[i]}");
    }
}