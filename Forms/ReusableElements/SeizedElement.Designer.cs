namespace WhereIsMyBox.Forms.ReusableElements
{
    partial class SeizedElement
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.number = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.Label();
            this.remains = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.delete = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.setFocus = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tableMain.ColumnCount = 7;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33443F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableMain.Controls.Add(this.number, 0, 0);
            this.tableMain.Controls.Add(this.box, 1, 0);
            this.tableMain.Controls.Add(this.delete, 6, 0);
            this.tableMain.Controls.Add(this.dateStart, 2, 0);
            this.tableMain.Controls.Add(this.remains, 3, 0);
            this.tableMain.Controls.Add(this.location, 4, 0);
            this.tableMain.Controls.Add(this.setFocus, 5, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1000, 30);
            this.tableMain.TabIndex = 0;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.number.ForeColor = System.Drawing.Color.DimGray;
            this.number.Location = new System.Drawing.Point(3, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(44, 30);
            this.number.TabIndex = 0;
            this.number.Text = "1";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.box.Location = new System.Drawing.Point(53, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(114, 30);
            this.box.TabIndex = 1;
            this.box.Text = "AA00000";
            this.box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.dateStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.dateStart.Location = new System.Drawing.Point(173, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(216, 30);
            this.dateStart.TabIndex = 3;
            this.dateStart.Text = "00:00 01.01.2001";
            this.dateStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remains
            // 
            this.remains.AutoSize = true;
            this.remains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remains.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.remains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.remains.Location = new System.Drawing.Point(395, 0);
            this.remains.Name = "remains";
            this.remains.Size = new System.Drawing.Size(216, 30);
            this.remains.TabIndex = 4;
            this.remains.Text = "00:00:00";
            this.remains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.location.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.location.Location = new System.Drawing.Point(617, 0);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(216, 30);
            this.location.TabIndex = 5;
            this.location.Text = "Сверка (Левая)";
            this.location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.EnteredColor = System.Drawing.Color.Red;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.delete.IconColor = System.Drawing.Color.DimGray;
            this.delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete.IconSize = 20;
            this.delete.Location = new System.Drawing.Point(919, 3);
            this.delete.Name = "delete";
            this.delete.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.delete.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.delete.Size = new System.Drawing.Size(78, 24);
            this.delete.TabIndex = 2;
            this.delete.Tag = "82; 81; 87";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // setFocus
            // 
            this.setFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.setFocus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setFocus.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.setFocus.FlatAppearance.BorderSize = 0;
            this.setFocus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.setFocus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.setFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setFocus.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.setFocus.IconColor = System.Drawing.Color.DimGray;
            this.setFocus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.setFocus.IconSize = 20;
            this.setFocus.Location = new System.Drawing.Point(839, 3);
            this.setFocus.Name = "setFocus";
            this.setFocus.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.setFocus.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.setFocus.Size = new System.Drawing.Size(74, 23);
            this.setFocus.TabIndex = 6;
            this.setFocus.Tag = "82; 81; 87";
            this.setFocus.UseVisualStyleBackColor = false;
            this.setFocus.Click += new System.EventHandler(this.setFocus_Click);
            // 
            // SeizedElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.tableMain);
            this.MaximumSize = new System.Drawing.Size(1500, 30);
            this.Name = "SeizedElement";
            this.Size = new System.Drawing.Size(1000, 30);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label box;
        private Elements.GrayButton delete;
        private System.Windows.Forms.Label dateStart;
        private System.Windows.Forms.Label remains;
        private System.Windows.Forms.Label location;
        private Elements.GrayButton setFocus;
    }
}
