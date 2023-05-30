/*12 вариант*/
int a = 1, bo = 0, bn = 30, delb = 10;
    double L = 0, b = 0, e = 0;

for (int i = bo; i <= bn; i += delb)
{
    L += (24.2 * Math.Cos(Math.Pow(a, 2)) + (Math.Sin(a + b)))
        / (Math.Cbrt(Math.Pow(e, a) - (Math.Pow(b, 3)) + (Math.Tan(b))));
}

Console.Write(L);