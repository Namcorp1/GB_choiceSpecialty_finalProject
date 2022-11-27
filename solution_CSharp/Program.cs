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
        Console.Write("Введите строку, после того как закончите, введите 'exit input': ");
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

int InputFilter()
{
    bool check = false;
    int num = -1;
    while(!check)
    {
        
        Console.Write("Введите кол-во символов для фильтрации: ");
        string input = Console.ReadLine();
        int.TryParse(input,out num);
    }
    return num;
}

// обработка введенных данных
string[] ProcessingData(string[] data, int filterCount)
{
    string[] newStringArray = new string[0];
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= filterCount)
        {
            Array.Resize(ref newStringArray, newStringArray.Length + 1);
            newStringArray[newStringArray.Length - 1] = data[i];
        }
    }
    return newStringArray;
}

//вывод результата
void PrintResult(string[] before, string[] after)
{
    Console.WriteLine("Итоги фильтрации:");
    Console.WriteLine($"Массив ДО - {string.Join(',',before)}");
    Console.WriteLine($"Массив ПОСЛЕ - {string.Join(',',after)}");
}

// клиентский код
string[] initialArray = InputData();
int count = InputFilter();
string[] processedArray = ProcessingData(initialArray, count);
PrintResult(initialArray, processedArray);