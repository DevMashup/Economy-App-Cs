using EconomyApp.Economy.Shop.Items;

namespace EconomyApp.Choices.Shop
{    
    public class ShopC
    {
        public void PickItem(string[] words, string state)
        {
            PantsE pE = new PantsE();

            if (words[0].Equals("Pants") || words[0].Equals("pants"))
            {
                if(state.Equals("B") || state.Equals("b")) {
                    pE.BuyPants(state);
                } else if(state.Equals("S") || state.Equals("s")) {
                    pE.SellPants(state);
                }
            }
        }
    }
}
