using System;
using System.Windows.Forms;

namespace pirma
{
    public partial class Destytojo : Form
    {
        public Destytojo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PazymiaiEdit form3 = new PazymiaiEdit();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Studentai form1 = new Studentai();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pazymiai form2 = new Pazymiai();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RedaguotiP form5 = new RedaguotiP();
            form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Moduliai form4 = new Moduliai();
            form4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RedaguotiM form6 = new RedaguotiM();
            form6.Show();
            this.Hide();
        }
    }
}
