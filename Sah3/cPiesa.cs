using System.Collections.Generic;

namespace chessv2
{
    abstract class cPiesa
    {
        public culoare culoare;
        protected int x, y;
        private char litera; //doar pentru consola
        private string link;

        protected cPiesa(int x, int y, culoare culoare, char litera, string linkPoza)
        {
            this.Culoare = culoare;
            this.x = x;
            this.y = y;
            this.Litera = litera;
            this.imagine = linkPoza;
        }

        public char Litera { get => litera; set => litera = value; }
        public string imagine { get => link; set => link = value; }
        protected culoare Culoare { get => culoare; set => culoare = value; }

        abstract public List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y);
    }
}