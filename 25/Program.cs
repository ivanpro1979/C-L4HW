// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Программа принимает на ввод два целых числа и возводит первое число в степень равную второму числу.");
Console.Write("Задайте число, которое нужно возвести в степень: ");
int numA = (Convert.ToInt32(Console.ReadLine()));
Console.Write("Задайте степень в которую нужно возвести: ");
int numB = (Convert.ToInt32(Console.ReadLine()));
int b = 1;
double PowNum = 1.0;
if (numB >= 0)
{
    while (b < numB + 1)
   {
       PowNum = Convert.ToInt32((Math.Pow(numA,b)));
       b ++;
   }
Console.Write(PowNum);
}
else 
{
    while (b < (-numB) +1)
   {
       PowNum = Convert.ToDouble(1 / (Convert.ToInt32((Math.Pow(numA,b)))));
       b ++;
   }
Console.Write(PowNum);   
}