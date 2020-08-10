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
    public partial class nowy_komputer : Form
    {
        List<Form1.procesor> list_of_procesors = new List<Form1.procesor>(Form1.getListProc());
        List<Form1.dysk> list_of_discs = new List<Form1.dysk>(Form1.getListDysk());
        float price_procesor = 0, price_dysk = 0;
        bool all_selected = false;

        public nowy_komputer()
        {
            InitializeComponent();
            foreach (var elem in list_of_procesors)
            {
                comboBox1.Items.Add(elem.procesor_nazwa);
            }
            Check_if_all_selected();
        }        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var elem in list_of_discs)
            {
                if (elem.dysk_nazwa.Equals(radioButton1.Text))
                {
                    price_dysk = elem.cena;
                    float halp = price_procesor + price_dysk;
                    //Form1.price_dysk = price_dysk;
                    sum.Text = halp.ToString();
                    textBox2.Text = price_dysk.ToString();
                    break;
                }
            }
            Check_if_all_selected();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var elem in list_of_discs)
            {
                if (elem.dysk_nazwa.Equals(radioButton2.Text))
                {
                    price_dysk = elem.cena;
                    float halp = price_procesor + price_dysk;
                    //Form1.price_dysk = price_dysk;
                    sum.Text = halp.ToString();
                    textBox2.Text = price_dysk.ToString();
                    break;
                }
            }
            Check_if_all_selected();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var elem in list_of_discs)
            {
                if (elem.dysk_nazwa.Equals(radioButton3.Text))
                {
                    price_dysk = elem.cena;
                    float halp = price_procesor + price_dysk;
                    //Form1.price_dysk = price_dysk;
                    sum.Text = halp.ToString();
                    textBox2.Text = price_dysk.ToString();
                    break;
                }
            }
            Check_if_all_selected();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var elem in list_of_procesors)
            {
                if (elem.procesor_nazwa.Equals(comboBox1.Text))
                {
                    price_procesor = elem.cena;
                    float halp = price_procesor + price_dysk;
                    //Form1.setPriceProcesor(price_procesor);//ustawianko w form1
                    sum.Text = halp.ToString();
                    textBox1.Text = price_procesor.ToString();
                    break;
                }
            }
            Check_if_all_selected();
        }

        public void Check_if_all_selected()
        {
            if (comboBox1.Text != "" && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                textBox1.BackColor = Color.PaleGreen;
                textBox2.BackColor = Color.PaleGreen;
                sum.BackColor = Color.PaleGreen;
                all_selected = true;
            }
            else if(comboBox1.Text != "" || (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                textBox1.BackColor = Color.LemonChiffon;
                textBox2.BackColor = Color.LemonChiffon;
                sum.BackColor = Color.LemonChiffon;
                all_selected = false;
            }
            else
            {
                textBox1.BackColor = Color.WhiteSmoke;
                textBox2.BackColor = Color.WhiteSmoke;
                sum.BackColor = Color.WhiteSmoke;
                all_selected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (all_selected)
            {
                Form1.price_dysk = price_dysk;
                Form1.price_procesor = price_procesor;
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("NIE WSZYSTKIE ELEMENTY ZOSTAŁY WYBRANE");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.setPriceProcesor(0);//zakładam, że skoro anulujemy to komputer pozostaje niewybrany
            Form1.setPriceDysk(0);
            this.Close();
        }


    }
}
