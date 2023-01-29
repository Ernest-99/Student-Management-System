using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Student_Management_System.PAL.Class;
using Student_Management_System.PAL.Forms;

namespace Student_Management_System.PAL.User_Control
{
    public partial class UserControlAddStudent : UserControl
    {       
        public UserControlAddStudent()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            this.dataGridView.Columns["Column3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }
        DB db = new DB();
        string sql, identification;
      //  public string Role ;

        private void UserControlAddStudent_Load(object sender, EventArgs e)
        {
            FillcomboAY();
            FillcomboFaculty();
            listBox.Items.Clear();
            comboBoxTypeSearch.Visible = false;      
            comboBoxDepart.SelectedIndex = -1;
            comboBoxSpeciality.SelectedIndex = -1;
            textBoxIMGLoc.Text = "studentIcon.png";
            defaultImageLoading();
        }

        private void FillcomboFaculty()
        {
            sql = "SELECT * FROM Faculty_Table";
            db.fiil_CBO(sql, comboBoxFaculty);
            comboBoxFaculty.SelectedIndex = -1;
        }

        private void FillcomboAY()
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
        }

        private void defaultImageLoading()
        {
            pictureBox.Image = Image.FromFile("studentIcon.png");
        }

        private void clear()
        {
            defaultImageLoading();
            textBoxIMGLoc.Text = "studentIcon.png";

            textBoxName.Text = "";
            maskedTextBoxDOB.Text = "";
            textBoxIDPas.Text = "";
            textBoxPerNumPas.Text = "";
            comboBoxCitizenship.Text = "";
            comboBoxNationality.Text = "";
            textBoxAddrPas.Text = "";
            cmbRegion.SelectedIndex = -1;
            textBoxIssuedBy.Text = "";
            maskedTextBoxValidPas.Text = "";
            comboBoxGender.SelectedIndex = -1;

            textBoxCertificate.Text = "";
            comboBoxFaculty.SelectedIndex = -1;
            comboBoxDepart.SelectedIndex = -1;
            comboBoxSpeciality.SelectedIndex = -1;
            txtSchool.Text = "";
            cmbLanEduc.SelectedIndex = -1;
            comboBoxTour.SelectedIndex = -1;
            comboBoxFormEbu.SelectedIndex = -1;
            comboBoxAfter.SelectedIndex = -1;
            maskedTextBoxPhone.Text = "";
            textBoxAddress.Text = "";

            textBoxFullNameF.Text = "";
            maskedTextBoxPhoneF.Text = "";
            textBoxFullNameM.Text = "";
            maskedTextBoxPhoneM.Text = "";
        }

        private void loadDataInListBox()
        {
            sql = "SELECT full_name FROM Student_Table WHERE id_year = '" + cmbAcademYear1.SelectedValue + "'";
            db.Load_ListBox(sql, listBox);       
        }

