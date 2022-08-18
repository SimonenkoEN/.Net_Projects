Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int negnum = num * -1;

while (negnum <= num)
{
    Console.Write(negnum);
    negnum++;
}
