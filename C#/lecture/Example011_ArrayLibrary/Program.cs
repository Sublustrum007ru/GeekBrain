Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count){
        if (collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int [] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOff(array, 444);
Console.WriteLine(pos);