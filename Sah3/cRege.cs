using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cRege : cPiesa
    {
        public cRege(int v1, int v2, culoare c) : base(v1, v2, c, c == culoare.alb ? 'r' : 'R', c == culoare.alb ? "alb_rege.png" : "negru_rege.png")
        {
        }
        public override List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y)
        {
            List<(int, int)> mutari = new List<(int, int)>();

            int i, j;

            i = x - 1;
            j = y;
            if (i >= 0 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x + 1;
            j = y;
            if (i <= 7 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x;
            j = y - 1;
            if (j >= 0 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x;
            j = y + 1;
            if (j <= 7 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x + 1;
            j = y;
            if (i <= 7 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x - 1;
            j = y - 1;
            if (i >= 0 && j >= 0 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x - 1;
            j = y + 1;
            if (i >= 0 && j <= 7 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x + 1;
            j = y - 1;
            if (i <= 7 && j >= 0 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            i = x + 1;
            j = y + 1;
            if (i <= 7 && j <= 7 && (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
                mutari.Add((i, j));

            return mutari;
        }
    }
}