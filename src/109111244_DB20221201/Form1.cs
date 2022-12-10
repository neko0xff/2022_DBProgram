using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace _109111244_DB20221201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*OLEDB: 異質資料庫連線 */
        private void button_send1_Click(object sender, EventArgs e)
        {
            String str = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                         "Data Source= Northwind.mdb"; //放在"/專案/bin/Debug"下
            OleDbConnection cn_Northwind = new OleDbConnection(str);
            
            try //打開
            {
                cn_Northwind.Open();
                toolStripStatusLabel_output.Text = "連線成功";
                MessageBox.Show("連線到Access DB=成功","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) //出問題時
            {
                toolStripStatusLabel_output.Text = "連線發生錯誤";
                MessageBox.Show(ex.ToString(),"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally //收尾時
            {
                if (cn_Northwind.State == ConnectionState.Open)
                {
                    toolStripStatusLabel_output.Text = "連線己結束";
                    cn_Northwind.Close();
                }
            }
        }

        /*SqlClient: SQL Server連線*/
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source ="+ textBox_source.Text +";" +
                         "Initial Catalog ="+ textBox_db.Text +";" +
                         "User Id="+  textBox_user.Text +";" +
                         "Password="+ textBox_password.Text ;
            SqlConnection cn_company = new SqlConnection(str);

            try //打開
            {
                cn_company.Open();
                toolStripStatusLabel_output.Text = "連線成功";
                MessageBox.Show("連線到SQLServer DB=成功","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) //出問題時
            {
                toolStripStatusLabel_output.Text = "連線發生錯誤";
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //收尾時
            {
                if (cn_company.State == ConnectionState.Open)
                {
                    toolStripStatusLabel_output.Text = "連線己結束";
                    cn_company.Close();
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel_output.Text = "関閉中";
            this.Close();
        }
    }
}
