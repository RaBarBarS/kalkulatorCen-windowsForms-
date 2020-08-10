using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nowy
{
    public partial class nowy_monitor : Form
    {
        List<Form1.monitor_class> list_of_monitors = new List<Form1.monitor_class>(Form1.getListMonitor());
        float price_monitor = 0;
        public nowy_monitor()
        {
            InitializeComponent();
            foreach (var elem in list_of_monitors)
            {
                listView1.Items.Add(elem.monitor_nazwa);
            }
        }
        private void button2_Click(object sender, EventArgs e)//anuluj
        {
            Form1.setPriceMonitor(0);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//ok
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null) return;
            int p = listView1.FocusedItem.Index;
            foreach (var elem in list_of_monitors)
            {
                if (elem.monitor_nazwa.Equals(listView1.Items[p].Text))
                {
                    price_monitor = elem.cena;
                    Form1.price_monitor = price_monitor;
                    sum.Text = price_monitor.ToString();
                    break;
                }
            }
        }
    }
}
