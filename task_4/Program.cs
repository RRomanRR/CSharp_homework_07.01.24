﻿// НП, котрая выводит третью с конца цифру заданного числа и сообщает, что третьей цифры нет. 
// 456=> 6, 7812 => 8, 91 => третьей цифры нет!.

int a = int.Parse(Console.ReadLine()!);

if ( a < 100 )
{Console.WriteLine ("нет");}
else 
{Console.WriteLine ("да " + a/100 % 10);}