using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cRegina : cPiesa
    {
        public cRegina(int v1, int v2, culoare c) : base(v1, v2, c, c == culoare.alb ? 'd' : 'D', c == culoare.alb ? "alb_regina.png" : "negru_regina.png")
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

            i = x - 1;
            j = y + 1;

            while (i >= 0 && j <= 7)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i--;
                j++;
            }

            i = x - 1;
            j = y - 1;

            while (i >= 0 && j >= 0)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i--;
                j--;
            }

            i = x + 1;
            j = y - 1;

            while (i <= 7 && j >= 0)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i++;
                j--;
            }

            i = x + 1;
            j = y + 1;

            while (i <= 7 && j <= 7)
            {
                if (sah.mTabla[i, j] != null && sah.mTabla[i, j].culoare == sah.mTabla[x, y].culoare)
                    break;
                mutari.Add((i, j));
                if (sah.mTabla[i, j] != null) break;
                i++;
                j++;
            }

            return mutari;
        }
    }
}