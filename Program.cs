// Задача 10: Показать вторую цифру трёхзначного числа.
int n = new Random().Next(100,1000);
Console.WriteLine("Случайное число: " +n);
int result = n %100 /10;
Console.WriteLine("Вторая цифра числа="+ result);
