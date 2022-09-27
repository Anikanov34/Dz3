// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 
void CheckingNumber()
{
     int number = 55;

     for (int i = 1; i <= number; i++)
     {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i ,3)}");
     }
}

 CheckingNumber();