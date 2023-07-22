namespace WhereIsMyBox.Forms.Elements
{
    partial class UC_BoxInfo
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.initialLocation = new System.Windows.Forms.Label();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.labelPostfix = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.DimGray;
            label1.Location = new System.Drawing.Point(3, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "Изначальное местоположение";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            label5.ForeColor = System.Drawing.Color.DimGray;
            label5.Location = new System.Drawing.Point(3, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(165, 30);
            label5.TabIndex = 4;
            label5.Text = "Текущее местоположение";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            label9.ForeColor = System.Drawing.Color.DimGray;
            label9.Location = new System.Drawing.Point(3, 148);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(165, 30);
            label9.TabIndex = 8;
            label9.Text = "Статус";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            label10.ForeColor = System.Drawing.Color.DimGray;
            label10.Location = new System.Drawing.Point(3, 178);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(165, 30);
            label10.TabIndex = 9;
            label10.Text = "Комментарий";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.initialLocation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPrefix, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPostfix, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.currentLocation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.status, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.label14.Location = new System.Drawing.Point(174, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 30);
            this.label14.TabIndex = 13;
            this.label14.Text = "12:00:00 14.08.2023";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.label13.Location = new System.Drawing.Point(174, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "d.magon";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialLocation
            // 
            this.initialLocation.AutoSize = true;
            this.initialLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.initialLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.initialLocation.Location = new System.Drawing.Point(174, 88);
            this.initialLocation.Name = "initialLocation";
            this.initialLocation.Size = new System.Drawing.Size(166, 30);
            this.initialLocation.TabIndex = 3;
            this.initialLocation.Text = "Сверка КК";
            this.initialLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrefix.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.labelPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.labelPrefix.Location = new System.Drawing.Point(3, 0);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(165, 88);
            this.labelPrefix.TabIndex = 1;
            this.labelPrefix.Text = "VZ";
            this.labelPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPostfix
            // 
            this.labelPostfix.AutoSize = true;
            this.labelPostfix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPostfix.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostfix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.labelPostfix.Location = new System.Drawing.Point(174, 0);
            this.labelPostfix.Name = "labelPostfix";
            this.labelPostfix.Size = new System.Drawing.Size(166, 88);
            this.labelPostfix.TabIndex = 2;
            this.labelPostfix.Text = "15626";
            this.labelPostfix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLocation
            // 
            this.currentLocation.AutoSize = true;
            this.currentLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.currentLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.currentLocation.Location = new System.Drawing.Point(174, 118);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(166, 30);
            this.currentLocation.TabIndex = 5;
            this.currentLocation.Text = "Сверка КК";
            this.currentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.status.ForeColor = System.Drawing.Color.MediumPurple;
            this.status.Location = new System.Drawing.Point(174, 148);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(166, 30);
            this.status.TabIndex = 6;
            this.status.Text = "Изъят";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(174, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Не забирать!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(3, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Сотрудник";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(3, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 30);
            this.label12.TabIndex = 11;
            this.label12.Text = "Станет доступен в";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_BoxInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_BoxInfo";
            this.Size = new System.Drawing.Size(343, 356);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label initialLocation;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Label labelPostfix;
        private System.Windows.Forms.Label currentLocation;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}
