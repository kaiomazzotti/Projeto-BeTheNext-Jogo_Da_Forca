
namespace ForcaAdaSinqia.Utils
{
    public static class Forca
    {
        public static string Estrutura(int erros)
        {
            string forca = "";
            if (erros == 0)
            {
                forca = @" ________
|        |
|        |
|
|
|
|";
            }
            if (erros == 1)
            {
                forca = @" ________
|        |
|        |
|        O
|
|
|";
            }
            if (erros == 2)
            {
                forca = @" ________
|        |
|        |
|        O
|        |
|
|";
            }
            if (erros == 3)
            {
                forca = @" ________
|        |
|        |
|        O
|       /|
|
|";
            }
            if (erros == 4)
            {
                forca = @" ________
|        |
|        |
|        O
|       /|\
|
|";
            }
            if (erros == 5)
            {
                forca = @" ________
|        |
|        |
|        O
|       /|\
|       /
|";
            }
            if (erros == 6)
            {
                forca = @" ________
|        |
|        |
|        O
|       /|\
|       / \
|";
            }
            return forca;
        }
    }
}
