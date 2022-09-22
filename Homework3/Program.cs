int akkerman(int n, int m)
{
   if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return akkerman(n - 1, 1);
    else
      return akkerman(n - 1, akkerman(n, m - 1));
}

Console.WriteLine("Введите число n");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int w = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(akkerman(q, w));