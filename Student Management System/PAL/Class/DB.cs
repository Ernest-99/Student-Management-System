using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSystem;
using MySql.Data.MySqlClient;

namespace Student_Management_System.PAL.Class
{
    class DB
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sms");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt;
        int result;

        usableFunction funct = new usableFunction();

        public static int IDteacher;

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                da.Dispose();
            }
        }
        public void Load_DTG(string sql, DataGridView dtg)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;

                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                conn.Close();
            }
        }
        public void Load_ListBox(string sql, ListBox list)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(sql, getConnection());                                                                                                              
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Items.Add(reader[0]).ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
    }
}
