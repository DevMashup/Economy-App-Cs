using EconomyApp.TextFormatting;

namespace EconomyApp.TextFormatting.Shop.Items
{
    public class PantsTF
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

        public void PantsReciept(int total)
        {
            CenterHor();
            Console.WriteLine("            PANTS             ");
            CenterHor();
            Console.WriteLine("-------------------------------");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|              |    CLOTHNG   |");
            CenterHor();
            Console.WriteLine("|    STORE     |              |");
            CenterHor();
            Console.WriteLine("|              |   EMPORIUM   |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("-------------------------------");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|     ITEM     |    PANTS     |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("-------------------------------");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine($"|    TOTAL     |      ${total}       |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("|              |              |");
            CenterHor();
            Console.WriteLine("-------------------------------");

        }
    }
}
