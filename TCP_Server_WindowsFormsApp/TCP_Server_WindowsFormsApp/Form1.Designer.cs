namespace TCP_Server_WindowsFormsApp
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IP_listBox = new System.Windows.Forms.ListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(369, 221);
            this.content.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 237);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(313, 22);
            this.input.TabIndex = 1;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(331, 237);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(50, 24);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            this.send_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.send_btn_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IP_listBox);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.Port_textBox);
            this.groupBox1.Controls.Add(this.IP_textBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(401, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 247);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP Status";
            // 
            // IP_listBox
            // 
            this.IP_listBox.FormattingEnabled = true;
            this.IP_listBox.ItemHeight = 12;
            this.IP_listBox.Location = new System.Drawing.Point(54, 77);
            this.IP_listBox.Name = "IP_listBox";
            this.IP_listBox.Size = new System.Drawing.Size(127, 160);
            this.IP_listBox.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "Port";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "IP";
            // 
            // Port_textBox
            // 
            this.Port_textBox.Location = new System.Drawing.Point(54, 49);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(127, 22);
            this.Port_textBox.TabIndex = 1;
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(54, 21);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(127, 22);
            this.IP_textBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.time_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(613, 22);
            this.statusStrip1.TabIndex = 74;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Time：";
            // 
            // time_toolStripStatusLabel
            // 
            this.time_toolStripStatusLabel.Name = "time_toolStripStatusLabel";
            this.time_toolStripStatusLabel.Size = new System.Drawing.Size(55, 17);
            this.time_toolStripStatusLabel.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Chat Room(Server)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.ListBox IP_listBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel time_toolStripStatusLabel;
    }
}
