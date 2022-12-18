using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _109111244_DBLogin
{
    public partial class EM01 : Form
    {
        static Form1 form_1= new Form1();

        static string str_DataSource = form_1.Msg_ServerSource;
        //static string str_DataSource = "192.168.1.10";
        static string str_ServerID = form_1.Msg_ServerUser;
        static string str_ServerPW = form_1.Msg_ServerPassword;
        static string cm_str = "Data Source =" + str_DataSource + ";" +
                               "Initial Catalog = 公司;" +
                               "User Id =" + str_ServerID + ";" +
                               "Password =" + str_ServerPW ;
        static SqlConnection cm_compary = new SqlConnection(cm_str);

        public EM01()
        {
            InitializeComponent();
        }

        private void EM01_Load(object sender, EventArgs e)
        {
            cm_compary.Open(); //資料庫連線

            /*查詢所有員工*/
            string sql = "SELECT 姓名 FROM 員工";
            SqlCommand cm_people = new SqlCommand(sql, cm_compary);
            SqlDataReader rd_people;
            rd_people = cm_people.ExecuteReader(); //啟用讀取器

            try
            {
                /*讀員工姓名到comboBox*/
                while (rd_people.Read())
                {
                    comboBox_people.Items.Add(rd_people.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                cm_compary.Close();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否要[新增]本筆資料", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否要[刪除]本筆資料", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否要[修改]本筆資料", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否要[重置]本筆資料", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_people.Text) || comboBox_people.SelectedItem == null)
            {
                MessageBox.Show(this, "請挑選要處理的員工[姓名]再點[查詢]!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cm_compary.Open();

                string sql = "SELECT * FROM 員工 WHERE 姓名= @姓名";
                SqlCommand cm_people = new SqlCommand(sql, cm_compary);
                cm_people.Parameters.AddWithValue("@姓名", comboBox_people.SelectedItem.ToString());
                SqlDataReader rd_people;
                rd_people = cm_people.ExecuteReader();

                if (rd_people.Read())
                {
                    textBox_ID.Text = rd_people.GetValue(0).ToString();
                    textBox_Name.Text = rd_people.GetValue(1).ToString();
                    dateTimePicker_birday.Text = rd_people.GetValue(2).ToString();
                    textBox_Address.Text = rd_people.GetValue(3).ToString();
                    textBox_Money.Text = rd_people.GetValue(4).ToString();
                    textBox_Boss.Text = rd_people.GetValue(5).ToString();
                    textBox_work.Text = rd_people.GetValue(6).ToString();
                }

                if (rd_people != null)
                {
                    rd_people.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                cm_compary.Close();
            }

        }
    }
}
