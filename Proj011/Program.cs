Console.Clear();
int m = 4;
int n = 4;
Console.WriteLine(GetPower(m, n));
Console.WriteLine(GetSum(GetPower(m, n)));

int GetPower(int a, int b, int res = 1)
{
    if (b > 0)
    {
        res *= a;
        return GetPower(a, b - 1, res);
    }
    return res;
}

int GetSum(int a, int res = 0)
{
    if (a != 0)
    {
        res += a % 10;
        return GetSum(a / 10, res);
    }
    return res;
}