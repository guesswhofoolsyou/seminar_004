/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int Expon(int n, int p)
{
    int result =(int)Math.Pow(n, p);
    return result;   
}

int firstNumber = GetNumber("Введите первое число:");
int secondNumber = GetNumber("Введите второе число:");

int expon = Expon(firstNumber,secondNumber);
Console.WriteLine(expon);