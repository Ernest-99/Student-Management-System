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
    public partial class UserControlAccounting : UserControl
    {
        public UserControlAccounting()
        {
            InitializeComponent();
        }

        DB db = new DB();
        string sql;
        int studID, facultID, departmenID, specialityID, groupID;

        private void LoadInListBox()
        {
            sql = "SELECT full_name FROM Student_Table WHERE id_course = '" + cmbCourse.Text + "' AND status = 'Обучается'";
            db.Load_ListBox(sql, listBoxStudent);
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudent.Items.Clear();
            LoadInListBox();
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name FROM Student_Table WHERE CONCAT(`full_name`) like'%" + txtSearchStudent.Text + "%' AND id_course = '" + cmbCourse.Text + "' AND status = 'Обучается'";
            listBoxStudent.Items.Clear();
            db.Load_ListBox(sql, listBoxStudent);
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();
            if (listBoxStudent.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT t1.id_student, t1.full_name, t2.id_faculty, t2.faculty,t3.id_departmen, t3.name,t4.id_speciality, t4.speciality,t5.id_group, t5.group FROM Student_Table t1, Faculty_Table t2, Departmen_Table t3, Speciality_Table t4, Group_Table t5 WHERE t1.id_faculty= t2.id_faculty AND t1.id_departmen = t3.id_departmen AND t1.id_speciality = t4.id_speciality AND t1.id_group = t5.id_group AND t1.full_name = '" + listBoxStudent.SelectedItem.ToString() + "'", db.getConnection());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    studID = Convert.ToInt32(dr["id_student"].ToString());
                    txtStudent.Text = dr["full_name"].ToString();
                    facultID = Convert.ToInt32(dr["id_faculty"].ToString());
                    txtFaculty.Text = dr["faculty"].ToString();
                    departmenID = Convert.ToInt32(dr["id_departmen"].ToString());
                    txtDepartmen.Text = dr["name"].ToString();
                    specialityID = Convert.ToInt32(dr["id_speciality"].ToString());
                    txtSpeciality.Text = dr["speciality"].ToString();
                    groupID = Convert.ToInt32(dr["id_group"].ToString());
                    txtGroup.Text = dr["group"].ToString();
                }
            }
            db.closeConnection();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO `Accountin_Table`(`id_student`,`id_faculty`,`id_departmen`, `id_speciality`, `id_group`, `pay_sum`,`date_time`) VALUES ( @id_student,@id_faculty, @id_departmen, @id_speciality, @id_group, @pay_sum, @date_time)";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@id_student", MySqlDbType.Int32).Value = studID;
            command.Parameters.Add("@id_faculty", MySqlDbType.Int32).Value = facultID;
            command.Parameters.Add("@id_departmen", MySqlDbType.Int32).Value = departmenID;
            command.Parameters.Add("@id_speciality", MySqlDbType.Int32).Value = specialityID;
            command.Parameters.Add("@id_group", MySqlDbType.Int32).Value = groupID;
            command.Parameters.Add("@pay_sum", MySqlDbType.Int32).Value = txtPaySum.Text;
            command.Parameters.Add("@date_time", MySqlDbType.DateTime).Value = DateTime.Now;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Платеж принят!");

            txtStudent.Text = "";
            txtFaculty.Text = "";
            txtDepartmen.Text = "";
            txtSpeciality.Text = "";
            txtGroup.Text = "";
            txtPaySum.Text = "";
        }
    }
}
