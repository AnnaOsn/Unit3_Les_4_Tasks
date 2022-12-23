// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число -> ");
int A = int.Parse(Console.ReadLine()!);
string STR_A = Convert.ToString(A);
int sum = 0;
for (int i = 0; i < STR_A.Length; i++)
{
    string a = Convert.ToString(STR_A[i]);
    sum = sum + Convert.ToInt32(a);
}
Console.WriteLine(sum);
