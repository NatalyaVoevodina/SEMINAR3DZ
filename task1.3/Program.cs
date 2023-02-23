//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());
int temp1 = N;
int num1=N/1000;
string num2="";
if ( (N / 10000 >= 1 && N / 10000 <= 9))
{
for(int i=0; i<2; i++)
{
num2 = num2 + $"{N % 10}";
N = N/10;
}
if (num1==Convert.ToInt32(num2)) Console.WriteLine($"{temp1} -Является палиндромным числом");
else Console.WriteLine($"{temp1} - Не является палиндромным числом");
}
else Console.WriteLine($"{temp1} - Не является пятизначным числом");