using MySql.Data.MySqlClient;
using Student_Management_System.PAL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.PAL.User_Control
{
    public partial class UserControlVedom : UserControl
    {
        public UserControlVedom()
        {
            InitializeComponent();
            //if(DateTime.Now < dateTimePicker1.Value)
            //{
            //    dataGridViewReport.Columns["Column3"].ReadOnly = false;
            //    dataGridViewReport.Columns["Column3"].DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);
            //}
                
        }
        DB db = new DB();
        string sql;

        private void FillcomboBoxDisciplines()
        {
            sql = "SELECT DISTINCT t2.id_discipline, discipline FROM Disciplines_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_discipline = t2.id_discipline WHERE id_teacher ='" + DB.IDteacher + "' AND id_semestr = '"+cmbSemestr.Text+"' AND id_year = '"+cmbAcademYear.SelectedValue+"'";
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
            sql= "SELECT DISTINCT t2.`id_group`, `group` FROM Group_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_group = t2.id_group WHERE id_teacher = '" + DB.IDteacher+ "' AND id_semestr = '" + cmbSemestr.Text + "' AND t2.id_year = '"+cmbAcademYear.SelectedValue+"' AND t2.id_discipline = '"+cmbDiscipline.SelectedValue+"'";
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

        private void cmbSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcomboBoxDisciplines();
            cmbGroup.SelectedIndex = -1;
            LoadInDTG();
            
        }

        private void UserControlReport_Load(object sender, EventArgs e)
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

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem != null)
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
        }

        private void LoadInDTG()
        {
            sql = "SELECT t1.id_student,full_name, module1, module2, common_module, grade FROM Student_Table t1 INNER JOIN Report_Table t2 ON t1.id_student=t2.id_student WHERE t2.id_group = '" + cmbGroup.SelectedValue + "' AND id_disciplines = '" + cmbDiscipline.SelectedValue + "' AND t2.id_semestr = '" + cmbSemestr.Text + "'AND t2.id_year = '" + cmbAcademYear.SelectedValue + "' ORDER BY `t1`.`full_name` ASC";
            db.Load_DTG(sql, dataGridViewReport);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInDTG();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAcademYear.SelectedIndex == -1 || cmbCourse.SelectedIndex == -1 ||
                cmbSemestr.SelectedIndex == -1 || cmbDiscipline.SelectedIndex == -1 || cmbGroup.SelectedIndex == -1)
                MessageBox.Show("Заполните все параметры!");
            else
            {
                db.openConnection();
                for (int i = 0; i < dataGridViewReport.Rows.Count; i++)
                {
                    string update = "UPDATE Report_Table SET `module1`='" + dataGridViewReport.Rows[i].Cells["Column3"].Value.ToString() + "',`common_module`='" + dataGridViewReport.Rows[i].Cells["Column3"].Value.ToString() + "',`module2`='" + dataGridViewReport.Rows[i].Cells["Column4"].Value.ToString() + "',`common_module`= `common_module` +'" + dataGridViewReport.Rows[i].Cells["Column4"].Value.ToString() + "'  WHERE `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr.SelectedValue + "'";
                    try
                    {
                        MySqlCommand command = new MySqlCommand(update, db.getConnection());
                        command.ExecuteNonQuery();
                        MySqlCommand cmd = new MySqlCommand("UPDATE Report_Table SET grade = '2' WHERE common_module < 99 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr.SelectedValue + "'", db.getConnection());
                        cmd.ExecuteNonQuery();
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE Report_Table SET grade = '3' WHERE common_module >= 100 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr.SelectedValue + "'", db.getConnection());
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE Report_Table SET grade = '4' WHERE common_module >= 150 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr.SelectedValue + "'", db.getConnection());
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd3 = new MySqlCommand("UPDATE Report_Table SET grade = '5' WHERE common_module >= 180 AND `id_student` = '" + dataGridViewReport.Rows[i].Cells["Column0"].Value.ToString() + "' AND `id_disciplines` = '" + cmbDiscipline.SelectedValue + "' AND `id_semestr` = '" + cmbSemestr.SelectedValue + "'", db.getConnection());
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

        private void dataGridViewReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewReport.Rows[e.RowIndex].Cells["column1"].Value = (e.RowIndex + 1).ToString();
        }

        private void cmbAcademYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse.SelectedIndex = -1;
            cmbSemestr.SelectedIndex = -1;
            cmbDiscipline.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
            LoadInDTG();
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = -1;
            FillcomboBoxGroup();
            LoadInDTG();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)          
                e.Handled = true;
        }

        private void dataGridViewReport_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //ввод только цифр
            if (dataGridViewReport.CurrentCell.ColumnIndex == 3 || dataGridViewReport.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
            else
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress -= tb_KeyPress;
            }
        }

        private void dataGridViewReport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // очень плохой спопсоб установки диапозона вводимых значении в datagridview но другого не знаю
            int val = 0;
            try
            {
                val = Convert.ToInt32(dataGridViewReport[e.ColumnIndex, e.RowIndex].Value);

               // if (dataGridViewReport.CurrentCell.ColumnIndex <= 5)//возможно = не надо, хз с какого столбца ты отсчет начал
                    if ((val >= 101) || (val <= -1))
                    {
                      //  throw new InvalidOperationException("В данном столбце число должно принадлежать диапазону [-10,10]");
                        dataGridViewReport.CurrentCell.Value = 0;
                    }
            }
            catch (InvalidOperationException x)
            {
                MessageBox.Show(x.Message);
            }
            catch
            {
               // MessageBox.Show("Должно быть введено целое число");
            }
        }
    }
}
