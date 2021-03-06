class Program
{
    static bool isreversed(int n)
    {
        if (n % 10 == 0)
            return false;
        int a = n;
        int r = 0;
        while (a > 0)
        {
            r *= 10;
            r += a % 10;
            a /= 10;
        }
        a = r + n;
        while (a > 0)
        {
            if (a % 2 == 0)
                return false;
            a /= 10;
        }
        return true;
    }
    static void Main(string[] args)
    {
        int cnt = 0;
        for (int i = 1; i < 100000000; i++)
        {
            if (isreversed(i))
                cnt++;
        }
        Console.WriteLine("все реверсивные числа меньше 100 000 000: {0}", cnt);
        Console.ReadKey();
    }
}