using Celular;

celular celular = new celular();

static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{

    Console.Write(texto);

    for (int i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }


}

Console.ForegroundColor = ConsoleColor.Green;
BarraCarregamento("Ligando", 7, 450);
Console.ResetColor();
Console.Clear();

int opcoes;

do
{
    Console.WriteLine(@$"
--------MENU--------
1 - Fazer ligacão
2 - Enviar mensagem
3 - Desligar
");
    opcoes = int.Parse(Console.ReadLine());

    switch (opcoes)
    {
        case 1:
            celular.FazerLigacao();
            break;

        case 2:
            celular.EnviarMensagem();
            break;
        case 3:
            celular.Desligar();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inválida, digite novamente!");
            Console.ResetColor();
            break;
    }

} while (opcoes == 1 || opcoes == 2 || opcoes > 3 || opcoes < 1);


















