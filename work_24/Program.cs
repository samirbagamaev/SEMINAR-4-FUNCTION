// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А       (7 => 28) (4 =>10)

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1ToA(int a)
{
   int sum = 0;
   for(int i = 1; i <= a; i++)
    {
       sum += i; 
       //sum = sum + i
    }
   return sum;
}

int number = ReadNumber("Введите чиcло: ");
if (number > 0)
{
    int sum = GetSum1ToA(number);
    Console.WriteLine(sum);
}
else 
{
Console.WriteLine("Число не правильное");
}