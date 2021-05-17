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
    public partial class Form1 : Form
    {
        OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = produse.accdb");
        ColectieProduse produse = new ColectieProduse();
        Produs p;

        public Form1()
        {
            InitializeComponent();
        }





        private void btAdaugare_Click(object sender, EventArgs e)
        {
            if (((TextBox)tbCod).Text == "")
                errorProvider1.SetError((TextBox)tbCod, "Introduceti denumire!");
            else
                    if (((TextBox)tbDenumire).Text == "")
                errorProvider1.SetError((TextBox)tbDenumire, "Introduceti pretul!");
            else
                    if (((TextBox)tbCantitate).Text == "")
                errorProvider1.SetError((TextBox)tbCantitate, "Introduceti cantitate!");
            else

                    if (((TextBox)tbPret).Text == "")
                errorProvider1.SetError((TextBox)tbPret, "Introduceti cantitate!");
            else
                    if (((TextBox)tbAdaos).Text == "")
                errorProvider1.SetError((TextBox)tbAdaos, "Introduceti cantitate!");
            else
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;

                    comanda.CommandText = "SELECT MAX(cod) FROM produse";
                    int cod = Convert.ToInt32(comanda.ExecuteScalar());

                    comanda.CommandText = "INSERT INTO produse VALUES(?,?,?,?,?)";
                    comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod +1 ;
                    comanda.Parameters.Add("pret", OleDbType.Integer).Value = Convert.ToInt32(tbPret.Text);
                    comanda.Parameters.Add("adaos", OleDbType.Decimal).Value = Convert.ToInt32(tbAdaos.Text);
                    comanda.Parameters.Add("Denumire", OleDbType.Char, 20).Value = tbDenumire.Text;
                    comanda.Parameters.Add("cantitate", OleDbType.Char, 2).Value = Convert.ToInt32(tbCantitate.Text);
                    




                    comanda.ExecuteNonQuery();
                    //int cod = Convert.ToInt32(tbCod.Text);
                    //string denumire = tbDenumire.Text;
                    //int cantitate = Convert.ToInt32(tbCantitate.Text);
                    //float pret = Convert.ToInt32(tbPret.Text);
                    //decimal adaos = Convert.ToInt32(tbAdaos.Text);
                    //float total = pret * (int)adaos;
                    //Produs p = new Produs(denumire, pret, adaos, cod, cantitate,total);
                   // produse += p;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                    tbCod.Clear();
                    tbDenumire.Clear();
                    tbCantitate.Clear();
                    tbPret.Clear();
                    tbAdaos.Clear();
                    //tbTotal.Clear();

                }
                
            }
        }
        private void btAfisare_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(produse);
            frm.Show();
        }

       
    }
    }

