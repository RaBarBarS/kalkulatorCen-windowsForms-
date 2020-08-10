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
    public partial class aktualizacja_monitor : Form
    {
        string marka, cena, przekatna;
        bool correct_cena = true, correct_przekatna = true;
        public aktualizacja_monitor()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)//marka
        {
            marka = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)//dodaj
        {
            if(textBox1.Text.Count()!= 0 && textBox2.Text.Count() != 0 && textBox3.Text.Count() != 0 && correct_cena && correct_przekatna)
            {
                float price, diagonal;
                try
                {
                    price = float.Parse(textBox2.Text.Replace(".", ","));
                    if (price == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("NIE MA NIC ZA DARMO");
                        return;
                    }
                    diagonal = float.Parse(textBox3.Text.Replace(".", ","));
                    if (diagonal == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("PRZEKĄTNA NIE MOŻE BYĆ ZEREM");
                        return;
                    }
                    Form1.monitor_class obj = new Form1.monitor_class();
                    obj.monitor_nazwa = textBox1.Text;
                    obj.cena = price;
                    obj.przekatna = diagonal;
                    Form1.baza_monitorow.Add(obj);
                    System.Windows.Forms.MessageBox.Show("ELEMENT ZOSTAL DODANY");
                }catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("TO NIE JEST ROZSĄDNA CENA");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DANE NIEPOPRAWNE");
            }
        }

        private void button2_Click(object sender, EventArgs e)//usuń
        {
            if(Form1.baza_monitorow.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("BAZA JEST PUSTA!");
                return;
            }
            if (textBox1.Text.Count() != 0 && textBox2.Text.Count() != 0 && textBox3.Text.Count() != 0 && correct_cena && correct_przekatna)
            {
                bool del = false;
                float price, diagonal;
                try
                {
                    price = float.Parse(textBox2.Text.Replace(".", ","));
                    diagonal = float.Parse(textBox3.Text.Replace(".", ","));
                    foreach (var elem in Form1.baza_monitorow)
                    {
                        if (elem.monitor_nazwa == textBox1.Text && elem.cena == price && elem.przekatna == diagonal)
                        {
                            del = true;
                            Form1.baza_monitorow.Remove(elem);
                            System.Windows.Forms.MessageBox.Show("ELEMENT ZOSTAL USUNIETY Z BAZY");
                            break;
                        }
                    }
                  if (!del)
                  {
                        System.Windows.Forms.MessageBox.Show("TAKI ELEMENT NIE ZNAJDUJE SIĘ W BAZIE");
                  }
                }catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("TO NIE JEST ROZSĄDNA CENA");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DANE NIEPOPRAWNE");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//cena
        {
            cena = textBox2.Text;
            int dot_count = 0, comma_count = 0;
            int dot_place = -1;
            correct_cena = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(cena);
            for (int i = 0; i < asciiBytes.Count(); i++)
            {
                if (asciiBytes[i] == 44)
                {
                    comma_count += 1;
                    dot_place = i;
                }
                if (asciiBytes[i] == 46)
                {
                    dot_count += 1;
                    dot_place = i;
                }
                if ((asciiBytes[i] < 48 && (asciiBytes[i] != 44 && asciiBytes[i] != 46)) || asciiBytes[i] > 57 || (dot_count + comma_count > 1) || dot_place == 0)
                {
                    textBox2.BackColor = Color.LightCoral;
                    correct_cena = false;
                }
                else if(i > 0 && textBox2.Text[0] == '0' && (dot_count + comma_count == 0))//liczba nie może się zaczynać od 0 chyba że ułamek
                {
                    textBox2.BackColor = Color.LightCoral;
                    correct_cena = false;
                }
                else if (dot_place != -1 && i - dot_place > 2)//niewięcej niż 2 liczby po przecinku
                {
                    textBox2.BackColor = Color.LightCoral;
                    correct_cena = false;
                }
                if (i == asciiBytes.Count() - 1 && correct_cena)//ostatni przebieg fora
                {
                    textBox2.BackColor = Color.White;
                }
            }
            
            if (textBox2.Text.Count() == 0)//żeby jak puste to też wróciło do białego
            {
                correct_cena = true;
                textBox2.BackColor = Color.White;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//przekatna
        {
            przekatna = textBox3.Text;
            int dot_count = 0, comma_count = 0;
            int dot_place = -1;
            correct_przekatna = true;
            
            byte[] asciiBytes = Encoding.ASCII.GetBytes(przekatna);
            for (int i = 0; i < asciiBytes.Count(); i++)
            {
                if (asciiBytes[i] == 44)
                {
                    comma_count += 1;
                    dot_place = i;
                }
                if (asciiBytes[i] == 46)
                {
                    dot_count += 1;
                    dot_place = i;
                }
                if ((asciiBytes[i] < 48 && (asciiBytes[i] != 44 && asciiBytes[i] != 46)) || asciiBytes[i] > 57 || (dot_count + comma_count > 1) || dot_place == 0)
                {
                    textBox3.BackColor = Color.LightCoral;
                    correct_przekatna = false;
                }
                else if (i > 0 && textBox3.Text[0] == '0' && (dot_count + comma_count == 0))
                {
                    textBox3.BackColor = Color.LightCoral;
                    correct_przekatna = false;
                }
                else if (dot_place != -1 && i - dot_place > 2)
                {
                    textBox3.BackColor = Color.LightCoral;
                    correct_przekatna = false;
                }
                if (i == asciiBytes.Count() - 1 && correct_przekatna)
                {
                    textBox3.BackColor = Color.White;
                }
            }
            if (textBox3.Text.Count() == 0)
            {
                correct_przekatna = true;
                textBox3.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
