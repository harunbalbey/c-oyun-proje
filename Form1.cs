namespace Proje_Oyunlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYilanOyunu_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            FormY�lanOyunu frmAnaForm = new FormY�lanOyunu(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU G�ZLER
            FormKelimeOyunu frmAnaForm = new FormKelimeOyunu(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi g�sterir.
        }
    }
}
