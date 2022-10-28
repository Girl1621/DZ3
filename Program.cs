//Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int palindrom = 0;
int num = number;

Console.WriteLine(num == palindrom ? "палиндром" : "не палиндром");

while (number > 0)
{
    palindrom = palindrom * 10 + number % 10; number /= 10;
}

//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dis;
}

Console.WriteLine("Введите координаты первой точки:");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);

Console.WriteLine("Введите координаты второй точки:");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

if (!isParsedXA || !isParsedYA || !isParsedZA || !isParsedXB || !isParsedYB || !isParsedZB)
{
    Console.WriteLine("Ошибка! Не правильно введены координаты.");
    return;
}

double distanceDot = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками: {distanceDot}");


//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
int [] GetTabOfCubes(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}
int[] result = GetTabOfCubes(n);
PrintArray(result);
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}

