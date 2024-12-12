using business;

internal class Program
{//mark 12/12
    private static void Main(string[] args)
    {
        Customer c1 = new Customer(1, "mark");
        c1.MakeIska(1200);
        Console.WriteLine(c1);
        Customer c2 = new Customer(2, "Lior");
        Console.WriteLine(c2);
        if (c1.IsBetterCustomer(c2))
        {
            Console.WriteLine("mark better then lior");
        }
        else
        {
            Console.WriteLine("lior is better");
        }
        Customer[] arr= new Customer[] { c1, c2 };
        Console.WriteLine(AmountMembers(arr));
    }
    public static int AmountMembers(Customer[] customers)
    {// get list and returns how many club members
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