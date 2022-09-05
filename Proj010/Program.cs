int GetValidNumber()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while (!isNumber)
    {
        Console.Write("Введено неверное значение! Попробуйте еще раз: ");
        isNumber = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

string GetBinNumber(int num)
{
    string binNum = string.Empty;
    while (num != 0)
    {
        binNum = num % 2 + binNum;
        num /= 2;
    }

    return binNum;
}

Console.WriteLine(GetBinNumber(GetValidNumber()));
GetFibonacci(GetValidNumber());

void GetFibonacci(int num)
{
    long[] arr = new long[num + 1];
    arr[1] = 1;
    if (num == 0)
    {
        Console.WriteLine("0");
    }
    else if (num == 1)
    {
        Console.WriteLine("0 1");
    }
    else if (num > 1)
    {
        Console.Write("0 1 ");
        for (int i = 2; i <= num; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
            Console.Write(arr[i] + " ");
        }
    }
}