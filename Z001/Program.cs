//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string TransformationArray (string str)
{
    char [] array = str.ToCharArray();
    Array.Reverse(array);
    string fin = new string(array);
    return fin;
}

Console.Write("Ведите пятизначное числоа : ");
string number = Console.ReadLine();
string newNumber = TransformationArray(number);

if (newNumber != number)
{
    Console.WriteLine("Данная запись не является палиндромом");
}
else
{
    Console.WriteLine("Данная запись является палиндромом");
}