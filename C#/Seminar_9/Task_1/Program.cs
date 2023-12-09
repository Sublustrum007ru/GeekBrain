int N = 5;
int stop = 1;

void Range(int N, int stop){
    if (N == stop){
        Console.Write(N + " ");
        return;
    }
    Console.Write(N + " ");
    Range(N - 1, stop);
}
Range(N, stop);