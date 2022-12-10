using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _109111244_DBLogin
{
    public partial class EM01 : Form
    {
        public EM01()
        {
            InitializeComponent();
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
    }
}
