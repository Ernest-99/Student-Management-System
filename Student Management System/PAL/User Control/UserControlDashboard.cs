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
    public partial class UserControlDashboard : UserControl
    {
       

        public UserControlDashboard()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void chart()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT d.name, COUNT(s.full_name) AS student_count FROM Student_Table s LEFT JOIN Departmen_Table d ON s.id_departmen = d.id_departmen GROUP BY name ORDER BY d.name", db.getConnection());
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.chart1.Series["Series1"].Points.AddXY(reader.GetString("name"), reader.GetInt32("student_count"));
 
            }
            db.closeConnection();
        }

        private void countStud()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `Student_Table` WHERE status = 'Обучается'", db.getConnection());
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM `Student_Table` WHERE id_course = 1 AND status = 'Обучается'", db.getConnection()); 
            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM `Student_Table` WHERE id_course = 2 AND  status = 'Обучается'", db.getConnection());
            MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT(*) FROM `Student_Table` WHERE id_course = 3 AND  status = 'Обучается'", db.getConnection());
            MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT(*) FROM `Student_Table` WHERE id_course = 4 AND  status = 'Обучается'", db.getConnection());

            db.openConnection();
            label8.Text = cmd.ExecuteScalar().ToString();
            label2.Text = cmd1.ExecuteScalar().ToString();
            label13.Text = cmd2.ExecuteScalar().ToString();
            label17.Text = cmd3.ExecuteScalar().ToString();
            label15.Text = cmd4.ExecuteScalar().ToString();
            db.closeConnection();
        }

        private void countTeachers()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `Teachers_Table`", db.getConnection());
            db.openConnection();
            label9.Text = cmd.ExecuteScalar().ToString();
            db.closeConnection();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"]["PieLabelStyle"] = "Disabled";
            chart();
            countStud();
            countTeachers();
        }

        private void UserControlDashboard_Enter(object sender, EventArgs e)
        {
            countStud();
            countTeachers();
        }
    }
}
