int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int res = (num / 100) * 10 + (num % 10);

Console.WriteLine(res);