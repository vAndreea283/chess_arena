using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace chessv2
{
    class cPion : cPiesa
    {
        public cPion(int x, int y, culoare culoare) : base(x, y, culoare, culoare == culoare.alb ? 'p' : 'P', culoare == culoare.alb ? "alb_pion.png" : "negru_pion.png")
        {
        }

        public override List<(int, int)> EsteMutareValida(cJocSah sah, int x, int y)
        {
            List<(int, int)> mutari = new List<(int, int)>();
            if (Culoare == culoare.alb)
            {
                if (x >= 1 && sah.mTabla[x - 1, y] == null) mutari.Add((x - 1, y));
                if (y >= 1 && x >= 1 && sah.mTabla[x - 1, y - 1] != null) mutari.Add((x - 1, y - 1));
                if (y <= 6 && x >= 1 && sah.mTabla[x - 1, y + 1] != null) mutari.Add((x - 1, y + 1));
                if (x == 6 && sah.mTabla[x - 2, y] == null) mutari.Add((x - 2, y));
            }
            else
            {
                if (x <= 6 && sah.mTabla[x + 1, y] == null) mutari.Add((x + 1, y)); // Mutare în față
                if (y >= 1 && x <= 6 && sah.mTabla[x + 1, y - 1] != null && sah.mTabla[x + 1, y - 1].culoare != Culoare)
                    mutari.Add((x + 1, y - 1)); // Capturare la stânga
                if (y <= 6 && x <= 6 && sah.mTabla[x + 1, y + 1] != null && sah.mTabla[x + 1, y + 1].culoare != Culoare)
                    mutari.Add((x + 1, y + 1)); // Capturare la dreapta
                if (x == 1 && sah.mTabla[x + 2, y] == null && sah.mTabla[x + 1, y] == null)
                    mutari.Add((x + 2, y)); // Mutare dublă din poziția inițială
            }
            return mutari;
        }
    }
}