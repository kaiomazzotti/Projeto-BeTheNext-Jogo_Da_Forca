using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaAdaSinqia.Utils
{
    public static class Palavras
    {
        public static Dictionary<string, string> BancoPalavras()
        {
            Dictionary<string, string> palavras = new();
            palavras.Add("abacaxi", "fruta: uma junção dos termos tupis i'bá e ká'ti");
            palavras.Add("melancia", "fruta: bastante refrescante que possui vitamina C, A, além de minerais");
            palavras.Add("ameixa", "fruta: de polpa firme das variedades de Prunus domestica que têm um alto teor de sólidos");
            palavras.Add("kiwi", "fruta: bem exótico de formato oval e na cor marrom");
            palavras.Add("tangerina", "fruta: faz parte do grupo de frutas cítricas");
            //esportes
            palavras.Add("futebol", "esporte: um dos maiores do mundo");
            palavras.Add("futsal", "esporte: praticado por 2 equipes dentro de uma quadra");
            palavras.Add("basquete", "esporte: um jogo desportivo coletivo inventado em 1891");
            palavras.Add("surf", "esporte: praticado dentro do mar");
            palavras.Add("skateboard", "esporte: fez sua primeira aparição nos Jogos Olímpicos em 2021");

            return palavras;
        }
    }
}
