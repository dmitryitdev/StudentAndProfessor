namespace StudentAndProffessor
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblcmbSupervisor = new System.Windows.Forms.Label();
            this.btbAddStudent = new System.Windows.Forms.Button();
            this.lblStudentAverage = new System.Windows.Forms.Label();
            this.txtStudentAverage = new System.Windows.Forms.TextBox();
            this.lblStudentLastName2 = new System.Windows.Forms.Label();
            this.txtStudentLastName2 = new System.Windows.Forms.TextBox();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblProfessorAge = new System.Windows.Forms.Label();
            this.txtProfessorAge = new System.Windows.Forms.TextBox();
            this.lblProfessorPublication = new System.Windows.Forms.Label();
            this.txtProfessorPublication = new System.Windows.Forms.TextBox();
            this.btbAddProfessor = new System.Windows.Forms.Button();
            this.lblProfessorLastName2 = new System.Windows.Forms.Label();
            this.txtProfessorLastName2 = new System.Windows.Forms.TextBox();
            this.lblProfessorLastName = new System.Windows.Forms.Label();
            this.txtProfessorLastName = new System.Windows.Forms.TextBox();
            this.lblProfessorFirstName = new System.Windows.Forms.Label();
            this.txtProfessorFirstName = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbSupervisor);
            this.tabPage1.Controls.Add(this.lblcmbSupervisor);
            this.tabPage1.Controls.Add(this.btbAddStudent);
            this.tabPage1.Controls.Add(this.lblStudentAverage);
            this.tabPage1.Controls.Add(this.txtStudentAverage);
            this.tabPage1.Controls.Add(this.lblStudentLastName2);
            this.tabPage1.Controls.Add(this.txtStudentLastName2);
            this.tabPage1.Controls.Add(this.lblStudentLastName);
            this.tabPage1.Controls.Add(this.txtStudentLastName);
            this.tabPage1.Controls.Add(this.lblStudentFirstName);
            this.tabPage1.Controls.Add(this.txtStudentFirstName);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(20, 241);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(344, 28);
            this.cmbSupervisor.TabIndex = 18;
            // 
            // lblcmbSupervisor
            // 
            this.lblcmbSupervisor.AutoSize = true;
            this.lblcmbSupervisor.Location = new System.Drawing.Point(18, 217);
            this.lblcmbSupervisor.Name = "lblcmbSupervisor";
            this.lblcmbSupervisor.Size = new System.Drawing.Size(122, 20);
            this.lblcmbSupervisor.TabIndex = 10;
            this.lblcmbSupervisor.Text = "Руководитель:";
            // 
            // btbAddStudent
            // 
            this.btbAddStudent.Location = new System.Drawing.Point(122, 331);
            this.btbAddStudent.Name = "btbAddStudent";
            this.btbAddStudent.Size = new System.Drawing.Size(139, 47);
            this.btbAddStudent.TabIndex = 8;
            this.btbAddStudent.Text = "Добавить";
            this.btbAddStudent.UseVisualStyleBackColor = true;
            this.btbAddStudent.Click += new System.EventHandler(this.btbAddStudent_Click);
            // 
            // lblStudentAverage
            // 
            this.lblStudentAverage.AutoSize = true;
            this.lblStudentAverage.Location = new System.Drawing.Point(18, 167);
            this.lblStudentAverage.Name = "lblStudentAverage";
            this.lblStudentAverage.Size = new System.Drawing.Size(122, 20);
            this.lblStudentAverage.TabIndex = 7;
            this.lblStudentAverage.Text = "Средний балл:";
            // 
            // txtStudentAverage
            // 
            this.txtStudentAverage.Location = new System.Drawing.Point(249, 164);
            this.txtStudentAverage.Name = "txtStudentAverage";
            this.txtStudentAverage.Size = new System.Drawing.Size(118, 26);
            this.txtStudentAverage.TabIndex = 6;
            // 
            // lblStudentLastName2
            // 
            this.lblStudentLastName2.AutoSize = true;
            this.lblStudentLastName2.Location = new System.Drawing.Point(18, 115);
            this.lblStudentLastName2.Name = "lblStudentLastName2";
            this.lblStudentLastName2.Size = new System.Drawing.Size(87, 20);
            this.lblStudentLastName2.TabIndex = 5;
            this.lblStudentLastName2.Text = "Отчество:";
            // 
            // txtStudentLastName2
            // 
            this.txtStudentLastName2.Location = new System.Drawing.Point(109, 112);
            this.txtStudentLastName2.Name = "txtStudentLastName2";
            this.txtStudentLastName2.Size = new System.Drawing.Size(258, 26);
            this.txtStudentLastName2.TabIndex = 4;
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(17, 72);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(44, 20);
            this.lblStudentLastName.TabIndex = 3;
            this.lblStudentLastName.Text = "Имя:";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(108, 69);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(258, 26);
            this.txtStudentLastName.TabIndex = 2;
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(17, 28);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(85, 20);
            this.lblStudentFirstName.TabIndex = 1;
            this.lblStudentFirstName.Text = "Фамилия:";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(108, 25);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(258, 26);
            this.txtStudentFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPosition);
            this.tabPage2.Controls.Add(this.cmbPosition);
            this.tabPage2.Controls.Add(this.lblProfessorAge);
            this.tabPage2.Controls.Add(this.txtProfessorAge);
            this.tabPage2.Controls.Add(this.lblProfessorPublication);
            this.tabPage2.Controls.Add(this.txtProfessorPublication);
            this.tabPage2.Controls.Add(this.btbAddProfessor);
            this.tabPage2.Controls.Add(this.lblProfessorLastName2);
            this.tabPage2.Controls.Add(this.txtProfessorLastName2);
            this.tabPage2.Controls.Add(this.lblProfessorLastName);
            this.tabPage2.Controls.Add(this.txtProfessorLastName);
            this.tabPage2.Controls.Add(this.lblProfessorFirstName);
            this.tabPage2.Controls.Add(this.txtProfessorFirstName);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преподаватель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(18, 156);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(99, 20);
            this.lblPosition.TabIndex = 18;
            this.lblPosition.Text = "Должность:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(22, 180);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(344, 28);
            this.cmbPosition.TabIndex = 17;
            // 
            // lblProfessorAge
            // 
            this.lblProfessorAge.AutoSize = true;
            this.lblProfessorAge.Location = new System.Drawing.Point(18, 275);
            this.lblProfessorAge.Name = "lblProfessorAge";
            this.lblProfessorAge.Size = new System.Drawing.Size(76, 20);
            this.lblProfessorAge.TabIndex = 16;
            this.lblProfessorAge.Text = "Возраст:";
            // 
            // txtProfessorAge
            // 
            this.txtProfessorAge.Location = new System.Drawing.Point(249, 272);
            this.txtProfessorAge.Name = "txtProfessorAge";
            this.txtProfessorAge.Size = new System.Drawing.Size(118, 26);
            this.txtProfessorAge.TabIndex = 15;
            // 
            // lblProfessorPublication
            // 
            this.lblProfessorPublication.AutoSize = true;
            this.lblProfessorPublication.Location = new System.Drawing.Point(18, 230);
            this.lblProfessorPublication.Name = "lblProfessorPublication";
            this.lblProfessorPublication.Size = new System.Drawing.Size(104, 20);
            this.lblProfessorPublication.TabIndex = 14;
            this.lblProfessorPublication.Text = "Публикации:";
            // 
            // txtProfessorPublication
            // 
            this.txtProfessorPublication.Location = new System.Drawing.Point(249, 227);
            this.txtProfessorPublication.Name = "txtProfessorPublication";
            this.txtProfessorPublication.Size = new System.Drawing.Size(118, 26);
            this.txtProfessorPublication.TabIndex = 13;
            this.txtProfessorPublication.Text = "0";
            // 
            // btbAddProfessor
            // 
            this.btbAddProfessor.Location = new System.Drawing.Point(122, 331);
            this.btbAddProfessor.Name = "btbAddProfessor";
            this.btbAddProfessor.Size = new System.Drawing.Size(139, 47);
            this.btbAddProfessor.TabIndex = 12;
            this.btbAddProfessor.Text = "Добавить";
            this.btbAddProfessor.UseVisualStyleBackColor = true;
            this.btbAddProfessor.Click += new System.EventHandler(this.btbAddProfessor_Click);
            // 
            // lblProfessorLastName2
            // 
            this.lblProfessorLastName2.AutoSize = true;
            this.lblProfessorLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfessorLastName2.Location = new System.Drawing.Point(18, 115);
            this.lblProfessorLastName2.Name = "lblProfessorLastName2";
            this.lblProfessorLastName2.Size = new System.Drawing.Size(87, 20);
            this.lblProfessorLastName2.TabIndex = 11;
            this.lblProfessorLastName2.Text = "Отчество:";
            // 
            // txtProfessorLastName2
            // 
            this.txtProfessorLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProfessorLastName2.Location = new System.Drawing.Point(109, 112);
            this.txtProfessorLastName2.Name = "txtProfessorLastName2";
            this.txtProfessorLastName2.Size = new System.Drawing.Size(258, 26);
            this.txtProfessorLastName2.TabIndex = 10;
            // 
            // lblProfessorLastName
            // 
            this.lblProfessorLastName.AutoSize = true;
            this.lblProfessorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfessorLastName.Location = new System.Drawing.Point(17, 72);
            this.lblProfessorLastName.Name = "lblProfessorLastName";
            this.lblProfessorLastName.Size = new System.Drawing.Size(44, 20);
            this.lblProfessorLastName.TabIndex = 9;
            this.lblProfessorLastName.Text = "Имя:";
            // 
            // txtProfessorLastName
            // 
            this.txtProfessorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProfessorLastName.Location = new System.Drawing.Point(108, 69);
            this.txtProfessorLastName.Name = "txtProfessorLastName";
            this.txtProfessorLastName.Size = new System.Drawing.Size(258, 26);
            this.txtProfessorLastName.TabIndex = 8;
            // 
            // lblProfessorFirstName
            // 
            this.lblProfessorFirstName.AutoSize = true;
            this.lblProfessorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfessorFirstName.Location = new System.Drawing.Point(17, 28);
            this.lblProfessorFirstName.Name = "lblProfessorFirstName";
            this.lblProfessorFirstName.Size = new System.Drawing.Size(85, 20);
            this.lblProfessorFirstName.TabIndex = 7;
            this.lblProfessorFirstName.Text = "Фамилия:";
            // 
            // txtProfessorFirstName
            // 
            this.txtProfessorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProfessorFirstName.Location = new System.Drawing.Point(108, 25);
            this.txtProfessorFirstName.Name = "txtProfessorFirstName";
            this.txtProfessorFirstName.Size = new System.Drawing.Size(258, 26);
            this.txtProfessorFirstName.TabIndex = 6;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.Location = new System.Drawing.Point(327, 478);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(262, 47);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Вывести сведения";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(425, 52);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(423, 407);
            this.lstInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 537);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Студенты и преподаватели";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label lblcmbSupervisor;
        private System.Windows.Forms.Button btbAddStudent;
        private System.Windows.Forms.Label lblStudentAverage;
        private System.Windows.Forms.TextBox txtStudentAverage;
        private System.Windows.Forms.Label lblStudentLastName2;
        private System.Windows.Forms.TextBox txtStudentLastName2;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.Label lblStudentFirstName;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label lblProfessorLastName2;
        private System.Windows.Forms.TextBox txtProfessorLastName2;
        private System.Windows.Forms.Label lblProfessorLastName;
        private System.Windows.Forms.TextBox txtProfessorLastName;
        private System.Windows.Forms.Label lblProfessorFirstName;
        private System.Windows.Forms.TextBox txtProfessorFirstName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblProfessorAge;
        private System.Windows.Forms.TextBox txtProfessorAge;
        private System.Windows.Forms.Label lblProfessorPublication;
        private System.Windows.Forms.TextBox txtProfessorPublication;
        private System.Windows.Forms.Button btbAddProfessor;
        private System.Windows.Forms.ComboBox cmbSupervisor;
    }
}

