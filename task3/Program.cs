// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

void DefCube(int num)
{
    Console.Write($"{num} -> ");
        for(int i = 1; i < num; i++)
        Console.Write(i * i * i + ", ");
    Console.Write(num * num * num +".");
}

int GetInfo (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");
DefCube(num);