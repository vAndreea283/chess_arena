using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cNebun : cPiesa
    {
        public cNebun(int v1, int v2, culoare c) : base(v1, v2, c, c == culoare.negru ? 'N' : 'n', c == culoare.alb ? "alb_nebun.png" : "negru_nebun.png")
        {
        }
        public override List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y)
        {
            List<(int, int)> mutari = new List<(int, int)>();

            int i = x - 1;
            int j = y + 1;

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