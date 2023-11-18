Console.Clear();

double b1 = Promt.Output("b1");
double k1 = Promt.Output("k1");
double b2 = Promt.Output("b2");
double k2 = Promt.Output("b1");
double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"y1 = {Math.Round(y1, 2)}, y2 = {Math.Round(y2, 2)}");