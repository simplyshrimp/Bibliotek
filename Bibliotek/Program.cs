namespace Bibliotek
{
    internal class Program
    {
        static List<Borrower> borrowers = new();
        static void Main(string[] args)
        {
            Borrower test = new(1, "Test Library");
            Borrower test2 = new(2, "Test Library");
            Borrower test3 = new(3, "test Library");
            borrowers.Add(test);
            borrowers.Add(test2);
            borrowers.Add(test3);

            Console.WriteLine(test.GetBorrower());
        }
        static void PrintBorrowers()
        {
            foreach(Borrower borrower in borrowers)
            {
                Console.WriteLine(borrower.GetBorrower());
            }
        }
    }
}
