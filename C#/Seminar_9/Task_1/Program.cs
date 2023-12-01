int m = 5;
int n = 1;

void Range(int m, int n){
    if (m == n){
        Console.Write(m + " ");
        return;
    }
    Console.Write(m + " ");
    Range(m - 1, n);
}
Range(m, n);