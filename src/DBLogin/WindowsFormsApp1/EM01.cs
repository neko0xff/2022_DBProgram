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
    public partial class EM01 : Form
    {
        //static String str = "Data Source=192.168.1.10;" +
        //                    "Database=公司;" +
        //                    "User ID=sa;" +
        //                    "Password=oitmis;";
        static String str = "Data Source=.\\SQLExpress;" +
                            "Database=公司;" +
                            "User ID=sa;" +
                            "Password=oitmis;";
        SqlConnection cm_connection = new SqlConnection(str);
        public EM01()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_id()
        {
            String sql = "SELECT COUNT(*) FROM 員工 WHERE 身分證號碼=@身分證號碼";
            SqlCommand cm_login = new SqlCommand(sql, cm_connection);
            cm_login.Parameters.AddWithValue("@身分證號碼", textBox_id.Text);

            if (cm_connection.State == ConnectionState.Closed) cm_connection.Open();
            int i_count = (int)cm_login.ExecuteScalar();
            if (i_count == 1)
            {
                MessageBox.Show(this, "員工[身分證號碼]不得重複", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm_connection.Close();
                return;
            }
        }
        private void check_data()
        {
            if (string.IsNullOrEmpty(textBox_id.Text))
            {
                MessageBox.Show(this, "員工[身分證號碼]不得空白!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show(this, "員工[姓名]不得空白!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show(this, "員工[生日]不得超過今日之後的日期!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //TryParse: return bool(true/false)
            if (string.IsNullOrEmpty(textBox_money.Text) == false && decimal.TryParse(textBox_money.Text, out decimal result) == false)
            {
                MessageBox.Show(this, "員工[薪水]不得為文字,請輸入數字資料!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void check_id2()
        {
            if (textBox_id.Text != textBox_id2.Text)
            {
                MessageBox.Show("[身分證號碼]不一致", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void EM01_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM 員工";
            SqlCommand cm_login = new SqlCommand(sql, cm_connection);
          
            try
            {
                if(cm_connection.State == ConnectionState.Closed) cm_connection.Open();

                SqlDataReader data_co = cm_login.ExecuteReader();
                while (data_co.Read())
                {
                    comboBox_data.Items.Add(data_co.GetValue(1)); //name
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cm_connection.State == ConnectionState.Open) cm_connection.Close();
            }
        }

        /*重置表單內容*/
        private void button_restart_Click(object sender, EventArgs e)
        {
            textBox_address.Text = "";
            textBox_id.Text = "";
            textBox_money.Text = "";
            textBox_name.Text = "";
            textBox_boss.Text = "";
            textBox_work.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        /*查詢資料*/
        private void button_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_data.Text) || comboBox_data.SelectedItem == null)
            {
                MessageBox.Show(this, "請挑選要處理的員工[姓名]再點[查詢]!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String search_sql = "SELECT * FROM 員工 WHERE 姓名=@姓名";
            SqlCommand cm_login = new SqlCommand(search_sql, cm_connection);
            cm_login.Parameters.AddWithValue("@姓名", comboBox_data.SelectedItem.ToString());

            try
            {
                cm_connection.Open();
                SqlDataReader rd_data= cm_login.ExecuteReader();
                if (rd_data.Read())
                {
                    textBox_id.Text = rd_data.GetValue(0).ToString();
                    textBox_id2.Text = rd_data.GetValue(0).ToString();
                    textBox_name.Text = rd_data.GetValue(1).ToString();
                    dateTimePicker1.Text = rd_data.GetValue(2).ToString();
                    textBox_address.Text = rd_data.GetValue(3).ToString();
                    textBox_money.Text = rd_data.GetValue(4).ToString();
                    textBox_boss.Text = rd_data.GetValue(5).ToString();
                    textBox_work.Text = rd_data.GetValue(6).ToString();
                }
                if(rd_data == null) rd_data.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cm_connection.State == ConnectionState.Open) cm_connection.Close();
            }
        }

        /*新增資料*/
        private void button_add_Click(object sender, EventArgs e)
        {
            check_data();
            try
            {
                check_id();
                check_id2();
                if (cm_connection.State == ConnectionState.Closed) cm_connection.Open();
          
                string add_sql = "INSERT INTO 員工 VALUES(@身分證號碼,@姓名,@生日,@地址,@薪水,@直屬上司,@工作部門)";
                SqlCommand add_data = new SqlCommand(add_sql, cm_connection);
                add_data.Parameters.AddWithValue("@身分證號碼", string.IsNullOrEmpty(textBox_id.Text)  ? (object)DBNull.Value: textBox_id.Text);
                add_data.Parameters.AddWithValue("@姓名", string.IsNullOrEmpty(textBox_name.Text) ? (object)DBNull.Value: textBox_name.Text );
                add_data.Parameters.AddWithValue("@生日", dateTimePicker1.Value);
                add_data.Parameters.AddWithValue("@地址", string.IsNullOrEmpty(textBox_address.Text) ?(object)DBNull.Value: textBox_address.Text);
                add_data.Parameters.AddWithValue("@薪水", string.IsNullOrEmpty(textBox_money.Text) ?(object)DBNull.Value: textBox_money.Text);
                add_data.Parameters.AddWithValue("@直屬上司", string.IsNullOrEmpty(textBox_boss.Text) ?(object)DBNull.Value: textBox_boss.Text);
                add_data.Parameters.AddWithValue("@工作部門", string.IsNullOrEmpty(textBox_work.Text) ?(object)DBNull.Value: textBox_work.Text);

                int i_count = (int)add_data.ExecuteNonQuery();
                if (i_count == 1)
                {
                    MessageBox.Show("成功建立一筆資料", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 加戴到查詢列表
                comboBox_data.Items.Clear();
                EM01_Load(sender, e);
                if (cm_connection.State == ConnectionState.Open) cm_connection.Close();
            }
        }

        /*更新資料*/
        private void button_update_Click(object sender, EventArgs e)
        {
            check_data();
            string update_sql = "UPDATE 員工 SET 姓名 = @姓名, 生日 = @生日, 地址 = @地址, 薪水 = @薪水, 直屬上司 = @直屬上司, 工作部門 = @工作部門 WHERE 身分證號碼 = @身分證號碼";
            SqlCommand upload_data = new SqlCommand(update_sql, cm_connection);
            upload_data.Parameters.AddWithValue("@身分證號碼", string.IsNullOrEmpty(textBox_id.Text) ? (object)DBNull.Value : textBox_id.Text);
            upload_data.Parameters.AddWithValue("@姓名", string.IsNullOrEmpty(textBox_name.Text) ? (object)DBNull.Value : textBox_name.Text);
            upload_data.Parameters.AddWithValue("@生日", dateTimePicker1.Value);
            upload_data.Parameters.AddWithValue("@地址", string.IsNullOrEmpty(textBox_address.Text) ? (object)DBNull.Value : textBox_address.Text);
            upload_data.Parameters.AddWithValue("@薪水", string.IsNullOrEmpty(textBox_money.Text) ? (object)DBNull.Value : textBox_money.Text);
            upload_data.Parameters.AddWithValue("@直屬上司", string.IsNullOrEmpty(textBox_boss.Text) ? (object)DBNull.Value : textBox_boss.Text);
            upload_data.Parameters.AddWithValue("@工作部門", string.IsNullOrEmpty(textBox_work.Text) ? (object)DBNull.Value : textBox_work.Text);

            int i_count;
            try
            {
                if (cm_connection.State == ConnectionState.Closed) cm_connection.Open();
                i_count =(int)upload_data.ExecuteNonQuery();
                if (i_count > 0)
                {
                    MessageBox.Show("成功修改一筆資料", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("修改失敗", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 加戴到查詢列表
                comboBox_data.Items.Clear();
                cm_connection.Close();
                EM01_Load(sender, e);
            }
        }

        /*刪除資料*/
        private void button_del_Click(object sender, EventArgs e)
        {
            check_data();
            string del_sql = "DELETE FROM 員工 WHERE 身分證號碼 = @身分證號碼";
            SqlCommand  del_data = new SqlCommand(del_sql, cm_connection);
            del_data.Parameters.AddWithValue("@身分證號碼", string.IsNullOrEmpty(textBox_id.Text) ? (object)DBNull.Value : textBox_id.Text);
            
            int i_count;
            try
            {
                if (cm_connection.State == ConnectionState.Closed) cm_connection.Open();
                if (MessageBox.Show(this, "是否要刪除本筆資料?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    i_count = (int)del_data.ExecuteNonQuery();
                    if (i_count > 0)
                    {
                        MessageBox.Show("成功刪除一筆資料", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("刪除失敗", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 加戴到查詢列表
                comboBox_data.Items.Clear();
                if (cm_connection.State == ConnectionState.Open) cm_connection.Close();
                EM01_Load(sender, e);
            }
        }
    }
}
