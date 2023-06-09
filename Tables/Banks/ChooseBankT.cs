using EconomyApp.TextFormatting;

namespace EconomyApp.Tables.Banks
{
    public class ChooseBankT
    {
        void AddBankItems(List<string> bankItems)
        {
            bankItems.Add("Null");
            bankItems.Add("Checking");
            bankItems.Add("Savings");
        }

        public void BankOptions()
        {
            AppTF aTF = new AppTF();
            aTF.SpacingVer();

            List<string> bankItems = new List<string>();
            AddBankItems(bankItems);

            for (int l = 1; l < bankItems.Count; l++)
            {
                Console.Write(bankItems[l] + "     ");

                if (l % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
