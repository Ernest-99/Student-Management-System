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
    public partial class UserControlAttendance : UserControl
    {
      
        public UserControlAttendance()
        {
            InitializeComponent();
            
        }
        DB db = new DB();
        string sql;

        private void FillcomboBoxDisciplines()
        {
            sql = "SELECT DISTINCT t2.id_discipline, discipline FROM Disciplines_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_discipline = t2.id_discipline WHERE id_teacher ='" + DB.IDteacher + "' AND id_semestr = '" + cmbSemestr.Text + "' AND id_year = '" + cmbAcademYear.SelectedValue + "'";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbDiscipline.DataSource = dt;
            cmbDiscipline.DisplayMember = "discipline";
            cmbDiscipline.ValueMember = "id_discipline";
            cmbDiscipline.SelectedIndex = -1;
        }

        private void FillcomboBoxGroup()
        {
            sql = "SELECT DISTINCT t2.`id_group`, `group` FROM Group_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_group = t2.id_group WHERE id_teacher = '" + DB.IDteacher + "' AND id_semestr = '" + cmbSemestr.Text + "' AND t2.id_year = '" + cmbAcademYear.SelectedValue + "' AND t2.id_discipline = '" + cmbDiscipline.SelectedValue + "'";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbGroup.DataSource = dt;
            cmbGroup.DisplayMember = "group";
            cmbGroup.ValueMember = "id_group";
            cmbGroup.SelectedIndex = -1;
        }

        private void LoadInDGV()
        {
            // sql = "SELECT t1.id_student,full_name FROM Student_Table t1 INNER JOIN Report_Table t2 ON t1.id_student=t2.id_student WHERE t2.id_group = '" + comboBoxGroup.SelectedValue + "' AND id_disciplines = '" + comboBoxDiscipline.SelectedValue + "'";
            sql = "SELECT t1.id_student,full_name FROM Student_Table t1 INNER JOIN Report_Table t2 ON t1.id_student=t2.id_student WHERE t2.id_group = '" + cmbGroup.SelectedValue + "' AND id_disciplines = '" + cmbDiscipline.SelectedValue + "' AND t2.id_semestr = '" + cmbSemestr.Text + "'AND t2.id_year = '" + cmbAcademYear.SelectedValue + "' ORDER BY `t1`.`full_name` ASC";
            db.Load_DTG(sql, dgvClass);
        }

        private void UserControlAttendance_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM AcademicYear_Table", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbAcademYear.DataSource = dt;
            cmbAcademYear.DisplayMember = "year";
            cmbAcademYear.ValueMember = "id_year";
            cmbAcademYear.SelectedIndex = -1;
        }

        private void UserControlAttendance_Enter(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Course_Table", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbCourse.DataSource = dt;
            cmbCourse.DisplayMember = "course";
            cmbCourse.ValueMember = "id_course";
            cmbCourse.SelectedIndex = -1;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Semestr_Table WHERE id_course = @id_course", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_course", cmbCourse.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbSemestr.DataSource = dt;
                cmbSemestr.DisplayMember = "semestr";
                cmbSemestr.ValueMember = "id_semestr";
                cmbSemestr.SelectedIndex = -1;
                db.closeConnection();
            }
        }

        private void cmbSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcomboBoxDisciplines();
            cmbGroup.SelectedIndex = -1;
            LoadInDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvClass.Rows)
            {
                bool chkboxSelected = Convert.ToBoolean(dr.Cells["Column4"].Value);
                if (chkboxSelected)
                {
                    sql = "INSERT INTO `Attendance_Table`(`id_group`,`id_discipline`,`id_student`, `id_year`, `id_course`, `id_semestr`,`date_time`) VALUES (@id_group, @id_discipline,@id_student, @id_year, @id_course, @id_semestr, @date_time)";
                    MySqlCommand command = new MySqlCommand(sql, db.getConnection());
                    command.Parameters.AddWithValue("@id_student", dr.Cells["Column1"].Value);
                    command.Parameters.Add("@id_group", MySqlDbType.VarChar).Value = cmbGroup.SelectedValue;
                    command.Parameters.Add("@id_discipline", MySqlDbType.VarChar).Value = cmbDiscipline.SelectedValue;
                    command.Parameters.Add("@id_year", MySqlDbType.VarChar).Value = cmbAcademYear.SelectedValue;
                    command.Parameters.Add("@id_course", MySqlDbType.Int32).Value = cmbCourse.Text;
                    command.Parameters.Add("@id_semestr", MySqlDbType.Int32).Value = cmbSemestr.SelectedValue;
                    command.Parameters.Add("@date_time", MySqlDbType.DateTime).Value = DateTime.Now;
                    db.openConnection();
                    command.ExecuteNonQuery();                  
                    db.closeConnection();
                }
            }
            MessageBox.Show("Пропуски сохранены!");
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInDGV();
        }

        private void dgvClass_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvClass.Rows[e.RowIndex].Cells["column2"].Value = (e.RowIndex + 1).ToString();
        }

        private void cmbAcademYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse.SelectedIndex = -1;
            cmbSemestr.SelectedIndex = -1;
            cmbDiscipline.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
            LoadInDGV();
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = -1;
            FillcomboBoxGroup();
            LoadInDGV();
        }
    }
}
