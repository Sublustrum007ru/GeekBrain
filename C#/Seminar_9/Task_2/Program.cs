int m = 1;
int n = 15;
int summ = 0;

void Range(int m, int n){
    if (m > n){
        Console.Write($"{summ}");
        return;
    }
    summ = summ + m;
    Range(m + 1, n);
}
Range(m, n);