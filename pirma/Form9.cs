using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows.Forms;

namespace pirma
{
    public partial class RedaguotiM : Form
    {
        public RedaguotiM()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vertinimasDataB.uzduotis' table. You can move, or remove it, as needed.
            this.uzduotisTableAdapter.Fill(this.vertinimasDataB.uzduotis);
            this.modulisTableAdapter.Fill(this.vertinimasDa.modulis);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                this.modulisTableAdapter.Update(this.vertinimasDa.modulis);

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

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            string searchValue = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("ModulioPavadinimas LIKE '%{0}%' OR KredituSkaicius LIKE '%{0}%'", searchValue);

                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView2.DataSource;
            string searchValue = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("UzduotiesPavadinimas LIKE '%{0}%'", searchValue);

                dataGridView2.DataSource = dataView;
            }
            else
            {
                dataGridView2.DataSource = dataTable;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                this.uzduotisTableAdapter.Update(this.vertinimasDataB.uzduotis);

                MessageBox.Show("Duomenys išsaugoti sėkmingai.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įrašant duomenis į duomenų bazę: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                dataGridView2.Rows.Remove(selectedRow);

                MessageBox.Show("Pasirinkta eilutė buvo sėkmingai pašalinta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pasirinkite eilutę, kurią norite pašalinti.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
