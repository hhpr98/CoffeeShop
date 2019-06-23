namespace CFProject
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.btnShowHidePass = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepassword = new CFProject.TextBoxH();
            this.btnChangedPassword = new CFProject.ButtonH();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewpassword = new CFProject.TextBoxH();
            this.txtOldpassword = new CFProject.TextBoxH();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new CFProject.TextBoxH();
            this.txtAddress = new CFProject.TextBoxH();
            this.txtCMND = new CFProject.TextBoxH();
            this.txtUsermanagement = new CFProject.TextBoxH();
            this.txtPassword = new CFProject.TextBoxH();
            this.txtUsername = new CFProject.TextBoxH();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowHidePass
            // 
            this.btnShowHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHidePass.Image")));
            this.btnShowHidePass.Location = new System.Drawing.Point(119, 118);
            this.btnShowHidePass.Name = "btnShowHidePass";
            this.btnShowHidePass.Size = new System.Drawing.Size(28, 23);
            this.btnShowHidePass.TabIndex = 61;
            this.btnShowHidePass.UseVisualStyleBackColor = true;
            this.btnShowHidePass.Click += new System.EventHandler(this.btnShowHidePass_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 313);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Số điện thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 265);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 57;
            this.label12.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Tên NQL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRepassword);
            this.panel1.Controls.Add(this.btnChangedPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNewpassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOldpassword);
            this.panel1.Location = new System.Drawing.Point(404, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 223);
            this.panel1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.Location = new System.Drawing.Point(152, 117);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(189, 27);
            this.txtRepassword.TabIndex = 69;
            this.txtRepassword.UseSystemPasswordChar = true;
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangedPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangedPassword.BorderWidth = 2;
            this.btnChangedPassword.ButtonShape = CFProject.ButtonH.ButtonsShapes.Rect;
            this.btnChangedPassword.ButtonText = "";
            this.btnChangedPassword.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChangedPassword.FlatAppearance.BorderSize = 0;
            this.btnChangedPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangedPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangedPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangedPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangedPassword.GradientAngle = 90;
            this.btnChangedPassword.Location = new System.Drawing.Point(133, 172);
            this.btnChangedPassword.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.btnChangedPassword.MouseClickColor2 = System.Drawing.Color.Red;
            this.btnChangedPassword.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.btnChangedPassword.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.ShowButtontext = true;
            this.btnChangedPassword.Size = new System.Drawing.Size(81, 28);
            this.btnChangedPassword.StartColor = System.Drawing.Color.Blue;
            this.btnChangedPassword.TabIndex = 63;
            this.btnChangedPassword.Text = "Xác nhận";
            this.btnChangedPassword.TextLocation_X = 26;
            this.btnChangedPassword.TextLocation_Y = 14;
            this.btnChangedPassword.Transparent1 = 75;
            this.btnChangedPassword.Transparent2 = 50;
            this.btnChangedPassword.UseVisualStyleBackColor = false;
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpassword.Location = new System.Drawing.Point(152, 69);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(189, 27);
            this.txtNewpassword.TabIndex = 67;
            this.txtNewpassword.UseSystemPasswordChar = true;
            // 
            // txtOldpassword
            // 
            this.txtOldpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldpassword.Location = new System.Drawing.Point(152, 21);
            this.txtOldpassword.Name = "txtOldpassword";
            this.txtOldpassword.Size = new System.Drawing.Size(189, 27);
            this.txtOldpassword.TabIndex = 65;
            this.txtOldpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(148, 308);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 27);
            this.txtPhoneNumber.TabIndex = 60;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(148, 260);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 27);
            this.txtAddress.TabIndex = 58;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(148, 214);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(189, 27);
            this.txtCMND.TabIndex = 56;
            // 
            // txtUsermanagement
            // 
            this.txtUsermanagement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsermanagement.Location = new System.Drawing.Point(148, 165);
            this.txtUsermanagement.Name = "txtUsermanagement";
            this.txtUsermanagement.Size = new System.Drawing.Size(189, 27);
            this.txtUsermanagement.TabIndex = 54;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(148, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 27);
            this.txtPassword.TabIndex = 52;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(148, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 27);
            this.txtUsername.TabIndex = 50;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowHidePass);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsermanagement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowHidePass;
        private TextBoxH txtPhoneNumber;
        private System.Windows.Forms.Label label13;
        private TextBoxH txtAddress;
        private System.Windows.Forms.Label label12;
        private TextBoxH txtCMND;
        private System.Windows.Forms.Label label11;
        private TextBoxH txtUsermanagement;
        private System.Windows.Forms.Label label10;
        private TextBoxH txtPassword;
        private System.Windows.Forms.Label label9;
        private TextBoxH txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private ButtonH btnChangedPassword;
        private TextBoxH txtOldpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private TextBoxH txtRepassword;
        private System.Windows.Forms.Label label4;
        private TextBoxH txtNewpassword;
        private System.Windows.Forms.Label label3;
    }
}