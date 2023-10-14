int FindMax(int arg1, int arg2, int arg3){
    int result = arg1;
    if ( arg2 > result) result = arg2;
    if ( arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 2532;
int b2 = 23;
int c2 = 522;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = FindMax(a1, b1, c1);
// int max2 = FindMax(a2, b2, c2);
// int max3 = FindMax(a3, b3, c3);
// int max = FindMax(max1, max2, max3);

int max = FindMax(FindMax(a1, b1, c1), FindMax(a2, b2, c2), FindMax(a3, b3, c3)); // вместо предыдущих 4 строчек можно использовать вот такую одну

Console.WriteLine(max);