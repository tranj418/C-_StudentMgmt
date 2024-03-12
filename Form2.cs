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
    public partial class newStudentForm : Form
    {
        public string connectionString = null;
        MySqlConnection conn;

        public newStudentForm()
        {
            InitializeComponent();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void _clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            _fNameBox.Clear();
            _lnameBox.Clear();
            _emailBox.Clear();
            _PhoneNumBox.Clear();
            _MajorListBox.ClearSelected();
            _birthdatepicker2.Value = DateTime.Today;
            _streetaddrBox.Clear();
            _cityBox.Clear();
            _stateBox.Clear();
            _zipcodebox.Clear();
            _beginYrBox.Clear();
            _endYrBox.Clear();
        }

        private void _addBtn_Click(object sender, EventArgs e)
        {

            int _zipcodeInt = Convert.ToInt32(_zipcodebox.Text);

            
            if(_fNameBox.Text == "" || _lnameBox.Text == "" || _emailBox.Text == "" || _PhoneNumBox.Text == "" || _streetaddrBox.Text == "" || _cityBox.Text == "" || _stateBox.Text == "" || _beginYrBox.Text == "" || _endYrBox.Text == "")
            {
                MessageBox.Show("Please fill out all the fields"); 
                return;
                
            }
            else if(_stateBox.TextLength > 2 || _stateBox.TextLength < 2)
            {
                MessageBox.Show("Two character limit for the state\n (i.e. MI, FL, NY, CA)");
                return;
            }
            else if(_zipcodebox.Text.Length < 5 || _zipcodebox.Text.Length > 5)
            {
                MessageBox.Show("Zipcode length is 5");
                return;
            }
            else if(_MajorListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an major program, if not sure, click undecided");
                return;
            }
            


            connectionString = "server=127.0.0.1; database=student_mgmt; uid=root; pwd=2193ECAstle!!;";
            conn = new MySqlConnection(connectionString);
            //int _zipcodeInt = Convert.ToInt32(_zipcodebox.Text);


            try
            {
                conn.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //At some point will want to see if you can execute a SQL proc instead..eh
            string sqlQuery = "insert into student_card (first_name, last_name, birthdate, phone, email, street_addr, city, zipcode, state, begin_year, expected_grad_yr, major) values(@fName, @lName, @birthDate, @phoneNum, @email, @strAddr, @city, @zipcode, @state, @beginYr, @expYr, @major)";

            var cmd = new MySqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("@fName", _fNameBox.Text);
            cmd.Parameters.AddWithValue("@lName", _lnameBox.Text);
            cmd.Parameters.AddWithValue("@birthDate", _birthdatepicker2.Value);
            //Must have a custom date format set, function for that very buttom, valuechange event

            cmd.Parameters.AddWithValue("@phoneNum", _PhoneNumBox.Text);
            cmd.Parameters.AddWithValue("@email", _emailBox.Text);
            cmd.Parameters.AddWithValue("@strAddr", _streetaddrBox.Text);
            cmd.Parameters.AddWithValue("@city", _cityBox.Text);
            cmd.Parameters.AddWithValue("@zipcode", _zipcodeInt);
            cmd.Parameters.AddWithValue("@state", _stateBox.Text);
            cmd.Parameters.AddWithValue("@beginYr", _beginYrBox.Text);
            cmd.Parameters.AddWithValue("@expYr", _endYrBox.Text);
            cmd.Parameters.AddWithValue("@major", _MajorListBox.Text);
           
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student added!");
            
            conn.Close();
            clearFields();
            
        }

        private void _birthdatepicker2_ValueChanged(object sender, EventArgs e)
        {
            _birthdatepicker2.CustomFormat = "yyyy/MM/dd";
        }

        private void _MajorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newStudentForm_Load(object sender, EventArgs e)
        {
            _PhoneNumBox.Text = "xxx-xxx-xxxx";
            _PhoneNumBox.ForeColor = Color.LightGray;
            _PhoneNumBox.Focus();
        }

        private void _PhoneNumBox_Enter(object sender, EventArgs e)
        {

            if(_PhoneNumBox.Text == "xxx-xxx-xxxx")
            {
                _PhoneNumBox.Text = "";
                _PhoneNumBox.ForeColor = Color.Black;
            }


        }

        private void _PhoneNumBox_Leave(object sender, EventArgs e)
        {

            if (_PhoneNumBox.Text == "")
            {
                _PhoneNumBox.Text = "xxx-xxx-xxxx";
                _PhoneNumBox.ForeColor = Color.LightGray;
            }

        }
    }
}
