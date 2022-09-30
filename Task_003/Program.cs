/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/



int GetLength(string message)
{
    int result = 0;
    bool correctInput = false;    

    while(!correctInput)
    {
        Console.WriteLine(message);
        correctInput = int.TryParse(Console.ReadLine(), out result);

        if(result < 1)
            correctInput = false;

        if(!correctInput)
            Console.WriteLine("Вы ввели некорректное число");

        Console.WriteLine();
    }

    return result;
}

int[] GenArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }

    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int arrayLength = GetLength("Введите длину массива");
int[] array = GenArray(arrayLength);

PrintArray(array);
var result = string.Join(", ", array);
Console.WriteLine($"[{result}]");

//______________________________________________________

string[] GetArray(string message)
{
    Console.WriteLine(message);
    string arrayStr = Console.ReadLine()??"";
    string [] array = arrayStr.Split(", ");

    return array;
}

string [] secondArray = GetArray("Введите массив");
var secondResult = string.Join(", ", array);
Console.WriteLine($"[{result}]");