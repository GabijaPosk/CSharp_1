using System;
using System.Windows.Forms;

namespace pirma
{
    public partial class Studentai : Form
    {
        public Studentai()
        {
            InitializeComponent();
        }

        private void Destytojo_studentai_Load(object sender, EventArgs e)
        {
            this.studentaiTableAdapter.Fill(this.vertinimasDa.studentai);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }
    }
}
