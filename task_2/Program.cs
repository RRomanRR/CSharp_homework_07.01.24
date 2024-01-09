//НП, которая принимает `на вход трёхзначное чисо а затем второе число возводит в степень равную третьему числу.487 => 8^7 => 2 097 152

// Console.Write("hello");

Console.Write ("введите трёхзначное число: ");
int a = int.Parse (Console.ReadLine()!);
int SecondNumber = a / 10 % 10;
int ThirdNumber = a % 10;
Console.Write (Math.Pow(SecondNumber,ThirdNumber));

