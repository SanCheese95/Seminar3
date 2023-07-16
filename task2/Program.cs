// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(int xA,int yA,int zA,int xB,int yB,int zB)
{
    double lenght = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
    return lenght;
}

int GetInfo (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int coorxA = GetInfo("Введите координату x числа A: ");
int cooryA = GetInfo("Введите координату y числа A: ");
int coorzA = GetInfo("Введите координату z числа A: ");
int coorxB = GetInfo("Введите координату x числа B: ");
int cooryB = GetInfo("Введите координату y числа B: ");
int coorzB = GetInfo("Введите координату z числа B: ");

Console.WriteLine($"A ({coorxA},{cooryA},{coorzA}); B ({coorxB},{cooryB},{coorzB}) -> {FindDistance(coorxA, cooryA, coorzA, coorxB, cooryB, coorzB)}");