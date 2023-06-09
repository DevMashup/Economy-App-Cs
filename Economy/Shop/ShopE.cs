using EconomyApp.Tables.Shop;
using EconomyApp.Choices.Shop;

namespace EconomyApp.Economy.Shop
    
{
    public class ShopE
    {
        public void Shop(string state)
        {
            ShopT sT = new ShopT();
            ShopC sC = new ShopC();

            string[] words; 

            Console.WriteLine("Welcome to the shop! Here you can buy clothing and fashion accesories to food and electronics and everything in between. Heres some options for your convienence");

            sT.ShopOptions();

            if(state.Equals("B") || state.Equals("b")) {
                Console.Write("What would you like to buy?: ");
                string? option = Console.ReadLine();

                if(option == null) {
                    return;
                } else
                {
                    words = option.Split(' ', option.Length);
                    sC.PickItem(words, state);
                }
            } else if(state.Equals("S") || state.Equals("s"))
            {
                Console.Write("What would you like to sell?: ");
                string? option = Console.ReadLine();

                if (option == null)
                {
                    return;
                }
                else
                {
                    words = option.Split(' ', option.Length);
                    sC.PickItem(words, state); ;
                }
            }
        }
    }
}
