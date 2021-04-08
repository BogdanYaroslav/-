
namespace Hospital.AddOrEditForm
{
    partial class AddOrdEditVisitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrdEditVisitForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.doctorBox = new System.Windows.Forms.TextBox();
            this.DoctorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PanelDoctor = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEployee = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.searchDoctorBox = new System.Windows.Forms.TextBox();
            this.viewProfile = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.removeSorted = new System.Windows.Forms.Button();
            this.DoctorGridView = new System.Windows.Forms.DataGridView();
            this.DoctorNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PanelDetailsPatient = new System.Windows.Forms.TableLayoutPanel();
            this.PersonalDataBox = new System.Windows.Forms.GroupBox();
            this.ViewPersonalDataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.patientBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.timeBox = new System.Windows.Forms.DateTimePicker();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorSplitContainer)).BeginInit();
            this.DoctorSplitContainer.Panel1.SuspendLayout();
            this.DoctorSplitContainer.Panel2.SuspendLayout();
            this.DoctorSplitContainer.SuspendLayout();
            this.PanelDoctor.SuspendLayout();
            this.groupBoxEployee.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorNavigator)).BeginInit();
            this.DoctorNavigator.SuspendLayout();
            this.PanelDetailsPatient.SuspendLayout();
            this.PersonalDataBox.SuspendLayout();
            this.ViewPersonalDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.doctorBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.DoctorSplitContainer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.createButton, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.idLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.timeBox, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // doctorBox
            // 
            this.doctorBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorBox.Location = new System.Drawing.Point(108, 95);
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.ReadOnly = true;
            this.doctorBox.Size = new System.Drawing.Size(194, 20);
            this.doctorBox.TabIndex = 27;
            // 
            // DoctorSplitContainer
            // 
            this.DoctorSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.DoctorSplitContainer, 2);
            this.DoctorSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorSplitContainer.Location = new System.Drawing.Point(308, 3);
            this.DoctorSplitContainer.Name = "DoctorSplitContainer";
            // 
            // DoctorSplitContainer.Panel1
            // 
            this.DoctorSplitContainer.Panel1.Controls.Add(this.PanelDoctor);
            // 
            // DoctorSplitContainer.Panel2
            // 
            this.DoctorSplitContainer.Panel2.Controls.Add(this.PanelDetailsPatient);
            this.DoctorSplitContainer.Panel2Collapsed = true;
            this.tableLayoutPanel2.SetRowSpan(this.DoctorSplitContainer, 6);
            this.DoctorSplitContainer.Size = new System.Drawing.Size(489, 444);
            this.DoctorSplitContainer.SplitterDistance = 238;
            this.DoctorSplitContainer.TabIndex = 26;
            this.DoctorSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.DoctorSplitContainer_SplitterMoved);
            // 
            // PanelDoctor
            // 
            this.PanelDoctor.AutoSize = true;
            this.PanelDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDoctor.ColumnCount = 1;
            this.PanelDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDoctor.Controls.Add(this.groupBoxEployee, 0, 0);
            this.PanelDoctor.Controls.Add(this.DoctorGridView, 0, 2);
            this.PanelDoctor.Controls.Add(this.DoctorNavigator, 0, 1);
            this.PanelDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDoctor.Location = new System.Drawing.Point(0, 0);
            this.PanelDoctor.Name = "PanelDoctor";
            this.PanelDoctor.RowCount = 3;
            this.PanelDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDoctor.Size = new System.Drawing.Size(489, 444);
            this.PanelDoctor.TabIndex = 0;
            // 
            // groupBoxEployee
            // 
            this.groupBoxEployee.AutoSize = true;
            this.groupBoxEployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxEployee.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxEployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxEployee.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBoxEployee.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEployee.Name = "groupBoxEployee";
            this.groupBoxEployee.Size = new System.Drawing.Size(483, 84);
            this.groupBoxEployee.TabIndex = 6;
            this.groupBoxEployee.TabStop = false;
            this.groupBoxEployee.Text = "Настройки отображения сотрудников";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchDoctorBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewProfile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Поиск(введите имя и/или фамилию)";
            // 
            // searchDoctorBox
            // 
            this.searchDoctorBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchDoctorBox.Location = new System.Drawing.Point(201, 3);
            this.searchDoctorBox.MaxLength = 100;
            this.searchDoctorBox.Name = "searchDoctorBox";
            this.searchDoctorBox.Size = new System.Drawing.Size(273, 20);
            this.searchDoctorBox.TabIndex = 5;
            this.searchDoctorBox.TextChanged += new System.EventHandler(this.searchDoctorBox_TextChanged);
            // 
            // viewProfile
            // 
            this.viewProfile.AutoSize = true;
            this.viewProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfile.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.viewProfile.Location = new System.Drawing.Point(3, 29);
            this.viewProfile.Name = "viewProfile";
            this.viewProfile.Size = new System.Drawing.Size(192, 17);
            this.viewProfile.TabIndex = 7;
            this.viewProfile.Text = "Показывать профиль";
            this.viewProfile.UseVisualStyleBackColor = true;
            this.viewProfile.CheckedChanged += new System.EventHandler(this.viewProfile_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.removeSorted, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(201, 29);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 33);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // removeSorted
            // 
            this.removeSorted.AutoSize = true;
            this.removeSorted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeSorted.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeSorted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.removeSorted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSorted.Location = new System.Drawing.Point(3, 3);
            this.removeSorted.Name = "removeSorted";
            this.removeSorted.Size = new System.Drawing.Size(144, 27);
            this.removeSorted.TabIndex = 12;
            this.removeSorted.Text = "Сбросить сортировку";
            this.removeSorted.UseVisualStyleBackColor = false;
            this.removeSorted.Click += new System.EventHandler(this.removeSorted_Click);
            // 
            // DoctorGridView
            // 
            this.DoctorGridView.AllowUserToAddRows = false;
            this.DoctorGridView.AllowUserToDeleteRows = false;
            this.DoctorGridView.AllowUserToResizeRows = false;
            this.DoctorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorGridView.Location = new System.Drawing.Point(3, 124);
            this.DoctorGridView.Name = "DoctorGridView";
            this.DoctorGridView.ReadOnly = true;
            this.DoctorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorGridView.Size = new System.Drawing.Size(483, 317);
            this.DoctorGridView.TabIndex = 5;
            this.DoctorGridView.SelectionChanged += new System.EventHandler(this.DoctorGridView_SelectionChanged);
            // 
            // DoctorNavigator
            // 
            this.DoctorNavigator.AddNewItem = null;
            this.DoctorNavigator.CountItem = this.bindingNavigatorCountItem;
            this.DoctorNavigator.DeleteItem = null;
            this.DoctorNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DoctorNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.DoctorNavigator.Location = new System.Drawing.Point(3, 93);
            this.DoctorNavigator.Margin = new System.Windows.Forms.Padding(3);
            this.DoctorNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DoctorNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DoctorNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DoctorNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DoctorNavigator.Name = "DoctorNavigator";
            this.DoctorNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.DoctorNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.DoctorNavigator.Size = new System.Drawing.Size(483, 25);
            this.DoctorNavigator.TabIndex = 4;
            this.DoctorNavigator.Text = "EmployeeNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.White;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PanelDetailsPatient
            // 
            this.PanelDetailsPatient.AutoSize = true;
            this.PanelDetailsPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDetailsPatient.ColumnCount = 1;
            this.PanelDetailsPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDetailsPatient.Controls.Add(this.PersonalDataBox, 0, 0);
            this.PanelDetailsPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetailsPatient.Location = new System.Drawing.Point(0, 0);
            this.PanelDetailsPatient.Name = "PanelDetailsPatient";
            this.PanelDetailsPatient.RowCount = 2;
            this.PanelDetailsPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PanelDetailsPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelDetailsPatient.Size = new System.Drawing.Size(96, 100);
            this.PanelDetailsPatient.TabIndex = 0;
            // 
            // PersonalDataBox
            // 
            this.PersonalDataBox.AutoSize = true;
            this.PersonalDataBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersonalDataBox.Controls.Add(this.ViewPersonalDataPanel);
            this.PersonalDataBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalDataBox.ForeColor = System.Drawing.Color.White;
            this.PersonalDataBox.Location = new System.Drawing.Point(3, 3);
            this.PersonalDataBox.Name = "PersonalDataBox";
            this.PersonalDataBox.Size = new System.Drawing.Size(90, 134);
            this.PersonalDataBox.TabIndex = 4;
            this.PersonalDataBox.TabStop = false;
            this.PersonalDataBox.Text = "Личные данные";
            // 
            // ViewPersonalDataPanel
            // 
            this.ViewPersonalDataPanel.AutoSize = true;
            this.ViewPersonalDataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewPersonalDataPanel.ColumnCount = 2;
            this.ViewPersonalDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ViewPersonalDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ViewPersonalDataPanel.Controls.Add(this.label12, 0, 0);
            this.ViewPersonalDataPanel.Controls.Add(this.label14, 0, 1);
            this.ViewPersonalDataPanel.Controls.Add(this.label15, 0, 2);
            this.ViewPersonalDataPanel.Controls.Add(this.label16, 0, 3);
            this.ViewPersonalDataPanel.Controls.Add(this.label17, 0, 4);
            this.ViewPersonalDataPanel.Controls.Add(this.nameLabel, 1, 0);
            this.ViewPersonalDataPanel.Controls.Add(this.phoneLabel, 1, 1);
            this.ViewPersonalDataPanel.Controls.Add(this.genderLabel, 1, 2);
            this.ViewPersonalDataPanel.Controls.Add(this.birthdayLabel, 1, 3);
            this.ViewPersonalDataPanel.Controls.Add(this.ageLabel, 1, 4);
            this.ViewPersonalDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPersonalDataPanel.ForeColor = System.Drawing.Color.DarkOrange;
            this.ViewPersonalDataPanel.Location = new System.Drawing.Point(3, 16);
            this.ViewPersonalDataPanel.Name = "ViewPersonalDataPanel";
            this.ViewPersonalDataPanel.RowCount = 5;
            this.ViewPersonalDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewPersonalDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewPersonalDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewPersonalDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewPersonalDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewPersonalDataPanel.Size = new System.Drawing.Size(84, 115);
            this.ViewPersonalDataPanel.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Имя";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Телефон";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Пол";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "День рождения";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 95);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Полных лет";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(120, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(1, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "label18";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(120, 26);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(1, 17);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "label20";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(120, 49);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(1, 17);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "label21";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayLabel.ForeColor = System.Drawing.Color.White;
            this.birthdayLabel.Location = new System.Drawing.Point(120, 72);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(3);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(1, 17);
            this.birthdayLabel.TabIndex = 11;
            this.birthdayLabel.Text = "label22";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(120, 95);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(1, 17);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "label23";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пациент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата визита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Врач";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время визита";
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createButton.BackColor = System.Drawing.Color.Transparent;
            this.createButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(3, 422);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(99, 25);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(108, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(194, 25);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(108, 3);
            this.idLabel.Margin = new System.Windows.Forms.Padding(3);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(194, 34);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "Добавляется\r\nавтоматически";
            // 
            // patientBox
            // 
            this.patientBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientBox.Location = new System.Drawing.Point(108, 121);
            this.patientBox.Name = "patientBox";
            this.patientBox.ReadOnly = true;
            this.patientBox.Size = new System.Drawing.Size(194, 20);
            this.patientBox.TabIndex = 23;
            // 
            // dateBox
            // 
            this.dateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateBox.Location = new System.Drawing.Point(108, 43);
            this.dateBox.Name = "dateBox";
            this.dateBox.ShowUpDown = true;
            this.dateBox.Size = new System.Drawing.Size(194, 20);
            this.dateBox.TabIndex = 28;
            // 
            // timeBox
            // 
            this.timeBox.CustomFormat = "HH : mm";
            this.timeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBox.Location = new System.Drawing.Point(108, 69);
            this.timeBox.Name = "timeBox";
            this.timeBox.ShowUpDown = true;
            this.timeBox.Size = new System.Drawing.Size(194, 20);
            this.timeBox.TabIndex = 29;
            // 
            // AddOrdEditVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddOrdEditVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.AddOrdEditVisitForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.DoctorSplitContainer.Panel1.ResumeLayout(false);
            this.DoctorSplitContainer.Panel1.PerformLayout();
            this.DoctorSplitContainer.Panel2.ResumeLayout(false);
            this.DoctorSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorSplitContainer)).EndInit();
            this.DoctorSplitContainer.ResumeLayout(false);
            this.PanelDoctor.ResumeLayout(false);
            this.PanelDoctor.PerformLayout();
            this.groupBoxEployee.ResumeLayout(false);
            this.groupBoxEployee.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorNavigator)).EndInit();
            this.DoctorNavigator.ResumeLayout(false);
            this.DoctorNavigator.PerformLayout();
            this.PanelDetailsPatient.ResumeLayout(false);
            this.PanelDetailsPatient.PerformLayout();
            this.PersonalDataBox.ResumeLayout(false);
            this.PersonalDataBox.PerformLayout();
            this.ViewPersonalDataPanel.ResumeLayout(false);
            this.ViewPersonalDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientBox;
        private System.Windows.Forms.SplitContainer DoctorSplitContainer;
        private System.Windows.Forms.TableLayoutPanel PanelDetailsPatient;
        private System.Windows.Forms.GroupBox PersonalDataBox;
        private System.Windows.Forms.TableLayoutPanel ViewPersonalDataPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TableLayoutPanel PanelDoctor;
        private System.Windows.Forms.BindingNavigator DoctorNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView DoctorGridView;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.BindingSource DoctorSource;
        private System.Windows.Forms.TextBox doctorBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.DateTimePicker timeBox;
        private System.Windows.Forms.GroupBox groupBoxEployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchDoctorBox;
        private System.Windows.Forms.CheckBox viewProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button removeSorted;
    }
}