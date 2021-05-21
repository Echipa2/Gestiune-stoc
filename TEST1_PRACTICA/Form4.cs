using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST1_PRACTICA
{
    public partial class Form4 : Form
    {
        List<ListViewItem> list;
        public Form4(List<ListViewItem> list1)
        {
            InitializeComponent();
            list = list1;
            foreach(ListViewItem itm in list)
            {
                ListViewItem itm2 = itm.Clone() as ListViewItem;
                itm2.SubItems[4].Text = "1";
                listView2.Items.Add(itm2);
                
            }
        }
    }
}
