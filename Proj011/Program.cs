Console.Clear();
int m = 8;
int n = 5;
Console.WriteLine(GetPower(m, n));
Console.WriteLine(GetSum(GetPower(m, n)));

int GetPower(int a, int b, int res = 1, int i = 1)
{
    if (i <= b)
    {
        res *= a;
        return GetPower(a, b, res, i + 1);
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