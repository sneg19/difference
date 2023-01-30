/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


/*
1. Задать массив вещественных чисел;
2. Найти макс и мин;
3. Найти разницу между макс и мин;
4. Вывести результат административным методом.
*/


Console.Clear();


double [] GetArray (int MinValue, int MaxValue)
{
    Random TempRandom = new Random();
    int size = TempRandom.Next(6, 12);
    double [] mas = new double[size];

    for (int index = 0; index < size; index++)
    {
        mas[index] = TempRandom.Next(MinValue, MaxValue);
    }
    return mas; 
}



double Max (double[] mas)
{
    double Max = mas[0];
    for (int indexMas = 0; indexMas < mas.Length; indexMas++)
    {
        if(mas[indexMas] > Max) Max = mas[indexMas];
    }
    return Max;
}


double Min (double[] mas)
{
    double Min = mas[0];
    for (int indexMas = 0; indexMas < mas.Length; indexMas++)
    {
        if(mas[indexMas] < Min) Min = mas[indexMas];
    }
    return Min;
}


double Difference(double Max, double Min)
{
    double difference = 0;
    difference = Max - Min;
    return difference; 
}


void print(double[] Mas, double difference)
{
Console.WriteLine($"Сгенерированный массив -> [{String.Join(",", Mas)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива [{String.Join(",", Mas)}] равна {difference}");
}



void main()
{
double[] Mas = GetArray(-100, 100);
double max = Max(Mas);
double min = Min(Mas);
double difference = Difference(Max: max, Min: min);
print(Mas, difference);
}


main();
