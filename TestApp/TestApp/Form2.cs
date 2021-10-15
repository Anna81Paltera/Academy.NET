using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCliccami_Click(object sender, EventArgs e)
        {
            #region Raggruppamento

            //List<Persona> persone = new List<Persona>();
            //persone.Add(new Persona { Nome = "Nome1", Cognome = "Cognome1" });
            //persone.Add(new Persona { Nome = "Nome2", Cognome = "Cognome2" });
            //persone.Add(new Persona { Nome = "Nome2", Cognome = "Cognome3" });
            //persone.Add(new Persona { Nome = "Nome2", Cognome = "Cognome4" });
            //persone.Add(new Persona { Nome = "Nome3", Cognome = "Cognome5" });
            //persone.Add(new Persona { Nome = "Nome3", Cognome = "Cognome6" });
            //persone.Add(new Persona { Nome = "Nome4", Cognome = "Cognome7" });
            //persone.Add(new Persona { Nome = "Nome4", Cognome = "Cognome8" });
            //persone.Add(new Persona { Nome = "Nome4", Cognome = "Cognome9" });

            //Persona nuovaPersona = new Persona { Nome = "Nmnmnm", Cognome = "ABCDE" };

            //if (persone.Where(p => p.Cognome == nuovaPersona.Cognome).Select(p=>p).First()==null)
            //{
            //    persone.Add(nuovaPersona);
            //}

            //var query = from p in persone
            //            group p by p.Nome into k
            //            select new { k.Key, Persone = k.ToList() };

            //foreach (var grp in query)
            //{
            //    txtGroups.Text += Environment.NewLine + grp.Key + Environment.NewLine;

            //    foreach (Persona p in grp.Persone)
            //        txtGroups.Text += "  " + p.Nome + " " + p.Cognome + Environment.NewLine;
            //}

            #endregion

            #region OperazioniSugliInsiemi

            List<int> n1 = new List<int>() { 8, 8, 15, 15, 11, 77, 50, 50, 20, 62, 175, 10 };
            List<int> n2 = new List<int>() { 62, 111, 175, 50, 10 };

            IEnumerable<int> l1 = n1.Distinct();       // 8,15,11,77,50,20,62,175,10
            IEnumerable<int> l2 = n1.Except(n2);	   // 8,15,11,77,20,
            IEnumerable<int> l3 = n1.Intersect(n2);    // 50,62,175,10,
            IEnumerable<int> l4 = n1.Union(n2);        // 8,15,11,77,50,20,62,175,10,111

            #endregion
        }

        private void Square(int x)
        {
            x *= x;
        }

        private void Square(int[] x)
        {
            x[2] *= x[2];
        }

        private void Square(ref int x)
        {
            x *= x;
        }

        private void Square(ref int[] x)
        {
            x[2] *= x[2];
            x = new int[2] { 4,5};
        }

        private void SquareOut(out int[] x)
        {
            x = new int[2] { 4, 5 };
            x[1] *= x[1];
        }
    }
}
