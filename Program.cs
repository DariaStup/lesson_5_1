static void Case()
{
    int start = 2;
    int end = 100;

    Console.WriteLine("Простые числа от " + start + " до " + end + ":");

    for (int num = start; num <= end; num++)
    {
        if (IsPrime(num))
        {
            Console.Write(num + " ");
        }
    }
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0) return false;
    }

    return true;
}
Case();