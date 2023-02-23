//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double n = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));


    Console.WriteLine($"Расстояние составляет {n}");
}

Console.WriteLine("Введите координату х1, у1, z1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2, y2, z2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Distance( x1,  y1, z1,  x2,  y2,  z2);
