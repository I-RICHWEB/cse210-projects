using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> userNumbers = new List<int>();
        string num = "";
        int max = -1;
        int sum = 0;
        int small = 99999999;

        while (num != "0")
        {
            Console.Write("Enter positive or negative number for calculations, enter 0 to stop: ");
            num = Console.ReadLine();
            int nums = int.Parse(num);

            if (nums == 0)
            {
                Console.WriteLine("Opps! Sorry negative number are not allowed.");
            }
            else
            {
                userNumbers.Add(nums);
            }
        }
        

        foreach (int item in userNumbers)
        {
            sum += item;
            if (item > max)
            {
                max = item;
            }
            if (item < small && item > 0)
            {
                small = item;
            }
        }
        
        int count = userNumbers.Count();
        int aver = sum / count;
        userNumbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {aver} ");
        Console.WriteLine($"The max number is: {max}");
        Console.WriteLine($"The smallest number is: {small}");
        Console.WriteLine("The sorted list is:");
        Console.WriteLine(string.Join(",", userNumbers));
    }
}