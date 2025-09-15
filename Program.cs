namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();

            Console.Write("Kérem a felhasználó nevét: ");
            string userName = Console.ReadLine();

            Console.Write("Kérem a felhasználó jelsazvát: ");
            string userPass = Console.ReadLine();

            Connect c = new Connect(dbName, userName, userPass);
        }
    }
}
