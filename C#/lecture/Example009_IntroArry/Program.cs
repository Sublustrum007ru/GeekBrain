int FindMax(int arg1, int arg2, int arg3){
    int result = arg1;
    if ( arg2 > result) result = arg2;
    if ( arg3 > result) result = arg3;
    return result;
}

int [] array = { 34, 68, 75, 753, 4563, 233, 2453, 123, 92 };
int count = 0;
int max = FindMax(array[0], array[1], array[2]);

Console.WriteLine(max);