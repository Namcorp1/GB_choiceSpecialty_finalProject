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