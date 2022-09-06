void FillArray(int[] collection) // метод создаёт массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  // метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == count -1) Console.WriteLine(col[position]);
        else Console.Write($"{col[position]}, ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // поиск индекса с икомым значением
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // на случай, если искомого значения не будет в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  // выход из поиска при первом найденном
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
int numToFind = 4;

FillArray(array);
PrintArray(array);
Console.WriteLine($"{numToFind}");
Console.WriteLine();

int pos = IndexOf(array, numToFind);
Console.WriteLine(pos);

