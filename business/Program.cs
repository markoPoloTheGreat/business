using business;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int AmountMembers(Customer[] customers)
    {
        int result = 0;
        for (int i = 0; i < customers.Length; i++)
        {
            bool clubStatus = customers[i].GetClubMember();
            if (clubStatus) 
            {
                result++;
            }
        }
        return result;
    }
}