var a = 2;
Console.WriteLine("drókuje liczby");
for (int i = 5; i < 10; i++)
{
    Console.WriteLine(i*a);
}
Console.WriteLine("konieccccc prógramu");

static double Average(int[] nums)
{
    int sum = 0;
    foreach (var number in nums)
    {
        sum += number;
    }

    return sum / nums.Length;
}

static double Max(int[] nums)
{
    return nums.Max();
}
