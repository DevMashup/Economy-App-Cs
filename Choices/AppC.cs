using EconomyApp.Economy.Banks;
using EconomyApp.Economy.Shop;
using EconomyApp.TextFormatting.Banks.Types;

namespace EconomyApp.Choices
{
    public class AppC
    {
        public void Choice(string[] word)
        {
            ChooseBankE cbE = new ChooseBankE();
            ShopE sE = new ShopE();
            CheckAccTF caTF = new CheckAccTF();

            if (word[0].Equals("Bank") || word[0].Equals("bank"))
            {
                if(word[1].Equals("I") || word[1].Equals("i"))
                {
                    cbE.ChooseBank();
                } else if(word[1].Equals("Checking") || word[1].Equals("checking"))
                {
                    caTF.CheckAccStory();
                }
            } else if(word[0].Equals("Shop") || word[0].Equals("shop"))
            {
                if(word[1].Equals("B") || word[1].Equals("b"))
                {
                    sE.Shop(word[1]);
                } 
                else if (word[1].Equals("S") || word[1].Equals("s"))
                {
                    sE.Shop(word[1]);
                }
            }
        }
    }
}
