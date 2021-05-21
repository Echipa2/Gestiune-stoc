using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace TEST1_PRACTICA
{
    public partial class Form5 : Form
    {
        
        List<Produs> list1=new List<Produs>();
        double total = 0;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; DATA SOURCE = produse.accdb";
        public Form5()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            list1.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                // MessageBox.Show("S-a deschis!");
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM produse";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    Produs p = new Produs();
                    p.Cod = Convert.ToInt32(reader["Cod"].ToString());
                    p.Denumire = reader["denumire"].ToString();
                    p.Adaos = Convert.ToInt32(reader["adaos"].ToString());
                    p.Pret = Convert.ToInt32(reader["pret"].ToString());
                    p.Cantitate = Convert.ToInt32(reader["cantitate"].ToString());

                    double total = p.Pret + (int)p.Adaos / 100.0 * p.Pret;
                    p.Total = total;

                    list1.Add(p);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conexiune = new OleDbConnection(connString);
            string cod_string = tbCod.Text;
            string cantitate_string = tbCantitate.Text;
            try
            {
                int cod = Convert.ToInt32(cod_string);
                int cantitate = Convert.ToInt32(cantitate_string);

                bool ok = false;

                foreach (var el in list1)
                {                  
                    if (el.Cod==cod && el.Cantitate>=cantitate && cantitate>0)
                    {
                        ok = true;
                        conexiune.Open();
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;
                        comanda.CommandText = "UPDATE produse SET cantitate=" + (el.Cantitate-cantitate) + " WHERE cod=" + cod;            
                        comanda.ExecuteNonQuery();
                        conexiune.Close();

                         var frm = (Form3)this.Owner;
                         if (frm != null)
                            frm.button1.PerformClick();
 
                        textBox3.Text += el.Cod + "\t" + el.Denumire + "\t" + cantitate + "\t" + cantitate * el.Total;
                        textBox3.AppendText(Environment.NewLine);
                        total += el.Total * cantitate;
                        tbTotal.Text = total.ToString();
                        

                    }
                    
                }
                if(ok==false)
                {
                    MessageBox.Show("Produs inexistent sau cantitate incorecta");
                }
                populate();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Formatul datelor este incorect");
            }
            finally
            {
               
            }
        }
    }
}
