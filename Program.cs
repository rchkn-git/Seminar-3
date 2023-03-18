/*int[] coords = new int[2];

System.Console.Write("Введите X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y: ");
coords[0] = Convert.ToInt32(Console.ReadLine());

if(coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if(coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if(coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}
else if(coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Точка находится в четвёртой четверти");
}
else if(coords[0] == 0 || coords[1] == 0)
{
    System.Console.WriteLine("Точка находится на оси");
}

*/

//Через функции
/*
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckQuarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится в первой четверти");
    }
    else if(x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится во второй четверти");
    }
    else if(x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в третьей четверти");
    }
    else if(x > 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в четвёртой четверти");
    }
    else if(x == 0 || y == 0)
    {
        System.Console.WriteLine("Точка находится на оси");
    }
}

int[] coords = new int[2];
coords[0] = ReadInt("Введите X: ");
coords[1] = ReadInt("Введите Y: ");
CheckQuarter(coords[0], coords[1]);
*/

/*
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[2];
int[] b = new int[2];
a[0] = ReadInt("Введите координату X точки A: ");
a[1] = ReadInt("Введите координату Y точки A: ");
b[0] = ReadInt("Введите координату X точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2)), 3);
System.Console.WriteLine("Расстояние между точками = " + res);
*/


//Через функцию
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите число: ");
double[] res = new double[a];
void PowNow(int X){
    for(int i = 1; i <= X; i++)
    {
        res[i-1] = Math.Pow(i, 2);
    }
    var str = string.Join(", ", res);
    Console.WriteLine ("Результат = " + str);
}
PowNow(a);
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4