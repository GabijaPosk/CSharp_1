using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows.Forms;

namespace pirma
{
    public partial class RedaguotiP : Form
    {
        public RedaguotiP()
        {
            InitializeComponent();
        }

        private void RedaguotiP_Load(object sender, EventArgs e)
        {
            this.ivertinimasTableAdapter.Fill(this.vertinimasDa.ivertinimas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            string searchValue = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("Vardas LIKE '%{0}%' OR StudentoNumeris LIKE '%{0}%'", searchValue);

                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                this.ivertinimasTableAdapter.Update(this.vertinimasDa.ivertinimas);

                MessageBox.Show("Duomenys išsaugoti sėkmingai.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įrašant duomenis į duomenų bazę: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Pasirinkta eilutė buvo sėkmingai pašalinta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pasirinkite eilutę, kurią norite pašalinti.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
