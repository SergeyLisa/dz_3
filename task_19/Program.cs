// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int d, sum = 0; 
int temp = a;
while (a > 0)
{
  d = a %  10;
  sum =  (sum * 10) + d;
  a = a / 10;
}
if (temp == sum)
{
  Console.WriteLine($"число {temp} является палиндромом.");
}
else
{
  Console.WriteLine($"число {temp} не является палиндромом");
}
