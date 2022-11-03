namespace TestBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rAccount = new BankAccount(100);

            Console.WriteLine(rAccount.GetBalance());

            rAccount.Deposit(200);

            Console.WriteLine(rAccount.GetBalance());

            rAccount.Withdraw(150);

            Console.WriteLine(rAccount.GetBalance());

        }
    }
}