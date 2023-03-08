/*Написать программу, которая из имеющегося
массива строк формирует массив из строк,
длина которых <=3 символа. Первоначальный маcсив можно задать на старте выполнения алгоритма.*/

string[] array = { "hello", "2", "world", ":-)" , "1234", "1567", "-2", "computer science"};

void MethodCreateInputArray(string[] InputArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}

void MethodCreateOutputArray(string[] OutputArray)
{
    Console.Write($"Output array: ");
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            newarr[i] = OutputArray[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}


Console.WriteLine();
MethodCreateInputArray(array);
Console.WriteLine();
MethodCreateOutputArray(array);
Console.WriteLine();
