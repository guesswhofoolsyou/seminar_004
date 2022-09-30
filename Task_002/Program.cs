/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)

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

int Summ(int number)
{
    string numberStr = number.ToString();
    int lengthNumber = numberStr.Length;
    int summ = 0;
    char [] numberArray = numberStr.ToCharArray();
    for (int i = 0; i <= lengthNumber-1; i++)
    {
        int digit = numberArray[i] - '0';
        Console.WriteLine(digit);
        summ = summ + digit;
    }
    return summ;
}

int number = GetNumber("Введите число"); 
int summ = Summ(number);
Console.WriteLine(summ);