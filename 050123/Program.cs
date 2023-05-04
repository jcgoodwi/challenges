public class goToOne
{
    public static int collatz(int n)
    {
        int counter = 0;
        while (n > 1)
        {
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = n * 3 + 1;
            }
            counter++;
        }
        return counter;
    }
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(collatz(n));
    }
}