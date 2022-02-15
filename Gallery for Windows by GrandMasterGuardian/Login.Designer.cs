
namespace Gallery_for_Windows_by_GrandMasterGuardian
{
    partial class Login
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPasswordWarn = new System.Windows.Forms.Label();
            this.LoginNameWarn = new System.Windows.Forms.Label();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.LoginEnter = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginReg = new System.Windows.Forms.Button();
            this.RegPanel = new System.Windows.Forms.Panel();
            this.RegPasswordWarn = new System.Windows.Forms.Label();
            this.RegNameWarn = new System.Windows.Forms.Label();
            this.RegRegister = new System.Windows.Forms.Button();
            this.RegConfPassword = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegBack = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.OptShowUsers = new System.Windows.Forms.Button();
            this.ShowUsPanel = new System.Windows.Forms.Panel();
            this.ShowUsBack = new System.Windows.Forms.Button();
            this.ShowUsLabel = new System.Windows.Forms.Label();
            this.OptShowNextForm = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.RegPanel.SuspendLayout();
            this.ShowUsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.MistyRose;
            this.LoginPanel.Controls.Add(this.LoginPasswordWarn);
            this.LoginPanel.Controls.Add(this.LoginNameWarn);
            this.LoginPanel.Controls.Add(this.LoginName);
            this.LoginPanel.Controls.Add(this.LoginEnter);
            this.LoginPanel.Controls.Add(this.LoginPassword);
            this.LoginPanel.Controls.Add(this.LoginReg);
            this.LoginPanel.Location = new System.Drawing.Point(225, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(392, 491);
            this.LoginPanel.TabIndex = 5;
            // 
            // LoginPasswordWarn
            // 
            this.LoginPasswordWarn.AutoSize = true;
            this.LoginPasswordWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordWarn.Location = new System.Drawing.Point(117, 256);
            this.LoginPasswordWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginPasswordWarn.Name = "LoginPasswordWarn";
            this.LoginPasswordWarn.Size = new System.Drawing.Size(101, 20);
            this.LoginPasswordWarn.TabIndex = 9;
            this.LoginPasswordWarn.Text = "Invalid password";
            this.LoginPasswordWarn.Visible = false;
            // 
            // LoginNameWarn
            // 
            this.LoginNameWarn.AutoSize = true;
            this.LoginNameWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNameWarn.Location = new System.Drawing.Point(117, 203);
            this.LoginNameWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginNameWarn.Name = "LoginNameWarn";
            this.LoginNameWarn.Size = new System.Drawing.Size(78, 20);
            this.LoginNameWarn.TabIndex = 8;
            this.LoginNameWarn.Text = "Invalid name";
            this.LoginNameWarn.Visible = false;
            // 
            // LoginName
            // 
            this.LoginName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginName.Location = new System.Drawing.Point(116, 172);
            this.LoginName.Margin = new System.Windows.Forms.Padding(4);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(173, 25);
            this.LoginName.TabIndex = 2;
            this.LoginName.Text = "Name";
            this.LoginName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.LoginName.Enter += new System.EventHandler(this.LoginName_Enter);
            this.LoginName.Leave += new System.EventHandler(this.LoginName_Leave);
            // 
            // LoginEnter
            // 
            this.LoginEnter.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEnter.Location = new System.Drawing.Point(52, 361);
            this.LoginEnter.Margin = new System.Windows.Forms.Padding(4);
            this.LoginEnter.Name = "LoginEnter";
            this.LoginEnter.Size = new System.Drawing.Size(129, 37);
            this.LoginEnter.TabIndex = 1;
            this.LoginEnter.Text = "Enter";
            this.LoginEnter.UseVisualStyleBackColor = true;
            this.LoginEnter.Click += new System.EventHandler(this.LoginEnter_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(116, 227);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(173, 25);
            this.LoginPassword.TabIndex = 3;
            this.LoginPassword.Text = "Password";
            this.LoginPassword.Enter += new System.EventHandler(this.LoginPassword_Enter);
            this.LoginPassword.Leave += new System.EventHandler(this.LoginPassword_Leave);
            // 
            // LoginReg
            // 
            this.LoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginReg.Location = new System.Drawing.Point(223, 361);
            this.LoginReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginReg.Name = "LoginReg";
            this.LoginReg.Size = new System.Drawing.Size(127, 37);
            this.LoginReg.TabIndex = 0;
            this.LoginReg.Text = "Register";
            this.LoginReg.UseVisualStyleBackColor = true;
            this.LoginReg.Click += new System.EventHandler(this.LoginReg_Click);
            // 
            // RegPanel
            // 
            this.RegPanel.BackColor = System.Drawing.Color.MistyRose;
            this.RegPanel.Controls.Add(this.RegPasswordWarn);
            this.RegPanel.Controls.Add(this.RegNameWarn);
            this.RegPanel.Controls.Add(this.RegRegister);
            this.RegPanel.Controls.Add(this.RegConfPassword);
            this.RegPanel.Controls.Add(this.RegPassword);
            this.RegPanel.Controls.Add(this.RegName);
            this.RegPanel.Controls.Add(this.RegBack);
            this.RegPanel.Location = new System.Drawing.Point(225, 0);
            this.RegPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(392, 487);
            this.RegPanel.TabIndex = 7;
            this.RegPanel.Visible = false;
            this.RegPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RegPanel_Paint);
            // 
            // RegPasswordWarn
            // 
            this.RegPasswordWarn.AutoSize = true;
            this.RegPasswordWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordWarn.Location = new System.Drawing.Point(108, 245);
            this.RegPasswordWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegPasswordWarn.Name = "RegPasswordWarn";
            this.RegPasswordWarn.Size = new System.Drawing.Size(0, 20);
            this.RegPasswordWarn.TabIndex = 8;
            this.RegPasswordWarn.Visible = false;
            this.RegPasswordWarn.Click += new System.EventHandler(this.RegPasswordWarn_Click);
            // 
            // RegNameWarn
            // 
            this.RegNameWarn.AutoSize = true;
            this.RegNameWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNameWarn.Location = new System.Drawing.Point(108, 192);
            this.RegNameWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegNameWarn.Name = "RegNameWarn";
            this.RegNameWarn.Size = new System.Drawing.Size(0, 20);
            this.RegNameWarn.TabIndex = 7;
            this.RegNameWarn.Visible = false;
            // 
            // RegRegister
            // 
            this.RegRegister.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegRegister.Location = new System.Drawing.Point(240, 385);
            this.RegRegister.Margin = new System.Windows.Forms.Padding(4);
            this.RegRegister.Name = "RegRegister";
            this.RegRegister.Size = new System.Drawing.Size(111, 28);
            this.RegRegister.TabIndex = 6;
            this.RegRegister.Text = "Register";
            this.RegRegister.UseVisualStyleBackColor = true;
            this.RegRegister.Click += new System.EventHandler(this.RegRegister_Click);
            // 
            // RegConfPassword
            // 
            this.RegConfPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConfPassword.Location = new System.Drawing.Point(105, 269);
            this.RegConfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.RegConfPassword.Name = "RegConfPassword";
            this.RegConfPassword.Size = new System.Drawing.Size(173, 25);
            this.RegConfPassword.TabIndex = 5;
            this.RegConfPassword.Text = "Confirm password";
            this.RegConfPassword.Enter += new System.EventHandler(this.RegConfPassword_Enter);
            this.RegConfPassword.Leave += new System.EventHandler(this.RegConfPassword_Leave);
            // 
            // RegPassword
            // 
            this.RegPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassword.Location = new System.Drawing.Point(105, 216);
            this.RegPassword.Margin = new System.Windows.Forms.Padding(4);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(173, 25);
            this.RegPassword.TabIndex = 4;
            this.RegPassword.Text = "Password";
            this.RegPassword.Enter += new System.EventHandler(this.RegPassword_Enter);
            this.RegPassword.Leave += new System.EventHandler(this.RegPassword_Leave);
            // 
            // RegName
            // 
            this.RegName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegName.Location = new System.Drawing.Point(105, 159);
            this.RegName.Margin = new System.Windows.Forms.Padding(4);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(173, 25);
            this.RegName.TabIndex = 3;
            this.RegName.Text = "Name";
            this.RegName.Click += new System.EventHandler(this.RegName_Click);
            this.RegName.TextChanged += new System.EventHandler(this.RegName_TextChanged);
            this.RegName.Enter += new System.EventHandler(this.RegName_Enter);
            this.RegName.Leave += new System.EventHandler(this.RegName_Leave);
            // 
            // RegBack
            // 
            this.RegBack.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBack.Location = new System.Drawing.Point(52, 385);
            this.RegBack.Margin = new System.Windows.Forms.Padding(4);
            this.RegBack.Name = "RegBack";
            this.RegBack.Size = new System.Drawing.Size(100, 28);
            this.RegBack.TabIndex = 0;
            this.RegBack.Text = "Back";
            this.RegBack.UseVisualStyleBackColor = true;
            this.RegBack.Click += new System.EventHandler(this.RegBack_Click);
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(765, 438);
            this.Options.Margin = new System.Windows.Forms.Padding(4);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(36, 28);
            this.Options.TabIndex = 8;
            this.Options.Text = "...";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // OptShowUsers
            // 
            this.OptShowUsers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptShowUsers.Location = new System.Drawing.Point(647, 438);
            this.OptShowUsers.Margin = new System.Windows.Forms.Padding(4);
            this.OptShowUsers.Name = "OptShowUsers";
            this.OptShowUsers.Size = new System.Drawing.Size(111, 28);
            this.OptShowUsers.TabIndex = 9;
            this.OptShowUsers.Text = "Show users";
            this.OptShowUsers.UseVisualStyleBackColor = true;
            this.OptShowUsers.Visible = false;
            this.OptShowUsers.Click += new System.EventHandler(this.OptShowUsers_Click);
            // 
            // ShowUsPanel
            // 
            this.ShowUsPanel.BackColor = System.Drawing.Color.MistyRose;
            this.ShowUsPanel.Controls.Add(this.ShowUsBack);
            this.ShowUsPanel.Controls.Add(this.ShowUsLabel);
            this.ShowUsPanel.Location = new System.Drawing.Point(0, 0);
            this.ShowUsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ShowUsPanel.Name = "ShowUsPanel";
            this.ShowUsPanel.Size = new System.Drawing.Size(817, 491);
            this.ShowUsPanel.TabIndex = 10;
            this.ShowUsPanel.Visible = false;
            // 
            // ShowUsBack
            // 
            this.ShowUsBack.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsBack.Location = new System.Drawing.Point(700, 444);
            this.ShowUsBack.Margin = new System.Windows.Forms.Padding(4);
            this.ShowUsBack.Name = "ShowUsBack";
            this.ShowUsBack.Size = new System.Drawing.Size(100, 28);
            this.ShowUsBack.TabIndex = 1;
            this.ShowUsBack.Text = "Back";
            this.ShowUsBack.UseVisualStyleBackColor = true;
            this.ShowUsBack.Click += new System.EventHandler(this.ShowUsBack_Click);
            // 
            // ShowUsLabel
            // 
            this.ShowUsLabel.AutoSize = true;
            this.ShowUsLabel.Location = new System.Drawing.Point(29, 16);
            this.ShowUsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowUsLabel.Name = "ShowUsLabel";
            this.ShowUsLabel.Size = new System.Drawing.Size(53, 17);
            this.ShowUsLabel.TabIndex = 0;
            this.ShowUsLabel.Text = "Users: \r\n";
            // 
            // OptShowNextForm
            // 
            this.OptShowNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptShowNextForm.Location = new System.Drawing.Point(647, 403);
            this.OptShowNextForm.Name = "OptShowNextForm";
            this.OptShowNextForm.Size = new System.Drawing.Size(111, 28);
            this.OptShowNextForm.TabIndex = 11;
            this.OptShowNextForm.Text = "Next form";
            this.OptShowNextForm.UseVisualStyleBackColor = true;
            this.OptShowNextForm.Visible = false;
            this.OptShowNextForm.Click += new System.EventHandler(this.OptShowNextForm_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(817, 486);
            this.Controls.Add(this.OptShowNextForm);
            this.Controls.Add(this.OptShowUsers);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.ShowUsPanel);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            this.ShowUsPanel.ResumeLayout(false);
            this.ShowUsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.Button LoginEnter;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Button LoginReg;
        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Button RegRegister;
        private System.Windows.Forms.TextBox RegConfPassword;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.Button RegBack;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button OptShowUsers;
        private System.Windows.Forms.Panel ShowUsPanel;
        private System.Windows.Forms.Label ShowUsLabel;
        private System.Windows.Forms.Button ShowUsBack;
        private System.Windows.Forms.Label RegNameWarn;
        private System.Windows.Forms.Label RegPasswordWarn;
        private System.Windows.Forms.Label LoginPasswordWarn;
        private System.Windows.Forms.Label LoginNameWarn;
        private System.Windows.Forms.Button OptShowNextForm;
    }
}

