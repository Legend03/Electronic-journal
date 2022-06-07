
namespace Электронный_журнал
{
    partial class ChangeSubject
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.subjectName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.ComboBox();
            this.formName = new System.Windows.Forms.Label();
            this.kolHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(70, 214);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(160, 35);
            this.buttonChange.TabIndex = 47;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // subjectName
            // 
            this.subjectName.AutoSize = true;
            this.subjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectName.ForeColor = System.Drawing.Color.Gray;
            this.subjectName.Location = new System.Drawing.Point(57, 100);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(67, 19);
            this.subjectName.TabIndex = 46;
            this.subjectName.Text = "Предмет";
            this.subjectName.Click += new System.EventHandler(this.subjectName_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(292, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 45;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // subjectField
            // 
            this.subjectField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectField.FormattingEnabled = true;
            this.subjectField.Location = new System.Drawing.Point(52, 97);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(203, 27);
            this.subjectField.TabIndex = 44;
            this.subjectField.SelectedIndexChanged += new System.EventHandler(this.subjectField_SelectedIndexChanged);
            this.subjectField.Enter += new System.EventHandler(this.subjectField_Enter);
            this.subjectField.Leave += new System.EventHandler(this.subjectField_Leave);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.ForeColor = System.Drawing.Color.Black;
            this.formName.Location = new System.Drawing.Point(31, 26);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(256, 36);
            this.formName.TabIndex = 43;
            this.formName.Text = "Изменить данные";
            this.formName.Click += new System.EventHandler(this.formName_Click);
            // 
            // kolHours
            // 
            this.kolHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kolHours.ForeColor = System.Drawing.Color.Gray;
            this.kolHours.Location = new System.Drawing.Point(52, 149);
            this.kolHours.Name = "kolHours";
            this.kolHours.Size = new System.Drawing.Size(203, 26);
            this.kolHours.TabIndex = 48;
            this.kolHours.Text = "Количество часов";
            this.kolHours.Enter += new System.EventHandler(this.kolHours_Enter);
            this.kolHours.Leave += new System.EventHandler(this.kolHours_Leave);
            // 
            // ChangeSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(316, 297);
            this.Controls.Add(this.kolHours);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.subjectName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeSubject";
            this.Activated += new System.EventHandler(this.ChangeSubject_Activated);
            this.Load += new System.EventHandler(this.ChangeSubject_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeSubject_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label subjectName;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.ComboBox subjectField;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.TextBox kolHours;
    }
}