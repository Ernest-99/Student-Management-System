
namespace Student_Management_System.PAL.User_Control
{
    partial class UserControlVedom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlVedom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridViewReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemestr = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDiscipline = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cmbAcademYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.dataGridViewReport;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeColumns = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeight = 21;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dataGridViewReport.Location = new System.Drawing.Point(123, 77);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowTemplate.Height = 26;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.ShowCellErrors = false;
            this.dataGridViewReport.ShowEditingIcon = false;
            this.dataGridViewReport.ShowRowErrors = false;
            this.dataGridViewReport.Size = new System.Drawing.Size(705, 460);
            this.dataGridViewReport.TabIndex = 37;
            this.dataGridViewReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.dataGridViewReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dataGridViewReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Empty;
            this.dataGridViewReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewReport.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridViewReport.ThemeStyle.ReadOnly = false;
            this.dataGridViewReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReport.ThemeStyle.RowsStyle.Height = 26;
            this.dataGridViewReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReport.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReport_CellValueChanged);
            this.dataGridViewReport.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewReport_EditingControlShowing);
            this.dataGridViewReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewReport_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Семестр";
            // 
            // cmbSemestr
            // 
            this.cmbSemestr.BackColor = System.Drawing.Color.Transparent;
            this.cmbSemestr.BorderRadius = 6;
            this.cmbSemestr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestr.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSemestr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSemestr.FocusedState.Parent = this.cmbSemestr;
            this.cmbSemestr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSemestr.ForeColor = System.Drawing.Color.Black;
            this.cmbSemestr.HoverState.Parent = this.cmbSemestr;
            this.cmbSemestr.ItemHeight = 30;
            this.cmbSemestr.ItemsAppearance.Parent = this.cmbSemestr;
            this.cmbSemestr.Location = new System.Drawing.Point(321, 35);
            this.cmbSemestr.Name = "cmbSemestr";
            this.cmbSemestr.ShadowDecoration.Parent = this.cmbSemestr;
            this.cmbSemestr.Size = new System.Drawing.Size(65, 36);
            this.cmbSemestr.TabIndex = 44;
            this.cmbSemestr.SelectedIndexChanged += new System.EventHandler(this.cmbSemestr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(655, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Группа";
            // 
            // cmbGroup
            // 
            this.cmbGroup.BackColor = System.Drawing.Color.Transparent;
            this.cmbGroup.BorderRadius = 6;
            this.cmbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGroup.FocusedState.Parent = this.cmbGroup;
            this.cmbGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbGroup.HoverState.Parent = this.cmbGroup;
            this.cmbGroup.ItemHeight = 30;
            this.cmbGroup.ItemsAppearance.Parent = this.cmbGroup;
            this.cmbGroup.Location = new System.Drawing.Point(658, 35);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.ShadowDecoration.Parent = this.cmbGroup;
            this.cmbGroup.Size = new System.Drawing.Size(128, 36);
            this.cmbGroup.TabIndex = 42;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.BackColor = System.Drawing.Color.Transparent;
            this.cmbDiscipline.BorderRadius = 6;
            this.cmbDiscipline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscipline.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDiscipline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDiscipline.FocusedState.Parent = this.cmbDiscipline;
            this.cmbDiscipline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiscipline.ForeColor = System.Drawing.Color.Black;
            this.cmbDiscipline.HoverState.Parent = this.cmbDiscipline;
            this.cmbDiscipline.ItemHeight = 30;
            this.cmbDiscipline.ItemsAppearance.Parent = this.cmbDiscipline;
            this.cmbDiscipline.Location = new System.Drawing.Point(392, 35);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.ShadowDecoration.Parent = this.cmbDiscipline;
            this.cmbDiscipline.Size = new System.Drawing.Size(260, 36);
            this.cmbDiscipline.TabIndex = 41;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(389, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Дисциплина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(120, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Учебный год";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 6;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(792, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.TabIndex = 46;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAcademYear
            // 
            this.cmbAcademYear.BackColor = System.Drawing.Color.Transparent;
            this.cmbAcademYear.BorderRadius = 6;
            this.cmbAcademYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAcademYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademYear.FillColor = System.Drawing.Color.DodgerBlue;
            this.cmbAcademYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAcademYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAcademYear.FocusedState.Parent = this.cmbAcademYear;
            this.cmbAcademYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAcademYear.ForeColor = System.Drawing.Color.White;
            this.cmbAcademYear.HoverState.Parent = this.cmbAcademYear;
            this.cmbAcademYear.ItemHeight = 30;
            this.cmbAcademYear.ItemsAppearance.Parent = this.cmbAcademYear;
            this.cmbAcademYear.Location = new System.Drawing.Point(123, 35);
            this.cmbAcademYear.Name = "cmbAcademYear";
            this.cmbAcademYear.ShadowDecoration.Parent = this.cmbAcademYear;
            this.cmbAcademYear.Size = new System.Drawing.Size(121, 36);
            this.cmbAcademYear.TabIndex = 137;
            this.cmbAcademYear.SelectedIndexChanged += new System.EventHandler(this.cmbAcademYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Курс";
            // 
            // cmbCourse
            // 
            this.cmbCourse.BackColor = System.Drawing.Color.Transparent;
            this.cmbCourse.BorderRadius = 6;
            this.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourse.FocusedState.Parent = this.cmbCourse;
            this.cmbCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCourse.ForeColor = System.Drawing.Color.Black;
            this.cmbCourse.HoverState.Parent = this.cmbCourse;
            this.cmbCourse.ItemHeight = 30;
            this.cmbCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCourse.ItemsAppearance.Parent = this.cmbCourse;
            this.cmbCourse.Location = new System.Drawing.Point(250, 35);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.ShadowDecoration.Parent = this.cmbCourse;
            this.cmbCourse.Size = new System.Drawing.Size(65, 36);
            this.cmbCourse.TabIndex = 139;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(763, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 25);
            this.dateTimePicker1.TabIndex = 141;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 25, 16, 15, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "id_student";
            this.Column0.FillWeight = 84.56415F;
            this.Column0.HeaderText = "id";
            this.Column0.Name = "Column0";
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column0.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "№";
            this.Column1.DividerWidth = 1;
            this.Column1.FillWeight = 30.82786F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "full_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.DividerWidth = 1;
            this.Column2.FillWeight = 234.104F;
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "module1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.DividerWidth = 1;
            this.Column3.FillWeight = 85.59427F;
            this.Column3.HeaderText = "Модуль 1";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "module2";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.DividerWidth = 1;
            this.Column4.FillWeight = 85.59427F;
            this.Column4.HeaderText = "Модуль 2";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "common_module";
            this.Column5.DividerWidth = 1;
            this.Column5.FillWeight = 93.72121F;
            this.Column5.HeaderText = "Общий балл";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "grade";
            this.Column6.FillWeight = 85.59427F;
            this.Column6.HeaderText = "Оценка";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserControlVedom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbAcademYear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSemestr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.cmbDiscipline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewReport);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlVedom";
            this.Size = new System.Drawing.Size(942, 555);
            this.Load += new System.EventHandler(this.UserControlReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReport;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemestr;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGroup;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDiscipline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAcademYear;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
