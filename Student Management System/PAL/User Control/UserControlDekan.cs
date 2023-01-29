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

namespace Student_Management_System.PAL.User_Control
{
    public partial class UserControlDekan : UserControl
    {
        public UserControlDekan()
        {
            InitializeComponent();
        }
        DB db = new DB();
        string sql, idGroup;
        string facultyID, departmenID, specialityID;

        private void UserControlMainSettings_Load(object sender, EventArgs e)
        {
            fillcmbAcademYear(cmbAcademYear);
            fillcmbAcademYear(cmbAddAcademYear);
            FillcomBoFaculty();
            cmbFaculty.SelectedIndex = -1;
        }

        private void fillcmbAcademYear(ComboBox comboBox)
        {
            sql = "SELECT * FROM AcademicYear_Table";
            db.fiil_CBO(sql, comboBox);
            comboBox.SelectedIndex = -1;
        }

        private void LoadInDTG()
        {
            sql = "SELECT t1.id_group, t2.year, t1.group FROM Group_Table t1, AcademicYear_Table t2 WHERE t1.id_year = t2.id_year AND id_course = '" + cmbCourse.Text + "'";
            db.Load_DTG(sql, dgvGroup);
        }

        private void FillcomBoFaculty()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Faculty_Table", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbFaculty.DataSource = dt;
            cmbFaculty.DisplayMember = "faculty";
            cmbFaculty.ValueMember = "id_faculty";
            db.closeConnection();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Departmen_Table WHERE id_faculty = @id_faculty", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_faculty", cmbFaculty.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbDepartmen.DataSource = dt;
                cmbDepartmen.DisplayMember = "name";
                cmbDepartmen.ValueMember = "id_departmen";
                cmbDepartmen.SelectedIndex = -1;
                db.closeConnection();

                facultyID = cmbFaculty.SelectedValue.ToString();
            }
            
        }

        private void comboBoxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDepartmen.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Speciality_Table WHERE id_departmen = @id_departmen", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_departmen", cmbDepartmen.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbSpeciality.DataSource = dt;
                cmbSpeciality.DisplayMember = "speciality";
                cmbSpeciality.ValueMember = "id_speciality";
                cmbSpeciality.SelectedIndex = -1;
                db.closeConnection();

                departmenID = cmbDepartmen.SelectedValue.ToString();
            }
            
        }

        private void cmbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeciality.SelectedItem != null)
                specialityID = cmbSpeciality.SelectedValue.ToString();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInDTG();
        }

        private void dgvGroup_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvGroup.Rows[e.RowIndex].Cells["column2"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnUpFaculty_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `Faculty_Table` SET `faculty`='" + cmbFaculty.Text + "' WHERE id_faculty='" + facultyID + "'";
            db.Execute_CUD(sql, "error to execute query", "Факультет обновлен!");
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {         
            sql = "INSERT INTO `Faculty_Table` (`faculty`) VALUES ('" + cmbFaculty.Text + "')";
            db.Execute_CUD(sql, "error to execute query", "Факультет создан!");
        }

        private void btnAddDepartmen_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO `Departmen_Table` (`name`, `id_faculty`) VALUES ('" + cmbDepartmen.Text + "', '" + facultyID + "')";
            db.Execute_CUD(sql, "error to execute query", "Кафедра создана!");
        }

        private void btnUpDepartmen_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `Departmen_Table` SET `name`='" + cmbDepartmen.Text + "' WHERE id_departmen = '" + departmenID + "' ";
            db.Execute_CUD(sql, "error to execute query", "Кафедра обновлена!");
        }

        private void btnAddSpeciality_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO `Speciality_Table` (`speciality`, `id_departmen`) VALUES ('" + cmbSpeciality.Text + "', '" + departmenID + "')";
            db.Execute_CUD(sql, "error to execute query", "Специальность создана!");
        }

        private void btnUpSpeciality_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `Speciality_Table` SET `speciality`='" + cmbSpeciality.Text + "' WHERE id_speciality = '" + specialityID + "' ";
            db.Execute_CUD(sql, "error to execute query", "Специальность обновлена!");
        }

        private void btnAddAcademYear_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO `AcademicYear_Table` (`year`) VALUES ('" + cmbAddAcademYear.Text + "')";
            db.Execute_CUD(sql, "error to execute query", "Учебный год добавлен!");
        }

        private void dgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroup.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                if (MessageBox.Show("Вы точно хотите удалить группу?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MySqlCommand command = new MySqlCommand("DELETE FROM Group_Table WHERE id_group = '" + idGroup + "'", db.getConnection());
                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    LoadInDTG();
                }
            }
            else if (dgvGroup.Columns[e.ColumnIndex].HeaderText == "Перевод")
            {
                if (MessageBox.Show("Перевести группу на следующий курс?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Group_Table t1, Student_Table t2 set t1.id_course = t1.id_course + 1, t2.id_course = t2.id_course + 1 WHERE t1.id_group = '" + idGroup + "' AND t2.id_group = '"+idGroup+"'", db.getConnection());
                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    LoadInDTG();
                }
            }
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dataGridView = dgvGroup.Rows[e.RowIndex];
                idGroup = dataGridView.Cells["Column1"].Value.ToString();
                cmbAcademYear.Text = dataGridView.Cells["column3"].Value.ToString();
                textBoxGroup.Text = dataGridView.Cells["column4"].Value.ToString();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (cmbSpeciality.Text == "")
                MessageBox.Show("Укажите на какую специальность создать группу!");
            else if (cmbCourse.Text == "" || cmbAcademYear.Text == "" || textBoxGroup.Text == "")
                MessageBox.Show("Заполните все поля группы!");
            else
            {
                sql = "INSERT INTO `Group_Table` ( `id_course`, `id_speciality`, `id_year`,`group` ) VALUES ( '" + cmbCourse.Text + "','" + specialityID + "', '" + cmbAcademYear.SelectedValue + "'," + "'" + textBoxGroup.Text + "')";
                db.Execute_CUD(sql, "error to execute query", "Новая группа создана!");
            }
            LoadInDTG();

        }

        private void btnUpGroup_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `Group_Table` SET `group` = '" + textBoxGroup.Text + "' WHERE id_group = '"+idGroup+"'";
            db.Execute_CUD(sql, "error to execute query", "Группа обновлена!");
            LoadInDTG();
        }

    }
}
