namespace EconomyApp.Tables.Shop
{
    public class ShopT
    {
        void ShopWarning()
        {
            //Console.WriteLine("NOTE: The '-' is used for a 2nd input(e.x Bank C). DO NOT USE THE HYPHEN");
        }
        void AddShopItems(List<string> items)
        {
            items.Add("NULL");
            items.Add("Pants");
            items.Add("Socks");
            items.Add("Tennis Racket");
            items.Add("Drumstick");
            items.Add("Cherries");
            items.Add("4K TV");
        }

        public void ShopOptions()
        {
            List<string> items = new List<string>();
            AddShopItems(items);

            for (int l = 1; l < items.Count; l++)
            {
                Console.Write(items[l] + "     ");

                if (l % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
