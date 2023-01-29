using MySql.Data.MySqlClient;
using Student_Management_System.PAL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.PAL.Forms
{
    public partial class FormForgotPassword : Form
    {        
        public FormForgotPassword()
        {
            InitializeComponent();
        }
        DB db = new DB();
        string userName, password;
        private void VerifyUser()
        {
            string query = "SELECT login, password FROM User_Table WHERE personal_num = '" + textBoxPerNumPasport.Text.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            MySqlDataReader dataReader;
            try
            {
                db.openConnection();
                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    string nameUser = dataReader.GetString("login");
                    userName = nameUser;
                    string passUser = dataReader.GetString("password");
                    password = passUser;
                    MessageBox.Show("Ваше имя пользователя: " + userName + " и пароль: " + password + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    pictureBoxError.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("erorr!");
            }
            db.closeConnection();
            
        }
        private void VerifyTeacher()
        {
            string query = "SELECT login, password FROM Teachers_Table WHERE personal_num = '" + textBoxPerNumPasport.Text.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            MySqlDataReader dataReader;
            try
            {
                db.openConnection();
                dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    string nameUser = dataReader.GetString("login");
                    userName = nameUser;
                    string passUser = dataReader.GetString("password");
                    password = passUser;
                    MessageBox.Show("Ваше имя пользователя: " + userName + " и пароль: " + password + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    pictureBoxError.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("erorr!");
            }
            db.closeConnection();
           
        }
        private void textBoxPerNumPasport_Enter(object sender, EventArgs e)
        {
            if (textBoxPerNumPasport.Text == "Ваш персональный номер паспорта")
            {
                textBoxPerNumPasport.Text = "";
                textBoxPerNumPasport.ForeColor = Color.Black;
            }
        }
        private void textBoxPerNumPasport_Leave(object sender, EventArgs e)
        {
            if (textBoxPerNumPasport.Text == "")
            {
                textBoxPerNumPasport.Text = "Ваш персональный номер паспорта";
                textBoxPerNumPasport.ForeColor = Color.Gray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (textBoxPerNumPasport.Text == "" || comboBoxUserType.Text == "")
                MessageBox.Show("Выберите тип учетной записи и введите ваш персональный номер паспорта");
            else if (comboBoxUserType.Text == "Администрация")
                VerifyUser();
            else if (comboBoxUserType.Text == "Преподаватель")
                VerifyTeacher();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
    }
}
