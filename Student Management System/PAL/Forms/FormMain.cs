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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start(); 
        }

        public string Username, Role;

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
            labelRole.Text = Role;
            if (Role == "Преподаватель")
            {
                buttonTeachers.Hide();
                buttonStudent.Hide();
                buttonUser.Hide();
                buttonDepartmen.Hide();
                buttonDekan.Hide();
                buttonAccounting.Hide();
                userControlReport1.tabPage4.Parent = null;
                userControlReport1.tabPage5.Parent = null;
                userControlReport1.tabPage6.Parent = null;
                userControlReport1.tabPage7.Parent = null;
                userControlReport1.tabPage8.Parent = null;
                userControlReport1.tabPage9.Parent = null;
            //    userControlReport1.tabPage10.Parent = null;
             //   userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Декан")
            {
                buttonTeachers.Hide();
                buttonUser.Hide();
                buttonStudent.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                userControlReport1.tabPage9.Parent = null;
           //     userControlReport1.tabPage10.Parent = null;
            //    userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Админ")
            {
                buttonTeachers.Hide();
                buttonDepartmen.Hide();
                buttonStudent.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                userControlReport1.tabPage9.Parent = null;
              //  userControlReport1.tabPage10.Parent = null;
               // userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Зав.Кафедры")
            {
                buttonTeachers.Hide();
                buttonUser.Hide();
                buttonStudent.Hide();
                buttonVedom.Hide();
                buttonDekan.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                userControlReport1.tabPage9.Parent = null;
            //    userControlReport1.tabPage10.Parent = null;
             //   userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Бухгалтер")
            {
                buttonTeachers.Hide();
                buttonUser.Hide();
                buttonStudent.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonDekan.Hide();
                buttonAttendance.Hide();
                buttonTimeTable.Hide();
                userControlReport1.tabPage1.Parent = null;
                userControlReport1.tabPage2.Parent = null;
                userControlReport1.tabPage3.Parent = null;
                userControlReport1.tabPage4.Parent = null;
                userControlReport1.tabPage5.Parent = null;
                userControlReport1.tabPage9.Parent = null;
             //   userControlReport1.tabPage10.Parent = null;
              //  userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Спец.Отдела-кадров")
            {
                buttonUser.Hide();
                buttonStudent.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonDekan.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                buttonTimeTable.Hide();
                userControlReport1.tabPage1.Parent = null;
                userControlReport1.tabPage2.Parent = null;
                userControlReport1.tabPage3.Parent = null;
                userControlReport1.tabPage4.Parent = null;
                userControlReport1.tabPage5.Parent = null;
                userControlReport1.tabPage6.Parent = null;
                userControlReport1.tabPage8.Parent = null;
                userControlReport1.tabPage9.Parent = null;
             //   userControlReport1.tabPage10.Parent = null;
             //   userControlReport1.tabPage11.Parent = null;
            }
            else if (Role == "Спец.Учебного-отдела")
            {
                buttonTeachers.Hide();
                buttonUser.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonDekan.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                buttonTimeTable.Hide();
                userControlAddStudent1.tabPage2.Parent = null;
                userControlAddStudent1.comboBoxTour.Text = "0";
                userControlAddStudent1.comboBoxTour.Visible = false;
                userControlReport1.tabPage7.Parent = null;
                userControlReport1.tabPage4.Parent = null;
                userControlReport1.tabPage8.Parent = null;
                userControlReport1.tabPage9.Parent = null;
             //   userControlReport1.tabPage10.Parent = null;
              //  userControlReport1.tabPage11.Parent = null;

            }
            else if (Role == "Спец.Приемной-комиссии")
            {
                buttonStudent.Text = "Абитуриент";
                buttonTeachers.Hide();
                buttonUser.Hide();
                buttonVedom.Hide();
                buttonDepartmen.Hide();
                buttonDekan.Hide();
                buttonAttendance.Hide();
                buttonAccounting.Hide();
                buttonTimeTable.Hide();
              //  buttonReports.Hide();
                userControlAddStudent1.cmbStatus.Visible = false;
                userControlAddStudent1.tabPage1.Text = "Абитуриент";
                userControlAddStudent1.tabPage3.Parent = null;
                userControlAddStudent1.btnRemoveStud.Visible = false;
                userControlAddStudent1.btnTypeSearch.Visible = false;

                userControlReport1.tabPage1.Parent = null;
                userControlReport1.tabPage2.Parent = null;
                userControlReport1.tabPage3.Parent = null;
                userControlReport1.tabPage4.Parent = null;
                userControlReport1.tabPage5.Parent = null;
              //  userControlReport1.tabPage6.Parent = null;
                userControlReport1.tabPage7.Parent = null;
                userControlReport1.tabPage8.Parent = null;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlDashboard1.Visible = true;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonTeachers);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = true;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonUser);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonStudent);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = true;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonVedom_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonVedom);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlVedom1.Visible = true;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlReport1.Visible = false;
            
        }

        private void buttonDepartmen_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDepartmen);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = true;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonDekan_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDekan);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = true;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonAccounting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAccounting);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = true;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = true;
            userControlTimeTable1.Visible = false;
            userControlVedom1.Visible = false;
        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonTimeTable);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlReport1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = true;
            userControlVedom1.Visible = false;
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReports);
            userControlDashboard1.Visible = false;
            userControlAddTeachers1.Visible = false;
            userControlAddUser1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlVedom1.Visible = false;
            userControlDepartmen1.Visible = false;
            userControlDekan1.Visible = false;
            userControlAccounting1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlTimeTable1.Visible = false;
            userControlReport1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из программы?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Application.Exit();
            }
        }
    }
}
