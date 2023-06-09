using EconomyApp.TextFormatting;
using EconomyApp.RND;

namespace EconomyApp
{
    public class App
    {
        static void Main(string[] args)
        {
            AppTF aTF = new AppTF();
            AppR aR = new AppR();

            string[] words = { };

            aTF.BeginApp();

            aR.Startapp(aTF, words);
            

            
        }
    }
}

