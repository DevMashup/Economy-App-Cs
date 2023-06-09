using EconomyApp.Choices;
using EconomyApp.Tables;
using EconomyApp.TextFormatting;

namespace EconomyApp.RND
{
    public class AppR
    {

        public void Startapp(AppTF aTF, string[] words)
        {
            AppT aT = new AppT();
            AppC aC = new AppC();

            Console.WriteLine("Heres a list of options you can do");
            aTF.SpacingVer();

            aT.MainOptions();
            aTF.SpacingVer();

            Console.Write("So what do you want to do?: ");
            string? userInput = Console.ReadLine();

            if (userInput == null)
            {
                Console.WriteLine("Please input something");
            }
            else
            {
                words = userInput.Split(' ', userInput.Length);
                aC.Choice(words);

            }
        }
    }
}
