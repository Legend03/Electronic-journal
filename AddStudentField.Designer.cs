
namespace Электронный_журнал
{
    partial class AddStudentField
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
            this.buttonClose = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.studentField = new System.Windows.Forms.ComboBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.cityField = new System.Windows.Forms.TextBox();
            this.studentNameField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(90, 264);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 35);
            this.buttonAdd.TabIndex = 43;
            this.buttonAdd.Text = "Изменить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(309, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.ForeColor = System.Drawing.Color.Black;
            this.formName.Location = new System.Drawing.Point(43, 27);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(256, 36);
            this.formName.TabIndex = 41;
            this.formName.Text = "Изменить данные";
            // 
            // studentField
            // 
            this.studentField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentField.FormattingEnabled = true;
            this.studentField.Location = new System.Drawing.Point(68, 106);
            this.studentField.Name = "studentField";
            this.studentField.Size = new System.Drawing.Size(203, 27);
            this.studentField.TabIndex = 44;
            this.studentField.Enter += new System.EventHandler(this.studentField_Enter);
            this.studentField.Leave += new System.EventHandler(this.studentField_Leave);
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateField.Location = new System.Drawing.Point(71, 151);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(200, 26);
            this.dateField.TabIndex = 45;
            // 
            // cityField
            // 
            this.cityField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityField.ForeColor = System.Drawing.Color.Gray;
            this.cityField.Location = new System.Drawing.Point(71, 200);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(200, 26);
            this.cityField.TabIndex = 46;
            this.cityField.Text = "Город";
            this.cityField.Enter += new System.EventHandler(this.cityField_Enter);
            this.cityField.Leave += new System.EventHandler(this.cityField_Leave);
            // 
            // studentNameField
            // 
            this.studentNameField.AutoSize = true;
            this.studentNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentNameField.ForeColor = System.Drawing.Color.Gray;
            this.studentNameField.Location = new System.Drawing.Point(74, 109);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(72, 19);
            this.studentNameField.TabIndex = 47;
            this.studentNameField.Text = "Фамилия";
            // 
            // AddStudentField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.studentNameField);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.studentField);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentField";
            this.Load += new System.EventHandler(this.AddStudentField_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddStudentField_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.ComboBox studentField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.Label studentNameField;
    }
}