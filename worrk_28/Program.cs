// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetFact(int a)
{
   int fact = 1;
   for(int i = 1; i <= a; i++)
    {
       fact =fact * i;
    }
   return fact;
}

int number = ReadNumber("Введите чиcло: ");
if (number > 0)
{
    int sum = GetFact(number);
    Console.WriteLine(sum);
}
else 
{
Console.WriteLine("Число не правильное");
}

