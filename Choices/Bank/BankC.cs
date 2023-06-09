using EconomyApp.Economy.Banks.Types;

namespace EconomyApp.Choices.Bank
{
    public class BankC
    {
        public void BankChoice(string userInput)
        {
            CheckAccE caE = new CheckAccE();

            if(userInput.Equals("Checking") || userInput.Equals("checking"))
            {
                caE.OpenCheckingAcc();

            } else if(userInput.Equals("Savings") || userInput.Equals("savings"))
            {

            }
        }
    }
}
