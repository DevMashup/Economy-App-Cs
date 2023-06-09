using EconomyApp.TextFormatting.Banks.Types;

namespace EconomyApp.Economy.Banks.Types
{
    public class CheckAccE
    {

        public string? name;
        public int amount = 500;
        public void OpenCheckingAcc()
        {
            CheckAccTF caTF = new CheckAccTF();

            Console.WriteLine("You decided to open up a Checking Acc? That's great! We just have a couple of questions for you");

            Console.Write("What's your name?: ");
            name = Console.ReadLine();
            if (name == null)
            {
                return;
            }

            Console.Write("How old are you?: ");
            int age = 0;
            string? ageInput = Console.ReadLine();
            if (!int.TryParse(ageInput, out age))
            {
                return;
            }
            if (age < 18) Console.WriteLine("Sorry. You're two young to open a bank account");

            Random rnd = new Random();
            int bankNum = rnd.Next(11111, 999999999); //<--Make it so it can be 8-17 digits long

            int logLength = "------------------------------".Length;
            string title = name + "'s Account";

            int center = (logLength - title.Length) / 2;

            caTF.CheckTyppeBankLog(name, amount, bankNum, title, center);
        }
    }
}
