using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Oyunlar
{
    public partial class FormKelimeOyunu : Form
    {
        public FormKelimeOyunu()
        {
            InitializeComponent();
        }
        int puan = 0;
        string secilen;
        private void FormKelimeOyunu_Load(object sender, EventArgs e)
        {
            Karistir();
        }
        Random rnd = new Random();
        public void Karistir()
        {
            String[] kelimeler = { "elma", "armut", "televizyon", "bilgisayar", "kalem", "peçete", "zımba", "makas", "pano", "fare", "kedi", "köpek", "üniversite", "yılan", "proje", "yazılım" };

            secilen = kelimeler[rnd.Next(0, kelimeler.Length)].ToUpper();

            List<String> harfler = new List<string>();
            foreach (var item in secilen)
            {
                harfler.Add(item.ToString());

            }

            for (int i = 0; i < secilen.Length; i++)
            {
                int a = rnd.Next(0, secilen.Length);
                int b = rnd.Next(0, secilen.Length);

                int tekrar = rnd.Next(3, 20);

                for (int j = 0; j < tekrar; j++)
                {


                    string gecici = harfler[a];
                    harfler[a] = harfler[b];
                    harfler[b] = gecici;
                }
            }

            string sonHal = "";

            foreach (var item in harfler)
            {
                sonHal += item;
            }
            if (secilen == sonHal)
            {
                Karistir();
            }
            else
            {

                lblKelime.Text = sonHal;
            }


        }

        private void buttonPas_Click(object sender, EventArgs e)
        {
            Karistir();
            puan -= 5;
            lblPuan.Text = puan.ToString();
        }

        private void buttonKontrolEt_Click(object sender, EventArgs e)
        {
            if (secilen == textBox1.Text.ToUpper())
            {
                puan += 10;

            }
            else
            {
                puan -= 7;

            }
            lblPuan.Text = puan.ToString();
            Karistir();
            textBox1.Text = "";
        }
        int sayac = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                sayac--;
                lblSaniye.Text = sayac.ToString();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("PUANINIZ:" + puan, "OYUN");
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayac = 30;
            timer1.Enabled = true;
            puan = 0;
            lblPuan.Text = puan + "";
            lblSaniye.Text = sayac + "";
            textBox1.Text = "";
            Karistir();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (secilen == textBox1.Text.ToUpper())
            {
                puan += 10;
                lblPuan.Text = puan.ToString();
                Karistir();
                textBox1.Text = "";

            }
        }
    }
}
