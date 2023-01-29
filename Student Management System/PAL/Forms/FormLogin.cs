using MySql.Data.MySqlClient;
using Student_Management_System.PAL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.PAL.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
        }
        DB db = new DB();
        string fio,role;
        int teacherID;
        private void LoginUser()
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `User_Table` WHERE `login`=@uL AND `password`= @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                //Загрузка ФИО пользователя и Роли
                db.openConnection();
                string loadFio = "SELECT full_name,role FROM `User_Table` WHERE password = '" + passUser + "' AND login = '" + loginUser + "'";
                MySqlCommand cmd = new MySqlCommand(loadFio, db.getConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    fio = dr["full_name"].ToString();
                    role = dr["role"].ToString();
                }
                db.closeConnection();
                formMain.Username = this.fio;
                formMain.Role = this.role;
                //
                formMain.Show();
            }
            else
                pictureBoxError.Show();
                labelError.Show();
        }
        private void LoginTeacher()
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Teachers_Table` WHERE `login`=@uL AND `password`= @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormMain formMain = new FormMain();              
                //Загрузка ФИО пользователя и Роли
                db.openConnection();
                string loadFio = "SELECT id_teacher,full_name,role FROM `Teachers_Table` WHERE password = '" + passUser + "' AND login = '" + loginUser + "'";
                MySqlCommand cmd = new MySqlCommand(loadFio, db.getConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    teacherID = dr.GetInt32("id_teacher");
                    fio = dr["full_name"].ToString();
                    role = dr["role"].ToString();
                }
                db.closeConnection();
                formMain.Username = this.fio;
                formMain.Role = this.role;
                DB.IDteacher = teacherID;
                //
                formMain.Show();
            }
            else
                pictureBoxError.Show();
                labelError.Show();
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBoxUserType.Text == "")
                MessageBox.Show("Выберите тип учетной записи!");
            else if (comboBoxUserType.Text == "Администрация")
                LoginUser();
            else if (comboBoxUserType.Text == "Преподаватель")
                LoginTeacher();
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }
    }
}
