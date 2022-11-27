/* Написать программу, 
которая из имеющегося массива строк 
формирует массив из строк, 
длина которых меньше либо равна 3 символа. */

// ввод данных
string[] InputData()
{
    string[] input = new string[1];
    string check = string.Empty;
    int index = 0;
    while (check != "exit input")
    {
        Console.Write("Введите строку: ");
        check = Console.ReadLine();
        if (check == "exit input") break;
        else
        {
            input[index] = check;
            Array.Resize(ref input, input.Length + 1);
            index++;
        }
    }
    Array.Resize(ref input, input.Length - 1);
    return input;
}

// обработка введенных данных
string[] ProcessingData(string[] data)
{
    string[] newStringArray = new string[0];
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= 3)
        {
            Array.Resize(ref newStringArray, newStringArray.Length + 1);
            newStringArray[newStringArray.Length - 1] = data[i];
        }
    }
    return newStringArray;
}

string[] before = InputData();
string[] after = ProcessingData(before);
Console.WriteLine(string.Join(',', before));
Console.WriteLine(string.Join(',', after));