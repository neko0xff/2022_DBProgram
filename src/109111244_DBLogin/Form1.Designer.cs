
namespace _109111244_DBLogin
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_IDUser = new System.Windows.Forms.TextBox();
            this.textBox_IDPassword = new System.Windows.Forms.TextBox();
            this.label_passwd = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_ServerPassword = new System.Windows.Forms.TextBox();
            this.textBox_ServerUser = new System.Windows.Forms.TextBox();
            this.textBox_ServerSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_name.Location = new System.Drawing.Point(74, 47);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 14);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // textBox_IDUser
            // 
            this.textBox_IDUser.Font = new System.Drawing.Font("新細明體", 10F);
            this.textBox_IDUser.Location = new System.Drawing.Point(132, 44);
            this.textBox_IDUser.Name = "textBox_IDUser";
            this.textBox_IDUser.Size = new System.Drawing.Size(136, 23);
            this.textBox_IDUser.TabIndex = 1;
            this.textBox_IDUser.Text = "李鴻章";
            // 
            // textBox_IDPassword
            // 
            this.textBox_IDPassword.Font = new System.Drawing.Font("新細明體", 10F);
            this.textBox_IDPassword.Location = new System.Drawing.Point(132, 77);
            this.textBox_IDPassword.Name = "textBox_IDPassword";
            this.textBox_IDPassword.PasswordChar = '*';
            this.textBox_IDPassword.Size = new System.Drawing.Size(136, 23);
            this.textBox_IDPassword.TabIndex = 3;
            this.textBox_IDPassword.Text = "A123456789";
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_passwd.Location = new System.Drawing.Point(33, 80);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(77, 14);
            this.label_passwd.TabIndex = 2;
            this.label_passwd.Text = "身份証號碼";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(54, 302);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(193, 302);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 174);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_IDUser);
            this.tabPage1.Controls.Add(this.textBox_IDPassword);
            this.tabPage1.Controls.Add(this.label_passwd);
            this.tabPage1.Controls.Add(this.label_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "使用者";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_ServerPassword);
            this.tabPage2.Controls.Add(this.textBox_ServerUser);
            this.tabPage2.Controls.Add(this.textBox_ServerSource);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label_user);
            this.tabPage2.Controls.Add(this.label_address);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "伺服器";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_ServerPassword
            // 
            this.textBox_ServerPassword.Font = new System.Drawing.Font("新細明體", 10F);
            this.textBox_ServerPassword.Location = new System.Drawing.Point(118, 87);
            this.textBox_ServerPassword.MaxLength = 8;
            this.textBox_ServerPassword.Name = "textBox_ServerPassword";
            this.textBox_ServerPassword.PasswordChar = '*';
            this.textBox_ServerPassword.Size = new System.Drawing.Size(100, 23);
            this.textBox_ServerPassword.TabIndex = 5;
            this.textBox_ServerPassword.Text = "oitmis";
            // 
            // textBox_ServerUser
            // 
            this.textBox_ServerUser.Font = new System.Drawing.Font("新細明體", 10F);
            this.textBox_ServerUser.Location = new System.Drawing.Point(118, 57);
            this.textBox_ServerUser.Name = "textBox_ServerUser";
            this.textBox_ServerUser.Size = new System.Drawing.Size(100, 23);
            this.textBox_ServerUser.TabIndex = 4;
            this.textBox_ServerUser.Text = "sa";
            // 
            // textBox_ServerSource
            // 
            this.textBox_ServerSource.Font = new System.Drawing.Font("新細明體", 10F);
            this.textBox_ServerSource.Location = new System.Drawing.Point(118, 28);
            this.textBox_ServerSource.Name = "textBox_ServerSource";
            this.textBox_ServerSource.Size = new System.Drawing.Size(100, 23);
            this.textBox_ServerSource.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_user.Location = new System.Drawing.Point(76, 60);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(31, 14);
            this.label_user.TabIndex = 1;
            this.label_user.Text = "User";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_address.Location = new System.Drawing.Point(37, 31);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(77, 14);
            this.label_address.TabIndex = 0;
            this.label_address.Text = "伺服器位置";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "準備連線";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "陽春資訊系統";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_Send);
            this.Name = "Form1";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_IDUser;
        private System.Windows.Forms.TextBox textBox_IDPassword;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_ServerPassword;
        private System.Windows.Forms.TextBox textBox_ServerUser;
        private System.Windows.Forms.TextBox textBox_ServerSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
    }
}

