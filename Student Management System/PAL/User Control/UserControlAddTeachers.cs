using MySql.Data.MySqlClient;
using Student_Management_System.PAL.Class;
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

namespace Student_Management_System.PAL.User_Control
{
    public partial class UserControlAddTeachers : UserControl
    {

        public UserControlAddTeachers()
        {
            InitializeComponent();
        }

        DB db = new DB();
        string sql, identification;
        public string Role;
        MemoryStream ms = new MemoryStream();

        private void btnTypeSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeSearch.Visible)
                comboBoxTypeSearch.Visible = false;
            else
                comboBoxTypeSearch.Visible = true;
        }

        private void loadDataInListBox()
        {
            sql = "SELECT full_name FROM Teachers_Table WHERE status = '" + "Работает" + "'";
            db.Load_ListBox(sql, listBoxEmployees);
        }
        private void loadDataInListBoxRemoveTeacher()
        {
            sql = "SELECT full_name FROM Teachers_Table WHERE status = '" + "Сокращен" + "'";
            db.Load_ListBox(sql, listBoxEmployees);
        }

        private void defaultImageLoading()
        {
            pictureBox.Image = Image.FromFile("teacherIcon.png");
        }

        private void removeTecher()
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE Teachers_Table SET `status`= 'Сокращен', `remove_date` = '" + DateTimePicker.Text + "' where `personal_num`= '" + identification + "'", db.getConnection());
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Преподавтель сокращен!");
            else
                MessageBox.Show("Преподавтель не сокращен!");

            db.closeConnection();
        }
        private void restoreTecher()
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE Teachers_Table SET `status`= 'Работает', `accept_date` = '" + DateTimePicker.Text + "' where `personal_num`= '" + identification + "'", db.getConnection());
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Преподавтель востановлен!");
            else
                MessageBox.Show("Преподавтель не востановлен!");

            db.closeConnection();
        }

        private void clear()
        {
            defaultImageLoading();
            textBoxIMGLoc.Text = "teacherIcon.png";

            textBoxName.Text = "";
            maskedTextBoxDOB.Text = "";
            textBoxIDPas.Text = "";
            textBoxPerNumPas.Text = "";
            comboBoxCitizenship.Text = "";
            comboBoxNationality.Text = "";
            textBoxAddrPas.Text = "";
            textBoxIssuedBy.Text = "";
            maskedTextBoxValidPas.Text = "";
            comboBoxGender.SelectedIndex = -1;

            comboBoxEducLvl.SelectedIndex = -1;
            textBoxDipNum.Text = "";
            textBoxInstitute.Text = "";
            maskedTextBoxEduFinDate.Text = "";
            textBoxSpeciality.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxEmail.Text = "";

            textBoxAddress.Text = "";
            maskedTextBoxPhone.Text = "";
            textBoxLogin.Text = "";
            textBoxPass.Text = "";
        }

        private void UserControlAddClass_Load(object sender, EventArgs e)
        {
            loadDataInListBox();
            comboBoxTypeSearch.Visible = false;
            defaultImageLoading();
            textBoxIMGLoc.Text = "teacherIcon.png";
        }

        private void UserControlAddTeachers_Enter(object sender, EventArgs e)
        {
            defaultImageLoading();
        }

        private void btnUpTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxPerNumPas.Text == "")
            {
                MessageBox.Show("Выберите преподавателя из списка!");
            }
            else
            {
                string query = "UPDATE Teachers_Table SET  `full_name`='" + textBoxName.Text
                  + "', `dob`='" + maskedTextBoxDOB.Text
                  + "', `passport_id`='" + textBoxIDPas.Text
                  + "', `citizenship`='" + comboBoxCitizenship.Text
                  + "', `nationality`='" + comboBoxNationality.Text
                  + "', `issued_by`='" + textBoxIssuedBy.Text
                  + "', `validity`='" + maskedTextBoxValidPas.Text
                  + "', `gender`='" + comboBoxGender.Text
                  + "', `address_pas`='" + textBoxAddrPas.Text
                  + "', `education_lvl`='" + comboBoxEducLvl.Text
                  + "', `diplom_num`='" + textBoxDipNum.Text
                  + "', `institute`='" + textBoxInstitute.Text
                  + "', `date_finish`='" + maskedTextBoxEduFinDate.Text
                  + "', `speciality`='" + textBoxSpeciality.Text
                  + "', `phone_num`='" + maskedTextBoxPhone.Text
                  + "', `email`='" + textBoxEmail.Text
                  + "', `address`='" + textBoxAddress.Text
                  + "', `login`='" + textBoxLogin.Text
                  + "', `password`='" + textBoxPass.Text
                  + "' where `personal_num`='" + identification + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                db.openConnection();
                try
                {
                    byte[] img = null;
                    FileStream fileStream = new FileStream(this.textBoxIMGLoc.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    img = binaryReader.ReadBytes((int)fileStream.Length);
                    MySqlCommand command = new MySqlCommand("UPDATE Teachers_Table SET teacher_photo = @teacher_photo where `personal_num`='" + identification + "'", db.getConnection());
                    command.Parameters.Add("@teacher_photo", MySqlDbType.Blob).Value = img;
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
                listBoxEmployees.Items.Clear();
                loadDataInListBox();
            }
        }

        private void textBoxSearchByWorking()
        {
            sql = "SELECT full_name FROM Teachers_Table WHERE CONCAT(`full_name`) like'%" + textBoxSearch.Text + "%' AND status = '" + "Работает" + "'";
            listBoxEmployees.Items.Clear();
            db.Load_ListBox(sql, listBoxEmployees);
        }

        private void textBoxSearchByRemove()
        {
            sql = "SELECT full_name FROM Teachers_Table WHERE CONCAT(`full_name`) like'%" + textBoxSearch.Text + "%' AND status = '" + "Сокращен" + "'";
            listBoxEmployees.Items.Clear();
            db.Load_ListBox(sql, listBoxEmployees);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeSearch.Text == "Работает")          
                textBoxSearchByWorking();          
            else if (comboBoxTypeSearch.Text == "Сокращен")           
                textBoxSearchByRemove();        
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIMGLoc.Text = "";
            db.openConnection();
            if(listBoxEmployees.SelectedItem != null)
            {
                string query = "SELECT * FROM Teachers_Table WHERE full_name = '" + listBoxEmployees.SelectedItem.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                //Загрузка картики
                try
                {
                    byte[] img = (byte[])dt.Rows[0][22];
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
                    identification = dr["personal_num"].ToString();

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

                    comboBoxEducLvl.Text = dr["education_lvl"].ToString();
                    textBoxDipNum.Text = dr["diplom_num"].ToString();
                    textBoxInstitute.Text = dr["institute"].ToString();
                    maskedTextBoxEduFinDate.Text = dr["date_finish"].ToString();
                    textBoxSpeciality.Text = dr["speciality"].ToString();

                    maskedTextBoxPhone.Text = dr["phone_num"].ToString();
                    textBoxEmail.Text = dr["email"].ToString();
                    textBoxAddress.Text = dr["address"].ToString();

                    textBoxLogin.Text = dr["login"].ToString();
                    textBoxPass.Text = dr["password"].ToString();

                    DateTimePicker.Text = dr["accept_date"].ToString();
                }
            }

            
            db.closeConnection();
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            clear();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (textBoxPerNumPas.Text == "")
            {
                MessageBox.Show("Выберите преподавателя из списка!");
            }
            else if (comboBoxTypeSearch.Text == "Работает")
            {
                removeTecher();
                comboBoxTypeSeatch();
            }
                
            else if (comboBoxTypeSearch.Text == "Сокращен")
            {
                restoreTecher();
                comboBoxTypeSeatch();
            }
                       
        }

        private void comboBoxTypeSeatch()
        {
            if (comboBoxTypeSearch.Text == "Работает")
            {
                listBoxEmployees.Items.Clear();
                loadDataInListBox();
                btnRemove.Text = "Сократить";
                btnRemove.FillColor = Color.FromArgb(237, 73, 73);
            }

            else if (comboBoxTypeSearch.Text == "Сокращен")
            {
                listBoxEmployees.Items.Clear();
                loadDataInListBoxRemoveTeacher();
                btnRemove.Text = "Востановить";
                btnRemove.FillColor = Color.DodgerBlue;
            }
        }

        private void comboBoxTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypeSeatch();
        }

        private void btnSaveTeach_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `Teachers_Table` (`full_name`, `dob`,`passport_id`," +
                "`personal_num`, `citizenship`, `nationality`, `issued_by`, `validity`, `gender`, `address_pas`, " +
                "`education_lvl`, `diplom_num`, `institute`,`date_finish`, `speciality`, `phone_num`,`email`," +
                "`address`,`role`,`login`,`password`,`teacher_photo`, `status`, `accept_date`) " +
                "VALUES (@full_name, @dob, @passport_id ,@personal_num ,@citizenship ,@nationality ,@issued_by , @validity , " +
                "@gender , @address_pas ,@education_lvl ,@diplom_num ,@institute ,@date_finish ,@speciality ,@phone_num ," +
                "@email ,@address ,@role ,@login ,@password ,@teacher_photo, @status, @accept_date )", db.getConnection());

            if (pictureBox.Image == null || textBoxName.Text == "" || maskedTextBoxDOB.Text == "" || textBoxIDPas.Text == ""
                || comboBoxCitizenship.Text == "" || comboBoxNationality.Text == "" || textBoxIssuedBy.Text == "" 
                || comboBoxGender.Text == "" || textBoxAddrPas.Text == "" || maskedTextBoxPhone.Text == "" 
                || textBoxAddress.Text == "" || comboBoxEducLvl.SelectedIndex == -1 || textBoxDipNum.Text == "" 
                || textBoxInstitute.Text == "" || maskedTextBoxEduFinDate.Text == "" || textBoxSpeciality.Text == ""
                || maskedTextBoxPhone.Text == "" || textBoxAddress.Text == "" || textBoxLogin.Text == "" || textBoxPass.Text == "")
                MessageBox.Show("Заполните все поля и установите фотографию!");
            else
            {
                if (textBoxPerNumPas.Text == identification)
                    MessageBox.Show("Этот преподаватель уже был добавлен в БД");
                else
                {
                    byte[] img = null;
                    FileStream fileStream = new FileStream(this.textBoxIMGLoc.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    img = binaryReader.ReadBytes((int)fileStream.Length);

                    cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = textBoxName.Text;
                    cmd.Parameters.Add("@dob", MySqlDbType.VarChar).Value = maskedTextBoxDOB.Text;
                    cmd.Parameters.Add("@passport_id", MySqlDbType.VarChar).Value = textBoxIDPas.Text;
                    cmd.Parameters.Add("@personal_num", MySqlDbType.Int32).Value = textBoxPerNumPas.Text;
                    cmd.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = comboBoxCitizenship.Text;
                    cmd.Parameters.Add("@nationality", MySqlDbType.VarChar).Value = comboBoxNationality.Text;
                    cmd.Parameters.Add("@issued_by", MySqlDbType.VarChar).Value = textBoxIssuedBy.Text;
                    cmd.Parameters.Add("@validity", MySqlDbType.VarChar).Value = maskedTextBoxValidPas.Text;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = comboBoxGender.Text;
                    cmd.Parameters.Add("@address_pas", MySqlDbType.VarChar).Value = textBoxAddrPas.Text;
                    cmd.Parameters.Add("@education_lvl", MySqlDbType.VarChar).Value = comboBoxEducLvl.Text;
                    cmd.Parameters.Add("@diplom_num", MySqlDbType.VarChar).Value = textBoxDipNum.Text;
                    cmd.Parameters.Add("@institute", MySqlDbType.VarChar).Value = textBoxInstitute.Text;
                    cmd.Parameters.Add("@date_finish", MySqlDbType.VarChar).Value = maskedTextBoxEduFinDate.Text;
                    cmd.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = textBoxSpeciality.Text;
                    cmd.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = maskedTextBoxPhone.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBoxAddress.Text;
                    cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Преподаватель";
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPass.Text;
                    cmd.Parameters.Add("@teacher_photo", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Работает";
                    cmd.Parameters.Add("@accept_date", MySqlDbType.VarChar).Value = DateTimePicker.Text;
                    db.openConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Преподаватель добавлен в БД!");
                    else
                        MessageBox.Show("Преподаватель не добавлен в БД!");
                    db.closeConnection();
                }
                listBoxEmployees.Items.Clear();
                loadDataInListBox();
            }
        }

        private void Mask(MaskedTextBox textBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                textBox.Select(0, 0);
            });
        }

        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "")
                maskedTextBoxDOB.Text = "";
            if (!maskedTextBoxDOB.MaskCompleted)
                Mask(maskedTextBoxDOB);
        }

        private void maskedTextBoxEduFinDate_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxEduFinDate.Text == "")
                maskedTextBoxEduFinDate.Text = "";
            if (!maskedTextBoxEduFinDate.MaskCompleted)
                Mask(maskedTextBoxEduFinDate);
        }

        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone.Text == "")
                maskedTextBoxPhone.Text = "";
            if (!maskedTextBoxPhone.MaskCompleted)
                Mask(maskedTextBoxPhone);
        }

        private void maskedTextBoxValidPas_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxValidPas.Text == "")
                maskedTextBoxValidPas.Text = "";
            if (!maskedTextBoxValidPas.MaskCompleted)
                Mask(maskedTextBoxValidPas);
        }

        
    }
}
