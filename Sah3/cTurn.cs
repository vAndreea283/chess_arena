using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cTurn : cPiesa
    {
        public cTurn(int x, int y, culoare c) : base(x, y, c, c == culoare.alb ? 't' : 'T', c == culoare.alb ? "alb_turn.png" : "negru_turn.png")
        {
        }

        public override List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y)
        {
            List<(int, int)> mutari = new List<(int, int)>();

            int i, j;

            i = x - 1; j = y;
            while (i >= 0)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i--;
            }

            i = x + 1; j = y;
            while (i <= 7)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i++;
            }

            i = x; j = y - 1;
            while (j >= 0)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                j--;
            }

            i = x; j = y + 1;
            while (j <= 7)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                j++;
            }

            return mutari;
        }
    }
}