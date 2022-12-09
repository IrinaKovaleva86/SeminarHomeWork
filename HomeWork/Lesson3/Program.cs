//Задача 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*
bool Palindrom(int number)
{
    int n = number;
    int temp = 0;
    int revNum = 0;
    while(n > 0)
        {
            temp = n % 10;
            revNum = revNum*10 + temp;
            n /= 10;
        }

    n = number;
    if (n == revNum)
        {
            Console.WriteLine("Yes");
            return true;
        }
    else
        {
            Console.WriteLine("No");
            return false;
        }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

/*
double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double x = xb - xa;
    double y = yb - ya;
    double z = zb - za;
    double result = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
    return result;
}

Console.Write("Введите xA: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите yA: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите zA: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите xB: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите yB: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите zB: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками " + dist);
*/

//Задача 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int num)
 {
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)}" + " ");
        count++;
    }
 }
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/
