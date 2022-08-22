
int num = new Random().Next(10, 100);
Console.WriteLine(num);

int firstNum = num / 10;
int secondNum = num % 10;

if(firstNum > secondNum){
    Console.WriteLine("Максимальное число: {0}", firstNum);
}
else{
    Console.WriteLine("Максимальное число: {0}", secondNum);
}