using EconomyApp.TextFormatting.Shop.Items;
using EconomyApp.RND;
using EconomyApp.TextFormatting;
using EconomyApp.Economy.Banks.Types;

namespace EconomyApp.Economy.Shop.Items
{
    public class PantsE
    {
        string[] words = { };
        AppTF appTF = new AppTF();

        List<string> pantsList = new List<string>(); //<--Make it so I can buy and the sell
        void Logic(string state, int num, int price)
        {
            CheckAccE caE = new CheckAccE();
            PantsTF pantsTF = new PantsTF();

            int total = num * price;

            if(state.Equals("B") || state.Equals("b"))
            {
                int CheckBankAccount = caE.amount - total;
               
                if(CheckBankAccount < 0)
                {
                    Console.WriteLine($"Sorry m8. You do not have enough to money to buy ${num} Swesater. ");
                }
                else {
                    for (int l = 0; l < num; l++)
                    {
                        pantsList.Add($"Pants #{l}");
                    }

                    caE.amount -= total;
                    Console.WriteLine($"Congrats! You've purchased ${num} sweaters for a total of {total} bucks. Enjoy and please come again");

                    pantsTF.PantsReciept(total);
                }
            } else if(state.Equals("S") || state.Equals("s"))
            {
                if(!pantsList.Any())
                {
                    Console.WriteLine("Looks like you have no pants too sell. :(");
                } else
                {
                    for (int l = 0; l < num; l++)
                    {
                        pantsList.Remove(pantsList[l]);
                    }

                    caE.amount += total;
                    Console.WriteLine($"Congrats! You've sold ${num} sweaters for a total of {total} bucks. Enjoy and please come again");

                    pantsTF.PantsReciept(total);
                }
            }

        }
        public void BuyPants(string state)
        {
            AppR aR = new AppR();

            int price = 30;

            Console.WriteLine($"Welcome to Clothing emprium. I see you wanna buy some pants. Pants cost ${price}$ here.");

            Console.Write("How many do you want to buy?: ");
            int num = 0;
            string? numInput = Console.ReadLine();
            if (!int.TryParse(numInput, out num))
            {
                return;
            }

            Logic(state, num, price);

            Console.Write("Do you wanna go back to the main menu? (Type 'Y' or 'N'):");

            string? option = Console.ReadLine();
            if(option == null)
            {
                return;
            } else
            {
                if(option.Equals("Y") || option.Equals("y")) {
                    aR.Startapp(appTF, words);
                } else if(option.Equals("N") || option.Equals("n"))
                {
                    Environment.Exit(0);
                }
            }
        }

        public void SellPants(string state)
        {
            AppR aR = new AppR();

            int price = 15;

            Console.WriteLine($"Welcome to Clothing emprium. I see you wanna sell some pants. Pants sell for ${price}$ here.");

            Console.Write("How many do you want to Sell: ");
            int num = 0;
            string? numInput = Console.ReadLine();
            if (!int.TryParse(numInput, out num))
            {
                return;
            }

            Logic(state, num, price);

            Console.Write("Do you wanna go back to the main menu? (Type 'Y' or 'N'):");

            string? option = Console.ReadLine();
            if (option == null)
            {
                return;
            }
            else
            {
                if (option.Equals("Y") || option.Equals("y"))
                {
                    aR.Startapp(appTF, words);
                }
                else if (option.Equals("N") || option.Equals("n"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
