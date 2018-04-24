namespace Login
{
    partial class flogin
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
            this.panelSoan = new System.Windows.Forms.Panel();
            this.buton_exit = new System.Windows.Forms.Button();
            this.buton_Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tboxUseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSoan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSoan
            // 
            this.panelSoan.Controls.Add(this.buton_exit);
            this.panelSoan.Controls.Add(this.buton_Login);
            this.panelSoan.Controls.Add(this.panel3);
            this.panelSoan.Controls.Add(this.panel2);
            this.panelSoan.Location = new System.Drawing.Point(12, 12);
            this.panelSoan.Name = "panelSoan";
            this.panelSoan.Size = new System.Drawing.Size(446, 232);
            this.panelSoan.TabIndex = 0;
            this.panelSoan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buton_exit
            // 
            this.buton_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buton_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_exit.Location = new System.Drawing.Point(328, 166);
            this.buton_exit.Name = "buton_exit";
            this.buton_exit.Size = new System.Drawing.Size(105, 40);
            this.buton_exit.TabIndex = 4;
            this.buton_exit.Text = "Thoát";
            this.buton_exit.UseVisualStyleBackColor = true;
            this.buton_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buton_exit_MouseClick);
            // 
            // buton_Login
            // 
            this.buton_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_Login.Location = new System.Drawing.Point(186, 166);
            this.buton_Login.Name = "buton_Login";
            this.buton_Login.Size = new System.Drawing.Size(116, 40);
            this.buton_Login.TabIndex = 3;
            this.buton_Login.Text = "Đăng Nhập";
            this.buton_Login.UseVisualStyleBackColor = true;
            this.buton_Login.Click += new System.EventHandler(this.buton_Login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 61);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tboxUseName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 61);
            this.panel2.TabIndex = 0;
            // 
            // tboxUseName
            // 
            this.tboxUseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUseName.Location = new System.Drawing.Point(180, 21);
            this.tboxUseName.Name = "tboxUseName";
            this.tboxUseName.Size = new System.Drawing.Size(247, 26);
            this.tboxUseName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // flogin
            // 
            this.AcceptButton = this.buton_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buton_exit;
            this.ClientSize = new System.Drawing.Size(460, 230);
            this.Controls.Add(this.panelSoan);
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.Load += new System.EventHandler(this.flogin_Load);
            this.panelSoan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxUseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buton_exit;
        private System.Windows.Forms.Button buton_Login;
    }
}

