string[] firstArray = { "Hello", "2", "World", ":-)" };

PrintArray(firstArray);
Console.WriteLine();
string[] secondArray = ReplaceString(firstArray);
PrintArray(secondArray);

string[] ReplaceString(string[] userString)
{
    string[] resultString = new string [userString.Length];
    for (int i = 0; i < userString.Length; i++)
    {
        if (userString[i].Length > 3) resultString[i] = "";
        else resultString[i] = userString[i];
    }
    return resultString;
}

void PrintArray(string[] array)
{
    foreach (var str in array) Console.Write($"{str} ");
}
