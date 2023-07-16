// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckNum(string num)
{
    if(num[0] == num[4] || num[1] == num[3])
    {
        Console.Write($"{num} -> да");
    }
    else Console.Write($"{num} -> нет");
}

string GetInfo (string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = GetInfo("Введите число: ");
CheckNum(num);