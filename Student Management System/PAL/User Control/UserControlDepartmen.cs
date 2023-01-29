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
using Student_Management_System.PAL.Class;

namespace Student_Management_System.PAL.User_Control
{
    public partial class UserControlDepartmen : UserControl
    {
        public UserControlDepartmen()
        {
            
            InitializeComponent();
         
        }

        DB db = new DB();
        string sql;
        
        private void UserControlSettings_Load(object sender, EventArgs e)
        {
           // loadDataInListBoxDiscipline();
            loadDataInListBoxTeacher();
            fillcomboBoxAcademYear();
          //  fillcomboBoxCourse();
        }

        public void Load_cmbSemestr(ComboBox cmbCourse, ComboBox cmbSemestr)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Semestr_Table WHERE id_course = @id_course", db.getConnection());
            db.openConnection();
            command.Parameters.AddWithValue("@id_course", cmbCourse.Text.ToString());
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbSemestr.DataSource = dt;
            cmbSemestr.DisplayMember = "semestr";
            cmbSemestr.ValueMember = "id_semestr";
            cmbSemestr.SelectedIndex = -1;
            db.closeConnection();
        }

        private void loadDataInListBoxDiscipline(ComboBox cmbCorse, ListBox listBox)
        {
            sql = "SELECT discipline FROM Disciplines_Table WHERE id_course = '"+ cmbCorse.Text+"'";
            db.Load_ListBox(sql, listBox);
        }
        private void loadDataInListBoxTeacher()
        {
            sql = "SELECT full_name FROM Teachers_Table WHERE status = 'Работает'";
            db.Load_ListBox(sql, listBoxTeacher);
        }
        private void loadDataInListBoxStudent()
        {
            sql = "SELECT full_name FROM Student_Table WHERE id_group = '"+cmbGroup3.SelectedValue+"'";
            db.Load_ListBox(sql, listBoxTeacher);
        }

