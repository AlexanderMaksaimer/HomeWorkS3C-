// #21. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве
// А(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

int GetNumber(string msg)
{
    
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number))
        {
           return number;
           
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}
double GetLengthWector (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double difx = Math.Pow((x1 - x2), 2);
    double dify = Math.Pow((y1 - y2), 2);
    double difz = Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(difx + dify+ difz);
    return length;
}

int x1 = GetNumber("Введите координату первой точки по оси Х");
int y1 = GetNumber("Введите координату первой точки по оси У");
int z1 = GetNumber("Введите координату первой точки по оси Z");
int x2 = GetNumber("Введите координату второй точки по оси Х");
int y2 = GetNumber("Введите координату второй точки по оси У");
int z2 = GetNumber("Введите координату второй точки по оси Z");

double resault = GetLengthWector(x1, x2, y1, y2, z1, z2);

Console.WriteLine(resault);
