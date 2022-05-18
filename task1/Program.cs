// # 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число: ");
string NumberStr = Console.ReadLine();

int number = int.Parse(NumberStr);

if ((number > 9999) && (number <= 99999))
{
    if (NumberStr[0]==NumberStr[4] && NumberStr[1]==NumberStr[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено некорректное значение");
}

