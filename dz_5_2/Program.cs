Console.Clear();
int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

void SumArray (int size, int maxNum)
{
    Console.Write ($"Ваш массив случайных чисел: ");
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(-maxNum, maxNum+1);
        Console.Write ($"{array [i]} ");
    }
    int sum = 0;
    int j = 1;
    while (j < size)
    {
        sum += array [j];
        j += 2;
    }
    Console.WriteLine ("");
    Console.Write ($"Сумма чисел на нечетных позициях: {sum}");
}

int size = InputNum ($"Задайте размер массива: ");

int maxNum = InputNum ($"Задайте максимальное число массива: ");

SumArray (size, maxNum);