using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1_PRACTICA
{
    public partial class Form2 : Form
    {
        ColectieProduse colect = new ColectieProduse();

        public Form2(ColectieProduse c)
        {


            InitializeComponent();

            colect = c;
            tbProduse.Text = c.ToString();

        }

        private void btSalvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                sw.WriteLine(colect.ToString());
                sw.Close();
                MessageBox.Show("Salvat cu succes!");
            }
        }

        private void btCitire_Click(object sender, EventArgs e)
        {
            OpenFileDialog svd = new OpenFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(svd.FileName);
                tbProduse.Clear();
                tbProduse.Text += "Citit din fisierul" + svd.FileName + Environment.NewLine;
                tbProduse.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Citire cu succes!");
            }
        }

        private void btSerializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileStream, colect);
            fileStream.Close();
            MessageBox.Show("Serializare cu succes!");
        }

        private void btDeserializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            colect = (ColectieProduse)bf.Deserialize(fileStream);

            tbProduse.Clear();
            tbProduse.Text += "Obiecte deserializate din fisier.dat" + Environment.NewLine;
            string result = "";
            foreach (Produs r in colect.Produse)
            {
                result += r.ToString() + Environment.NewLine;
            }
            tbProduse.Text += result;
            fileStream.Close();
            MessageBox.Show("Deserializare cu succes!");
        }
        private void btSalvare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbProduse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBaza_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(colect);
            frm.Show();
        }
    }
}

