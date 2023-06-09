//Console width at full screen is 211-30 =  181 / 2 = 90

namespace EconomyApp.TextFormatting
{
    public class AppTF
    {
        public void SpacingHor()
        {
            Console.Write("                                      "); //38
        }

        public void SpacingVer()
        {
            Console.WriteLine("");
        }

        void Warning()
        {
            Console.WriteLine("NOTE: You have to maximise the application in order to format it correctly");
        }

        void AppIcon()
        {
            SpacingVer();

            CenterLogo();       
            Console.WriteLine("------------------------------");
            CenterLogo();
            Console.WriteLine("|                            |");
            CenterLogo();
            Console.WriteLine("|   WELCOME TO THE ECONOMY   |");
            CenterLogo();
            Console.WriteLine("|         SIMULATOR          |");
            CenterLogo();
            Console.WriteLine("|                            |");
            CenterLogo();
            Console.WriteLine("------------------------------");
        }

        void AppDesc()
        {
            SpacingVer();

            SpacingHor();
            Console.WriteLine("I made ths application so you could simulate the Economy & Market and do stuff like open a bank account, shop, trsade stocks, become a");
            SpacingHor();
            Console.WriteLine("               millionare and basically anything you can do in the real world when it comees to the Economy and Market");

            SpacingVer();
            SpacingVer();
        }

        void CenterLogo()
        {
            int s = 0;
            SpacingHor();
            for (; s < 53; s++)
            {
                Console.Write(" ");
            }
        }

        public void BeginApp()
        {
            Warning();
            AppIcon();
            AppDesc();
        }
    }
}
