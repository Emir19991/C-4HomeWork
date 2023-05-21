// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите любое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = NaturalStep(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");
// Console.WriteLine("Ответ: " + result);


int NaturalStep(int numA, int numB)
{
    int count = 1;
    for (int i = 1; i <= numB; i++)
    {
        count = count * numA;
    }
    return count;
}    