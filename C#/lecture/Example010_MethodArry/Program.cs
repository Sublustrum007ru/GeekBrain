Console.Clear();
int [] array = { 1, 42, 42, 4, 18, 47, 79, 123, 456, 18};

int size = array.Length;
int find = 18;

int index = 0;

while (index < size){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}