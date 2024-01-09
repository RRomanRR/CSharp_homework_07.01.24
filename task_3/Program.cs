// НП, которая будет принимать на вход два числа и выводить, являеься ли второе число кратным первому.
//  если второе число некратно первому, то программа выводит отстаток от деления.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if ( a % b == 0 )
{Console.WriteLine ("да");}
else 
{Console.WriteLine ("нет " + a % b);}