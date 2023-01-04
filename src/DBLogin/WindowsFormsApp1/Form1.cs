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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        EM01 form_em01;
        //static String str = "Data Source=192.168.1.10;" +
        //                "Database=公司;" +
        //                "User ID=sa;" +
        //                "Password=oitmis;";
        static String str = "Data Source=.\\SQLExpress;" +
                            "Database=公司;" +
                            "User ID=sa;" +
                            "Password=oitmis;";
        SqlConnection cm_connection = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
            form_em01 = new EM01();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           
            String sql = "SELECT COUNT(*) FROM 員工 WHERE 姓名 = @姓名 AND 身分證號碼 = @身分證號碼";
            SqlCommand cm_login = new SqlCommand(sql, cm_connection);
            cm_login.Parameters.AddWithValue("@姓名", textBox_name.Text);
            cm_login.Parameters.AddWithValue("@身分證號碼", textBox_id.Text);

            try
            {
                cm_connection.Open();
                int iCount = (int)cm_login.ExecuteScalar();
                if(iCount == 1)
                {
                    MessageBox.Show(this, textBox_name.Text + "歡迎使用!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    form_em01.ShowDialog();
                    form_em01 = null;
                    if(form_em01 == null) this.Show();
                }
                else
                {
                    MessageBox.Show("[姓名]或[身份証號碼]錯誤,請重新登入!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cm_connection.State == ConnectionState.Open)
                {
                    cm_connection.Close();
                }
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_name.Text = "李鴻章";
            textBox_id.Text = "A123456789";
        }
    }
}
