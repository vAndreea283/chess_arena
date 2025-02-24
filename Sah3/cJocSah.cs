using System;
using System.Collections.Generic;

namespace chessv2
{
    class cJocSah
    {
        cPiesa[,] tabla;
        cJucator jucator1, jucator2;

        public cJocSah()
        {
            tabla = new cPiesa[8, 8];
            jucator1 = new cJucator();
            jucator2 = new cJucator();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mTabla[i, j] = null;
                }
            }

            for (int j = 0; j < 8; j++)
            {
                mTabla[6, j] = new cPion(6, j, culoare.alb);
                mTabla[1, j] = new cPion(1, j, culoare.negru);
            }

            mTabla[0, 0] = new cTurn(0, 0, culoare.negru);
            mTabla[0, 7] = new cTurn(0, 7, culoare.negru);
            mTabla[7, 0] = new cTurn(7, 0, culoare.alb);
            mTabla[7, 7] = new cTurn(7, 7, culoare.alb);

            mTabla[0, 1] = new cCal(0, 1, culoare.negru);
            mTabla[0, 6] = new cCal(0, 6, culoare.negru);
            mTabla[7, 1] = new cCal(7, 1, culoare.alb);
            mTabla[7, 6] = new cCal(7, 6, culoare.alb);

            mTabla[0, 2] = new cNebun(0, 2, culoare.negru);
            mTabla[0, 5] = new cNebun(0, 5, culoare.negru);
            mTabla[7, 2] = new cNebun(7, 2, culoare.alb);
            mTabla[7, 5] = new cNebun(7, 5, culoare.alb);

            mTabla[0, 3] = new cRegina(0, 3, culoare.negru);
            mTabla[0, 4] = new cRege(0, 4, culoare.negru);

            mTabla[7, 3] = new cRegina(7, 3, culoare.alb);
            mTabla[7, 4] = new cRege(7, 4, culoare.alb);

        }
        internal cPiesa[,] mTabla { get => tabla; set => tabla = value; }

        public void AfiseazaConsola()
        {
            for (int i = 0; i < 8; i++)
            {
                string linie = string.Empty;
                for (int j = 0; j < 8; j++)
                {
                    linie += (mTabla[i, j] != null ? mTabla[i, j].Litera : '.');
                }
                System.Console.WriteLine(linie);
            }
        }

        internal bool MutareValida(int i1, int j1, int i2, int j2)
        {
            List<(int, int)> mutariPosibile = tabla[i1, j1].EsteMutareValida(this, i1, j1);

            foreach ((int,int) mutare in mutariPosibile)
            {
                if (i2 == mutare.Item1 && j2 == mutare.Item2)
                {
                    return true;
                }
            }

            return false ;
        }

        internal void Muta(int i1, int j1, int i2, int j2)
        {
            tabla[i2, j2] = tabla[i1, j1];
            tabla[i1, j1] = null;
        }
    }
}