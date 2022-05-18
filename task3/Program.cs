// #23. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов числа от 1 до N
// 3 -> 1,4,9
// 5 -> 1, 8, 27, 64, 125

void GetSquar(int N)
{
    foreach (int ind in Enumerable.Range(1, N))
    //foreach (int ind in Range(1,N))
    System.Console.Write($"{ind * ind * ind}, ");
}

//функция которая получает число, введенное с клавиатуры
//+ проверка на то что ввели именно число
//+ проверка что число !=0
int GetNumber(string msg)
{
    
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 0)
                return number;
            else
            {
                Console.WriteLine("Число должно быть больше нуля");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число отличное от нуля.");
        }
    }
}

string messageI = "Введите N от 1, N =";
int sqr = GetNumber(messageI);

GetSquar(sqr);