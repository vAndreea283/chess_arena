using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cCal : cPiesa
    {
        public cCal(int x, int y, culoare culoare) : base(x, y, culoare, culoare == culoare.alb ? 'c' : 'C', culoare == culoare.alb ? "alb_cal.png" : "negru_cal.png")
        {
        }
        public override List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y)
        {
            List<(int, int)> mutari = new List<(int, int)>();

            int i, j;
            i = x - 1; j = y - 2;
            if (i >= 0 && j >= 0 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x - 1; j = y + 2;
            if (i >= 0 && j <= 7 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x - 2; j = y + 1;
            if (i >= 0 && j <= 7 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x - 2; j = y - 1;
            if (i >= 0 && j >= 0 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x + 1; j = y + 2;
            if (i <= 7 && j <= 7 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x + 1; j = y - 2;
            if (i <= 7 && j >= 0 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x + 2; j = y + 1;
            if (i <= 7 && j <= 7 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            i = x + 2; j = y - 1;
            if (i <= 7 && j >= 0 &&
                (sah.mTabla[i, j] == null || sah.mTabla[i, j].culoare != sah.mTabla[x, y].culoare))
            {
                mutari.Add((i, j));
            }

            return mutari;
        }
    }
}