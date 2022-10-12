// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("--------------Задача №25.--------------");
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
Console.WriteLine($"Число {A} в {B} степени = {Exponentiation(A)}");

