using Devart.Data.MySql;
using System;
using System.Windows.Forms;

namespace pirma
{
    public partial class Moduliai : Form
    {
        public Moduliai()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }

        private void Moduliai_Load(object sender, EventArgs e)
        {
            this.modulisTableAdapter.Fill(this.vertinimasDa.modulis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "INSERT INTO modulis (ModulioPavadinimas, KredituSkaicius) VALUES (@ModulioPavadinimas, @KredituSkaicius)";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                command.Parameters.AddWithValue("@ModulioPavadinimas", textBox1.Text);
                command.Parameters.AddWithValue("@KredituSkaicius", textBox2.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Duomenys buvo sėkmingai įrašyti į lentelę 'modulis'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Įvyko klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "INSERT INTO uzduotis (UzduotiesPavadinimas) VALUES (@UzduotiesPavadinimas)";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                command.Parameters.AddWithValue("@UzduotiesPavadinimas", textBox3.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Duomenys buvo sėkmingai įrašyti į lentelę 'uzduotis'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Įvyko klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
