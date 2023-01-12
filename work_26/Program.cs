// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5


int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumber (int number)
{
    int count = 1;
    while (number / 10 != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}

int num = ReadNumber("Введите число");
int count1 = CountNumber(num);
Console.WriteLine(count1);
