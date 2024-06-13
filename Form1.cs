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
            this.Hide(); //BU FORMU GÝZLER
            FormYýlanOyunu frmAnaForm = new FormYýlanOyunu(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //BU FORMU GÝZLER
            FormKelimeOyunu frmAnaForm = new FormKelimeOyunu(); //form2 yi kullanabiliriz.
            frmAnaForm.Show(); // form2 yi gösterir.
        }
    }
}
