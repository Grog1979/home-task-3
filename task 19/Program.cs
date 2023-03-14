// задача 19
Console.Clear();
Console.Write("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n/10000 == n%10 && n/1000 - (n/10000)*10 == (n%100 - n%10)/10)
  Console.WriteLine("палиндром");
else
  Console.WriteLine("не палиндром");
