using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular
{
    public class celular
    {

        static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
        {

            Console.Write(texto);

            for (int i = 0; i < quantidadePontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }


        }

        public void Desligar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            BarraCarregamento("Desligando", 6, 450);
            Console.ResetColor();
            Environment.Exit(10);
        }

        public void FazerLigacao()
        {
            Console.WriteLine(@$"Digite o nome da pessoa que receberá a ligação: ");
            string recebeMensagem = Console.ReadLine();

            BarraCarregamento("Efetuando ligação", 6, 450);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"ligação efetuada!");
            Console.ResetColor();
        }

        public void EnviarMensagem()
        {
            Console.WriteLine(@$"Digite o nome da pessoa que receberá a mensagem:");
            string recebeMensagem = Console.ReadLine();

            Console.WriteLine(@$"Digite a mensagem: ");
            string mensagem = Console.ReadLine();

            BarraCarregamento("Enviando a mensagem", 6, 450);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Mensagem enviada!");
            Console.ResetColor();
        }

    }
}