namespace WhereIsMyBox.Forms.OneInstanceElements
{
    partial class UC_ListOfSeized
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Пиздец"}, -1);
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTerminate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCanReassign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewMain
            // 
            this.listViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.listViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBox,
            this.columnType,
            this.columnStartDate,
            this.columnEndDate,
            this.columnCanReassign,
            this.columnTerminate});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.listViewMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.listViewMain.HideSelection = false;
            this.listViewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewMain.Location = new System.Drawing.Point(0, 0);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(580, 320);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnBox
            // 
            this.columnBox.Text = "№ короба";
            this.columnBox.Width = 120;
            // 
            // columnType
            // 
            this.columnType.Text = "Тип короба";
            this.columnType.Width = 120;
            // 
            // columnStartDate
            // 
            this.columnStartDate.Text = "Дата изъятия";
            this.columnStartDate.Width = 140;
            // 
            // columnEndDate
            // 
            this.columnEndDate.Text = "Дата окончания";
            this.columnEndDate.Width = 140;
            // 
            // columnTerminate
            // 
            this.columnTerminate.DisplayIndex = 4;
            this.columnTerminate.Text = "Удалить";
            this.columnTerminate.Width = 100;
            // 
            // columnCanReassign
            // 
            this.columnCanReassign.DisplayIndex = 5;
            this.columnCanReassign.Text = "Переназначение";
            this.columnCanReassign.Width = 120;
            // 
            // UC_ListOfSeized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.listViewMain);
            this.Name = "UC_ListOfSeized";
            this.Size = new System.Drawing.Size(580, 320);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnBox;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnStartDate;
        private System.Windows.Forms.ColumnHeader columnEndDate;
        private System.Windows.Forms.ColumnHeader columnCanReassign;
        private System.Windows.Forms.ColumnHeader columnTerminate;
    }
}
