// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int sum = 0;
while(x > 0)
{
    sum = sum + x % 10;
    x = x / 10;
}
Console.Write(sum);