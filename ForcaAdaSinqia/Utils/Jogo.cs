using System;
namespace ForcaAdaSinqia.Utils
{
    public static class Jogo
    {
        public static void JogoForca()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*                 JOGO DA FORCA                  *");
            Console.WriteLine("**************************************************");

            var palavras = Palavras.BancoPalavras();
            Random rd = new Random();

            string palavra = palavras.Keys.ElementAt(rd.Next(0, palavras.Count));
            int tamanho = palavra.Length;
            const int maxErros = 6;
            int tentativas = 6;
            Console.WriteLine($"Uma palavra de {tamanho} letras");
            Console.WriteLine("A dica da palavra é:");
            Console.WriteLine(palavras[palavra].ToUpper());
            int erros = 0;
            char letra = ' ';
            char[] palavraforca = new char[tamanho];
            char[] digitadasCertas = new char[palavraforca.Length];
            char[] digitadasErradas = new char[maxErros];


            for (int i = 0; i < tamanho; i++)
            {
                palavraforca[i] = '_';
            }
            Console.WriteLine(Forca.Estrutura(erros)
                + string.Join(" ", palavraforca)
                + "\n");

            bool start = true;
            bool ganhou = false;
            do
            {

                letra = VerificaLetra(letra);
                if (palavra.Contains(letra))
                {
                    if (digitadasCertas.Contains(letra))
                    {
                        Console.WriteLine("\nvocê já acertou esta letra\n");
                        continue;
                    }
                    for (int i = 0; i < tamanho; i++)
                    {
                        if (letra == palavra[i])
                        {
                            palavraforca[i] = letra;
                            digitadasCertas[i] = letra;
                        }
                    }
                    Console.WriteLine("\nAcertou");
                    if (String.Join("", digitadasCertas) == palavra)
                    {
                        ganhou = true;
                        start = false;
                    }
                }
                else
                {

                    if (digitadasErradas.Contains(letra))
                    {
                        Console.WriteLine("\nVocê já digitou essa letra!");
                    }
                    else
                    {
                        Console.WriteLine("\nVocê errou!");
                        digitadasErradas[erros] = letra;
                        erros++;
                        tentativas--;
                        if (erros == maxErros)
                        {
                            ganhou = false;
                            start = false;
                        }
                    }
                }

                Console.WriteLine(Forca.Estrutura(erros)
                    + string.Join(" ", palavraforca)
                    + "\n");
                Console.WriteLine("A dica é: "+palavras[palavra].ToUpper());
                Console.WriteLine($"Tentativas Restantes: {tentativas}\n\nLetras erradas digitadas: {String.Join(" ", digitadasErradas)}\n");
                letra = ' ';
            } while (start);

            if (ganhou)
            {
                Console.WriteLine($"Parabéns você ganhou o jogo: {palavra.ToUpper()}");
            }
            else
            {
                Console.WriteLine("Que pena... Você foi enforcado!!");
            }
        }
        public static char VerificaLetra(char letra)
        {
            do
            {
                try
                {
                    Console.Write("Digite uma letra: ");
                    letra = char.Parse(Console.ReadLine().ToLower());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite somente uma letra!!");
                }

            } while (letra < 'a' || letra > 'z');
            return letra;
        }
    }
}
