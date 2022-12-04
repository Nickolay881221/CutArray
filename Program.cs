// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которык меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] TextMassive = {"hello", "2", "world", ":-)"};

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

string[] CutArray (string[] firstarray)
{
    int m = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        if (firstarray[i].Length <= 3)
        {
            m++;
        }
    }
    
    string[] newarray = new string[m];
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        if (firstarray[i].Length <= 3)
        {
            newarray[count] = firstarray[i];
            count++;
        }
    }
    return newarray;
}

PrintArray(TextMassive);
System.Console.WriteLine();
string[] finalarray = CutArray(TextMassive);
PrintArray(finalarray);