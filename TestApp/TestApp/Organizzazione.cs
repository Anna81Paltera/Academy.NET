using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Organizzazione
    {
        public string Stato {get; set; }

        public static void Pippo()
        { }

        private string _piva;
        protected string PartitaIva
        {
            get
            {
                return _piva;
            }
            set
            {
                _piva = value;
            }
        }
    }
}
