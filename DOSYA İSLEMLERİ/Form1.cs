using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//kloasor olusturmak ıcın kutuphanae tanımla


namespace DOSYA_İSLEMLERİ
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnklasorolustur_Click(object sender, EventArgs e)
        {
            string klasor = textBox1.Text;
         Directory.CreateDirectory   ("C:\\Users\\beyza aktas\\OneDrive\\Belgeler\\C#\\c# form app\\DOSYA İSLEMLERİ\\DOSYA İSLEMLERİ\\bin" + klasor );// dosya ekleme
        }

        private void btnklasörsil_Click(object sender, EventArgs e)
        {
            string klasor = textBox1.Text;
            Directory.Delete("C:\\Users\\beyza aktas\\OneDrive\\Belgeler\\C#\\c# form app\\DOSYA İSLEMLERİ\\DOSYA İSLEMLERİ\\bin" + klasor);// dosya silme istenilen dosyanın ozellikler guvenlıge gel name koppyala
        }

        private void btnyolkontrol_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app\DOSYA İSLEMLERİ\DOSYA İSLEMLERİ\bin";// dosya var mi yok mu true folse
            MessageBox.Show(Directory.Exists(yol).ToString());
        }

        private void btnolusturmatarihi_Click(object sender, EventArgs e)
        {
            string adres = @"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app\DOSYA İSLEMLERİ\DOSYA İSLEMLERİ\bin";
            MessageBox.Show(Directory.GetCreationTime(adres).ToString ());// adresin olusturma zamanını al
        }

        private void aktifprogramyolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "program dosyalari";

            string adres = @"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app";
            string[] klasor = Directory.GetDirectories(adres);
            foreach (string i in klasor)
            {
                listBox1.Items.Add(ToString());
            }
        }

        private void btnsonerisimzamani_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app\DOSYA İSLEMLERİ\DOSYA İSLEMLERİbeyza";
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToString());
        }

        private void btnklasoradidegistir_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app\DOSYA İSLEMLERİ\DOSYA İSLEMLERİbeyza", @"C:\Users\beyza aktas\OneDrive\Belgeler\C#\c# form app\DOSYA İSLEMLERİ\ayse");
        }

        private void btnsuruculerlistele_Click(object sender, EventArgs e)
        {
string[]dizi=System.IO.Directory.GetLogicalDrives();
            listBox1.Items.AddRange(dizi);
        }

        private void btnustdizin_Click(object sender, EventArgs e)
        {
            DirectoryInfo ustdizin = Directory.GetParent(@"C:\Users\beyza aktas\OneDrive\Resimler");
            MessageBox.Show(ustdizin.ToString());
        }
    }
}
