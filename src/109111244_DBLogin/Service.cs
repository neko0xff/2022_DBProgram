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
    public partial class Service : Form
    {
        EM01 form_em01;
        Form1 form_1;

        public Service()
        {
            InitializeComponent();
            form_em01 = new EM01();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_EM01_Click(object sender, EventArgs e)
        {
            form_em01.ShowDialog();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            
        }
    }
}
