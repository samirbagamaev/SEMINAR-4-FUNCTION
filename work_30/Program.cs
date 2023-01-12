// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillRandomArray(int size)
{
    int[] arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(0, 2); 
       // пишем 2, чтобы включить в диапазон 1
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] +" ");
    }
}

int[] array = FillRandomArray(8);
PrintArray(array);

// И БУДЕТ ВОТ ТАК: 1 0 0 1 0 0 0 0




//ИЛИ ЖЕ МОЖЕМ НАПИСАТЬ ВОТ ТАК, БЕЗ ЦИКЛА ~
//ИЛИ ЖЕ МОЖЕМ НАПИСАТЬ ВОТ ТАК, БЕЗ ЦИКЛА ~
//ИЛИ ЖЕ МОЖЕМ НАПИСАТЬ ВОТ ТАК, БЕЗ ЦИКЛА ~




int[] FillRandomArray(int size)
{
    int[] arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(0, 2); 
       // пишем 2, чтобы включить в диапазон 1
    }
    return arr;
}

int[] array = FillRandomArray(8);
Console.WriteLine(string.Join(", ", array));

// И БУДЕТ ВОТ ТАК: 1, 1, 1, 0, 0, 1, 0, 1