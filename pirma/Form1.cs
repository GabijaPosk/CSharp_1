using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pirma
{
    public partial class Login : Form
    {
        private string username;
        private string user_password;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentai WHERE StudentoNumeris = @username AND Slaptazodis = @password", mySqlConnection);
                cmd.Parameters.AddWithValue("@username", PrisijungimoVardas.Text);
                cmd.Parameters.AddWithValue("@password", Slaptazodis.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = PrisijungimoVardas.Text;
                    user_password = Slaptazodis.Text;

                    Studento form2 = new Studento(username, user_password);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PrisijungimoVardas.Clear();
                    Slaptazodis.Clear();
                    PrisijungimoVardas.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            string username, user_password;

            username = PrisijungimoVardas2.Text;
            user_password = Slaptazodis2.Text;

            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM destytojai WHERE VartotojoVardas = '" + username + "' AND Slaptazodis = '" + user_password + "'", mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = PrisijungimoVardas2.Text;
                    user_password = Slaptazodis2.Text;

                    Destytojo form3 = new Destytojo();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PrisijungimoVardas2.Clear();
                    Slaptazodis2.Clear();
                    PrisijungimoVardas2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Slaptazodis.PasswordChar = '\0';
            }
            else
            {
                Slaptazodis.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Slaptazodis2.PasswordChar = '\0';
            }
            else
            {
                Slaptazodis2.PasswordChar = '*';
            }
        }
    }
}
