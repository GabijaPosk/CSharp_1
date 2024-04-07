using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pirma
{
    public partial class Studento : Form
    {
        private string username;
        private string user_password;

        public Studento(string username, string user_password)
        {
            InitializeComponent();
            this.username = username;
            this.user_password = user_password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void Studento_Load_1(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            string query = "SELECT Grupe, Pavarde, Vardas, ModulioPavadinimas, KredituSkaicius, UzduotiesPavadinimas, Iskaityta, Ivertinimas, StudentoNumeris, data FROM ivertinimas WHERE StudentoNumeris = @studentoNumeris";

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
            {
                try
                {
                    mySqlConnection.Open();
                    cmd.Parameters.AddWithValue("@studentoNumeris", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;

                            double bendraSuma = 0;
                            double bendrasKredituSkaicius = 0;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                double kreditai = Convert.ToDouble(row["KredituSkaicius"]);
                                double pazymys = Convert.ToDouble(row["Ivertinimas"]);

                                bendraSuma += kreditai * pazymys;
                                bendrasKredituSkaicius += kreditai;
                            }

                            double vidurkis = Math.Round(bendraSuma / bendrasKredituSkaicius, 2);
                            textBox1.Text = vidurkis.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nerasta duomenų pagal jūsų vartotojo vardą.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida įkeliant duomenis iš duomenų bazės: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}