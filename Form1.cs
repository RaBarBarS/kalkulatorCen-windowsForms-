using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace nowy
{
    public partial class Form1 : Form
    {
        public static float price_monitor = 0, price_dysk = 0, price_procesor = 0;
        public static List<procesor> baza_procesorow = new List<procesor>();
        public static List<dysk> baza_dyskow = new List<dysk>();
        public static List<monitor_class> baza_monitorow = new List<monitor_class>();
        
        //WYSYŁANIE LIST DO INNYCH FORM I USTAWIANIE ZMIENNYCH FORM1
        public static List<procesor> getListProc()
        {
            return baza_procesorow;
        }
        public static void setPriceProcesor(float cena)
        {
            price_procesor = cena;
        }
        public static List<dysk> getListDysk()
        {
            return baza_dyskow;
        }
        public static void setPriceDysk(float cena)
        {
            price_dysk = cena;
        }
        public static List<monitor_class> getListMonitor()
        {
            return baza_monitorow;
        }
        public static void setPriceMonitor(float cena)
        {
            price_monitor = cena;
        }

        [Serializable()]
        public class procesor
        {
            public string procesor_nazwa { get; set; }
            public float cena { get; set; }
        }
        [Serializable()]
        public class dysk
        {
            public string dysk_nazwa { get; set; }
            public float cena { get; set; }
        }
        [Serializable()]
        public class monitor_class
        {
            public string monitor_nazwa { get; set; }
            public float cena { get; set; }
            public float przekatna { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            read();
        }


        private void button_monitor_aktu_Click(object sender, EventArgs e)
        {
            aktualizacja_monitor ak_mon = new aktualizacja_monitor();
            ak_mon.ShowDialog();
        }

        
        private void button_procesor_Click(object sender, EventArgs e)
        {
            aktualizacja_procesor ak_proc = new aktualizacja_procesor();
            ak_proc.ShowDialog();
        }

        private void button_komputer_Click(object sender, EventArgs e)
        {
            if (baza_dyskow == null || baza_procesorow == null || baza_dyskow.Count == 0 || baza_procesorow.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("BAZA KOMPUTEROW JEST PUSTA!");
            }
            else
            {
                nowy_komputer now_kom = new nowy_komputer();
                now_kom.FormClosed += (s, a) => sum.Text = (price_monitor + price_dysk + price_procesor).ToString();//https://stackoverflow.com/questions/33337092/form1-do-something-when-form2-closed
                now_kom.ShowDialog();
            }
        }

       

        private void button_monitor_Click(object sender, EventArgs e)
        {
            if (baza_monitorow == null || baza_monitorow.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("BAZA MONITOROW JEST PUSTA!");
            }
            else
            {
                nowy_monitor now_mon = new nowy_monitor();
                now_mon.FormClosed += (s, a) => sum.Text = (price_monitor + price_dysk + price_procesor).ToString();
                now_mon.ShowDialog();
            }
        }

        private void read()
        {
            try
            {
                StreamReader fileStream = new StreamReader("baza_procesorow.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<procesor>));
                baza_procesorow = (List<procesor>)serializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("nie istnieje plik baza_procesorow.xml");
            }
            try
            {
                StreamReader fileStream = new StreamReader("baza_dyskow.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<dysk>));
                baza_dyskow = (List<dysk>)serializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("nie istnieje plik baza_dyskow.xml");
            }
            try
            {
                StreamReader fileStream = new StreamReader("baza_monitorow.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<monitor_class>));
                baza_monitorow = (List<monitor_class>)serializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("nie istnieje plik baza_monitorow.xml");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baza_procesorow.Count() != 0)
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<procesor>));
                TextWriter filestream = new StreamWriter(@"baza_procesorow.xml");
                serialiser.Serialize(filestream, baza_procesorow);
                filestream.Close();
                Console.WriteLine("baza_procesorow.xml zapisana");//bin/Debug
            }
            //if (baza_dyskow.Count() != 0)
            //{
            //    XmlSerializer serialiser = new XmlSerializer(typeof(List<dysk>));
            //    TextWriter filestream = new StreamWriter(@"baza_dyskow.xml");
            //    serialiser.Serialize(filestream, baza_dyskow);
            //    filestream.Close();
            //    Console.WriteLine("baza_dyskow.xml zapisana");//bin/Debug
            //}
            if (baza_monitorow.Count() != 0)
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<monitor_class>));
                TextWriter filestream = new StreamWriter(@"baza_monitorow.xml");
                serialiser.Serialize(filestream, baza_monitorow);
                filestream.Close();
                Console.WriteLine("baza_monitorow.xml zapisana");//bin/Debug
            }
        }
    }
}
