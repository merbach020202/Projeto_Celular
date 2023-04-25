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

Console.WriteLine(@$"
--------MENU--------
1 - Fazer ligacão
2 - Enviar mensagem
3 - Desligar
");
string opcoes = Console.ReadLine();

switch (opcoes)
{
    case "1":
    celular.FazerLigacao();
        break;
    default:
        break
}













