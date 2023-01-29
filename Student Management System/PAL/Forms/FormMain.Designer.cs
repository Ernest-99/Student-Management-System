
namespace Student_Management_System.PAL.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonTimeTable = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAccounting = new System.Windows.Forms.Button();
            this.buttonDekan = new System.Windows.Forms.Button();
            this.buttonDepartmen = new System.Windows.Forms.Button();
            this.buttonVedom = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelBack = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.userControlReport1 = new Student_Management_System.PAL.User_Control.UserControlReport();
            this.userControlTimeTable1 = new Student_Management_System.PAL.User_Control.UserControlTimeTable();
            this.userControlAttendance1 = new Student_Management_System.PAL.User_Control.UserControlAttendance();
            this.userControlAccounting1 = new Student_Management_System.PAL.User_Control.UserControlAccounting();
            this.userControlDekan1 = new Student_Management_System.PAL.User_Control.UserControlDekan();
            this.userControlDepartmen1 = new Student_Management_System.PAL.User_Control.UserControlDepartmen();
            this.userControlVedom1 = new Student_Management_System.PAL.User_Control.UserControlVedom();
            this.userControlAddStudent1 = new Student_Management_System.PAL.User_Control.UserControlAddStudent();
            this.userControlAddUser1 = new Student_Management_System.PAL.User_Control.UserControlAddUser();
            this.userControlAddTeachers1 = new Student_Management_System.PAL.User_Control.UserControlAddTeachers();
            this.userControlDashboard1 = new Student_Management_System.PAL.User_Control.UserControlDashboard();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.buttonReports);
            this.panel1.Controls.Add(this.buttonTimeTable);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonAccounting);
            this.panel1.Controls.Add(this.buttonDekan);
            this.panel1.Controls.Add(this.buttonDepartmen);
            this.panel1.Controls.Add(this.buttonVedom);
            this.panel1.Controls.Add(this.buttonStudent);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonTeachers);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 720);
            this.panel1.TabIndex = 1;
            // 
            // buttonReports
            // 
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReports.ForeColor = System.Drawing.Color.White;
            this.buttonReports.Image = ((System.Drawing.Image)(resources.GetObject("buttonReports.Image")));
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.Location = new System.Drawing.Point(8, 650);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(250, 47);
            this.buttonReports.TabIndex = 11;
            this.buttonReports.Text = "Отчеты";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimeTable.FlatAppearance.BorderSize = 0;
            this.buttonTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTimeTable.ForeColor = System.Drawing.Color.White;
            this.buttonTimeTable.Image = ((System.Drawing.Image)(resources.GetObject("buttonTimeTable.Image")));
            this.buttonTimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimeTable.Location = new System.Drawing.Point(8, 603);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(250, 47);
            this.buttonTimeTable.TabIndex = 10;
            this.buttonTimeTable.Text = "Настройки";
            this.buttonTimeTable.UseVisualStyleBackColor = true;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Image = ((System.Drawing.Image)(resources.GetObject("buttonAttendance.Image")));
            this.buttonAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.Location = new System.Drawing.Point(8, 556);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(250, 47);
            this.buttonAttendance.TabIndex = 9;
            this.buttonAttendance.Text = "Посещаемость";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 698);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Development EniKa";
            // 
            // buttonAccounting
            // 
            this.buttonAccounting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccounting.FlatAppearance.BorderSize = 0;
            this.buttonAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccounting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAccounting.ForeColor = System.Drawing.Color.White;
            this.buttonAccounting.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccounting.Image")));
            this.buttonAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccounting.Location = new System.Drawing.Point(8, 509);
            this.buttonAccounting.Name = "buttonAccounting";
            this.buttonAccounting.Size = new System.Drawing.Size(250, 47);
            this.buttonAccounting.TabIndex = 8;
            this.buttonAccounting.Text = "Бухгалтерия";
            this.buttonAccounting.UseVisualStyleBackColor = true;
            this.buttonAccounting.Click += new System.EventHandler(this.buttonAccounting_Click);
            // 
            // buttonDekan
            // 
            this.buttonDekan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDekan.FlatAppearance.BorderSize = 0;
            this.buttonDekan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDekan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDekan.ForeColor = System.Drawing.Color.White;
            this.buttonDekan.Image = ((System.Drawing.Image)(resources.GetObject("buttonDekan.Image")));
            this.buttonDekan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDekan.Location = new System.Drawing.Point(8, 462);
            this.buttonDekan.Name = "buttonDekan";
            this.buttonDekan.Size = new System.Drawing.Size(250, 47);
            this.buttonDekan.TabIndex = 7;
            this.buttonDekan.Text = "Деканат";
            this.buttonDekan.UseVisualStyleBackColor = true;
            this.buttonDekan.Click += new System.EventHandler(this.buttonDekan_Click);
            // 
            // buttonDepartmen
            // 
            this.buttonDepartmen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartmen.FlatAppearance.BorderSize = 0;
            this.buttonDepartmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartmen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDepartmen.ForeColor = System.Drawing.Color.White;
            this.buttonDepartmen.Image = ((System.Drawing.Image)(resources.GetObject("buttonDepartmen.Image")));
            this.buttonDepartmen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepartmen.Location = new System.Drawing.Point(8, 415);
            this.buttonDepartmen.Name = "buttonDepartmen";
            this.buttonDepartmen.Size = new System.Drawing.Size(250, 47);
            this.buttonDepartmen.TabIndex = 6;
            this.buttonDepartmen.Text = "Кафедра";
            this.buttonDepartmen.UseVisualStyleBackColor = true;
            this.buttonDepartmen.Click += new System.EventHandler(this.buttonDepartmen_Click);
            // 
            // buttonVedom
            // 
            this.buttonVedom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVedom.FlatAppearance.BorderSize = 0;
            this.buttonVedom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVedom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonVedom.ForeColor = System.Drawing.Color.White;
            this.buttonVedom.Image = ((System.Drawing.Image)(resources.GetObject("buttonVedom.Image")));
            this.buttonVedom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVedom.Location = new System.Drawing.Point(8, 368);
            this.buttonVedom.Name = "buttonVedom";
            this.buttonVedom.Size = new System.Drawing.Size(250, 47);
            this.buttonVedom.TabIndex = 5;
            this.buttonVedom.Text = "Ведомость";
            this.buttonVedom.UseVisualStyleBackColor = true;
            this.buttonVedom.Click += new System.EventHandler(this.buttonVedom_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStudent.ForeColor = System.Drawing.Color.White;
            this.buttonStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudent.Image")));
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudent.Location = new System.Drawing.Point(8, 321);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(250, 47);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Студенты";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonUser.Image")));
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(8, 274);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(250, 47);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "Пользователи";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeachers.FlatAppearance.BorderSize = 0;
            this.buttonTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeachers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTeachers.ForeColor = System.Drawing.Color.White;
            this.buttonTeachers.Image = ((System.Drawing.Image)(resources.GetObject("buttonTeachers.Image")));
            this.buttonTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeachers.Location = new System.Drawing.Point(8, 227);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(250, 47);
            this.buttonTeachers.TabIndex = 2;
            this.buttonTeachers.Text = "Преподователи";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(8, 180);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(250, 47);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Обзор";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 540);
            this.panel4.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 47);
            this.panelSide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 180);
            this.panel2.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(53, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(154, 154);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelBack;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.btnClose);
            this.panelBack.Controls.Add(this.btnMinimize);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(942, 165);
            this.panelBack.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 6;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(894, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 0;
            this.guna2HtmlToolTip1.SetToolTip(this.btnClose, "Выйти из программы!");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BorderRadius = 6;
            this.btnMinimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(852, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(36, 29);
            this.btnMinimize.TabIndex = 0;
            this.guna2HtmlToolTip1.SetToolTip(this.btnMinimize, "Свернуть программу!");
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(6, 24);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(28, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(942, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(99, 48);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(28, 19);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "{?}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(99, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(28, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome:";
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // userControlReport1
            // 
            this.userControlReport1.BackColor = System.Drawing.Color.LightGray;
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlReport1.Location = new System.Drawing.Point(258, 165);
            this.userControlReport1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(942, 555);
            this.userControlReport1.TabIndex = 13;
            this.userControlReport1.Visible = false;
            // 
            // userControlTimeTable1
            // 
            this.userControlTimeTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTimeTable1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlTimeTable1.Location = new System.Drawing.Point(258, 165);
            this.userControlTimeTable1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlTimeTable1.Name = "userControlTimeTable1";
            this.userControlTimeTable1.Size = new System.Drawing.Size(942, 555);
            this.userControlTimeTable1.TabIndex = 12;
            this.userControlTimeTable1.Visible = false;
            // 
            // userControlAttendance1
            // 
            this.userControlAttendance1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAttendance1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlAttendance1.Location = new System.Drawing.Point(258, 165);
            this.userControlAttendance1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlAttendance1.Name = "userControlAttendance1";
            this.userControlAttendance1.Size = new System.Drawing.Size(942, 555);
            this.userControlAttendance1.TabIndex = 11;
            this.userControlAttendance1.Visible = false;
            // 
            // userControlAccounting1
            // 
            this.userControlAccounting1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAccounting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAccounting1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlAccounting1.Location = new System.Drawing.Point(258, 165);
            this.userControlAccounting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAccounting1.Name = "userControlAccounting1";
            this.userControlAccounting1.Size = new System.Drawing.Size(942, 555);
            this.userControlAccounting1.TabIndex = 10;
            this.userControlAccounting1.Visible = false;
            // 
            // userControlDekan1
            // 
            this.userControlDekan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDekan1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlDekan1.Location = new System.Drawing.Point(258, 165);
            this.userControlDekan1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDekan1.Name = "userControlDekan1";
            this.userControlDekan1.Size = new System.Drawing.Size(942, 555);
            this.userControlDekan1.TabIndex = 9;
            this.userControlDekan1.Visible = false;
            // 
            // userControlDepartmen1
            // 
            this.userControlDepartmen1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlDepartmen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDepartmen1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlDepartmen1.Location = new System.Drawing.Point(258, 165);
            this.userControlDepartmen1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDepartmen1.Name = "userControlDepartmen1";
            this.userControlDepartmen1.Size = new System.Drawing.Size(942, 555);
            this.userControlDepartmen1.TabIndex = 8;
            this.userControlDepartmen1.Visible = false;
            // 
            // userControlVedom1
            // 
            this.userControlVedom1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlVedom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlVedom1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.userControlVedom1.Location = new System.Drawing.Point(258, 165);
            this.userControlVedom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlVedom1.Name = "userControlVedom1";
            this.userControlVedom1.Size = new System.Drawing.Size(942, 555);
            this.userControlVedom1.TabIndex = 7;
            this.userControlVedom1.Visible = false;
            // 
            // userControlAddStudent1
            // 
            this.userControlAddStudent1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddStudent1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlAddStudent1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddStudent1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userControlAddStudent1.Name = "userControlAddStudent1";
            this.userControlAddStudent1.Size = new System.Drawing.Size(942, 555);
            this.userControlAddStudent1.TabIndex = 6;
            this.userControlAddStudent1.Visible = false;
            // 
            // userControlAddUser1
            // 
            this.userControlAddUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddUser1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlAddUser1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddUser1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAddUser1.Name = "userControlAddUser1";
            this.userControlAddUser1.Size = new System.Drawing.Size(942, 555);
            this.userControlAddUser1.TabIndex = 5;
            this.userControlAddUser1.Visible = false;
            // 
            // userControlAddTeachers1
            // 
            this.userControlAddTeachers1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAddTeachers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddTeachers1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlAddTeachers1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddTeachers1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAddTeachers1.Name = "userControlAddTeachers1";
            this.userControlAddTeachers1.Size = new System.Drawing.Size(942, 555);
            this.userControlAddTeachers1.TabIndex = 4;
            this.userControlAddTeachers1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.userControlDashboard1.Location = new System.Drawing.Point(258, 165);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(942, 555);
            this.userControlDashboard1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.userControlReport1);
            this.Controls.Add(this.userControlTimeTable1);
            this.Controls.Add(this.userControlAttendance1);
            this.Controls.Add(this.userControlAccounting1);
            this.Controls.Add(this.userControlDekan1);
            this.Controls.Add(this.userControlDepartmen1);
            this.Controls.Add(this.userControlVedom1);
            this.Controls.Add(this.userControlAddStudent1);
            this.Controls.Add(this.userControlAddUser1);
            this.Controls.Add(this.userControlAddTeachers1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTimeTable;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAccounting;
        private System.Windows.Forms.Button buttonDekan;
        private System.Windows.Forms.Button buttonDepartmen;
        private System.Windows.Forms.Button buttonVedom;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerDateAndTime;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button buttonReports;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private User_Control.UserControlDashboard userControlDashboard1;
        private User_Control.UserControlAddStudent userControlAddStudent1;
        private User_Control.UserControlAddUser userControlAddUser1;
        private User_Control.UserControlAddTeachers userControlAddTeachers1;
        private User_Control.UserControlVedom userControlVedom1;
        private User_Control.UserControlReport userControlReport1;
        private User_Control.UserControlTimeTable userControlTimeTable1;
        private User_Control.UserControlAttendance userControlAttendance1;
        private User_Control.UserControlAccounting userControlAccounting1;
        private User_Control.UserControlDekan userControlDekan1;
        private User_Control.UserControlDepartmen userControlDepartmen1;
        private System.Windows.Forms.Panel panelBack;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label3;
    }
}