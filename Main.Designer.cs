namespace WhereIsMyBox
{
    partial class Main
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label labelLocation;
            System.Windows.Forms.Label labelLogin;
            System.Windows.Forms.Label labelStatus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutLocation = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutBottomInfo = new System.Windows.Forms.TableLayoutPanel();
            this.LocationOfUser = new System.Windows.Forms.Label();
            this.tableLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.Login = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutStatus = new System.Windows.Forms.TableLayoutPanel();
            this.UserStatusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelLocation = new System.Windows.Forms.Label();
            labelLogin = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutLocation.SuspendLayout();
            this.tableLayoutBottom.SuspendLayout();
            this.tableLayoutBottomInfo.SuspendLayout();
            this.tableLayoutLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelBottom.Controls.Add(this.tableLayoutBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 388);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(884, 73);
            this.panelBottom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(191, 13);
            label1.TabIndex = 1;
            label1.Text = "Информация по использованию:";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutMain.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutMain.Controls.Add(this.panelMain, 1, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutMain.Size = new System.Drawing.Size(884, 388);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLeft.Controls.Add(this.tableLayoutStatus);
            this.panelLeft.Controls.Add(this.tableLayoutLogin);
            this.panelLeft.Controls.Add(this.tableLayoutLocation);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(176, 388);
            this.panelLeft.TabIndex = 0;
            // 
            // tableLayoutLocation
            // 
            this.tableLayoutLocation.ColumnCount = 1;
            this.tableLayoutLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLocation.Controls.Add(this.LocationOfUser, 0, 1);
            this.tableLayoutLocation.Controls.Add(labelLocation, 0, 0);
            this.tableLayoutLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutLocation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLocation.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutLocation.Name = "tableLayoutLocation";
            this.tableLayoutLocation.RowCount = 2;
            this.tableLayoutLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutLocation.Size = new System.Drawing.Size(176, 70);
            this.tableLayoutLocation.TabIndex = 0;
            this.tableLayoutLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            label2.Location = new System.Drawing.Point(3, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(525, 39);
            label2.TabIndex = 2;
            label2.Text = "Перед изъятием документа отсканируйте номер его короба и внесите в программу. Пос" +
    "ле окончания работы с документом или при фактическом окончании работы с коробом," +
    " удалите короб из программы.";
            // 
            // tableLayoutBottom
            // 
            this.tableLayoutBottom.ColumnCount = 4;
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.72222F));
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.583333F));
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69444F));
            this.tableLayoutBottom.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutBottom.Controls.Add(this.tableLayoutBottomInfo, 1, 0);
            this.tableLayoutBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBottom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBottom.Name = "tableLayoutBottom";
            this.tableLayoutBottom.RowCount = 1;
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.Size = new System.Drawing.Size(884, 73);
            this.tableLayoutBottom.TabIndex = 0;
            // 
            // tableLayoutBottomInfo
            // 
            this.tableLayoutBottomInfo.ColumnCount = 1;
            this.tableLayoutBottomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottomInfo.Controls.Add(label1, 0, 1);
            this.tableLayoutBottomInfo.Controls.Add(label2, 0, 2);
            this.tableLayoutBottomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBottomInfo.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutBottomInfo.Name = "tableLayoutBottomInfo";
            this.tableLayoutBottomInfo.RowCount = 3;
            this.tableLayoutBottomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutBottomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutBottomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutBottomInfo.Size = new System.Drawing.Size(540, 67);
            this.tableLayoutBottomInfo.TabIndex = 1;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            labelLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelLocation.Location = new System.Drawing.Point(3, 0);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new System.Drawing.Size(170, 28);
            labelLocation.TabIndex = 0;
            labelLocation.Text = "Локация:";
            labelLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LocationOfUser
            // 
            this.LocationOfUser.AutoSize = true;
            this.LocationOfUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationOfUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationOfUser.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationOfUser.Location = new System.Drawing.Point(3, 28);
            this.LocationOfUser.Name = "LocationOfUser";
            this.LocationOfUser.Size = new System.Drawing.Size(170, 42);
            this.LocationOfUser.TabIndex = 1;
            this.LocationOfUser.Text = "А1";
            this.LocationOfUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipMain.SetToolTip(this.LocationOfUser, "Нажмите, чтобы переназначить вашу локацию");
            this.LocationOfUser.Click += new System.EventHandler(this.LocationOfUser_Click);
            this.LocationOfUser.MouseEnter += new System.EventHandler(this.LocationOfUser_MouseEnter);
            this.LocationOfUser.MouseLeave += new System.EventHandler(this.LocationOfUser_MouseLeave);
            // 
            // tableLayoutLogin
            // 
            this.tableLayoutLogin.ColumnCount = 1;
            this.tableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLogin.Controls.Add(this.Login, 0, 1);
            this.tableLayoutLogin.Controls.Add(labelLogin, 0, 0);
            this.tableLayoutLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutLogin.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutLogin.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutLogin.Name = "tableLayoutLogin";
            this.tableLayoutLogin.RowCount = 2;
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLogin.Size = new System.Drawing.Size(176, 70);
            this.tableLayoutLogin.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(3, 28);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 42);
            this.Login.TabIndex = 1;
            this.Login.Text = "Неизвестно";
            this.Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            labelLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelLogin.Location = new System.Drawing.Point(3, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new System.Drawing.Size(170, 28);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин:";
            labelLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolTipMain
            // 
            this.toolTipMain.AutoPopDelay = 5000;
            this.toolTipMain.InitialDelay = 300;
            this.toolTipMain.IsBalloon = true;
            this.toolTipMain.ReshowDelay = 100;
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain.ToolTipTitle = "Подсказка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WhereIsMyBox.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(179, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(702, 382);
            this.panelMain.TabIndex = 1;
            // 
            // tableLayoutStatus
            // 
            this.tableLayoutStatus.ColumnCount = 1;
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStatus.Controls.Add(labelStatus, 0, 0);
            this.tableLayoutStatus.Controls.Add(this.UserStatusLabel, 0, 1);
            this.tableLayoutStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutStatus.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutStatus.Name = "tableLayoutStatus";
            this.tableLayoutStatus.RowCount = 2;
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutStatus.Size = new System.Drawing.Size(176, 70);
            this.tableLayoutStatus.TabIndex = 2;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            labelStatus.Location = new System.Drawing.Point(3, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(170, 28);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Статус:";
            labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UserStatusLabel
            // 
            this.UserStatusLabel.AutoSize = true;
            this.UserStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserStatusLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.UserStatusLabel.Location = new System.Drawing.Point(3, 28);
            this.UserStatusLabel.Name = "UserStatusLabel";
            this.UserStatusLabel.Size = new System.Drawing.Size(170, 30);
            this.UserStatusLabel.TabIndex = 1;
            this.UserStatusLabel.Text = "Неизвестно";
            this.UserStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.panelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Where Is My Box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelBottom.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutLocation.ResumeLayout(false);
            this.tableLayoutLocation.PerformLayout();
            this.tableLayoutBottom.ResumeLayout(false);
            this.tableLayoutBottomInfo.ResumeLayout(false);
            this.tableLayoutBottomInfo.PerformLayout();
            this.tableLayoutLogin.ResumeLayout(false);
            this.tableLayoutLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutStatus.ResumeLayout(false);
            this.tableLayoutStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBottomInfo;
        private System.Windows.Forms.Label LocationOfUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLogin;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatus;
        private System.Windows.Forms.Label UserStatusLabel;
    }
}