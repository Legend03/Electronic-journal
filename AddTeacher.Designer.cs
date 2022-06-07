
namespace Электронный_журнал
{
    partial class AddTeacher
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.teacherName = new System.Windows.Forms.Label();
            this.subjectName = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.teacherField = new System.Windows.Forms.ComboBox();
            this.formName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(87, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 35);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teacherName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherName.ForeColor = System.Drawing.Color.Gray;
            this.teacherName.Location = new System.Drawing.Point(73, 158);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(72, 19);
            this.teacherName.TabIndex = 39;
            this.teacherName.Text = "Фамилия";
            // 
            // subjectName
            // 
            this.subjectName.AutoSize = true;
            this.subjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectName.ForeColor = System.Drawing.Color.Gray;
            this.subjectName.Location = new System.Drawing.Point(73, 98);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(67, 19);
            this.subjectName.TabIndex = 41;
            this.subjectName.Text = "Предмет";
            // 
            // subjectField
            // 
            this.subjectField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectField.FormattingEnabled = true;
            this.subjectField.Location = new System.Drawing.Point(68, 95);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(203, 27);
            this.subjectField.TabIndex = 40;
            this.subjectField.SelectedIndexChanged += new System.EventHandler(this.subjectField_SelectedIndexChanged);
            this.subjectField.Enter += new System.EventHandler(this.subjectField_Enter);
            this.subjectField.Leave += new System.EventHandler(this.subjectField_Leave);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(309, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 38;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // teacherField
            // 
            this.teacherField.Enabled = false;
            this.teacherField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherField.FormattingEnabled = true;
            this.teacherField.Location = new System.Drawing.Point(68, 155);
            this.teacherField.Name = "teacherField";
            this.teacherField.Size = new System.Drawing.Size(203, 27);
            this.teacherField.TabIndex = 37;
            this.teacherField.Enter += new System.EventHandler(this.teacherField_Enter);
            this.teacherField.Leave += new System.EventHandler(this.teacherField_Leave);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.ForeColor = System.Drawing.Color.Black;
            this.formName.Location = new System.Drawing.Point(38, 26);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(259, 36);
            this.formName.TabIndex = 36;
            this.formName.Text = "Добавить учителя";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(333, 312);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.teacherField);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacher";
            this.Activated += new System.EventHandler(this.AddTeacher_Activated_1);
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTeacher_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Label subjectName;
        private System.Windows.Forms.ComboBox subjectField;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.ComboBox teacherField;
        private System.Windows.Forms.Label formName;
    }
}