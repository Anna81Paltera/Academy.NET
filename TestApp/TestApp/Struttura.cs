using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
        public struct Targa
        {
            public string Numero;
            public string Prov;
            public int Anno;
            public Azienda Az;

            public string TargaFull()
            { return Numero + Prov; }
        }
}
