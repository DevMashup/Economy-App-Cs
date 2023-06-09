using EconomyApp.TextFormatting;

namespace EconomyApp.TextFormatting.Banks.Types
{
    public class CheckAccTF
    {

        void CenterHor()
        {
            AppTF appTF = new AppTF();

            int s = 0;
            appTF.SpacingHor(); //38

            for (; s <= 53; s++)
            {
                Console.Write(" ");
            }

        }
        public void CheckTyppeBankLog(string name, int amount, int bankNum, string title, int center)
        {

            CenterHor();
            for(int i = 0; i < center + 1; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(title);
            CenterHor(); // 212 - 38 - 30 = 144 / 2 = 72 
            Console.WriteLine("------------------------------");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine($"|   BANK #   |   {bankNum}   |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("------------------------------");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine($"|   AMOUNT   |      {amount}      |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("------------------------------");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine($"|    OWNER   |   {name}    |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("|            |               |");
            CenterHor();
            Console.WriteLine("------------------------------");

        }

        public void CheckAccStory()
        {
            Console.WriteLine("Checking accounts are all-purpose places to keep money for short- to medium-term financial needs. Your employer can directly deposit your paychecks in the account, you can link it to payment apps like Venmo and PayPal, you can make wire transfers and mobile check deposits, you can pay bills from it and more. Checking accounts are a building block to manage your money and make financial tasks easier.");
            Console.WriteLine("Description produced by https://www.nerdwallet.com/article/banking/what-is-a-checking-account");
        }
    }
}
