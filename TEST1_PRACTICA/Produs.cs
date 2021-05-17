using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1_PRACTICA
{
    public class Produs
    {

        private string denumire;
        private float pret;
        private decimal adaos;
        private int cod_de_bare;
        private int cantitate;
        private float total;

        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }
        public decimal Adaos { get =>adaos; set => adaos = value; }
        public int Cod { get => cod_de_bare; set => cod_de_bare = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }

        public float Total{ get => total; set => total = value; }

        public Produs(string d, float p, decimal a, int c, int cant, float t)
        {
            denumire = d;

            pret = p;
            adaos = a;
            cod_de_bare = c;
            cantitate = cant;
            total = t;

        }

        public Produs()
        {
        }

      
        public override string ToString()
        {
            return  cod_de_bare + "\t" + "\t"+ denumire + "\t" + "\t"  + pret + "\t" + "\t" + adaos + "\t" + "\t" + total + "\t" + "\t" + cantitate;
        }


       
    }

}