        private void fillcomboBoxAcademYear()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM AcademicYear_Table", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbAcademYear1.DataSource = dt;
            cmbAcademYear1.DisplayMember = "year";
            cmbAcademYear1.ValueMember = "id_year";
            cmbAcademYear1.SelectedIndex = -1;
            cmbAcademYear2.DataSource = dt;
            cmbAcademYear2.DisplayMember = "year";
            cmbAcademYear2.ValueMember = "id_year";
            cmbAcademYear2.SelectedIndex = -1;
            cmbAcademYear3.DataSource = dt;
            cmbAcademYear3.DisplayMember = "year";
            cmbAcademYear3.ValueMember = "id_year";
            cmbAcademYear3.SelectedIndex = -1;
            cmbAcademYear4.DataSource = dt;
            cmbAcademYear4.DisplayMember = "year";
            cmbAcademYear4.ValueMember = "id_year";
            cmbAcademYear4.SelectedIndex = -1;
            db.closeConnection();
        }
       
        private void clear()
        {
            textBoxDiscipline.Text = "";
            textBoxLecHours.Text = "";
            textBoxLabHours.Text = "";
            comboBoxFormCon.SelectedIndex = -1;
            txtDiscipline.Text = "";
            txtTeacher.Text = "";
            cmbGroup1.SelectedIndex = -1;
            cmbSemestr1.SelectedIndex = -1;
            cmbAcademYear1.SelectedIndex = -1;
        }
        private void loadDataInComboBoxGroup(ComboBox cmbCourse, ComboBox cmbGroup)
        {
            sql = "SELECT  `id_group`,`group` FROM Group_Table WHERE id_course = '" + cmbCourse.Text + "'";
            db.fiil_CBO(sql, cmbGroup);
            cmbGroup.SelectedIndex = -1;
        }

        // Первая вкладка (Дисциплины, распределение)

        int disciplineID, teacherID;

        private void cmbCourse1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse1.SelectedItem != null)
            {
                Load_cmbSemestr(cmbCourse1, cmbSemestr1);
                listBoxDiscipline.Items.Clear();
                loadDataInListBoxDiscipline(cmbCourse1, listBoxDiscipline);
                loadDataInComboBoxGroup(cmbCourse1 , cmbGroup1);
                listBoxTeacher.Items.Clear();
                loadDataInListBoxTeacher();
            }
            clear();
        }

        private void listBoxDicsipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiscipline.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Disciplines_Table WHERE discipline = '" + listBoxDiscipline.SelectedItem.ToString() + "'", db.getConnection());
                MySqlDataReader dataReader;
                try
                {
                    db.openConnection();
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        disciplineID = dataReader.GetInt32("id_discipline");
                        txtDiscipline.Text = dataReader.GetString("discipline");
                        textBoxDiscipline.Text = dataReader.GetString("discipline");
                        textBoxLecHours.Text = dataReader.GetString("lec_hours");
                        textBoxLabHours.Text = dataReader.GetString("lab_hours");
                        comboBoxFormCon.Text = dataReader.GetString("form_control");
                        cmbCourse1.Text = dataReader.GetString("id_course");
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("erorr!");
                }
            }
        }

        private void listBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeacher.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Teachers_Table WHERE full_name = '" + listBoxTeacher.SelectedItem.ToString() + "'", db.getConnection());
                MySqlDataReader dataReader;
                try
                {
                    db.openConnection();
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        teacherID = dataReader.GetInt32("id_teacher");
                        txtTeacher.Text = dataReader.GetString("full_name");
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("erorr!");
                }
            }
        }


        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            if(textBoxDiscipline.Text == "" || textBoxLecHours.Text == "" || textBoxLabHours.Text == ""
                || comboBoxFormCon.Text == "" || cmbCourse1.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                sql = "INSERT INTO `Disciplines_Table` (`discipline`, `lec_hours`, `lab_hours`," +
                "form_control, id_course) VALUES ('" + textBoxDiscipline.Text + "', '" + textBoxLecHours.Text + "'," +
                "'" + textBoxLabHours.Text + "', '" + comboBoxFormCon.Text + "', '"+ cmbCourse1.Text + "')";
                db.Execute_CUD(sql, "error to execute query", "Дисциплина добавлена!");
                clear();
                listBoxDiscipline.Items.Clear();
                loadDataInListBoxDiscipline(cmbCourse1, listBoxDiscipline);
            }
            
        }

        private void btnUpdateDiscipline_Click(object sender, EventArgs e)
        {
            if (textBoxDiscipline.Text == "")
            {
                MessageBox.Show("Выберите дисциплину из списка!");
            }
            else
            {
                string query = "UPDATE Disciplines_Table SET  `discipline`='" + textBoxDiscipline.Text
                  + "', `lec_hours`='" + textBoxLecHours.Text
                  + "', `lab_hours`='" + textBoxLabHours.Text
                  + "', `form_control`='" + comboBoxFormCon.Text
                  + "', `id_course`='" + cmbCourse1.Text
                  + "' where `id_discipline`='" + disciplineID + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                db.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные обновлены!");
                else
                    MessageBox.Show("Данные не обновлены!");

                db.closeConnection();
            }
            listBoxDiscipline.Items.Clear();
            loadDataInListBoxDiscipline(cmbCourse1, listBoxDiscipline);

        }

        private void btnStudyLoad_Click(object sender, EventArgs e)
        {
            if(txtDiscipline.Text == "" || txtTeacher.Text == "" || cmbGroup1.Text == "" || cmbSemestr1.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все необходимые поля!");
            }
            else
            {
                sql = "INSERT INTO `StudyLoad_Table` (`id_teacher`, `id_discipline`, `id_group`, `id_year`,`id_course`, `id_semestr`) " +
                "VALUES ('" + teacherID + "', '" + disciplineID + "','" + cmbGroup1.SelectedValue + "', '"+ cmbAcademYear1.SelectedValue+"', '"+cmbCourse1.Text+"', '" + cmbSemestr1.Text + "')";
                db.Execute_CUD(sql, "error to execute query", "Дисциплина распределена!");

                //      MySqlCommand cmd = new MySqlCommand("INSERT INTO `Report_Table`(`id_group`,`id_disciplines`, `id_student`, `id_semestr`) SELECT t2.id_group, id_discipline, id_student , id_semestr FROM Semestr_Table t1, Group_Table t2, Disciplines_Table t3, Student_Table t4 WHERE t1.id_semestr = '" + comboBoxSemestr.Text + "' t2.id_group = '" + groupID + "' AND t4.id_group = '" + groupID + "' AND t3.id_discipline = '" + disciplineID + "'", db.getConnection());
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `Report_Table`( `id_semestr`,`id_group`,`id_disciplines`, `id_student`, `id_year`,`id_course`) SELECT t1.id_semestr, t2.id_group, id_discipline, id_student, t5.id_year, t6.id_course FROM Semestr_Table t1, Group_Table t2, Disciplines_Table t3, Student_Table t4, AcademicYear_Table t5, Course_Table t6 WHERE t1.id_semestr ='" + cmbSemestr1.Text + "'  AND t2.id_group = '" + cmbGroup1.SelectedValue + "' AND t4.id_group = '" + cmbGroup1.SelectedValue + "' AND t3.id_discipline = '" + disciplineID + "' AND t5.id_year = '"+cmbAcademYear1.SelectedValue+"' AND t6.id_course = '"+cmbCourse1.Text+"'", db.getConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            
        }

        // Вторая вкладка (учебна нагрузка)

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if(dataGridViewSL.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                int idStudyLoad = Convert.ToInt32(dataGridViewSL.Rows[e.RowIndex].Cells["id_sl"].FormattedValue.ToString());
                int idGroup = Convert.ToInt32(dataGridViewSL.Rows[e.RowIndex].Cells["ColumnGroupID"].FormattedValue.ToString());
                int idSemestr = Convert.ToInt32(dataGridViewSL.Rows[e.RowIndex].Cells["ColumnSemestr"].FormattedValue.ToString());
                int idDiscipline = Convert.ToInt32(dataGridViewSL.Rows[e.RowIndex].Cells["ColumnDisciplineID"].FormattedValue.ToString());

                if (MessageBox.Show("Вы точно хотите удалить нагрузку?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `StudyLoad_Table` WHERE id_sl = '"+ idStudyLoad + "' ", db.getConnection());                   
                    db.openConnection();
                    cmd.ExecuteNonQuery();

                    MySqlCommand command = new MySqlCommand("DELETE FROM Report_Table WHERE id_group = '"+ idGroup + "' AND id_semestr = '"+idSemestr+ "' AND id_disciplines ='"+ idDiscipline + "'", db.getConnection());

                    command.ExecuteNonQuery();
                    db.closeConnection();
                    studyLoad();
                }
            }      
        }

        private void dataGridViewSL_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewSL.Rows[e.RowIndex].Cells["ColumnNum"].Value = (e.RowIndex + 1).ToString();
        }

        private void studyLoad()
        {
            sql = "SELECT t4.id_sl,t3.id_group, t2.id_discipline, t1.full_name, t2.discipline, t3.group, t4.id_semestr FROM Teachers_Table t1, Disciplines_Table t2, Group_Table t3, StudyLoad_Table t4 WHERE t1.id_teacher = t4.id_teacher AND t2.id_discipline= t4.id_discipline AND t3.id_group = t4.id_group AND t4.id_year = '" + cmbAcademYear2.SelectedValue + "' AND t1.id_teacher = '" + cmbTeacherStudyLoad.SelectedValue + "' ";
            db.Load_DTG(sql, dataGridViewSL);
        }

        private void cmbTeacherStudyLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            studyLoad();
        }

        private void cmbAcademYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id_teacher`,`full_name` FROM Teachers_Table WHERE status = 'Работает'", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbTeacherStudyLoad.DataSource = dt;
            cmbTeacherStudyLoad.DisplayMember = "full_name";
            cmbTeacherStudyLoad.ValueMember = "id_teacher";
            cmbTeacherStudyLoad.SelectedIndex = -1;
            cmbTeacherStudyLoad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTeacherStudyLoad.AutoCompleteSource = AutoCompleteSource.ListItems;
            db.closeConnection();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            studyLoad();
        }

        // Третья вкладка (учебна нагрузка)

        int disciplineID3 , studentID3;

        private void cmbCourse3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCourse3.SelectedItem != null)
            {
                Load_cmbSemestr(cmbCourse3, cmbSemestr3);
                loadDataInComboBoxGroup(cmbCourse3, cmbGroup3);
                listBoxDisciplineV.Items.Clear();
                loadDataInListBoxDiscipline(cmbCourse3, listBoxDisciplineV);

            }
        }

        private void cmbGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudV.Items.Clear();
            sql = "SELECT full_name FROM Student_Table WHERE id_group = '" + cmbGroup3.SelectedValue + "'";
            db.Load_ListBox(sql, listBoxStudV);         
        }

        private void listBoxDisciplineV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDisciplineV.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Disciplines_Table WHERE discipline = '" + listBoxDisciplineV.SelectedItem.ToString() + "'", db.getConnection());
                MySqlDataReader dataReader;
                try
                {
                    db.openConnection();
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        disciplineID3 = dataReader.GetInt32("id_discipline");
                        txtDiscipline3.Text = dataReader.GetString("discipline");
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("erorr!");
                }
            }
        }

        private void listBoxStudV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudV.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Student_Table WHERE full_name = '" + listBoxStudV.SelectedItem.ToString() + "'", db.getConnection());
                MySqlDataReader dataReader;
                try
                {
                    db.openConnection();
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        studentID3 = dataReader.GetInt32("id_student");
                        txtStud3.Text = dataReader.GetString("full_name");
                    }
                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("erorr!");
                }
            }
        }

        private void btnAddStudReport_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `Report_Table`(`id_group`, `id_disciplines`, `id_student`, `id_semestr`, `id_year`) VALUES ('"+cmbGroup3.SelectedValue+"', '"+disciplineID3+"', '"+studentID3+"', '"+cmbSemestr3.SelectedValue+"', '"+cmbAcademYear3.SelectedValue+"')", db.getConnection());
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Студент добавлен в ведомость!");
            else
                MessageBox.Show("Студент не добавлен в ведомость!");
            db.closeConnection();
        }

        // Четвертая вкладка (ведомости)

        private void LoadcmbDiscipline()
        {
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT t2.id_discipline, discipline FROM Disciplines_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_discipline = t2.id_discipline WHERE id_semestr = '" + cmbSemestr4.SelectedValue + "' AND t1.id_course = '" + cmbCourse4.Text + "' AND id_year = '"+cmbAcademYear4.SelectedValue+"'", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbDiscipline4.DataSource = dt;
            cmbDiscipline4.DisplayMember = "discipline";
            cmbDiscipline4.ValueMember = "id_discipline";
            cmbDiscipline4.SelectedIndex = -1;
            db.closeConnection();
        }

        private void LoadcmbGroup()
        {
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT t2.`id_group`, `group` FROM Group_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_group = t2.id_group WHERE id_semestr = '" + cmbSemestr4.SelectedValue + "'AND t2.id_year = '" + cmbAcademYear4.SelectedValue + "' AND t2.id_discipline = '" + cmbDiscipline4.SelectedValue + "'", db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbGroup4.DataSource = dt;
            cmbGroup4.DisplayMember = "group";
            cmbGroup4.ValueMember = "id_group";
            cmbGroup4.SelectedIndex = -1;
            db.closeConnection();
        }

        private void cmbCourseV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse4.SelectedItem != null)
            {
                Load_cmbSemestr(cmbCourse4,cmbSemestr4);
            }
            LoadInDTG();
        }

        private void cmbSemestrV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcmbDiscipline();
            
        }

        private void comboBoxDisciplineV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup4.SelectedIndex = -1;
            LoadcmbGroup();
            LoadInDTG();
        }

        private void cmbAcademYearV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse4.SelectedIndex = -1;
            cmbSemestr4.SelectedIndex = -1;
            cmbDiscipline4.SelectedIndex = -1;
            cmbGroup4.SelectedIndex = -1;
            LoadInDTG();
        }

        private void dataGridViewReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewReport.Rows[e.RowIndex].Cells["column1"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAcademYear4.SelectedIndex == -1 || cmbCourse4.SelectedIndex == -1 ||
                cmbSemestr4.SelectedIndex == -1 || cmbDiscipline4.SelectedIndex == -1 || cmbGroup4.SelectedIndex == -1)
                MessageBox.Show("Заполните все параметры!");
            else
            {
                db.openConnection();
                for (int i = 0; i < dataGridViewReport.Rows.Count; i++)
                {
                    string update = "UPDATE Report_Table SET `module1`='" + dataGridViewReport.Rows[i].Cells["Column3"].Value.ToString() + "',`common_module`='" + dataGridViewReport.Rows[i].Cells["Column3"].Value.ToString() + "',`module2`='" + dataGridViewReport.Rows[i].Cells["Column4"].Value.ToString() + "',`common_module`= `common_module` +'" + dataGridViewReport.Rows[i].Cells["Column4"].Value.ToString() + "'  WHERE `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline4.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr4.SelectedValue + "'";
                    try
                    {
                        MySqlCommand command = new MySqlCommand(update, db.getConnection());
                        command.ExecuteNonQuery();
                        MySqlCommand cmd = new MySqlCommand("UPDATE Report_Table SET grade = '2' WHERE common_module < 99 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline4.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr4.SelectedValue + "'", db.getConnection());
                        cmd.ExecuteNonQuery();
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE Report_Table SET grade = '3' WHERE common_module >= 100 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline4.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr4.SelectedValue + "'", db.getConnection());
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE Report_Table SET grade = '4' WHERE common_module >= 150 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline4.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr4.SelectedValue + "'", db.getConnection());
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd3 = new MySqlCommand("UPDATE Report_Table SET grade = '5' WHERE common_module >= 180 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline4.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr4.SelectedValue + "'", db.getConnection());
                        cmd3.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                db.closeConnection();
                MessageBox.Show("Баллы сохранены!");
                LoadInDTG();
            }
        }

        private void LoadInDTG()
        {
            sql = "SELECT t1.id_student,full_name,module1, module2, common_module, grade FROM Student_Table t1 INNER JOIN Report_Table t2 ON t1.id_student=t2.id_student WHERE t2.id_group = '" + cmbGroup4.SelectedValue + "' AND id_disciplines = '" + cmbDiscipline4.SelectedValue + "' AND t2.id_semestr = '" + cmbSemestr4.Text + "' AND t2.id_year = '" + cmbAcademYear4.SelectedValue + "'";
            db.Load_DTG(sql, dataGridViewReport);

            this.dataGridViewReport.Sort(this.dataGridViewReport.Columns["Column2"], ListSortDirection.Ascending);
        }

        

        private void comboBoxGroupV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInDTG();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            
            //sql = "SELECT t1.id_student,full_name,1_module, 2_module FROM Student_Table t1 INNER JOIN Report_Table t2 ON t1.id_student=t2.id_student WHERE t2.id_group = '" + comboBoxGroup.SelectedValue + "' AND id_disciplines = '" + comboBoxDiscipline.SelectedValue + "' AND t2.semestr = '" + comboBoxSemestr.Text + "'";
            //db.Load_DTG(sql, dataGridViewReport);
        }
    }
}
