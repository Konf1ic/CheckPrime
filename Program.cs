internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 2)
            System.Console.WriteLine(number + " is not a prime!");
        else
        {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
                System.Console.WriteLine(number + " is a prime!");
            else
                System.Console.WriteLine(number + " is not a prime!");
        }
    }
}