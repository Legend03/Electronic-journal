
namespace Электронный_журнал
{
    partial class MenuTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.klassNameField = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Label();
            this.buttonMark = new System.Windows.Forms.Button();
            this.buttonTema = new System.Windows.Forms.Button();
            this.buttonChangeStudent = new System.Windows.Forms.Button();
            this.buttonChangeTeacher = new System.Windows.Forms.Button();
            this.buttonChangeSubject = new System.Windows.Forms.Button();
            this.klassField = new System.Windows.Forms.ComboBox();
            this.subjectNameField = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // klassNameField
            // 
            this.klassNameField.AutoSize = true;
            this.klassNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.klassNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klassNameField.ForeColor = System.Drawing.Color.Gray;
            this.klassNameField.Location = new System.Drawing.Point(145, 116);
            this.klassNameField.Name = "klassNameField";
            this.klassNameField.Size = new System.Drawing.Size(49, 19);
            this.klassNameField.TabIndex = 27;
            this.klassNameField.Text = "Класс";
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(474, -1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // buttonMark
            // 
            this.buttonMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMark.Location = new System.Drawing.Point(140, 208);
            this.buttonMark.Name = "buttonMark";
            this.buttonMark.Size = new System.Drawing.Size(230, 28);
            this.buttonMark.TabIndex = 30;
            this.buttonMark.Text = "Выставить оценку";
            this.buttonMark.UseVisualStyleBackColor = false;
            this.buttonMark.Click += new System.EventHandler(this.buttonMark_Click);
            this.buttonMark.MouseLeave += new System.EventHandler(this.buttonMark_MouseLeave);
            this.buttonMark.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMark_MouseMove);
            // 
            // buttonTema
            // 
            this.buttonTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTema.Location = new System.Drawing.Point(140, 254);
            this.buttonTema.Name = "buttonTema";
            this.buttonTema.Size = new System.Drawing.Size(230, 28);
            this.buttonTema.TabIndex = 31;
            this.buttonTema.Text = "Заполнить тему урока";
            this.buttonTema.UseVisualStyleBackColor = false;
            this.buttonTema.Click += new System.EventHandler(this.buttonTema_Click);
            this.buttonTema.MouseLeave += new System.EventHandler(this.buttonTema_MouseLeave);
            this.buttonTema.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonTema_MouseMove);
            // 
            // buttonChangeStudent
            // 
            this.buttonChangeStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChangeStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeStudent.Location = new System.Drawing.Point(140, 300);
            this.buttonChangeStudent.Name = "buttonChangeStudent";
            this.buttonChangeStudent.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeStudent.TabIndex = 32;
            this.buttonChangeStudent.Text = "Изменить данные учеников";
            this.buttonChangeStudent.UseVisualStyleBackColor = false;
            this.buttonChangeStudent.Click += new System.EventHandler(this.buttonChangeStudent_Click);
            this.buttonChangeStudent.MouseLeave += new System.EventHandler(this.buttonChangeStudent_MouseLeave);
            this.buttonChangeStudent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangeStudent_MouseMove);
            // 
            // buttonChangeTeacher
            // 
            this.buttonChangeTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChangeTeacher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeTeacher.Location = new System.Drawing.Point(140, 346);
            this.buttonChangeTeacher.Name = "buttonChangeTeacher";
            this.buttonChangeTeacher.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeTeacher.TabIndex = 33;
            this.buttonChangeTeacher.Text = "Изменить список учителей";
            this.buttonChangeTeacher.UseVisualStyleBackColor = false;
            this.buttonChangeTeacher.Click += new System.EventHandler(this.buttonChangeTeacher_Click);
            this.buttonChangeTeacher.MouseLeave += new System.EventHandler(this.buttonChangeTeacher_MouseLeave);
            this.buttonChangeTeacher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangeTeacher_MouseMove);
            // 
            // buttonChangeSubject
            // 
            this.buttonChangeSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChangeSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeSubject.Location = new System.Drawing.Point(140, 390);
            this.buttonChangeSubject.Name = "buttonChangeSubject";
            this.buttonChangeSubject.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeSubject.TabIndex = 34;
            this.buttonChangeSubject.Text = "Изменить данные предметов";
            this.buttonChangeSubject.UseVisualStyleBackColor = false;
            this.buttonChangeSubject.Click += new System.EventHandler(this.buttonChangeSubject_Click);
            this.buttonChangeSubject.MouseLeave += new System.EventHandler(this.buttonChangeSubject_MouseLeave);
            this.buttonChangeSubject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangeSubject_MouseMove);
            // 
            // klassField
            // 
            this.klassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klassField.FormattingEnabled = true;
            this.klassField.Location = new System.Drawing.Point(140, 112);
            this.klassField.Name = "klassField";
            this.klassField.Size = new System.Drawing.Size(230, 28);
            this.klassField.TabIndex = 35;
            this.klassField.Enter += new System.EventHandler(this.klassField_Enter);
            this.klassField.Leave += new System.EventHandler(this.klassField_Leave);
            // 
            // subjectNameField
            // 
            this.subjectNameField.AutoSize = true;
            this.subjectNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameField.ForeColor = System.Drawing.Color.Gray;
            this.subjectNameField.Location = new System.Drawing.Point(145, 164);
            this.subjectNameField.Name = "subjectNameField";
            this.subjectNameField.Size = new System.Drawing.Size(67, 19);
            this.subjectNameField.TabIndex = 38;
            this.subjectNameField.Text = "Предмет";
            // 
            // subjectField
            // 
            this.subjectField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectField.FormattingEnabled = true;
            this.subjectField.Location = new System.Drawing.Point(140, 161);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(230, 27);
            this.subjectField.TabIndex = 37;
            this.subjectField.Enter += new System.EventHandler(this.subjectField_Enter);
            this.subjectField.Leave += new System.EventHandler(this.subjectField_Leave);
            this.subjectField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subjectField_MouseDown);
            // 
            // MenuTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.subjectNameField);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.klassNameField);
            this.Controls.Add(this.buttonChangeSubject);
            this.Controls.Add(this.buttonChangeTeacher);
            this.Controls.Add(this.buttonChangeStudent);
            this.Controls.Add(this.buttonTema);
            this.Controls.Add(this.buttonMark);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klassField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuTeacher";
            this.Load += new System.EventHandler(this.MenuTeacher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTeacher_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label klassNameField;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Button buttonMark;
        private System.Windows.Forms.Button buttonTema;
        private System.Windows.Forms.Button buttonChangeStudent;
        private System.Windows.Forms.Button buttonChangeTeacher;
        private System.Windows.Forms.Button buttonChangeSubject;
        private System.Windows.Forms.ComboBox klassField;
        private System.Windows.Forms.Label subjectNameField;
        private System.Windows.Forms.ComboBox subjectField;
    }
}