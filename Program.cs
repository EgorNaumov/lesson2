// See https://aka.ms/new-console-template for more information
Console.WriteLine("Угадай число 1-10");
int a;
int b;
bool win=false;
Random rnd = new Random();
b = rnd.Next(1,10);
while (win==false)
{
a = int.Parse(Console.ReadLine());
if (b>a)
{
    Console.WriteLine("Больше");
}
if (b<a)
{
  Console.WriteLine("Меньше");
}
if (b==a)
{
  win = true;
  Console.WriteLine("Победа");
}
}