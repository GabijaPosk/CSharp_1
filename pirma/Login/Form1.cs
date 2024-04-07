using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pirma
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    // Galite apdoroti klaidą čia arba perduoti išimtį aukščiau
                    throw ex;
                }
                return dataTable;
            }
        }
    }

    public class LoginService
    {
        private DatabaseManager dbManager;

        public LoginService(string connectionString)
        {
            dbManager = new DatabaseManager(connectionString);
        }

        public bool StudentLogin(string username, string password)
        {
            string query = "SELECT * FROM studentai WHERE StudentoNumeris = @username AND Slaptazodis = @password";
            DataTable result = dbManager.ExecuteQuery(query, new MySqlParameter("@username", username), new MySqlParameter("@password", password));
            return result.Rows.Count > 0;
        }

        public bool LecturerLogin(string username, string password)
        {
            string query = "SELECT * FROM destytojai WHERE VartotojoVardas = @username AND Slaptazodis = @password";
            DataTable result = dbManager.ExecuteQuery(query, new MySqlParameter("@username", username), new MySqlParameter("@password", password));
            return result.Rows.Count > 0;
        }
    }

    public partial class Login : Form
    {
        private LoginService loginService;

        public Login(LoginService loginService)
        {
            InitializeComponent();
            this.loginService = loginService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = PrisijungimoVardas.Text;
            string password = Slaptazodis.Text;

            bool success = loginService.StudentLogin(username, password);
            if (success)
            {
                Studento form2 = new Studento(username, password);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string username = PrisijungimoVardas2.Text;
            string password = Slaptazodis2.Text;

            bool success = loginService.LecturerLogin(username, password);
            if (success)
            {
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