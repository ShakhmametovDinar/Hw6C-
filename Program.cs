// Задача 41.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void SumIf(int[] array)
{
    int sum = 0;
    for(int i = 0; i <array.Length; i++)
        if(array[i] > 0)
            sum++;
    Console.Write(sum);
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
SumIf(myArray);

// Задача  43.

void IntersectionPoint(int b1,int b2,int k1,int k2)
{
    double x1 = -100;
    double x = 0;
    double y1 = 0;
    double y2 = 0;
    double y = 0;
    while(x1 < 100)
    {
        x1 += 0.5;
        y1 = k1 * x1 + b1;
        y2 = k2 * x1 + b2;
        if(y1 == y2)
        {
            y = y1;
            x = x1;
        }
    }
    Console.Write($"({x};{y})");
}

Console.Write("Input a number: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int k2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(b1,b2,k1,k2);