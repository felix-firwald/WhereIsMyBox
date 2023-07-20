namespace WhereIsMyBox.Forms
{
    partial class UC_Boxes
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutFunc = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableFindTop = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFind = new FontAwesome.Sharp.IconButton();
            this.inputFind = new System.Windows.Forms.TextBox();
            this.buttonCancelFind = new FontAwesome.Sharp.IconButton();
            this.HelpTextFind = new System.Windows.Forms.Label();
            this.tableMicroActions = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grayButton4 = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.grayButton3 = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.grayButton1 = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.grayButton2 = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.BoxInfoPanel = new WhereIsMyBox.Forms.Elements.UC_BoxInfo();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.tableFindTop.SuspendLayout();
            this.tableMicroActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.label1, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutFunc, 0, 1);
            this.tableLayoutMain.Controls.Add(this.splitContainerMain, 0, 2);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutMain.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДВИЖЕНИЕ КОРОБОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutFunc
            // 
            this.tableLayoutFunc.ColumnCount = 2;
            this.tableLayoutFunc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFunc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFunc.Controls.Add(this.elementHost1, 1, 0);
            this.tableLayoutFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFunc.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutFunc.Name = "tableLayoutFunc";
            this.tableLayoutFunc.RowCount = 1;
            this.tableLayoutFunc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFunc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutFunc.Size = new System.Drawing.Size(894, 84);
            this.tableLayoutFunc.TabIndex = 1;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(450, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 78);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutMain.SetColumnSpan(this.splitContainerMain, 2);
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 153);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutLeft);
            this.splitContainerMain.Panel1MinSize = 50;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.splitContainerMain.Panel2MinSize = 200;
            this.splitContainerMain.Size = new System.Drawing.Size(894, 444);
            this.splitContainerMain.SplitterDistance = 297;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.ColumnCount = 1;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.Controls.Add(this.tableFindTop, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.HelpTextFind, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.tableMicroActions, 0, 3);
            this.tableLayoutLeft.Controls.Add(this.BoxInfoPanel, 0, 1);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(295, 442);
            this.tableLayoutLeft.TabIndex = 0;
            // 
            // tableFindTop
            // 
            this.tableFindTop.ColumnCount = 3;
            this.tableFindTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableFindTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFindTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableFindTop.Controls.Add(this.buttonFind, 0, 0);
            this.tableFindTop.Controls.Add(this.inputFind, 1, 0);
            this.tableFindTop.Controls.Add(this.buttonCancelFind, 2, 0);
            this.tableFindTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFindTop.Location = new System.Drawing.Point(3, 3);
            this.tableFindTop.Name = "tableFindTop";
            this.tableFindTop.RowCount = 1;
            this.tableFindTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFindTop.Size = new System.Drawing.Size(289, 34);
            this.tableFindTop.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFind.Enabled = false;
            this.buttonFind.FlatAppearance.BorderSize = 0;
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buttonFind.IconColor = System.Drawing.Color.DimGray;
            this.buttonFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFind.IconSize = 20;
            this.buttonFind.Location = new System.Drawing.Point(3, 3);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(44, 23);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            this.buttonFind.MouseEnter += new System.EventHandler(this.buttonFind_MouseEnter);
            this.buttonFind.MouseLeave += new System.EventHandler(this.buttonFind_MouseLeave);
            // 
            // inputFind
            // 
            this.inputFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.inputFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFind.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFind.ForeColor = System.Drawing.Color.Chartreuse;
            this.inputFind.Location = new System.Drawing.Point(53, 3);
            this.inputFind.MaxLength = 7;
            this.inputFind.Name = "inputFind";
            this.inputFind.Size = new System.Drawing.Size(183, 22);
            this.inputFind.TabIndex = 1;
            this.inputFind.Tag = "64; 64; 65";
            this.inputFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
            this.inputFind.Enter += new System.EventHandler(this.inputFind_Enter);
            // 
            // buttonCancelFind
            // 
            this.buttonCancelFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelFind.FlatAppearance.BorderSize = 0;
            this.buttonCancelFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.buttonCancelFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.buttonCancelFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelFind.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.buttonCancelFind.IconColor = System.Drawing.Color.DimGray;
            this.buttonCancelFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCancelFind.IconSize = 20;
            this.buttonCancelFind.Location = new System.Drawing.Point(242, 3);
            this.buttonCancelFind.Name = "buttonCancelFind";
            this.buttonCancelFind.Size = new System.Drawing.Size(44, 23);
            this.buttonCancelFind.TabIndex = 2;
            this.buttonCancelFind.UseVisualStyleBackColor = true;
            this.buttonCancelFind.Click += new System.EventHandler(this.buttonCancelFind_Click);
            this.buttonCancelFind.MouseEnter += new System.EventHandler(this.buttonCancelFind_MouseEnter);
            this.buttonCancelFind.MouseLeave += new System.EventHandler(this.buttonCancelFind_MouseLeave);
            // 
            // HelpTextFind
            // 
            this.HelpTextFind.AutoSize = true;
            this.HelpTextFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpTextFind.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpTextFind.ForeColor = System.Drawing.Color.DimGray;
            this.HelpTextFind.Location = new System.Drawing.Point(5, 372);
            this.HelpTextFind.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.HelpTextFind.Name = "HelpTextFind";
            this.HelpTextFind.Size = new System.Drawing.Size(285, 20);
            this.HelpTextFind.TabIndex = 1;
            this.HelpTextFind.Text = "Введите номер короба или отсканируйте его";
            this.HelpTextFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableMicroActions
            // 
            this.tableMicroActions.ColumnCount = 4;
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.Controls.Add(this.grayButton4, 0, 0);
            this.tableMicroActions.Controls.Add(this.grayButton3, 0, 0);
            this.tableMicroActions.Controls.Add(this.grayButton1, 3, 0);
            this.tableMicroActions.Controls.Add(this.grayButton2, 2, 0);
            this.tableMicroActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableMicroActions.Location = new System.Drawing.Point(132, 405);
            this.tableMicroActions.Name = "tableMicroActions";
            this.tableMicroActions.RowCount = 1;
            this.tableMicroActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMicroActions.Size = new System.Drawing.Size(160, 34);
            this.tableMicroActions.TabIndex = 2;
            this.tableMicroActions.Visible = false;
            // 
            // grayButton4
            // 
            this.grayButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayButton4.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.grayButton4.FlatAppearance.BorderSize = 0;
            this.grayButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton4.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.grayButton4.IconColor = System.Drawing.Color.DimGray;
            this.grayButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.grayButton4.IconSize = 20;
            this.grayButton4.Location = new System.Drawing.Point(43, 3);
            this.grayButton4.Name = "grayButton4";
            this.grayButton4.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.grayButton4.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.grayButton4.Size = new System.Drawing.Size(34, 23);
            this.grayButton4.TabIndex = 3;
            this.grayButton4.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.grayButton4, "Показать на карте");
            this.grayButton4.UseVisualStyleBackColor = false;
            // 
            // grayButton3
            // 
            this.grayButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayButton3.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.grayButton3.FlatAppearance.BorderSize = 0;
            this.grayButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton3.IconChar = FontAwesome.Sharp.IconChar.List;
            this.grayButton3.IconColor = System.Drawing.Color.DimGray;
            this.grayButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.grayButton3.IconSize = 20;
            this.grayButton3.Location = new System.Drawing.Point(3, 3);
            this.grayButton3.Name = "grayButton3";
            this.grayButton3.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.grayButton3.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Moderator;
            this.grayButton3.Size = new System.Drawing.Size(34, 23);
            this.grayButton3.TabIndex = 2;
            this.grayButton3.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.grayButton3, "Просмотреть историю движения короба");
            this.grayButton3.UseVisualStyleBackColor = false;
            // 
            // grayButton1
            // 
            this.grayButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayButton1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.grayButton1.FlatAppearance.BorderSize = 0;
            this.grayButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.grayButton1.IconColor = System.Drawing.Color.DimGray;
            this.grayButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.grayButton1.IconSize = 20;
            this.grayButton1.Location = new System.Drawing.Point(123, 3);
            this.grayButton1.Name = "grayButton1";
            this.grayButton1.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.grayButton1.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Moderator;
            this.grayButton1.Size = new System.Drawing.Size(34, 23);
            this.grayButton1.TabIndex = 0;
            this.grayButton1.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.grayButton1, "Добавить найденный короб к своему ведению");
            this.grayButton1.UseVisualStyleBackColor = false;
            // 
            // grayButton2
            // 
            this.grayButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayButton2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.grayButton2.FlatAppearance.BorderSize = 0;
            this.grayButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grayButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton2.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.grayButton2.IconColor = System.Drawing.Color.DimGray;
            this.grayButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.grayButton2.IconSize = 20;
            this.grayButton2.Location = new System.Drawing.Point(83, 3);
            this.grayButton2.Name = "grayButton2";
            this.grayButton2.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.grayButton2.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Moderator;
            this.grayButton2.Size = new System.Drawing.Size(34, 23);
            this.grayButton2.TabIndex = 1;
            this.grayButton2.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.grayButton2, "Добавить временный комментарий к коробу (может быть переопределен другим пользова" +
        "телем)");
            this.grayButton2.UseVisualStyleBackColor = false;
            // 
            // BoxInfoPanel
            // 
            this.BoxInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxInfoPanel.Location = new System.Drawing.Point(3, 43);
            this.BoxInfoPanel.Name = "BoxInfoPanel";
            this.BoxInfoPanel.Size = new System.Drawing.Size(289, 316);
            this.BoxInfoPanel.TabIndex = 3;
            this.BoxInfoPanel.Visible = false;
            // 
            // UC_Boxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.tableLayoutMain);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "UC_Boxes";
            this.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tableLayoutFunc.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutLeft.PerformLayout();
            this.tableFindTop.ResumeLayout(false);
            this.tableFindTop.PerformLayout();
            this.tableMicroActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFunc;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private System.Windows.Forms.TableLayoutPanel tableFindTop;
        private FontAwesome.Sharp.IconButton buttonFind;
        private System.Windows.Forms.TextBox inputFind;
        private System.Windows.Forms.Label HelpTextFind;
        private FontAwesome.Sharp.IconButton buttonCancelFind;
        private System.Windows.Forms.TableLayoutPanel tableMicroActions;
        private Elements.GrayButton grayButton1;
        private Elements.GrayButton grayButton2;
        private Elements.GrayButton grayButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Elements.UC_BoxInfo BoxInfoPanel;
        private Elements.GrayButton grayButton4;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}
