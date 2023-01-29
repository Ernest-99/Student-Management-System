
namespace Student_Management_System.PAL.User_Control
{
    partial class UserControlAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAttendance));
            this.dgvClass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAcademYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemestr = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDiscipline = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeColumns = false;
            this.dgvClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.ColumnHeadersHeight = 21;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClass.EnableHeadersVisualStyles = false;
            this.dgvClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dgvClass.Location = new System.Drawing.Point(123, 77);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowTemplate.Height = 26;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.ShowCellErrors = false;
            this.dgvClass.ShowEditingIcon = false;
            this.dgvClass.ShowRowErrors = false;
            this.dgvClass.Size = new System.Drawing.Size(705, 460);
            this.dgvClass.TabIndex = 7;
            this.dgvClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClass.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dgvClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClass.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvClass.ThemeStyle.ReadOnly = false;
            this.dgvClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClass.ThemeStyle.RowsStyle.Height = 26;
            this.dgvClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClass.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvClass_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_student";
            this.Column1.DividerWidth = 1;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 1;
            this.Column2.FillWeight = 15.22843F;
            this.Column2.HeaderText = "№";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "full_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.DividerWidth = 1;
            this.Column3.FillWeight = 222.1262F;
            this.Column3.HeaderText = "ФИО";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "status";
            this.Column4.FillWeight = 62.64536F;
            this.Column4.HeaderText = "Статус";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.dgvClass;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 151;
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
            this.cmbCourse.ItemsAppearance.Parent = this.cmbCourse;
            this.cmbCourse.Location = new System.Drawing.Point(250, 35);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.ShadowDecoration.Parent = this.cmbCourse;
            this.cmbCourse.Size = new System.Drawing.Size(65, 36);
            this.cmbCourse.TabIndex = 150;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
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
            this.cmbAcademYear.TabIndex = 149;
            this.cmbAcademYear.SelectedIndexChanged += new System.EventHandler(this.cmbAcademYear_SelectedIndexChanged);
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
            this.btnSave.TabIndex = 148;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 147;
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
            this.cmbSemestr.TabIndex = 146;
            this.cmbSemestr.SelectedIndexChanged += new System.EventHandler(this.cmbSemestr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(655, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 145;
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
            this.cmbGroup.TabIndex = 144;
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
            this.cmbDiscipline.TabIndex = 143;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(389, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Дисциплина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(120, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "Учебный год";
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Controls.Add(this.dgvClass);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(942, 555);
            this.Load += new System.EventHandler(this.UserControlAttendance_Load);
            this.Enter += new System.EventHandler(this.UserControlAttendance_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvClass;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCourse;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAcademYear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemestr;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGroup;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDiscipline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}
