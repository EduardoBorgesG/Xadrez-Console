using System.Xml;

namespace Tabuleiro
{
    internal class Posicao
    {
        public int lina { get; set; }
        public int coluna { get; set; }
        public Posicao(int lina, int coluna)
        {
            this.lina = lina;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return lina + "," + coluna;
        }
    }
}
