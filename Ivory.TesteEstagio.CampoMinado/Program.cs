using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            Console.WriteLine("Dinâmica do jogo: você deve informar qual linha e em seguida qual a coluna referente ao campo que deseja abrir (entre 1 e 9)");

            while (campoMinado.JogoStatus == 0)
            {

                Console.Write("\nQual seria a linha? : ");
                int linha = int.Parse(Console.ReadLine());
                Console.Write("Qual seria a coluna? : ");
                int coluna = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (linha <= 9 && coluna <= 9 && linha >= 0 && coluna >= 0)
                {
                    campoMinado.Abrir(linha, coluna);

                }
                else
                {
                    Console.WriteLine("\nValor incorreto, por favor, insira um número entre 1 e 9 para ambos :)\n");
                }

                Console.WriteLine(campoMinado.Tabuleiro);



            }

            if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("\nBOOOOOOM! Você encontrou uma mina terrestre");
                Console.WriteLine("                 _.-^^---....,,--       ");
                Console.WriteLine("             _--                  --_  ");
                Console.WriteLine("            <                        >)");
                Console.WriteLine("            |                         | ");
                Console.WriteLine("             _                   _./  ");
                Console.WriteLine("                ```--. . , ; .--'''       ");
                Console.WriteLine("                      | |   |             ");
                Console.WriteLine("                   .-=||  | |=-.   ");
                Console.WriteLine("                   `-=#$%&%$#=-'   ");
                Console.WriteLine("                      | ;  :|     ");
                Console.WriteLine("             _____.,-#%&$@%#&#~,._____");
                Console.WriteLine("\nInfelizmente o jogo acabou para você!");
            }

            else
            {
                Console.WriteLine("\nParabéns!! Você acaba de vencer o jogo");
                Console.WriteLine("\nTudo continua em paz e nada foi explodido");
            }


        }

    }
}
