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
            this.initialLocation = new System.Windows.Forms.Label();
            this.delete = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tableMain.ColumnCount = 6;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33443F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableMain.Controls.Add(this.number, 0, 0);
            this.tableMain.Controls.Add(this.box, 1, 0);
            this.tableMain.Controls.Add(this.delete, 5, 0);
            this.tableMain.Controls.Add(this.dateStart, 2, 0);
            this.tableMain.Controls.Add(this.remains, 3, 0);
            this.tableMain.Controls.Add(this.initialLocation, 4, 0);
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
            this.dateStart.Size = new System.Drawing.Size(239, 30);
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
            this.remains.Location = new System.Drawing.Point(418, 0);
            this.remains.Name = "remains";
            this.remains.Size = new System.Drawing.Size(239, 30);
            this.remains.TabIndex = 4;
            this.remains.Text = "00:00:00";
            this.remains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialLocation
            // 
            this.initialLocation.AutoSize = true;
            this.initialLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialLocation.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.initialLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.initialLocation.Location = new System.Drawing.Point(663, 0);
            this.initialLocation.Name = "initialLocation";
            this.initialLocation.Size = new System.Drawing.Size(239, 30);
            this.initialLocation.TabIndex = 5;
            this.initialLocation.Text = "Сверка (Левая)";
            this.initialLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.delete.Location = new System.Drawing.Point(908, 3);
            this.delete.Name = "delete";
            this.delete.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.delete.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.delete.Size = new System.Drawing.Size(89, 24);
            this.delete.TabIndex = 2;
            this.delete.Tag = "82; 81; 87";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
        private System.Windows.Forms.Label initialLocation;
    }
}
