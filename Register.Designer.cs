namespace product_management
{
    partial class Register
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.ll_gotologin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(30, 97);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(30, 164);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(30, 214);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(30, 266);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(60, 13);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "User Nmae";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(30, 314);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(181, 20);
            this.txt_name.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(119, 86);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(181, 49);
            this.txt_address.TabIndex = 7;
            this.txt_address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(119, 157);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(181, 20);
            this.txt_phone.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(119, 207);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(181, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(119, 259);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(181, 20);
            this.txt_username.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(119, 307);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(181, 20);
            this.txt_password.TabIndex = 11;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(119, 364);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // ll_gotologin
            // 
            this.ll_gotologin.AutoSize = true;
            this.ll_gotologin.Location = new System.Drawing.Point(234, 369);
            this.ll_gotologin.Name = "ll_gotologin";
            this.ll_gotologin.Size = new System.Drawing.Size(66, 13);
            this.ll_gotologin.TabIndex = 13;
            this.ll_gotologin.TabStop = true;
            this.ll_gotologin.Text = "Go To Login";
            this.ll_gotologin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gotologin_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 416);
            this.Controls.Add(this.ll_gotologin);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.LinkLabel ll_gotologin;
    }
}