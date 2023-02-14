int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
string[] InputMassive(int x)
{
    string[] array = new string[x];
    for (int i = 0; i < x; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
int Length3Symbol(string[] array)
{
   int d=0;
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            d++;
        }
    }
    return d;
}
string[] TrimLength(string[] array)
{
    int j = 0;
    string[] MASS2 = new string[Length3Symbol(array)];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            MASS2[j] = array[i];
            j++;
        }
    }
    return MASS2;
}
Console.Clear();
int x = InputInt("Введите количество элементов в массиве > ");
string[] MASS = InputMassive(x);
System.Console.WriteLine();
System.Console.WriteLine("Заданный массив:");
PrintArray(MASS);
string[] MASS2 = TrimLength(MASS);
System.Console.WriteLine("Новый массив:");
PrintArray(MASS2);