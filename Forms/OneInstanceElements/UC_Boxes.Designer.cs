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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableFindTop = new System.Windows.Forms.TableLayoutPanel();
            this.inputFind = new System.Windows.Forms.TextBox();
            this.HelpTextFind = new System.Windows.Forms.Label();
            this.tableMicroActions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutSeizedBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.tableAddToSeizedBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.inputSeize = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFind = new FontAwesome.Sharp.IconButton();
            this.buttonCancelFind = new FontAwesome.Sharp.IconButton();
            this.buttonAddBox = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonShowMap = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonShowQRCode = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonComment = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonMarkAsNotFound = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.BoxInfoPanel = new WhereIsMyBox.Forms.Elements.UC_BoxInfo();
            this.buttonAddToSeized = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonClearSeizingBox = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.buttonSettingsForSeize = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.grayButton1 = new WhereIsMyBox.Forms.Elements.GrayButton();
            this.ListOfSeized = new WhereIsMyBox.Forms.OneInstanceElements.UC_ListOfSeized();
            this.pageTitle1 = new WhereIsMyBox.Forms.ReusableElements.PageTitle();
            this.tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.tableFindTop.SuspendLayout();
            this.tableMicroActions.SuspendLayout();
            this.tableLayoutSeizedBoxes.SuspendLayout();
            this.tableAddToSeizedBoxes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.splitContainerMain, 0, 2);
            this.tableLayoutMain.Controls.Add(this.pageTitle1, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutMain.SetColumnSpan(this.splitContainerMain, 2);
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 93);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutLeft);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutSeizedBoxes);
            this.splitContainerMain.Panel2MinSize = 300;
            this.splitContainerMain.Size = new System.Drawing.Size(994, 504);
            this.splitContainerMain.SplitterDistance = 332;
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
            this.tableLayoutLeft.Size = new System.Drawing.Size(330, 502);
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
            this.tableFindTop.Size = new System.Drawing.Size(324, 34);
            this.tableFindTop.TabIndex = 0;
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
            this.inputFind.Size = new System.Drawing.Size(218, 22);
            this.inputFind.TabIndex = 1;
            this.inputFind.Tag = "";
            this.inputFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputFind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputFind_MouseClick);
            this.inputFind.TextChanged += new System.EventHandler(this.inputFind_TextChanged);
            // 
            // HelpTextFind
            // 
            this.HelpTextFind.AutoSize = true;
            this.HelpTextFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpTextFind.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpTextFind.ForeColor = System.Drawing.Color.DimGray;
            this.HelpTextFind.Location = new System.Drawing.Point(5, 432);
            this.HelpTextFind.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.HelpTextFind.Name = "HelpTextFind";
            this.HelpTextFind.Size = new System.Drawing.Size(320, 20);
            this.HelpTextFind.TabIndex = 1;
            this.HelpTextFind.Text = "Введите номер короба или отсканируйте его";
            this.HelpTextFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableMicroActions
            // 
            this.tableMicroActions.ColumnCount = 7;
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMicroActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMicroActions.Controls.Add(this.buttonAddBox, 5, 0);
            this.tableMicroActions.Controls.Add(this.buttonShowMap, 4, 0);
            this.tableMicroActions.Controls.Add(this.buttonShowQRCode, 3, 0);
            this.tableMicroActions.Controls.Add(this.buttonComment, 2, 0);
            this.tableMicroActions.Controls.Add(this.buttonMarkAsNotFound, 1, 0);
            this.tableMicroActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMicroActions.Location = new System.Drawing.Point(3, 465);
            this.tableMicroActions.Name = "tableMicroActions";
            this.tableMicroActions.RowCount = 1;
            this.tableMicroActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMicroActions.Size = new System.Drawing.Size(324, 34);
            this.tableMicroActions.TabIndex = 2;
            this.tableMicroActions.Visible = false;
            // 
            // tableLayoutSeizedBoxes
            // 
            this.tableLayoutSeizedBoxes.ColumnCount = 1;
            this.tableLayoutSeizedBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSeizedBoxes.Controls.Add(this.tableAddToSeizedBoxes, 0, 0);
            this.tableLayoutSeizedBoxes.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutSeizedBoxes.Controls.Add(this.label2, 0, 2);
            this.tableLayoutSeizedBoxes.Controls.Add(this.ListOfSeized, 0, 1);
            this.tableLayoutSeizedBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSeizedBoxes.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutSeizedBoxes.Name = "tableLayoutSeizedBoxes";
            this.tableLayoutSeizedBoxes.RowCount = 4;
            this.tableLayoutSeizedBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutSeizedBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSeizedBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutSeizedBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutSeizedBoxes.Size = new System.Drawing.Size(656, 502);
            this.tableLayoutSeizedBoxes.TabIndex = 0;
            // 
            // tableAddToSeizedBoxes
            // 
            this.tableAddToSeizedBoxes.ColumnCount = 4;
            this.tableAddToSeizedBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAddToSeizedBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAddToSeizedBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAddToSeizedBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAddToSeizedBoxes.Controls.Add(this.buttonAddToSeized, 0, 0);
            this.tableAddToSeizedBoxes.Controls.Add(this.inputSeize, 1, 0);
            this.tableAddToSeizedBoxes.Controls.Add(this.buttonClearSeizingBox, 2, 0);
            this.tableAddToSeizedBoxes.Controls.Add(this.buttonSettingsForSeize, 3, 0);
            this.tableAddToSeizedBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAddToSeizedBoxes.Location = new System.Drawing.Point(3, 3);
            this.tableAddToSeizedBoxes.Name = "tableAddToSeizedBoxes";
            this.tableAddToSeizedBoxes.RowCount = 1;
            this.tableAddToSeizedBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAddToSeizedBoxes.Size = new System.Drawing.Size(650, 34);
            this.tableAddToSeizedBoxes.TabIndex = 0;
            // 
            // inputSeize
            // 
            this.inputSeize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.inputSeize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSeize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSeize.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.inputSeize.ForeColor = System.Drawing.Color.Chartreuse;
            this.inputSeize.Location = new System.Drawing.Point(53, 3);
            this.inputSeize.Name = "inputSeize";
            this.inputSeize.Size = new System.Drawing.Size(494, 22);
            this.inputSeize.TabIndex = 1;
            this.inputSeize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSeize.TextChanged += new System.EventHandler(this.inputSeize_TextChanged);
            this.inputSeize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSeize_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grayButton1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вы все? Не забудьте нажать на галочку ниже для сохранения данных!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonCancelFind.Location = new System.Drawing.Point(277, 3);
            this.buttonCancelFind.Name = "buttonCancelFind";
            this.buttonCancelFind.Size = new System.Drawing.Size(44, 23);
            this.buttonCancelFind.TabIndex = 2;
            this.buttonCancelFind.UseVisualStyleBackColor = true;
            this.buttonCancelFind.Click += new System.EventHandler(this.buttonCancelFind_Click);
            this.buttonCancelFind.MouseEnter += new System.EventHandler(this.buttonCancelFind_MouseEnter);
            this.buttonCancelFind.MouseLeave += new System.EventHandler(this.buttonCancelFind_MouseLeave);
            // 
            // buttonAddBox
            // 
            this.buttonAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddBox.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonAddBox.FlatAppearance.BorderSize = 0;
            this.buttonAddBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBox.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAddBox.IconColor = System.Drawing.Color.DimGray;
            this.buttonAddBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddBox.IconSize = 20;
            this.buttonAddBox.Location = new System.Drawing.Point(225, 3);
            this.buttonAddBox.Name = "buttonAddBox";
            this.buttonAddBox.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.buttonAddBox.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Moderator;
            this.buttonAddBox.Size = new System.Drawing.Size(34, 23);
            this.buttonAddBox.TabIndex = 0;
            this.buttonAddBox.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.buttonAddBox, "Изъять (если короб физически изъят вами)");
            this.buttonAddBox.UseVisualStyleBackColor = false;
            this.buttonAddBox.Click += new System.EventHandler(this.buttonAddBox_Click);
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowMap.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonShowMap.FlatAppearance.BorderSize = 0;
            this.buttonShowMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowMap.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.buttonShowMap.IconColor = System.Drawing.Color.DimGray;
            this.buttonShowMap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonShowMap.IconSize = 20;
            this.buttonShowMap.Location = new System.Drawing.Point(185, 3);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.buttonShowMap.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.buttonShowMap.Size = new System.Drawing.Size(34, 23);
            this.buttonShowMap.TabIndex = 1;
            this.buttonShowMap.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.buttonShowMap, "Показать местоположение короба на карте");
            this.buttonShowMap.UseVisualStyleBackColor = false;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // buttonShowQRCode
            // 
            this.buttonShowQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowQRCode.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonShowQRCode.FlatAppearance.BorderSize = 0;
            this.buttonShowQRCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowQRCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowQRCode.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.buttonShowQRCode.IconColor = System.Drawing.Color.DimGray;
            this.buttonShowQRCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonShowQRCode.IconSize = 20;
            this.buttonShowQRCode.Location = new System.Drawing.Point(145, 3);
            this.buttonShowQRCode.Name = "buttonShowQRCode";
            this.buttonShowQRCode.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.buttonShowQRCode.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.buttonShowQRCode.Size = new System.Drawing.Size(34, 23);
            this.buttonShowQRCode.TabIndex = 2;
            this.buttonShowQRCode.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.buttonShowQRCode, "Показать QR-код");
            this.buttonShowQRCode.UseVisualStyleBackColor = false;
            this.buttonShowQRCode.Click += new System.EventHandler(this.buttonShowQRCode_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComment.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonComment.FlatAppearance.BorderSize = 0;
            this.buttonComment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComment.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.buttonComment.IconColor = System.Drawing.Color.DimGray;
            this.buttonComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonComment.IconSize = 20;
            this.buttonComment.Location = new System.Drawing.Point(105, 3);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.buttonComment.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.buttonComment.Size = new System.Drawing.Size(34, 23);
            this.buttonComment.TabIndex = 3;
            this.buttonComment.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.buttonComment, "Добавить комментарий");
            this.buttonComment.UseVisualStyleBackColor = false;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonMarkAsNotFound
            // 
            this.buttonMarkAsNotFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMarkAsNotFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMarkAsNotFound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonMarkAsNotFound.FlatAppearance.BorderSize = 0;
            this.buttonMarkAsNotFound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMarkAsNotFound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMarkAsNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarkAsNotFound.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.buttonMarkAsNotFound.IconColor = System.Drawing.Color.DimGray;
            this.buttonMarkAsNotFound.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMarkAsNotFound.IconSize = 20;
            this.buttonMarkAsNotFound.Location = new System.Drawing.Point(65, 3);
            this.buttonMarkAsNotFound.Name = "buttonMarkAsNotFound";
            this.buttonMarkAsNotFound.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Rising;
            this.buttonMarkAsNotFound.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Operator;
            this.buttonMarkAsNotFound.Size = new System.Drawing.Size(34, 23);
            this.buttonMarkAsNotFound.TabIndex = 4;
            this.buttonMarkAsNotFound.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.buttonMarkAsNotFound, "Пометить как не найденный");
            this.buttonMarkAsNotFound.UseVisualStyleBackColor = false;
            this.buttonMarkAsNotFound.Click += new System.EventHandler(this.buttonMarkAsNotFound_Click);
            // 
            // BoxInfoPanel
            // 
            this.BoxInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.BoxInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxInfoPanel.Location = new System.Drawing.Point(3, 43);
            this.BoxInfoPanel.Name = "BoxInfoPanel";
            this.BoxInfoPanel.Size = new System.Drawing.Size(324, 376);
            this.BoxInfoPanel.TabIndex = 3;
            this.BoxInfoPanel.Visible = false;
            // 
            // buttonAddToSeized
            // 
            this.buttonAddToSeized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddToSeized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToSeized.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonAddToSeized.FlatAppearance.BorderSize = 0;
            this.buttonAddToSeized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddToSeized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddToSeized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToSeized.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAddToSeized.IconColor = System.Drawing.Color.DimGray;
            this.buttonAddToSeized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddToSeized.IconSize = 20;
            this.buttonAddToSeized.Location = new System.Drawing.Point(3, 3);
            this.buttonAddToSeized.Name = "buttonAddToSeized";
            this.buttonAddToSeized.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.buttonAddToSeized.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.buttonAddToSeized.Size = new System.Drawing.Size(44, 23);
            this.buttonAddToSeized.TabIndex = 0;
            this.buttonAddToSeized.Tag = "82; 81; 87";
            this.buttonAddToSeized.UseVisualStyleBackColor = false;
            this.buttonAddToSeized.Click += new System.EventHandler(this.buttonAddToSeized_Click);
            // 
            // buttonClearSeizingBox
            // 
            this.buttonClearSeizingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearSeizingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearSeizingBox.EnteredColor = System.Drawing.Color.Red;
            this.buttonClearSeizingBox.FlatAppearance.BorderSize = 0;
            this.buttonClearSeizingBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearSeizingBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearSeizingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSeizingBox.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.buttonClearSeizingBox.IconColor = System.Drawing.Color.DimGray;
            this.buttonClearSeizingBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClearSeizingBox.IconSize = 20;
            this.buttonClearSeizingBox.Location = new System.Drawing.Point(553, 3);
            this.buttonClearSeizingBox.Name = "buttonClearSeizingBox";
            this.buttonClearSeizingBox.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.buttonClearSeizingBox.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.buttonClearSeizingBox.Size = new System.Drawing.Size(44, 23);
            this.buttonClearSeizingBox.TabIndex = 2;
            this.buttonClearSeizingBox.Tag = "82; 81; 87";
            this.buttonClearSeizingBox.UseVisualStyleBackColor = false;
            this.buttonClearSeizingBox.Click += new System.EventHandler(this.buttonClearSeizingBox_Click);
            // 
            // buttonSettingsForSeize
            // 
            this.buttonSettingsForSeize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettingsForSeize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettingsForSeize.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.buttonSettingsForSeize.FlatAppearance.BorderSize = 0;
            this.buttonSettingsForSeize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettingsForSeize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettingsForSeize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsForSeize.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.buttonSettingsForSeize.IconColor = System.Drawing.Color.DimGray;
            this.buttonSettingsForSeize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSettingsForSeize.IconSize = 20;
            this.buttonSettingsForSeize.Location = new System.Drawing.Point(603, 3);
            this.buttonSettingsForSeize.Name = "buttonSettingsForSeize";
            this.buttonSettingsForSeize.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Cascade;
            this.buttonSettingsForSeize.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.buttonSettingsForSeize.Size = new System.Drawing.Size(44, 23);
            this.buttonSettingsForSeize.TabIndex = 3;
            this.buttonSettingsForSeize.Tag = "82; 81; 87";
            this.buttonSettingsForSeize.UseVisualStyleBackColor = false;
            this.buttonSettingsForSeize.Click += new System.EventHandler(this.buttonSettingsForSeize_Click);
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
            this.grayButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.grayButton1.IconColor = System.Drawing.Color.DimGray;
            this.grayButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.grayButton1.IconSize = 20;
            this.grayButton1.Location = new System.Drawing.Point(308, 3);
            this.grayButton1.Name = "grayButton1";
            this.grayButton1.PermissionMode = WhereIsMyBox.Classes.PermissionMode.Monopoly;
            this.grayButton1.RequiredPermission = WhereIsMyBox.Classes.PermissionGroup.Admin;
            this.grayButton1.Size = new System.Drawing.Size(34, 23);
            this.grayButton1.TabIndex = 0;
            this.grayButton1.Tag = "82; 81; 87";
            this.toolTip1.SetToolTip(this.grayButton1, "Сохранить изменения");
            this.grayButton1.UseVisualStyleBackColor = false;
            // 
            // ListOfSeized
            // 
            this.ListOfSeized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ListOfSeized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfSeized.Location = new System.Drawing.Point(3, 43);
            this.ListOfSeized.Name = "ListOfSeized";
            this.ListOfSeized.Size = new System.Drawing.Size(650, 376);
            this.ListOfSeized.TabIndex = 3;
            // 
            // pageTitle1
            // 
            this.pageTitle1.Description = "Используйте этот раздел для того, чтобы найти или добавить к своему изъятию нужны" +
    "й вам короб.";
            this.pageTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTitle1.Location = new System.Drawing.Point(3, 3);
            this.pageTitle1.Name = "pageTitle1";
            this.pageTitle1.Size = new System.Drawing.Size(994, 74);
            this.pageTitle1.TabIndex = 3;
            this.pageTitle1.Title = "Движение коробов";
            // 
            // UC_Boxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "UC_Boxes";
            this.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutLeft.PerformLayout();
            this.tableFindTop.ResumeLayout(false);
            this.tableFindTop.PerformLayout();
            this.tableMicroActions.ResumeLayout(false);
            this.tableLayoutSeizedBoxes.ResumeLayout(false);
            this.tableLayoutSeizedBoxes.PerformLayout();
            this.tableAddToSeizedBoxes.ResumeLayout(false);
            this.tableAddToSeizedBoxes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private System.Windows.Forms.TableLayoutPanel tableFindTop;
        private FontAwesome.Sharp.IconButton buttonFind;
        private System.Windows.Forms.TextBox inputFind;
        private System.Windows.Forms.Label HelpTextFind;
        private FontAwesome.Sharp.IconButton buttonCancelFind;
        private System.Windows.Forms.TableLayoutPanel tableMicroActions;

        private System.Windows.Forms.ToolTip toolTip1;
        private Elements.UC_BoxInfo BoxInfoPanel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutSeizedBoxes;
        private Elements.GrayButton buttonAddBox;
        private Elements.GrayButton buttonShowMap;
        private Elements.GrayButton buttonShowQRCode;
        private Elements.GrayButton buttonComment;
        private Elements.GrayButton buttonMarkAsNotFound;
        private System.Windows.Forms.TableLayoutPanel tableAddToSeizedBoxes;
        private Elements.GrayButton buttonAddToSeized;
        private System.Windows.Forms.TextBox inputSeize;
        private Elements.GrayButton buttonClearSeizingBox;
        private Elements.GrayButton buttonSettingsForSeize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Elements.GrayButton grayButton1;
        private System.Windows.Forms.Label label2;
        private OneInstanceElements.UC_ListOfSeized ListOfSeized;
        private ReusableElements.PageTitle pageTitle1;
    }
}