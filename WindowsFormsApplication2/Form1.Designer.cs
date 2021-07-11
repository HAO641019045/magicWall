namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Status_B = new System.Windows.Forms.Label();
            this.label_Status_A = new System.Windows.Forms.Label();
            this.button_runServiceB = new System.Windows.Forms.Button();
            this.button_runServiceA = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 200);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_Status_B);
            this.tabPage1.Controls.Add(this.label_Status_A);
            this.tabPage1.Controls.Add(this.button_runServiceB);
            this.tabPage1.Controls.Add(this.button_runServiceA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "魔墙服务";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_Status_B
            // 
            this.label_Status_B.AutoSize = true;
            this.label_Status_B.Location = new System.Drawing.Point(48, 34);
            this.label_Status_B.Name = "label_Status_B";
            this.label_Status_B.Size = new System.Drawing.Size(29, 12);
            this.label_Status_B.TabIndex = 3;
            this.label_Status_B.Text = "NULL";
            // 
            // label_Status_A
            // 
            this.label_Status_A.AutoSize = true;
            this.label_Status_A.Location = new System.Drawing.Point(48, 13);
            this.label_Status_A.Name = "label_Status_A";
            this.label_Status_A.Size = new System.Drawing.Size(29, 12);
            this.label_Status_A.TabIndex = 2;
            this.label_Status_A.Text = "NULL";
            // 
            // button_runServiceB
            // 
            this.button_runServiceB.Location = new System.Drawing.Point(6, 29);
            this.button_runServiceB.Name = "button_runServiceB";
            this.button_runServiceB.Size = new System.Drawing.Size(43, 23);
            this.button_runServiceB.TabIndex = 1;
            this.button_runServiceB.Text = "运行";
            this.button_runServiceB.UseVisualStyleBackColor = true;
            this.button_runServiceB.Click += new System.EventHandler(this.button_runServiceB_Click);
            // 
            // button_runServiceA
            // 
            this.button_runServiceA.Location = new System.Drawing.Point(6, 6);
            this.button_runServiceA.Name = "button_runServiceA";
            this.button_runServiceA.Size = new System.Drawing.Size(43, 23);
            this.button_runServiceA.TabIndex = 0;
            this.button_runServiceA.Text = "运行";
            this.button_runServiceA.UseVisualStyleBackColor = true;
            this.button_runServiceA.Click += new System.EventHandler(this.button_runServiceA_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(292, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "计算工具";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "超8K墙宽高计算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(301, 202);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_Status_B;
        private System.Windows.Forms.Label label_Status_A;
        private System.Windows.Forms.Button button_runServiceB;
        private System.Windows.Forms.Button button_runServiceA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

