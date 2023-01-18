using tabuleiro;
using xadrez_console;
using xadrez;
try
{
    PosicaoXadrez pos = new PosicaoXadrez('a', 1);
    PosicaoXadrez pos1 = new PosicaoXadrez('c', 7);
    PosicaoXadrez pos2 = new PosicaoXadrez('a', 1);
    PosicaoXadrez pos3 = new PosicaoXadrez('a', 1);
    Console.WriteLine(pos.toPosicao());
    Console.WriteLine(pos1.toPosicao());
    Console.ReadLine();
}
catch (TabuleiroException e)
{

    Console.WriteLine(e.Message);
}