        private void cmbAcademYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            loadDataInListBox();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFaculty.SelectedItem != null)
            {
                string query = "SELECT * FROM Departmen_Table WHERE id_faculty = @id_faculty";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_faculty", comboBoxFaculty.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                comboBoxDepart.DataSource = dt;
                comboBoxDepart.DisplayMember = "name";
                comboBoxDepart.ValueMember = "id_departmen";
                db.closeConnection();
            }           
        }

        private void comboBoxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDepart.SelectedItem != null)
            {
                string query = "SELECT * FROM Speciality_Table WHERE id_departmen = @id_departmen";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_departmen", comboBoxDepart.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                comboBoxSpeciality.DataSource = dt;
                comboBoxSpeciality.DisplayMember = "speciality";
                comboBoxSpeciality.ValueMember = "id_speciality";
                db.closeConnection();
            }  
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string picPath = opf.FileName.ToString();
                textBoxIMGLoc.Text = picPath;
                pictureBox.ImageLocation = picPath;
            }
        }

        private void btnTypeSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeSearch.Visible)
                comboBoxTypeSearch.Visible = false;
            else
                comboBoxTypeSearch.Visible = true;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIMGLoc.Text = "";
            db.openConnection();
            if (listBox.SelectedItem != null)
            {
                string query = "SELECT * FROM Student_Table WHERE full_name = '" + listBox.SelectedItem.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                //Загрузка картики
                try
                {
                    byte[] img = (byte[])dt.Rows[0][32];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                catch (Exception)
                {
                    pictureBox.Image = null;
                }
                //
                foreach (DataRow dr in dt.Rows)
                {
                    identification = dr["certificate"].ToString();

                    textBoxName.Text = dr["full_name"].ToString();
                    maskedTextBoxDOB.Text = dr["dob"].ToString();
                    textBoxIDPas.Text = dr["passport_id"].ToString();
                    textBoxPerNumPas.Text = dr["personal_num"].ToString();
                    comboBoxCitizenship.Text = dr["citizenship"].ToString();
                    comboBoxNationality.Text = dr["nationality"].ToString();
                    textBoxAddrPas.Text = dr["address_pas"].ToString();
                    textBoxIssuedBy.Text = dr["issued_by"].ToString();
                    maskedTextBoxValidPas.Text = dr["validity"].ToString();
                    comboBoxGender.Text = dr["gender"].ToString();
                    textBoxAddrPas.Text = dr["address_pas"].ToString();
                    cmbRegion.Text = dr["region"].ToString();

                    textBoxCertificate.Text = dr["certificate"].ToString();
                    comboBoxFaculty.SelectedValue = dr["id_faculty"].ToString();
                    comboBoxDepart.SelectedValue = dr["id_departmen"].ToString();
                    comboBoxSpeciality.SelectedValue = dr["id_speciality"].ToString();
                    txtSchool.Text = dr["school"].ToString();
                    comboBoxTour.Text = dr["number_tour"].ToString();
                    cmbLanEduc.Text = dr["lan_education"].ToString();
                    comboBoxFormEbu.Text = dr["form_education"].ToString();
                    comboBoxAfter.Text = dr["after"].ToString();
                    maskedTextBoxPhone.Text = dr["phone"].ToString();
                    textBoxAddress.Text = dr["address"].ToString();

                    cmbStatus.Text = dr["status"].ToString();
                    textBoxFullNameF.Text = dr["full_name_f"].ToString();
                    maskedTextBoxPhoneF.Text = dr["phone_num_f"].ToString();
                    textBoxFullNameM.Text = dr["full_name_m"].ToString();
                    maskedTextBoxPhoneM.Text = dr["phone_num_m"].ToString();
                }
            }
            
            db.closeConnection();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name FROM Student_Table WHERE CONCAT(`full_name`) like'%" + textBoxSearch.Text + "%'";
            listBox.Items.Clear();
            db.Load_ListBox(sql, listBox);
        }

        private void btnSaveStud_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `Student_Table` (`full_name`, `dob`,`passport_id`," +
                "`personal_num`, `citizenship`, `nationality`, `issued_by`, `validity`, `gender`, `address_pas`,`region`, " +
                "`certificate`, `id_faculty`, `id_departmen`,`id_speciality`,`id_year`, `school`, `number_tour`,`lan_education`,`status`,`form_education`," +
                "`after`,`phone`,`address`,`full_name_f`,`phone_num_f`,`full_name_m`,`phone_num_m`,`stud_photo`, `accept_date`) " +
                "VALUES (@full_name, @dob, @passport_id ,@personal_num ,@citizenship ,@nationality ,@issued_by , @validity , " +
                "@gender , @address_pas, @region,@certificate ,@id_faculty ,@id_departmen ,@id_speciality ,@id_year,@school ,@number_tour,@lan_education ,@status," +
                "@form_education ,@after ,@phone ,@address ,@full_name_f ,@phone_num_f ,@full_name_m ,@phone_num_m ,@stud_photo, @accept_date)", db.getConnection());

            if (textBoxName.Text == "" || maskedTextBoxDOB.Text == "" || textBoxIDPas.Text == ""
                || comboBoxCitizenship.Text == "" || comboBoxNationality.Text == ""
                || textBoxIssuedBy.Text == "" || comboBoxGender.Text == "" || textBoxAddrPas.Text == ""
                || textBoxCertificate.Text == "" || comboBoxFaculty.SelectedIndex == -1 || comboBoxDepart.SelectedIndex ==-1 
                || comboBoxSpeciality.SelectedIndex == -1 || cmbAcademYear1.SelectedIndex == -1 || txtSchool.Text == "" 
                || comboBoxTour.SelectedIndex == -1 || comboBoxFormEbu.SelectedIndex == -1
                || comboBoxAfter.SelectedIndex == -1 || maskedTextBoxPhone.Text == "" || textBoxAddress.Text == "")
                MessageBox.Show("Заполните все поля!");
            else
            {
                if (textBoxCertificate.Text == identification)
                    MessageBox.Show("Этот абитуриент уже был добавлен в БД");
                else
                {
                    byte[] img = null;
                    FileStream fileStream = new FileStream(this.textBoxIMGLoc.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    img = binaryReader.ReadBytes((int)fileStream.Length);

                    cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = textBoxName.Text;
                    cmd.Parameters.Add("@dob", MySqlDbType.VarChar).Value = maskedTextBoxDOB.Text;
                    cmd.Parameters.Add("@passport_id", MySqlDbType.VarChar).Value = textBoxIDPas.Text;
                    cmd.Parameters.Add("@personal_num", MySqlDbType.VarChar).Value = textBoxPerNumPas.Text;
                    cmd.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = comboBoxCitizenship.Text;
                    cmd.Parameters.Add("@nationality", MySqlDbType.VarChar).Value = comboBoxNationality.Text;
                    cmd.Parameters.Add("@issued_by", MySqlDbType.VarChar).Value = textBoxIssuedBy.Text;
                    cmd.Parameters.Add("@validity", MySqlDbType.VarChar).Value = maskedTextBoxValidPas.Text;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = comboBoxGender.Text;
                    cmd.Parameters.Add("@address_pas", MySqlDbType.VarChar).Value = textBoxAddrPas.Text;
                    cmd.Parameters.Add("@region", MySqlDbType.VarChar).Value = cmbRegion.Text;
                    cmd.Parameters.Add("@certificate", MySqlDbType.VarChar).Value = textBoxCertificate.Text;
                    cmd.Parameters.Add("@id_faculty", MySqlDbType.Int32).Value = comboBoxFaculty.SelectedValue;
                    cmd.Parameters.Add("@id_departmen", MySqlDbType.Int32).Value = comboBoxDepart.SelectedValue;
                    cmd.Parameters.Add("@id_speciality", MySqlDbType.Int32).Value = comboBoxSpeciality.SelectedValue;
                    cmd.Parameters.Add("@id_year", MySqlDbType.Int32).Value = cmbAcademYear1.SelectedValue;
                    cmd.Parameters.Add("@school", MySqlDbType.VarChar).Value = txtSchool.Text;                 
                    cmd.Parameters.Add("@number_tour", MySqlDbType.Int32).Value = comboBoxTour.Text;
                    cmd.Parameters.Add("@lan_education", MySqlDbType.VarChar).Value = cmbLanEduc.Text;
                    if (comboBoxTour.Text == "0")
                        cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Прошел";
                    else
                        cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = "";
                    cmd.Parameters.Add("@form_education", MySqlDbType.VarChar).Value = comboBoxFormEbu.Text;
                    cmd.Parameters.Add("@after", MySqlDbType.Int32).Value = comboBoxAfter.Text;
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = maskedTextBoxPhone.Text;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBoxAddress.Text;
                    cmd.Parameters.Add("@full_name_f", MySqlDbType.VarChar).Value = textBoxFullNameF.Text;
                    cmd.Parameters.Add("@phone_num_f", MySqlDbType.VarChar).Value = maskedTextBoxPhoneF.Text;
                    cmd.Parameters.Add("@full_name_m", MySqlDbType.VarChar).Value = textBoxFullNameM.Text;
                    cmd.Parameters.Add("@phone_num_m", MySqlDbType.VarChar).Value = maskedTextBoxPhoneM.Text;
                    cmd.Parameters.Add("@stud_photo", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@accept_date", MySqlDbType.VarChar).Value = dateTimePicker.Text;
                    db.openConnection();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Абитуриент добавлен");
                    }
                    else
                        MessageBox.Show("Абитуриент не добавлен");

                    db.closeConnection();
                    listBox.Items.Clear();
                    loadDataInListBox();
                }
            }
        }

        private void btnNewStud_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpStud_Click(object sender, EventArgs e)
        {
            if (textBoxCertificate.Text == "")
            {
                MessageBox.Show("Выберите студента из списка!");
            }
            else
            {
                string query = "UPDATE Student_Table SET  `full_name`='" + textBoxName.Text
                  + "', `dob`='" + maskedTextBoxDOB.Text
                  + "', `passport_id`='" + textBoxIDPas.Text
                  + "', `personal_num`='" + textBoxPerNumPas.Text
                  + "', `citizenship`='" + comboBoxCitizenship.Text
                  + "', `nationality`='" + comboBoxNationality.Text
                  + "', `issued_by`='" + textBoxIssuedBy.Text
                  + "', `validity`='" + maskedTextBoxValidPas.Text
                  + "', `gender`='" + comboBoxGender.Text
                  + "', `address_pas`='" + textBoxAddrPas.Text
                  + "', `region`='" + cmbRegion.Text
                  + "', `id_faculty`='" + comboBoxFaculty.SelectedValue
                  + "', `id_departmen`='" + comboBoxDepart.SelectedValue
                  + "', `id_speciality`='" + comboBoxSpeciality.SelectedValue
                  + "', `school`='" + txtSchool.Text
                  + "', `number_tour`='" + comboBoxTour.Text
                  + "', `lan_education`='" + cmbLanEduc.Text
                  + "', `form_education`='" + comboBoxFormEbu.Text
                  + "', `after`='" + comboBoxAfter.Text
                  + "', `phone`='" + maskedTextBoxPhone.Text
                  + "', `address`='" + textBoxAddress.Text
                  + "', `full_name_f`='" + textBoxFullNameF.Text
                  + "', `phone_num_f`='" + maskedTextBoxPhoneF.Text
                  + "', `full_name_m`='" + textBoxFullNameM.Text
                  + "', `phone_num_m`='" + maskedTextBoxPhoneM.Text
                  + "' where `certificate`='" + identification + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                db.openConnection();
                try
                {
                    byte[] img = null;
                    FileStream fileStream = new FileStream(this.textBoxIMGLoc.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    img = binaryReader.ReadBytes((int)fileStream.Length);
                    MySqlCommand command = new MySqlCommand("UPDATE Student_Table SET stud_photo = @stud_photo where `certificate`='" + identification + "'", db.getConnection());
                    command.Parameters.Add("@stud_photo", MySqlDbType.Blob).Value = img;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные обновлены!");
                else
                    MessageBox.Show("Данные не обновлены!");

                db.closeConnection();
                listBox.Items.Clear();
                loadDataInListBox();
            }
        }

        private void btnRemoveStud_Click(object sender, EventArgs e)
        {

        }

        private void Mask(MaskedTextBox textBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                textBox.Select(0, 0);
            });
        }
        private void maskedTextBoxValidPas_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxValidPas.Text == "")
                maskedTextBoxValidPas.Text = "";
            if (!maskedTextBoxValidPas.MaskCompleted)
                Mask(maskedTextBoxValidPas);
        }
        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "")
                maskedTextBoxDOB.Text = "";
            if (!maskedTextBoxDOB.MaskCompleted)
                Mask(maskedTextBoxDOB);
        }
        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone.Text == "")
                maskedTextBoxPhone.Text = "";
            if (!maskedTextBoxPhone.MaskCompleted)
                Mask(maskedTextBoxPhone);
        }
        private void maskedTextBoxPhoneF_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPhoneF.Text == "")
                maskedTextBoxPhoneF.Text = "";
            if (!maskedTextBoxPhoneF.MaskCompleted)
                Mask(maskedTextBoxPhoneF);
        }

        private void maskedTextBoxPhoneM_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPhoneM.Text == "")
                maskedTextBoxPhoneM.Text = "";
            if (!maskedTextBoxPhoneM.MaskCompleted)
                Mask(maskedTextBoxPhoneM);
        }


        // Вторая вкладка "Проходные баллы"

        private void loadDataInDTG()
        {
            sql = "SELECT full_name, points,status FROM Student_Table WHERE number_tour = '" + comboBoxNumTour.Text + "' AND id_year = '"+cmbAcademYear2.SelectedValue+ "' ORDER BY `Student_Table`.`points` DESC";
            db.Load_DTG(sql, dataGridView);
        }

        private void cmbAcademYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumTour.SelectedIndex = -1;
        }

        private void SetStatusPassed()
        {
            MySqlCommand command = new MySqlCommand("UPDATE Student_Table SET status = @status WHERE points >='" + textBoxPoints.Text + "'AND id_year = '" + cmbAcademYear2.SelectedValue + "' AND number_tour = '" + comboBoxNumTour.Text + "'", db.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Прошел";
            db.openConnection();
            command.ExecuteNonQuery();                      
            db.closeConnection();                                       
        }
        private void SetStatusDidntPass()
        {          
            MySqlCommand command = new MySqlCommand("UPDATE Student_Table SET status = @status WHERE points < '" + textBoxPoints.Text + "' AND id_year = '"+cmbAcademYear2.SelectedValue+"' AND number_tour = '"+comboBoxNumTour.Text+"'", db.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Не прошел";
            db.openConnection();
            command.ExecuteNonQuery();                       
            db.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.openConnection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string update = "UPDATE Student_Table SET points='" + dataGridView.Rows[i].Cells["Column4"].Value.ToString() + "' WHERE full_name = '" + dataGridView.Rows[i].Cells["Column3"].Value.ToString() + "'";
                try
                {
                    MySqlCommand command = new MySqlCommand(update, db.getConnection());
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Баллы сохранены!");
            db.closeConnection();
            SetStatusPassed();
            SetStatusDidntPass();
            loadDataInDTG();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["Column2"].Value = (e.RowIndex + 1).ToString();
        }

        private void comboBoxNumTour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadDataInDTG();
        }
       
        private void textBoxPoints_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        // Третья Вкладка "Распределения по группам" 

        int studID;

        private void loadDataInListBoxDistribution()
        {
            sql = "SELECT full_name FROM Student_Table WHERE id_group = 0 AND id_year = '" + cmbAcademYear3.SelectedValue + "' AND status = 'Прошел'";
            db.Load_ListBox(sql, listBoxAddInGroup);
        }

        private void loadDataInListBoxChangeGroup()
        {
            sql = "SELECT full_name FROM Student_Table WHERE id_course = '" + cmbCourse.Text + "'  AND status = 'Обучается'";
            db.Load_ListBox(sql, listBoxStudTransferGroup);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            FillcomboBoxFacluty();
            //listBoxStud.Items.Clear();
            //loadDataInListBoxDistribution();
        }

        private void FillcomboBoxFacluty()
        {
            sql = "SELECT * FROM Faculty_Table ";
            db.fiil_CBO(sql, cmbFalucty);
            cmbFalucty.SelectedIndex = -1;
        }

        private void cmbAcademYear3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAddInGroup.Items.Clear();
            loadDataInListBoxDistribution();
            listBoxStudTransferGroup.Items.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbFalucty.SelectedIndex = -1;
            cmbDepartmen.SelectedIndex = -1;
            cmbSpeciality.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
            txtStud.Text = "";
        }

        private void cmbFalucty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFalucty.SelectedItem != null)
                {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Departmen_Table WHERE id_faculty = @id_faculty", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_faculty", cmbFalucty.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbDepartmen.DataSource = dt;
                cmbDepartmen.DisplayMember = "name";
                cmbDepartmen.ValueMember = "id_departmen";
                db.closeConnection();
            }
        }

        private void cmbDepartmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartmen.SelectedItem != null)
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
                db.closeConnection();
            }
        }

        private void cmbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeciality.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Group_Table WHERE id_speciality = @id_speciality", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_speciality", cmbSpeciality.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbGroup.DataSource = dt;
                cmbGroup.DisplayMember = "group";
                cmbGroup.ValueMember = "id_group";
                db.closeConnection();
            }
        }

        private void listBoxStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();
            if (listBoxAddInGroup.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Student_Table WHERE full_name = '" + listBoxAddInGroup.SelectedItem.ToString() + "'", db.getConnection());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    studID = Convert.ToInt32(dr["id_student"].ToString());
                    txtStud.Text = dr["full_name"].ToString();
                    cmbFalucty.SelectedValue = dr["id_faculty"].ToString();
                    cmbDepartmen.SelectedValue = dr["id_departmen"].ToString();
                    cmbSpeciality.SelectedValue = dr["id_speciality"].ToString();
                    cmbGroup.SelectedValue = dr["id_group"].ToString();
                }
            }
            db.closeConnection();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudTransferGroup.Items.Clear();
            loadDataInListBoxChangeGroup();
        }

        private void listBoxStudChangeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();
            if (listBoxStudTransferGroup.SelectedItem != null)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Student_Table WHERE full_name = '" + listBoxStudTransferGroup.SelectedItem.ToString() + "'", db.getConnection());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    studID = Convert.ToInt32(dr["id_student"].ToString());
                    txtStud.Text = dr["full_name"].ToString();
                    cmbFalucty.SelectedValue = dr["id_faculty"].ToString();
                    cmbDepartmen.SelectedValue = dr["id_departmen"].ToString();
                    cmbSpeciality.SelectedValue = dr["id_speciality"].ToString();
                    cmbGroup.SelectedValue = dr["id_group"].ToString();
                }
            }
            db.closeConnection();
        }

        private void btnChangeGroup_Click(object sender, EventArgs e)
        {
            if (txtStud.Text == "")
            {
                MessageBox.Show("Выберите студента из списка!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Student_Table SET `id_faculty` = '" + cmbFalucty.SelectedValue + "', `id_departmen`='" + cmbDepartmen.SelectedValue + "', id_speciality = '"+cmbSpeciality.SelectedValue+"', id_group = '"+cmbGroup.SelectedValue+"' where `id_student`='" + studID + "'", db.getConnection());
                db.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Студент переведен в группу!");
                else
                    MessageBox.Show("Студент не переведен в группу!");
                db.closeConnection();

                listBoxStudTransferGroup.Items.Clear();
                loadDataInListBoxChangeGroup();
            }
        }

        private void txtSearchAddGroup_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name FROM Student_Table WHERE CONCAT(`full_name`) like'%" + txtSearchAddInGroup.Text + "%' AND status = 'Прошел'";
            listBoxAddInGroup.Items.Clear();
            db.Load_ListBox(sql, listBoxAddInGroup);
        }

        private void txtSearchTransferGroup_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name FROM Student_Table WHERE CONCAT(`full_name`) like'%" + txtSearchTransferGroup.Text + "%' AND id_course = '"+cmbCourse.Text+"'";
            listBoxStudTransferGroup.Items.Clear();
            db.Load_ListBox(sql, listBoxStudTransferGroup);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Group_Table WHERE id_group = @id_group", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_group", cmbGroup.SelectedValue.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "id_course";
                cmbCourse.ValueMember = "id_course";
                db.closeConnection();
            }
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            if (txtStud.Text == "")
            {
                MessageBox.Show("Выберите студента из списка!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Student_Table SET `id_course` = '"+cmbCourse.Text+"', `id_group`='" + cmbGroup.SelectedValue + "', status = 'Обучается' where `id_student`='" + studID + "'", db.getConnection());
                db.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Студент добавлен в группу!");
                else
                    MessageBox.Show("Студент не добавлен в группу!");
                db.closeConnection();

                listBoxAddInGroup.Items.Clear();
                loadDataInListBoxDistribution();

                listBoxStudTransferGroup.Items.Clear();
                loadDataInListBoxChangeGroup();
            }
        }

    }
}
