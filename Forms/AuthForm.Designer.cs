namespace WhereIsMyBox
{
    partial class AuthForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.checkVisible = new System.Windows.Forms.CheckBox();
            this.toolTipAuth = new System.Windows.Forms.ToolTip(this.components);
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Enabled = false;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(12, 15);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(150, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Войти";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.Location = new System.Drawing.Point(222, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.toolTipAuth.SetToolTip(this.buttonClose, "Закрыть программу");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panelControls.Controls.Add(this.buttonClose);
            this.panelControls.Controls.Add(this.buttonOk);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 134);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(384, 51);
            this.panelControls.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser.Location = new System.Drawing.Point(9, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(84, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Пользователь:";
            // 
            // comboUsers
            // 
            this.comboUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.comboUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUsers.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.comboUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(12, 30);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.Size = new System.Drawing.Size(360, 21);
            this.comboUsers.TabIndex = 3;
            this.comboUsers.Tag = "64; 64; 65";
            this.toolTipAuth.SetToolTip(this.comboUsers, "Имя пользователя учетной записи");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.inputPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(15)));
            this.inputPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inputPassword.Location = new System.Drawing.Point(12, 84);
            this.inputPassword.MaxLength = 10;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(360, 22);
            this.inputPassword.TabIndex = 5;
            this.inputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipAuth.SetToolTip(this.inputPassword, "Введите пароль, если ранее его уже присвоили, или назначьте его, если впервые отк" +
        "рыли программу на этом компьютере");
            this.inputPassword.UseSystemPasswordChar = true;
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            // 
            // checkVisible
            // 
            this.checkVisible.AutoSize = true;
            this.checkVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkVisible.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkVisible.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkVisible.Location = new System.Drawing.Point(12, 110);
            this.checkVisible.Name = "checkVisible";
            this.checkVisible.Size = new System.Drawing.Size(116, 17);
            this.checkVisible.TabIndex = 6;
            this.checkVisible.Text = "показать пароль";
            this.checkVisible.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkVisible.UseVisualStyleBackColor = true;
            this.checkVisible.CheckStateChanged += new System.EventHandler(this.checkVisible_CheckStateChanged);
            // 
            // AuthForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(384, 185);
            this.ControlBox = false;
            this.Controls.Add(this.checkVisible);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboUsers);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panelControls);
            this.MaximumSize = new System.Drawing.Size(400, 224);
            this.MinimumSize = new System.Drawing.Size(400, 224);
            this.Name = "AuthForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.CheckBox checkVisible;
        private System.Windows.Forms.ToolTip toolTipAuth;
    }
}