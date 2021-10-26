
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
            this.LoginPanel.SuspendLayout();
            this.RegPanel.SuspendLayout();
            this.ShowUsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginPasswordWarn);
            this.LoginPanel.Controls.Add(this.LoginNameWarn);
            this.LoginPanel.Controls.Add(this.LoginName);
            this.LoginPanel.Controls.Add(this.LoginEnter);
            this.LoginPanel.Controls.Add(this.LoginPassword);
            this.LoginPanel.Controls.Add(this.LoginReg);
            this.LoginPanel.Location = new System.Drawing.Point(160, 53);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(313, 222);
            this.LoginPanel.TabIndex = 5;
            // 
            // LoginPasswordWarn
            // 
            this.LoginPasswordWarn.AutoSize = true;
            this.LoginPasswordWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordWarn.Location = new System.Drawing.Point(88, 120);
            this.LoginPasswordWarn.Name = "LoginPasswordWarn";
            this.LoginPasswordWarn.Size = new System.Drawing.Size(81, 16);
            this.LoginPasswordWarn.TabIndex = 9;
            this.LoginPasswordWarn.Text = "Invalid password";
            this.LoginPasswordWarn.Visible = false;
            // 
            // LoginNameWarn
            // 
            this.LoginNameWarn.AutoSize = true;
            this.LoginNameWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNameWarn.Location = new System.Drawing.Point(88, 79);
            this.LoginNameWarn.Name = "LoginNameWarn";
            this.LoginNameWarn.Size = new System.Drawing.Size(63, 16);
            this.LoginNameWarn.TabIndex = 8;
            this.LoginNameWarn.Text = "Invalid name";
            this.LoginNameWarn.Visible = false;
            // 
            // LoginName
            // 
            this.LoginName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginName.Location = new System.Drawing.Point(87, 54);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(131, 22);
            this.LoginName.TabIndex = 2;
            this.LoginName.Text = "Name";
            this.LoginName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.LoginName.Enter += new System.EventHandler(this.LoginName_Enter);
            this.LoginName.Leave += new System.EventHandler(this.LoginName_Leave);
            // 
            // LoginEnter
            // 
            this.LoginEnter.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEnter.Location = new System.Drawing.Point(39, 172);
            this.LoginEnter.Name = "LoginEnter";
            this.LoginEnter.Size = new System.Drawing.Size(97, 30);
            this.LoginEnter.TabIndex = 1;
            this.LoginEnter.Text = "Enter";
            this.LoginEnter.UseVisualStyleBackColor = true;
            this.LoginEnter.Click += new System.EventHandler(this.LoginEnter_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(87, 95);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(131, 22);
            this.LoginPassword.TabIndex = 3;
            this.LoginPassword.Text = "Password";
            this.LoginPassword.Enter += new System.EventHandler(this.LoginPassword_Enter);
            this.LoginPassword.Leave += new System.EventHandler(this.LoginPassword_Leave);
            // 
            // LoginReg
            // 
            this.LoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginReg.Location = new System.Drawing.Point(180, 171);
            this.LoginReg.Margin = new System.Windows.Forms.Padding(2);
            this.LoginReg.Name = "LoginReg";
            this.LoginReg.Size = new System.Drawing.Size(95, 30);
            this.LoginReg.TabIndex = 0;
            this.LoginReg.Text = "Register";
            this.LoginReg.UseVisualStyleBackColor = true;
            this.LoginReg.Click += new System.EventHandler(this.LoginReg_Click);
            // 
            // RegPanel
            // 
            this.RegPanel.Controls.Add(this.RegPasswordWarn);
            this.RegPanel.Controls.Add(this.RegNameWarn);
            this.RegPanel.Controls.Add(this.RegRegister);
            this.RegPanel.Controls.Add(this.RegConfPassword);
            this.RegPanel.Controls.Add(this.RegPassword);
            this.RegPanel.Controls.Add(this.RegName);
            this.RegPanel.Controls.Add(this.RegBack);
            this.RegPanel.Location = new System.Drawing.Point(169, 12);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(294, 304);
            this.RegPanel.TabIndex = 7;
            this.RegPanel.Visible = false;
            this.RegPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RegPanel_Paint);
            // 
            // RegPasswordWarn
            // 
            this.RegPasswordWarn.AutoSize = true;
            this.RegPasswordWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordWarn.Location = new System.Drawing.Point(79, 117);
            this.RegPasswordWarn.Name = "RegPasswordWarn";
            this.RegPasswordWarn.Size = new System.Drawing.Size(0, 16);
            this.RegPasswordWarn.TabIndex = 8;
            this.RegPasswordWarn.Visible = false;
            this.RegPasswordWarn.Click += new System.EventHandler(this.RegPasswordWarn_Click);
            // 
            // RegNameWarn
            // 
            this.RegNameWarn.AutoSize = true;
            this.RegNameWarn.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNameWarn.Location = new System.Drawing.Point(78, 76);
            this.RegNameWarn.Name = "RegNameWarn";
            this.RegNameWarn.Size = new System.Drawing.Size(0, 16);
            this.RegNameWarn.TabIndex = 7;
            this.RegNameWarn.Visible = false;
            // 
            // RegRegister
            // 
            this.RegRegister.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegRegister.Location = new System.Drawing.Point(162, 253);
            this.RegRegister.Name = "RegRegister";
            this.RegRegister.Size = new System.Drawing.Size(83, 23);
            this.RegRegister.TabIndex = 6;
            this.RegRegister.Text = "Register";
            this.RegRegister.UseVisualStyleBackColor = true;
            this.RegRegister.Click += new System.EventHandler(this.RegRegister_Click);
            // 
            // RegConfPassword
            // 
            this.RegConfPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConfPassword.Location = new System.Drawing.Point(79, 134);
            this.RegConfPassword.Name = "RegConfPassword";
            this.RegConfPassword.Size = new System.Drawing.Size(131, 22);
            this.RegConfPassword.TabIndex = 5;
            this.RegConfPassword.Text = "Confirm password";
            this.RegConfPassword.Enter += new System.EventHandler(this.RegConfPassword_Enter);
            this.RegConfPassword.Leave += new System.EventHandler(this.RegConfPassword_Leave);
            // 
            // RegPassword
            // 
            this.RegPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassword.Location = new System.Drawing.Point(79, 93);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(131, 22);
            this.RegPassword.TabIndex = 4;
            this.RegPassword.Text = "Password";
            this.RegPassword.Enter += new System.EventHandler(this.RegPassword_Enter);
            this.RegPassword.Leave += new System.EventHandler(this.RegPassword_Leave);
            // 
            // RegName
            // 
            this.RegName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegName.Location = new System.Drawing.Point(79, 53);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(131, 22);
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
            this.RegBack.Location = new System.Drawing.Point(31, 253);
            this.RegBack.Name = "RegBack";
            this.RegBack.Size = new System.Drawing.Size(75, 23);
            this.RegBack.TabIndex = 0;
            this.RegBack.Text = "Back";
            this.RegBack.UseVisualStyleBackColor = true;
            this.RegBack.Click += new System.EventHandler(this.RegBack_Click);
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(574, 356);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(27, 23);
            this.Options.TabIndex = 8;
            this.Options.Text = "...";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // OptShowUsers
            // 
            this.OptShowUsers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptShowUsers.Location = new System.Drawing.Point(485, 356);
            this.OptShowUsers.Name = "OptShowUsers";
            this.OptShowUsers.Size = new System.Drawing.Size(83, 23);
            this.OptShowUsers.TabIndex = 9;
            this.OptShowUsers.Text = "Show users";
            this.OptShowUsers.UseVisualStyleBackColor = true;
            this.OptShowUsers.Visible = false;
            this.OptShowUsers.Click += new System.EventHandler(this.OptShowUsers_Click);
            // 
            // ShowUsPanel
            // 
            this.ShowUsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowUsPanel.Controls.Add(this.ShowUsBack);
            this.ShowUsPanel.Controls.Add(this.ShowUsLabel);
            this.ShowUsPanel.Location = new System.Drawing.Point(1, -1);
            this.ShowUsPanel.Name = "ShowUsPanel";
            this.ShowUsPanel.Size = new System.Drawing.Size(613, 399);
            this.ShowUsPanel.TabIndex = 10;
            this.ShowUsPanel.Visible = false;
            // 
            // ShowUsBack
            // 
            this.ShowUsBack.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsBack.Location = new System.Drawing.Point(525, 361);
            this.ShowUsBack.Name = "ShowUsBack";
            this.ShowUsBack.Size = new System.Drawing.Size(75, 23);
            this.ShowUsBack.TabIndex = 1;
            this.ShowUsBack.Text = "Back";
            this.ShowUsBack.UseVisualStyleBackColor = true;
            this.ShowUsBack.Click += new System.EventHandler(this.ShowUsBack_Click);
            // 
            // ShowUsLabel
            // 
            this.ShowUsLabel.AutoSize = true;
            this.ShowUsLabel.Location = new System.Drawing.Point(22, 13);
            this.ShowUsLabel.Name = "ShowUsLabel";
            this.ShowUsLabel.Size = new System.Drawing.Size(40, 13);
            this.ShowUsLabel.TabIndex = 0;
            this.ShowUsLabel.Text = "Users: \r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 395);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.OptShowUsers);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.ShowUsPanel);
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
    }
}

