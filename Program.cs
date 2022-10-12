// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*Console.WriteLine("--------------Задача №25.--------------");
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int Exponentiation(int num)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
//      result *= A:
        result = result * A;
    }
    return result;
}
Console.WriteLine($"Число {A} в {B} степени = {Exponentiation(A)}");*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("--------------Задача №27.--------------");
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {i} = {SumNumber(i)}");

int SumNumber(int num)
{
    int sum = 0;
    while (i > 0)
    {
        num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    return sum;
}