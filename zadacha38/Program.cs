//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Clear();

double size = 10;
double leftRange = 0;
double rightRange = 100;

double[] FillArray(double size, double leftRange, double rightRange)    // Метод рандомный массив и наполнить его
{
    double[] arr = new double[(int)size];
    double length = arr.Length;
    double index = 0;
    while (index < length)
    {
        arr[(int)index] = new Random().Next(0, 100); // заполнение массива,также можно указать Next(leftRange, rightRange +1)
        index++;
    }
    return arr;
}

double ArrayNumberDifference(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}

double[] array = FillArray(size, leftRange, rightRange);
//System.Console.WriteLine('[' + string.Join(",", array) + ']');
double result = ArrayNumberDifference (array);
System.Console.WriteLine('[' + string.Join(",", array) + "] -> "+ result);