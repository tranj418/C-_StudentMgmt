using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace StudentPortal
{
    public partial class AdminForm : Form

    {
        public string connectionString = null;
        MySqlConnection conn;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            connectionString = "server=127.0.0.1; database=student_mgmt; uid=root; pwd=2193ECAstle!!;";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string studentRecords = "Select * from student_card";
            MySqlCommand cmd = new MySqlCommand(studentRecords, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            studentGrid.DataSource = dt;
            conn.Close();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            newStudentForm newStudentF = new newStudentForm();
            newStudentF.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            connectionString = "server=127.0.0.1; database=student_mgmt; uid=root; pwd=2193ECAstle!!;";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //string updateQuery = "Update Student"


        }

        private void _clearfields()
        {
            idBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            emailBox.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            connectionString = "server=127.0.0.1; database=student_mgmt; uid=root; pwd=2193ECAstle!!;";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            string deleteQuery = "delete from student_card where student_id = @studentID";
            var cmd = new MySqlCommand(deleteQuery, conn);

            cmd.Parameters.AddWithValue("@studentID", idBox.Text);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted!");
            _clearfields();
            conn.Close();

        }

        private void studentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow studentrows = studentGrid.Rows[e.RowIndex];
                idBox.Text = studentrows.Cells[0].Value.ToString();
                firstNameBox.Text = studentrows.Cells[1].Value.ToString();
                lastNameBox.Text = studentrows.Cells[2].Value.ToString();
                //birthdatePicker.Value = studentrows.Cells[3].Value.ToString();
                phoneBox.Text = studentrows.Cells[4].Value.ToString();
                emailBox.Text = studentrows.Cells[5].Value.ToString();
                streetBox.Text = studentrows.Cells[6].Value.ToString();
                cityBox.Text = studentrows.Cells[7].Value.ToString();
                zipcodeBox.Text = studentrows.Cells[8].Value.ToString();
                stateBox.Text = studentrows.Cells[9].Value.ToString();
                beginYrBox.Text = studentrows.Cells[10].Value.ToString();
                endYrBox.Text = studentrows.Cells[11].Value.ToString();
                //majorlistBox.SelectedIndex = studentrows.Cells[12].Value.ToString();

            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            birthdatePicker.CustomFormat = "yyyy/MM/dd";
        }
    }
}
