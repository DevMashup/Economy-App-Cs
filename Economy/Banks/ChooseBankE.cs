using EconomyApp.Tables.Banks;
using EconomyApp.Choices.Bank;

namespace EconomyApp.Economy.Banks
{
    public class ChooseBankE
    {
        public void ChooseBank()
        {
            ChooseBankT cbT = new ChooseBankT();
            BankC bC = new BankC();

            Console.WriteLine("Welcome, so glad you've decided to open a bank. We have many types of banks to choose from");
            cbT.BankOptions();

            Console.Write("Whick bank would you like to open?: ");
            string? userInput = Console.ReadLine();

            if(userInput == null)
            {
                return;
            } else
            {
                bC.BankChoice(userInput);
            }
        }
    }
}
