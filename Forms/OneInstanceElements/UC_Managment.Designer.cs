namespace WhereIsMyBox.Forms.OneInstanceElements
{
    partial class UC_Managment
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
            this.pageTitle1 = new WhereIsMyBox.Forms.ReusableElements.PageTitle();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Controls.Add(this.pageTitle1, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1000, 600);
            this.tableMain.TabIndex = 0;
            // 
            // pageTitle1
            // 
            this.pageTitle1.Description = "На этой странице можно добавить, отредактировать или удалить короб, а также отфил" +
    "ьтровать список коробов по нужному фильтру";
            this.pageTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTitle1.Icon = FontAwesome.Sharp.IconChar.PenToSquare;
            this.pageTitle1.Location = new System.Drawing.Point(3, 3);
            this.pageTitle1.Name = "pageTitle1";
            this.pageTitle1.Size = new System.Drawing.Size(994, 74);
            this.pageTitle1.TabIndex = 0;
            this.pageTitle1.Title = "Управление коробами";
            // 
            // UC_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.tableMain);
            this.Name = "UC_Managment";
            this.Size = new System.Drawing.Size(1000, 600);
            this.tableMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private ReusableElements.PageTitle pageTitle1;
    }
}
