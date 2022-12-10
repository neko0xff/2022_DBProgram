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
    public partial class Form1 : Form
    {
        Service form_service;
        public Form1()
        {
            InitializeComponent();
            form_service = new Service();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {

            /* DB 連線字串 */
            string str = "Data Source="+ textBox_ServerSource.Text +";" +
                         "Initial Catalog = 公司;" +
                         "User Id="+textBox_ServerUser.Text+";" +
                         "Password="+textBox_ServerPassword.Text;
            string sql = "SELECT COUNT(*) FROM 員工 WHERE 姓名 = @姓名 AND 身分證號碼 = @身分證號碼";

            /*SQL 連線物件*/
            SqlConnection cm_company = new SqlConnection(str);
            SqlCommand cm_people = new SqlCommand(sql,cm_company);
            
            /* 定義輸入物件 */
            //寫法2
            cm_people.Parameters.AddWithValue("@姓名", textBox_IDUser.Text);
            cm_people.Parameters.AddWithValue("@身分證號碼", textBox_IDPassword.Text);

            /* 連線判斷 */
            try //打開
            {
                cm_company.Open();
                int iCount = (int)cm_people.ExecuteScalar();
                toolStripStatusLabel1.Text = "連線成功";

                /*ExecuteScalar 寫法*/
                if (iCount == 1)
                {
                    MessageBox.Show(this, textBox_IDUser.Text + "歡迎使用!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("[姓名]或[身份証號碼]錯誤,請重新登入!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //this.Hide(); // 把表單隱藏
                form_service.Close();
                form_service.Dispose();
                form_service = new Service();
                form_service.ShowDialog();

            }
            catch (Exception ex) //出問題時
            {
                toolStripStatusLabel1.Text = "連線失敗";
                MessageBox.Show(ex.ToString(),"Message",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally //收尾時
            {
                if (cm_company.State == ConnectionState.Open)
                {
                    toolStripStatusLabel1.Text = "連線関閉";
                    cm_company.Close();
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
