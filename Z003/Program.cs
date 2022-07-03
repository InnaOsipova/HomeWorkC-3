//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNum (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow (i, 3)+"; ");
    }
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number+"  -> ");
CubeNum(number);