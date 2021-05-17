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
    public partial class Form3 : Form
    {
        ColectieProduse colect = new ColectieProduse();
        string connString;
        public Form3(ColectieProduse c)
        {
            colect = c;
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; DATA SOURCE = produse.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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

                    ListViewItem itm = new ListViewItem(reader["Cod"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    itm.SubItems.Add(reader["adaos"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["cantitate"].ToString());
                    //  itm.SubItems.Add(reader["total"].ToString());
                    listView1.Items.Add(itm);
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        //comanda.CommandText = "UPDATE produse SET cantitate='"+ cbAlege.Text+ tbEdit.Text+ "' WHERE cod=" + cod;
                        if (cbAlege.SelectedItem.ToString() == "pret")
                        {
                            comanda.CommandText = "UPDATE produse SET pret='" + tbEdit.Text + "' WHERE cod=" + cod;
                        }

                        if (cbAlege.SelectedItem.ToString() == "cantitate")
                        {
                            comanda.CommandText = "UPDATE produse SET cantitate='" + tbEdit.Text + "' WHERE cod=" + cod;
                        }

                        if (cbAlege.SelectedItem.ToString() == "Denumire")
                        {
                            comanda.CommandText = "UPDATE produse SET Denumire='" + tbEdit.Text + "' WHERE cod=" + cod;
                        }
                        if (cbAlege.SelectedItem.ToString() == "Adaos")
                        {
                            comanda.CommandText = "UPDATE produse SET adaos='" + tbEdit.Text + "' WHERE cod=" + cod;
                        }

                        comanda.ExecuteNonQuery();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            button1_Click(sender, e);
        }

        
        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM produse WHERE  cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            button1_Click(sender, e);
        }
    }

}
