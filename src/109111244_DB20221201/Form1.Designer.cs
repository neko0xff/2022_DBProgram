
namespace _109111244_DB20221201
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_send1 = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_output = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_send1
            // 
            this.button_send1.Location = new System.Drawing.Point(35, 24);
            this.button_send1.Name = "button_send1";
            this.button_send1.Size = new System.Drawing.Size(133, 32);
            this.button_send1.TabIndex = 0;
            this.button_send1.Text = "連線到Access DB";
            this.button_send1.UseVisualStyleBackColor = true;
            this.button_send1.Click += new System.EventHandler(this.button_send1_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(35, 62);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(133, 32);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "連線到SQL Server DB";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 226);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1 連線設定";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 195);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL Server 連線設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_password);
            this.groupBox2.Controls.Add(this.textBox_user);
            this.groupBox2.Controls.Add(this.label_password);
            this.groupBox2.Controls.Add(this.label_user);
            this.groupBox2.Location = new System.Drawing.Point(219, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "使用者";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(81, 56);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Text = "oitmis";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(81, 26);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(100, 22);
            this.textBox_user.TabIndex = 2;
            this.textBox_user.Text = "sa";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(20, 59);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(29, 12);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "密碼";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(20, 29);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(41, 12);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "使用者";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_db);
            this.groupBox1.Controls.Add(this.textBox_source);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料庫";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(78, 59);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(100, 22);
            this.textBox_db.TabIndex = 3;
            this.textBox_db.Text = "公司";
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(78, 26);
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(100, 22);
            this.textBox_source.TabIndex = 2;
            this.textBox_source.Text = ".\\SQLEXPRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB name";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Access連線設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_send1);
            this.groupBox4.Controls.Add(this.button_send);
            this.groupBox4.Location = new System.Drawing.Point(503, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 110);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2 開始";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(538, 142);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(133, 25);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "関閉";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_output});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // toolStripStatusLabel_output
            // 
            this.toolStripStatusLabel_output.Name = "toolStripStatusLabel_output";
            this.toolStripStatusLabel_output.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel_output.Text = "準備連線";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 273);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "客戶端資料庫連線測試";
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_output;
    }
}

