using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows.Forms;

namespace pirma
{
    public partial class PazymiaiEdit : Form
    {
        public PazymiaiEdit()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            this.uzduotisTableAdapter.Fill(this.vertinimasDataB.uzduotis);
            this.pazymysTableAdapter.Fill(this.vertinimasDa.pazymys);
            this.modulisTableAdapter.Fill(this.vertinimasDa.modulis);
            this.studentaiTableAdapter.Fill(this.vertinimasDa.studentai);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;

                if (selectedRow != null)
                {
                    string studentoNumeris = selectedRow["StudentoNumeris"].ToString();
                    string studentoVardas = GautiStudentoVarda(studentoNumeris);
                    string studentoPavarde = GautiStudentoPavarde(studentoNumeris);
                    string studentoGrupe = GautiStudentoGrupe(studentoNumeris);

                    textBox1.Text = studentoNumeris;
                    textBox2.Text = studentoVardas;
                    textBox3.Text = studentoPavarde;
                    textBox4.Text = studentoGrupe;
                }
            }
        }

        private string GautiStudentoVarda(string studentoNumeris)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            
            string studentoVardas = ""; 
            string query = "SELECT Vardas FROM Studentai WHERE StudentoNumeris = @StudentoNumeris";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection)) 
            {
                command.Parameters.AddWithValue("@StudentoNumeris", studentoNumeris); 
                                                                              
                mySqlConnection.Open();
                studentoVardas = (string)command.ExecuteScalar(); 
                mySqlConnection.Close(); 
            }
            return studentoVardas;
        }

        private string GautiStudentoPavarde(string studentoNumeris)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string studentoPavarde = ""; 
            string query = "SELECT Pavarde FROM Studentai WHERE StudentoNumeris = @StudentoNumeris";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection)) 
            {
                command.Parameters.AddWithValue("@StudentoNumeris", studentoNumeris); 
                                                                                     
                mySqlConnection.Open();
                studentoPavarde = (string)command.ExecuteScalar(); 
                mySqlConnection.Close(); 
            }
            return studentoPavarde;
        }

        private string GautiStudentoGrupe(string studentoNumeris)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string studentoGrupe = ""; 
            string query = "SELECT Grupe FROM Studentai WHERE StudentoNumeris = @StudentoNumeris";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection)) 
            {
                command.Parameters.AddWithValue("@StudentoNumeris", studentoNumeris); 
                                                                                      
                mySqlConnection.Open();
                studentoGrupe = (string)command.ExecuteScalar(); 
                mySqlConnection.Close(); 
            }
            return studentoGrupe;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox2.SelectedItem;

                if (selectedRow != null)
                {
                    string modulioPavadinimas = selectedRow["ModulioPavadinimas"].ToString();
                    string kredituSkaicius = GautiKreditus(modulioPavadinimas);

                    textBox5.Text = modulioPavadinimas;
                    textBox6.Text = kredituSkaicius;
                }
            }
        }
        private string GautiKreditus(string modulioPavadinimas)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string kredituSkaicius = "";
            string query = "SELECT KredituSkaicius FROM modulis WHERE ModulioPavadinimas = @ModulioPavadinimas";
            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@ModulioPavadinimas", modulioPavadinimas);

                mySqlConnection.Open();
                
                kredituSkaicius = Convert.ToString(command.ExecuteScalar());
                mySqlConnection.Close();
            }
            return kredituSkaicius;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox3.SelectedItem;

                if (selectedRow != null)
                {
                    string uzduotis = selectedRow["UzduotiesPavadinimas"].ToString();
                    
                    textBox7.Text = uzduotis;
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox4.SelectedItem;

                if (selectedRow != null)
                {
                    string balas = selectedRow["Balas"].ToString();
                    textBox8.Text = balas;

                    if (Int32.TryParse(balas, out int balasSkaicius) && balasSkaicius < 5)
                    {
                        textBox9.Text = "NEIS";
                    }
                    else
                    {
                        textBox9.Text = "IS";
                    }
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.ToShortDateString();

            textBox10.Text = selectedDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Destytojo form = new Destytojo();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=vertinimas; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "INSERT INTO ivertinimas (Grupe, Pavarde, Vardas, ModulioPavadinimas, KredituSkaicius, UzduotiesPavadinimas, Iskaityta, Ivertinimas, StudentoNumeris, data) VALUES (@Grupe, @Pavarde, @Vardas, @ModulioPavadinimas, @KredituSkaicius, @UzduotiesPavadinimas, @Iskaityta, @Balas, @StudentoNumeris, @data)";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                command.Parameters.AddWithValue("@Grupe", textBox4.Text);
                command.Parameters.AddWithValue("@Pavarde", textBox3.Text);
                command.Parameters.AddWithValue("@Vardas", textBox2.Text);
                command.Parameters.AddWithValue("@ModulioPavadinimas", textBox5.Text);
                command.Parameters.AddWithValue("@KredituSkaicius", textBox6.Text);
                command.Parameters.AddWithValue("@UzduotiesPavadinimas", textBox7.Text);
                command.Parameters.AddWithValue("@Iskaityta", textBox9.Text);
                command.Parameters.AddWithValue("@Balas", textBox8.Text);
                command.Parameters.AddWithValue("@StudentoNumeris", textBox1.Text);
                command.Parameters.AddWithValue("@data", textBox10.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Duomenys buvo sėkmingai įrašyti į lentelę 'ivertinimas'.");
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
