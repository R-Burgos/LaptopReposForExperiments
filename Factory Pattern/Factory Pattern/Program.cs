namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What phone do you want to create?");
            var userPhone = Console.ReadLine();

            var phone = PhoneFactory.GetPhone(userPhone);
            phone.Build();

        }
    }
}