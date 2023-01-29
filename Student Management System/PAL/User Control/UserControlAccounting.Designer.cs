
namespace Student_Management_System.PAL.User_Control
{
    partial class UserControlAccounting
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaculty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDepartmen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSpeciality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGroup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudent = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaySum = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 191;
            this.label3.Text = "Курс:";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Animated = true;
            this.txtSearchStudent.BorderRadius = 6;
            this.txtSearchStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStudent.DefaultText = "";
            this.txtSearchStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStudent.DisabledState.Parent = this.txtSearchStudent;
            this.txtSearchStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStudent.FocusedState.Parent = this.txtSearchStudent;
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStudent.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStudent.HoverState.Parent = this.txtSearchStudent;
            this.txtSearchStudent.Location = new System.Drawing.Point(113, 35);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.PasswordChar = '\0';
            this.txtSearchStudent.PlaceholderText = "Поиск...";
            this.txtSearchStudent.SelectedText = "";
            this.txtSearchStudent.ShadowDecoration.Parent = this.txtSearchStudent;
            this.txtSearchStudent.Size = new System.Drawing.Size(257, 36);
            this.txtSearchStudent.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchStudent.TabIndex = 192;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
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
            this.cmbCourse.Location = new System.Drawing.Point(42, 35);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.ShadowDecoration.Parent = this.cmbCourse;
            this.cmbCourse.Size = new System.Drawing.Size(65, 36);
            this.cmbCourse.TabIndex = 190;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 6;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.DisabledState.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Location = new System.Drawing.Point(407, 485);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(102, 36);
            this.btnPay.TabIndex = 193;
            this.btnPay.Text = "Оплатить";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.ItemHeight = 17;
            this.listBoxStudent.Location = new System.Drawing.Point(42, 77);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(328, 446);
            this.listBoxStudent.TabIndex = 194;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 195;
            this.label2.Text = "Поиск:";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Animated = true;
            this.txtFaculty.BorderRadius = 6;
            this.txtFaculty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaculty.DefaultText = "";
            this.txtFaculty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFaculty.DisabledState.Parent = this.txtFaculty;
            this.txtFaculty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFaculty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFaculty.FocusedState.Parent = this.txtFaculty;
            this.txtFaculty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFaculty.ForeColor = System.Drawing.Color.Black;
            this.txtFaculty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFaculty.HoverState.Parent = this.txtFaculty;
            this.txtFaculty.Location = new System.Drawing.Point(407, 165);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.PasswordChar = '\0';
            this.txtFaculty.PlaceholderText = "Факультет";
            this.txtFaculty.ReadOnly = true;
            this.txtFaculty.SelectedText = "";
            this.txtFaculty.ShadowDecoration.Parent = this.txtFaculty;
            this.txtFaculty.Size = new System.Drawing.Size(257, 36);
            this.txtFaculty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFaculty.TabIndex = 196;
            // 
            // txtDepartmen
            // 
            this.txtDepartmen.Animated = true;
            this.txtDepartmen.BorderRadius = 6;
            this.txtDepartmen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartmen.DefaultText = "";
            this.txtDepartmen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDepartmen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDepartmen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepartmen.DisabledState.Parent = this.txtDepartmen;
            this.txtDepartmen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepartmen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepartmen.FocusedState.Parent = this.txtDepartmen;
            this.txtDepartmen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDepartmen.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepartmen.HoverState.Parent = this.txtDepartmen;
            this.txtDepartmen.Location = new System.Drawing.Point(407, 229);
            this.txtDepartmen.Name = "txtDepartmen";
            this.txtDepartmen.PasswordChar = '\0';
            this.txtDepartmen.PlaceholderText = "Кафедра";
            this.txtDepartmen.ReadOnly = true;
            this.txtDepartmen.SelectedText = "";
            this.txtDepartmen.ShadowDecoration.Parent = this.txtDepartmen;
            this.txtDepartmen.Size = new System.Drawing.Size(257, 36);
            this.txtDepartmen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDepartmen.TabIndex = 197;
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Animated = true;
            this.txtSpeciality.BorderRadius = 6;
            this.txtSpeciality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpeciality.DefaultText = "";
            this.txtSpeciality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSpeciality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSpeciality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpeciality.DisabledState.Parent = this.txtSpeciality;
            this.txtSpeciality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpeciality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpeciality.FocusedState.Parent = this.txtSpeciality;
            this.txtSpeciality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpeciality.ForeColor = System.Drawing.Color.Black;
            this.txtSpeciality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpeciality.HoverState.Parent = this.txtSpeciality;
            this.txtSpeciality.Location = new System.Drawing.Point(407, 293);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.PasswordChar = '\0';
            this.txtSpeciality.PlaceholderText = "Специальность";
            this.txtSpeciality.ReadOnly = true;
            this.txtSpeciality.SelectedText = "";
            this.txtSpeciality.ShadowDecoration.Parent = this.txtSpeciality;
            this.txtSpeciality.Size = new System.Drawing.Size(257, 36);
            this.txtSpeciality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSpeciality.TabIndex = 198;
            // 
            // txtGroup
            // 
            this.txtGroup.Animated = true;
            this.txtGroup.BorderRadius = 6;
            this.txtGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroup.DefaultText = "";
            this.txtGroup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroup.DisabledState.Parent = this.txtGroup;
            this.txtGroup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroup.FocusedState.Parent = this.txtGroup;
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGroup.ForeColor = System.Drawing.Color.Black;
            this.txtGroup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroup.HoverState.Parent = this.txtGroup;
            this.txtGroup.Location = new System.Drawing.Point(407, 357);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.PasswordChar = '\0';
            this.txtGroup.PlaceholderText = "Группа";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.SelectedText = "";
            this.txtGroup.ShadowDecoration.Parent = this.txtGroup;
            this.txtGroup.Size = new System.Drawing.Size(257, 36);
            this.txtGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGroup.TabIndex = 199;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(404, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 200;
            this.label4.Text = "Кафедра:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(404, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 201;
            this.label5.Text = "Специальность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(404, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 202;
            this.label6.Text = "Группа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(404, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 203;
            this.label7.Text = "Факультет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(404, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 205;
            this.label1.Text = "Студент:";
            // 
            // txtStudent
            // 
            this.txtStudent.Animated = true;
            this.txtStudent.BorderRadius = 6;
            this.txtStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudent.DefaultText = "";
            this.txtStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudent.DisabledState.Parent = this.txtStudent;
            this.txtStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudent.FocusedState.Parent = this.txtStudent;
            this.txtStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudent.ForeColor = System.Drawing.Color.Black;
            this.txtStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudent.HoverState.Parent = this.txtStudent;
            this.txtStudent.Location = new System.Drawing.Point(407, 101);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PasswordChar = '\0';
            this.txtStudent.PlaceholderText = "Студент";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.SelectedText = "";
            this.txtStudent.ShadowDecoration.Parent = this.txtStudent;
            this.txtStudent.Size = new System.Drawing.Size(257, 36);
            this.txtStudent.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtStudent.TabIndex = 204;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(404, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 15);
            this.label8.TabIndex = 207;
            this.label8.Text = "Вносимая сумма (сом):";
            // 
            // txtPaySum
            // 
            this.txtPaySum.Animated = true;
            this.txtPaySum.BorderRadius = 6;
            this.txtPaySum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaySum.DefaultText = "";
            this.txtPaySum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaySum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaySum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaySum.DisabledState.Parent = this.txtPaySum;
            this.txtPaySum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaySum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaySum.FocusedState.Parent = this.txtPaySum;
            this.txtPaySum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaySum.ForeColor = System.Drawing.Color.Black;
            this.txtPaySum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaySum.HoverState.Parent = this.txtPaySum;
            this.txtPaySum.Location = new System.Drawing.Point(407, 421);
            this.txtPaySum.Name = "txtPaySum";
            this.txtPaySum.PasswordChar = '\0';
            this.txtPaySum.PlaceholderText = "Вносимая сумма";
            this.txtPaySum.SelectedText = "";
            this.txtPaySum.ShadowDecoration.Parent = this.txtPaySum;
            this.txtPaySum.Size = new System.Drawing.Size(257, 36);
            this.txtPaySum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPaySum.TabIndex = 206;
            // 
            // UserControlAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPaySum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtSpeciality);
            this.Controls.Add(this.txtDepartmen);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCourse);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAccounting";
            this.Size = new System.Drawing.Size(942, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStudent;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCourse;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFaculty;
        private Guna.UI2.WinForms.Guna2TextBox txtDepartmen;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeciality;
        private Guna.UI2.WinForms.Guna2TextBox txtGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtStudent;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPaySum;
    }
}
