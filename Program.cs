// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
void CheckingNumber()
{
int number =23432;
int current_number = number;
int result = 0;
while (current_number > 0)
{
    int digit = current_number % 10;
    result = result * 10+ digit;
    current_number /= 10;
    Console.WriteLine(result);
}
if(number == result)
{
    Console.WriteLine($"число палиндром");
}
else
{
    Console.WriteLine($"число не палиндром");
}
}
CheckingNumber();