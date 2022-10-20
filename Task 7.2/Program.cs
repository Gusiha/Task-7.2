int[] ints = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, -1, 9, 10 };

//Вывод массива:
foreach (var item in ints)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


//Вывод в обратном порядке:
for (int i = ints.Length - 1; i >= 0; i--)
{
    Console.Write($"{ints[i]} ");
}
Console.WriteLine();


//Вывод чётных элементов массива
foreach (var item in ints)
{
    if (item % 2 == 0)
        Console.Write($"{item} ");
}
Console.WriteLine();


//Вывод всех элементов массива через 1
for (int i = 0; i < ints.Length - 1; i += 2)
{
    Console.Write($"{ints[i]} ");
}
Console.WriteLine();


//Вывод всех элементов массива пока не встретится элемент -1
foreach (var item in ints)
{
    if (item != -1)
    {
        Console.Write($"{item} ");
    }
    else
    {
        break;
    }
}