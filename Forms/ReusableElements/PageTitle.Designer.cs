namespace WhereIsMyBox.Forms.ReusableElements
{
    partial class PageTitle
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.textTable = new System.Windows.Forms.TableLayoutPanel();
            this.divider = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.mainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.textTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Controls.Add(this.iconPictureBox1, 0, 0);
            this.mainTable.Controls.Add(this.textTable, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.Size = new System.Drawing.Size(800, 80);
            this.mainTable.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 74);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("SF UI Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Transparent;
            this.mainLabel.Location = new System.Drawing.Point(3, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(708, 33);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Наименование страницы";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTable
            // 
            this.textTable.ColumnCount = 1;
            this.textTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textTable.Controls.Add(this.mainLabel, 0, 0);
            this.textTable.Controls.Add(this.divider, 0, 1);
            this.textTable.Controls.Add(this.descriptionLabel, 0, 2);
            this.textTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTable.Location = new System.Drawing.Point(83, 3);
            this.textTable.Name = "textTable";
            this.textTable.RowCount = 3;
            this.textTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.textTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textTable.Size = new System.Drawing.Size(714, 74);
            this.textTable.TabIndex = 2;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.DimGray;
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.Location = new System.Drawing.Point(3, 36);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(708, 2);
            this.divider.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("SF UI Text", 10F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 41);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(153, 16);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Описание страницы";
            // 
            // PageTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTable);
            this.Name = "PageTitle";
            this.Size = new System.Drawing.Size(800, 80);
            this.mainTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.textTable.ResumeLayout(false);
            this.textTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TableLayoutPanel textTable;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label descriptionLabel;
    }
}
