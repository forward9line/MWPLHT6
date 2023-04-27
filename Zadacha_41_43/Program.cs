
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*
Console.Write("Задайте длинну диапазона: L =  ");
bool isParsed = int.TryParse(Console.ReadLine(), out int l);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;

}


if (l !< 0)
{
    Console.WriteLine("Введено не положительное число");
    return;
}






int[] array = GetMeArray(l);


int e = NumberOfPositive(array);



PrintArray(array, e);


int[] GetMeArray(int l)
{
    int[] array = new int[l];


    for (int i = 0; i < l; i++)
    {
        Console.WriteLine($"Введите число №{i+1}");
        bool isParsed = int.TryParse(Console.ReadLine(), out int n);

    if (!isParsed)
    {
        Console.WriteLine("Введено не число");
        break;

    }

    array[i] = n;    



    }


return array;


}

int NumberOfPositive(int[] array)
{
    int e = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            e++;
        }
        
    }
    return e;
}





void PrintArray(int[] array, int e)
{
    Console.WriteLine($"{string.Join(", ", array)} -> {e}");
}


*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");


Console.WriteLine("Введите b1:");

bool isParsedB1 = int.TryParse(Console.ReadLine(), out int b1);

if (!isParsedB1)
{
    Console.WriteLine("Введено не число");
    return;

}

Console.WriteLine("Введите k1:");

bool isParsedK1 = int.TryParse(Console.ReadLine(), out int k1);

if (!isParsedK1)
{
    Console.WriteLine("Введено не число");
    return;

}

Console.WriteLine("Введите b2:");

bool isParsedB2 = int.TryParse(Console.ReadLine(), out int b2);

if (!isParsedB2)
{
    Console.WriteLine("Введено не число");
    return;

}


Console.WriteLine("Введите k2:");

bool isParsedK2 = int.TryParse(Console.ReadLine(), out int k2);

if (!isParsedK2)
{
    Console.WriteLine("Введено не число");
    return;

}
float x = 0;
float y = 0;

//y = k1 * x + b1, y = k2 * x + b2
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые паралельны");
        }
        else
        {
        x = (b2 - b1) / (k1 - k2);
    
        y = k1*(b2-b1)/(k1-k2)+b1;
    

        Console.WriteLine($"{x}, {y}");
        }
    }


































