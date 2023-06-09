
namespace EconomyApp.Tables
{
    public class AppT
    { 
        void Warning()
        {
            Console.WriteLine("NOTE: The '-' is used for a 2nd input(e.x Bank C). DO NOT USE THE HYPHEN");
        }
        void AddMainItems(List<string> items)
        {
            items.Add("NULL");
            items.Add("Bank");
            items.Add("Shop");
            items.Add("Test");
            items.Add(" -I");
            items.Add(" -S");
            items.Add("Test");
            items.Add(" -<Type>");
            items.Add(" -B");
        }

        public void MainOptions()
        {
            Warning();

            List<string> items = new List<string>();
            AddMainItems(items);

            for(int l = 1; l < items.Count; l++)
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
