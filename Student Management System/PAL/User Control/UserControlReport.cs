using Microsoft.Reporting.WinForms;
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
    public partial class UserControlReport : UserControl
    {
        public UserControlReport()
        {
            InitializeComponent();
          //  this.reportViewer1.RefreshReport();
        }
        string sql;
        DB db = new DB();

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
            cmbAcademYear2.DataSource = dt;
            cmbAcademYear2.DisplayMember = "year";
            cmbAcademYear2.ValueMember = "id_year";
            cmbAcademYear2.SelectedIndex = -1;
            cmbAcademYear4.DataSource = dt;
            cmbAcademYear4.DisplayMember = "year";
            cmbAcademYear4.ValueMember = "id_year";
            cmbAcademYear4.SelectedIndex = -1;
            cmbAcademYear6.DataSource = dt;
            cmbAcademYear6.DisplayMember = "year";
            cmbAcademYear6.ValueMember = "id_year";
            cmbAcademYear6.SelectedIndex = -1;
            cmbAcademYear9.DataSource = dt;
            cmbAcademYear9.DisplayMember = "year";
            cmbAcademYear9.ValueMember = "id_year";
            cmbAcademYear9.SelectedIndex = -1;
          /* cmbAcademYear10.DataSource = dt;
            cmbAcademYear10.DisplayMember = "year";
            cmbAcademYear10.ValueMember = "id_year";
            cmbAcademYear10.SelectedIndex = -1;
            cmbAcademYear11.DataSource = dt;
            cmbAcademYear11.DisplayMember = "year";
            cmbAcademYear11.ValueMember = "id_year";
            cmbAcademYear11.SelectedIndex = -1;*/
            db.closeConnection();
        }

        private void Report(string sql)
        {      
            MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        //Первая вкладка

        private void LoadcmbDisciplines()
        {
            string query = "SELECT DISTINCT t2.id_discipline, discipline FROM Disciplines_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_discipline = t2.id_discipline WHERE id_semestr = '" + cmbSemestr.SelectedValue + "' AND t1.id_course = '" + cmbCourse.Text + "' AND id_year = '" + cmbAcademYear.SelectedValue + "'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbDiscipline.DataSource = dt;
            cmbDiscipline.DisplayMember = "discipline";
            cmbDiscipline.ValueMember = "id_discipline";
            cmbDiscipline.SelectedIndex = -1;
            db.closeConnection();
        }

        private void LoadcmbGroup()
        {
            string query = "SELECT DISTINCT t2.`id_group`, `group` FROM Group_Table t1 INNER JOIN StudyLoad_Table t2 ON t1.id_group = t2.id_group WHERE id_semestr = '" + cmbSemestr.SelectedValue + "' AND t2.id_year = '" + cmbAcademYear.SelectedValue + "'  AND t2.id_discipline = '" + cmbDiscipline.SelectedValue + "'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            MySqlDataAdapter sdr = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cmbGroup.DataSource = dt;
            cmbGroup.DisplayMember = "group";
            cmbGroup.ValueMember = "id_group";
            cmbGroup.SelectedIndex = -1;
            db.closeConnection();
        }

        private void Clear()
        {      
            cmbCourse.SelectedIndex = -1;
            cmbSemestr.SelectedIndex = -1;
            cmbDiscipline.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
        }

        private void LoadReportVedom()
        {

            sql = "SELECT Student_Table.full_name, Report_Table.module1, Report_Table.module2, Report_Table.common_module, Report_Table.grade, AcademicYear_Table.year, Semestr_Table.semestr, Group_Table.`group`,Disciplines_Table.discipline, Report_Table.id_course " +
                "FROM Student_Table INNER JOIN Report_Table ON Student_Table.id_student = Report_Table.id_student INNER JOIN AcademicYear_Table ON Report_Table.id_year = AcademicYear_Table.id_year INNER JOIN Semestr_Table ON Report_Table.id_semestr = Semestr_Table.id_semestr INNER JOIN" +
                " Disciplines_Table ON Report_Table.id_disciplines = Disciplines_Table.id_discipline INNER JOIN Group_Table ON Report_Table.id_group = Group_Table.id_group " +
                "WHERE(Report_Table.id_year = '" + cmbAcademYear.SelectedValue + "') AND(Report_Table.id_course = '" + cmbCourse.Text + "') AND(Report_Table.id_semestr ='" + cmbSemestr.SelectedValue + "') AND(Report_Table.id_disciplines = '" + cmbDiscipline.SelectedValue + "') AND(Report_Table.id_group = '" + cmbGroup.SelectedValue + "') ORDER BY Student_Table.full_name ASC";
            reportViewer1.LocalReport.ReportPath = "ReportVedom.rdlc";
            Report(sql);
        }

        private void LoadReportAttendance()
        {
            sql = "SELECT Student_Table.full_name, Attendance_Table.date_time, AcademicYear_Table.year, Course_Table.course, Semestr_Table.semestr, Disciplines_Table.discipline, Group_Table.`group` " +
                "FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.id_student = Attendance_Table.id_student INNER JOIN " +
                "AcademicYear_Table ON Attendance_Table.id_year = AcademicYear_Table.id_year INNER JOIN" +
                " Course_Table ON Attendance_Table.id_course = Course_Table.id_course INNER JOIN" +
                " Semestr_Table ON Attendance_Table.id_semestr = Semestr_Table.id_semestr INNER JOIN" +
                " Disciplines_Table ON Attendance_Table.id_discipline = Disciplines_Table.id_discipline INNER JOIN" +
                " Group_Table ON Attendance_Table.id_group = Group_Table.id_group " +
                "WHERE(Attendance_Table.id_year = '" + cmbAcademYear.SelectedValue + "') AND(Attendance_Table.id_course = '" + cmbCourse.Text + "') AND(Attendance_Table.id_semestr = '" + cmbSemestr.SelectedValue + "') AND(Attendance_Table.id_discipline = '" + cmbDiscipline.SelectedValue + "') AND (Attendance_Table.id_group = '" + cmbGroup.SelectedValue + "') ORDER BY Student_Table.full_name ASC";
            reportViewer1.LocalReport.ReportPath = "ReportAttendance.rdlc";
            Report(sql);
        }

        private void cmbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAcademYear.SelectedIndex = -1;
            Clear();
        }

        private void cmbAcademYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
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

                cmbSemestr.SelectedIndex = -1;
                cmbDiscipline.SelectedIndex = -1;
                cmbGroup.SelectedIndex = -1;
            }
        }

        private void cmbSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcmbDisciplines();
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcmbGroup();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeReport.Text == "Ведомость")
                LoadReportVedom();
            else if (cmbTypeReport.Text == "Посещаемость")
                LoadReportAttendance();
        }

        // Вторая вкладка

        private void cmbAcademYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse2.SelectedIndex = -1;
            cmbGroup2.SelectedIndex = -1;
        }

        private void cmbCourse2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT DISTINCT t2.id_group, t2.group FROM Report_Table t1 , Group_Table t2 WHERE t1.id_group = t2.id_group AND t1.id_course = '"+cmbCourse2.Text+"' AND t1.id_year = '"+cmbAcademYear2.SelectedValue+"'";
            db.fiil_CBO(sql, cmbGroup2);
            cmbGroup2.SelectedIndex = -1;

            sql = "SELECT Student_Table.full_name, SUM(Report_Table.module1 + Report_Table.module2) AS Expr1, Report_Table.id_course , AcademicYear_Table.year, Group_Table.`group`  FROM Student_Table INNER JOIN Report_Table ON Student_Table.id_student = Report_Table.id_student INNER JOIN AcademicYear_Table ON Report_Table.id_year = AcademicYear_Table.id_year INNER JOIN Group_Table ON Report_Table.id_group = Group_Table.id_group WHERE (Report_Table.id_year = '" + cmbAcademYear2.SelectedValue + "' AND Report_Table.id_course = '" + cmbCourse2.Text + "') GROUP BY Report_Table.id_student ORDER BY Expr1 DESC";
            reportViewer1.LocalReport.ReportPath = "ReportRating.rdlc";
            Report(sql);
        }

        private void cmbGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Student_Table.full_name, SUM(Report_Table.module1 + Report_Table.module2) AS Expr1, Report_Table.id_course , AcademicYear_Table.year , Group_Table.`group` FROM Student_Table INNER JOIN Report_Table ON Student_Table.id_student = Report_Table.id_student INNER JOIN AcademicYear_Table ON Report_Table.id_year = AcademicYear_Table.id_year INNER JOIN Group_Table ON Report_Table.id_group = Group_Table.id_group WHERE(Report_Table.id_year = '" + cmbAcademYear2.SelectedValue + "' AND Report_Table.id_course = '" + cmbCourse2.Text + "' AND Student_Table.id_group = '" + cmbGroup2.SelectedValue + "') GROUP BY Report_Table.id_student ORDER BY Expr1 DESC";
            reportViewer1.LocalReport.ReportPath = "ReportRating.rdlc";
            Report(sql);

        }

        //Третья вкладка

        private void LoadReportGradeDiscipline()
        {
            sql = "SELECT Student_Table.full_name, Disciplines_Table.discipline, Report_Table.grade, Group_Table.`group` ,Semestr_Table.semestr " +
                "FROM Disciplines_Table INNER JOIN Report_Table ON Disciplines_Table.id_discipline = Report_Table.id_disciplines INNER JOIN" +
                " Student_Table ON Report_Table.id_student = Student_Table.id_student INNER JOIN Group_Table ON Report_Table.id_group = Group_Table.id_group INNER JOIN Semestr_Table ON Report_Table.id_semestr = Semestr_Table.id_semestr WHERE(Report_Table.id_group = '" + cmbGroup3.SelectedValue + "')";
            reportViewer1.LocalReport.ReportPath = "ReportGradeAllGroup.rdlc";
            Report(sql);
        }

        private void FillcmbGroup()
        {
            sql = "SELECT  `id_group`,`group` FROM Group_Table WHERE id_course = '" + cmbCourse3.Text + "'";
            db.fiil_CBO(sql, cmbGroup3);
            cmbGroup3.SelectedIndex = -1;
        }

        private void cmbCourse3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillcmbGroup();
        }

        private void cmbGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportGradeDiscipline();
        }

        private void cmbFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Disciplines_Table.discipline, Report_Table.grade, Student_Table.full_name " +
                "FROM Disciplines_Table INNER JOIN Report_Table ON Disciplines_Table.id_discipline = Report_Table.id_disciplines INNER JOIN" +
                "  Student_Table ON Report_Table.id_student = Student_Table.id_student WHERE(Report_Table.id_student = '" + cmbFullName.SelectedValue + "')";
            reportViewer1.LocalReport.ReportPath = "ReportTranscript.rdlc";
            Report(sql);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            sql = "SELECT  `id_student`,`full_name` FROM Student_Table WHERE status = 'Обучается'";
            db.fiil_CBO(sql, cmbFullName);
            cmbFullName.SelectedIndex = -1;
            cmbFullName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFullName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbCourse5_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_group`,`group` FROM Group_Table WHERE id_course = '" + cmbCourse5.Text + "'";
            db.fiil_CBO(sql, cmbGroup5);
            cmbGroup5.SelectedIndex = -1;
        }

        private void cmbGroup5_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Student_Table.full_name, Student_Table.phone, Group_Table.`group` FROM Student_Table INNER JOIN" +
                " Group_Table ON Student_Table.id_group = Group_Table.id_group WHERE(Student_Table.id_group = '"+cmbGroup5.SelectedValue+"')";
            reportViewer1.LocalReport.ReportPath = "ReportContactSudents.rdlc";
            Report(sql);
        }

        private void cmbFullNameTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT        Teachers_Table.full_name, Disciplines_Table.discipline, AcademicYear_Table.year, Course_Table.course, Semestr_Table.semestr, Group_Table.`group` " +
                "FROM StudyLoad_Table INNER JOIN " +
                "Teachers_Table ON StudyLoad_Table.id_teacher = Teachers_Table.id_teacher INNER JOIN" +
                " Disciplines_Table ON StudyLoad_Table.id_discipline = Disciplines_Table.id_discipline INNER JOIN" +
                " AcademicYear_Table ON StudyLoad_Table.id_year = AcademicYear_Table.id_year INNER JOIN" +
                " Course_Table ON StudyLoad_Table.id_course = Course_Table.id_course INNER JOIN" +
                " Semestr_Table ON StudyLoad_Table.id_semestr = Semestr_Table.id_semestr INNER JOIN" +
                " Group_Table ON StudyLoad_Table.id_group = Group_Table.id_group " +
                "WHERE(Teachers_Table.id_teacher = '"+cmbFullNameTeacher.SelectedValue+"') AND(StudyLoad_Table.id_semestr = '"+cmbSemestr4.SelectedValue+"')";
            reportViewer1.LocalReport.ReportPath = "ReportStudyLoad.rdlc";
            Report(sql);
        }

        private void cmbAcademYear4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse4.SelectedIndex = -1;
            cmbFullNameTeacher.SelectedIndex = -1;
            cmbSemestr4.SelectedIndex = -1;
        }

        private void cmbCourse4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse4.SelectedItem != null)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Semestr_Table WHERE id_course = @id_course", db.getConnection());
                db.openConnection();
                command.Parameters.AddWithValue("@id_course", cmbCourse4.Text.ToString());
                MySqlDataAdapter sdr = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                cmbSemestr4.DataSource = dt;
                cmbSemestr4.DisplayMember = "semestr";
                cmbSemestr4.ValueMember = "id_semestr";
                cmbSemestr4.SelectedIndex = -1;
                db.closeConnection();
            }  
        }

        private void cmbSemestr4_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_teacher`,`full_name` FROM Teachers_Table WHERE status = 'Работает'";
            db.fiil_CBO(sql, cmbFullNameTeacher);
            cmbFullNameTeacher.SelectedIndex = -1;
            cmbFullNameTeacher.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFullNameTeacher.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbStudentCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Student_Table.full_name, Student_Table.dob, Student_Table.passport_id, Student_Table.personal_num, Student_Table.citizenship, Student_Table.nationality, Student_Table.issued_by, Student_Table.validity, " +
                "   Student_Table.gender, Student_Table.address_pas, Student_Table.phone, Student_Table.address, Student_Table.full_name_f, Student_Table.phone_num_f, Student_Table.full_name_m, " +
                "  Student_Table.phone_num_m, Student_Table.stud_photo, Student_Table.status, Faculty_Table.faculty, Departmen_Table.name, Speciality_Table.speciality, Group_Table.`group`, Student_Table.school, Student_Table.lan_education FROM Student_Table INNER JOIN" +
                "   Faculty_Table ON Student_Table.id_faculty = Faculty_Table.id_faculty INNER JOIN" +
                "   Departmen_Table ON Student_Table.id_departmen = Departmen_Table.id_departmen AND Faculty_Table.id_faculty = Departmen_Table.id_faculty INNER JOIN" +
                "  Speciality_Table ON Student_Table.id_speciality = Speciality_Table.id_speciality AND Departmen_Table.id_departmen = Speciality_Table.id_departmen INNER JOIN" +
                "     Group_Table ON Speciality_Table.id_speciality = Group_Table.id_speciality WHERE(Student_Table.id_student = '"+cmbStudentCard.SelectedValue+"')";
            reportViewer1.LocalReport.ReportPath = "ReportStudentCard.rdlc";
            Report(sql);
        }

        private void cmbAcademYear6_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_student`,`full_name` FROM Student_Table WHERE id_year = '" + cmbAcademYear6.SelectedValue + "'";
            db.fiil_CBO(sql, cmbStudentCard);
            cmbStudentCard.SelectedIndex = -1;
            cmbStudentCard.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbStudentCard.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //Седьмая вкладка

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            sql = "SELECT  `id_teacher`,`full_name` FROM Teachers_Table";
            db.fiil_CBO(sql, cmbTeacherCard);
            cmbTeacherCard.SelectedIndex = -1;
            cmbTeacherCard.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTeacherCard.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbTeacherCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name, dob, passport_id, personal_num, citizenship, nationality, issued_by, validity, gender, address_pas, education_lvl, diplom_num, institute, date_finish, speciality, " +
                "phone_num, email, address, teacher_photo, status FROM Teachers_Table WHERE(id_teacher = '" + cmbTeacherCard.SelectedValue + "')";
            reportViewer1.LocalReport.ReportPath = "ReportTeacherCard.rdlc";
            Report(sql);
        }

        //Восьмя вкладка

        private void cmbCourse8_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_group`,`group` FROM Group_Table WHERE id_course = '" + cmbCourse8.Text + "'";
            db.fiil_CBO(sql, cmbGroup8);
            cmbGroup8.SelectedIndex = -1;
        }

        private void cmbGroup8_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Group_Table.`group`, Student_Table.full_name, Accountin_Table.pay_sum, Accountin_Table.date_time, Student_Table.id_course FROM Accountin_Table INNER JOIN" +
                " Student_Table ON Accountin_Table.id_student = Student_Table.id_student INNER JOIN  Group_Table ON Accountin_Table.id_group = Group_Table.id_group " +
                "WHERE(Accountin_Table.id_group = '"+cmbGroup8.SelectedValue+"')";
            reportViewer1.LocalReport.ReportPath = "ReportAccountin.rdlc";
            Report(sql);
        }

        private void cmbNumTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT full_name, points, status, number_tour FROM Student_Table " +
                "WHERE(id_year = '"+cmbAcademYear9.SelectedValue+"') AND(number_tour = '"+cmbNumTour.Text+"') ORDER BY points DESC";
            reportViewer1.LocalReport.ReportPath = "ReportEntryExams.rdlc";
            Report(sql);
        }
        /*
        private void cmbStudentStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Student_Table.full_name, Student_Table.address, Student_Table.phone, Departmen_Table.name, Speciality_Table.speciality, Student_Table.dob, Student_Table.passport_id, Student_Table.personal_num, " +
                "Student_Table.citizenship, Student_Table.nationality, Student_Table.issued_by, Student_Table.validity, Student_Table.gender, Student_Table.address_pas, Student_Table.full_name_f, Student_Table.phone_num_f, " +
                " Student_Table.full_name_m, Student_Table.phone_num_m, Student_Table.school FROM            Student_Table INNER JOIN" +
                "  Departmen_Table ON Student_Table.id_departmen = Departmen_Table.id_departmen INNER JOIN" +
                " Speciality_Table ON Student_Table.id_speciality = Speciality_Table.id_speciality AND Departmen_Table.id_departmen = Speciality_Table.id_departmen " +
                "WHERE(Student_Table.full_name = '"+cmbStudentStatement.Text+"')";
            reportViewer1.LocalReport.ReportPath = "ReportStatement.rdlc";
            Report(sql);
        }

        private void cmbAcademYear10_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_student`,`full_name` FROM Student_Table WHERE id_year = '"+cmbAcademYear10.SelectedValue+"'";
            db.fiil_CBO(sql, cmbStudentStatement);
            cmbStudentStatement.SelectedIndex = -1;
            cmbStudentStatement.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbStudentStatement.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbAcademYear11_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  `id_student`,`full_name` FROM Student_Table WHERE id_year = '" + cmbAcademYear11.SelectedValue + "'";
            db.fiil_CBO(sql, cmbStudentReceipt);
            cmbStudentReceipt.SelectedIndex = -1;
            cmbStudentReceipt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbStudentReceipt.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbStudentReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Student_Table.full_name, Departmen_Table.name, Speciality_Table.speciality " +
                "FROM Student_Table INNER JOIN  " +
                "Departmen_Table ON Student_Table.id_departmen = Departmen_Table.id_departmen INNER JOIN" +
                "  Speciality_Table ON Student_Table.id_speciality = Speciality_Table.id_speciality AND Departmen_Table.id_departmen = Speciality_Table.id_departmen " +
                "WHERE(Student_Table.full_name = '"+cmbStudentReceipt.Text+"')";
            reportViewer1.LocalReport.ReportPath = "ReportReceipt.rdlc";
            Report(sql);
        }*/

        
    }
}
