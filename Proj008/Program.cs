
Console.Write("Введите координату х: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);
Console.Write("Введите координату y: ");
bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

if(!isNumberX || !isNumberY){
    System.Console.WriteLine("Ошибка ввода!");
    return;
}

System.Console.WriteLine(isNumberX + " " + isNumberY);
System.Console.WriteLine(x + " " + y);