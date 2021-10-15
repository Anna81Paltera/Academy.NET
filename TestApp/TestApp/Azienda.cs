using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Azienda : Organizzazione
    {
        public Azienda()
        {
           
        }
        public Azienda(string nome)
        {
            Nome = nome;
        }

        private string _indirizzo = "Gianni";
        private string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        

        private string _nome;
        public string Nome 
        {
            get 
            { 
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public void Salva()
        {
            PartitaIva = "";
        }

        public Persona[] Dipendenti
        { get; set; }
    }
}
