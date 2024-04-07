using System;
using System.Windows.Forms;

namespace pirma
{
    public partial class Pazymiai : Form
    {
        public Pazymiai()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.ivertinimasTableAdapter.Fill(this.vertinimasDa.ivertinimas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }
    }
}
