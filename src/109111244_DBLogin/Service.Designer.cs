
namespace _109111244_DBLogin
{
    partial class Service
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_EM01 = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "主選單";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_EM01);
            this.groupBox1.Location = new System.Drawing.Point(29, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服務";
            this.groupBox1.UseWaitCursor = true;
            // 
            // button_EM01
            // 
            this.button_EM01.Location = new System.Drawing.Point(67, 21);
            this.button_EM01.Name = "button_EM01";
            this.button_EM01.Size = new System.Drawing.Size(150, 33);
            this.button_EM01.TabIndex = 0;
            this.button_EM01.Text = "EM01-員工資料維護";
            this.button_EM01.UseVisualStyleBackColor = true;
            this.button_EM01.UseWaitCursor = true;
            this.button_EM01.Click += new System.EventHandler(this.button_EM01_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(130, 199);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(93, 31);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "離開";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.UseWaitCursor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(361, 266);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "陽春資訊系統 V1.0.0";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Service_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_EM01;
        private System.Windows.Forms.Button button_close;
    }
}