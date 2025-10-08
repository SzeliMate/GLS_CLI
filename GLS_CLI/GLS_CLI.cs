using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLS_CLI
{
    internal class GLS_CLI
    {
        internal class GLS
        {
            public int datum { get; set; }
            public string sofornev { get; set; }
            public int km { get; set; }
            public int kcssz { get; set; }

            public int fogyasztas { get; set; }


            public GLS(string adat)
            {
                var resz = adat.Split(';');
                datum = int.Parse(resz[0]);
                sofornev = resz[1];
                km = int.Parse(resz[2]);
                kcssz = int.Parse(resz[3]);
                fogyasztas = int.Parse(resz[4]);
            }
            public GLS(int datum, string sofornev, int km, int kcssz, int fogyasztas)
            {
                this.datum = datum;
                this.sofornev = sofornev;
                this.km = km;
                this.kcssz = kcssz;
                this.fogyasztas = fogyasztas;
            }


            public override string ToString()
            {
                return $"{datum} {sofornev} {km} {kcssz} {fogyasztas}";
            }

        }
    }
}
