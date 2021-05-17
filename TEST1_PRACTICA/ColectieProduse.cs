using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1_PRACTICA
{
    public class ColectieProduse: ICloneable
    {
        private List<Produs> produse;

        public ColectieProduse()
        {
            produse = new List<Produs>();
        }

        public ColectieProduse(List<Produs> Produse)
        {
            produse = Produse;
        }

        public List<Produs> Produse
        {
            get { return produse; }
            set { if (value != null) produse = value; }
        }

        public object Clone()
        {
            ColectieProduse colectie = (ColectieProduse)this.MemberwiseClone();
            List<Produs> lista = new List<Produs>();
            foreach (Produs r in produse)
                lista.Add(r);
            colectie.produse = lista;
            return colectie;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Produs p in produse)
            {
                result += p.ToString() + Environment.NewLine;
            }
            return result;
        }

        public Produs this[int index]
        {
            get
            {
                if (index < produse.Count() && index >= 0 && produse != null)
                {
                    return produse[index];
                }
                else
                    return null;
            }
        }

        public static ColectieProduse operator +(ColectieProduse c, Produs p)
        {
            c.produse.Add(p);
            return c;
        }
    }
}
