
namespace Электронный_журнал
{
    partial class ChangeMark
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
            this.studentFieldName = new System.Windows.Forms.Label();
            this.markName = new System.Windows.Forms.Label();
            this.markField = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.studentField = new System.Windows.Forms.ComboBox();
            this.formName = new System.Windows.Forms.Label();
            this.dateNameField = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentFieldName
            // 
            this.studentFieldName.AutoSize = true;
            this.studentFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentFieldName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentFieldName.ForeColor = System.Drawing.Color.Gray;
            this.studentFieldName.Location = new System.Drawing.Point(76, 84);
            this.studentFieldName.Name = "studentFieldName";
            this.studentFieldName.Size = new System.Drawing.Size(130, 19);
            this.studentFieldName.TabIndex = 37;
            this.studentFieldName.Text = "Фамилия ученика";
            this.studentFieldName.Click += new System.EventHandler(this.studentFieldName_Click);
            // 
            // markName
            // 
            this.markName.AutoSize = true;
            this.markName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markName.ForeColor = System.Drawing.Color.Gray;
            this.markName.Location = new System.Drawing.Point(76, 200);
            this.markName.Name = "markName";
            this.markName.Size = new System.Drawing.Size(60, 19);
            this.markName.TabIndex = 39;
            this.markName.Text = "Оценка";
            // 
            // markField
            // 
            this.markField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markField.FormattingEnabled = true;
            this.markField.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.markField.Location = new System.Drawing.Point(71, 197);
            this.markField.Name = "markField";
            this.markField.Size = new System.Drawing.Size(203, 27);
            this.markField.TabIndex = 38;
            this.markField.Enter += new System.EventHandler(this.mark_Enter);
            this.markField.Leave += new System.EventHandler(this.mark_Leave);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(311, -1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // studentField
            // 
            this.studentField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentField.FormattingEnabled = true;
            this.studentField.Location = new System.Drawing.Point(71, 81);
            this.studentField.Name = "studentField";
            this.studentField.Size = new System.Drawing.Size(203, 27);
            this.studentField.TabIndex = 35;
            this.studentField.SelectedIndexChanged += new System.EventHandler(this.studentField_SelectedIndexChanged);
            this.studentField.Enter += new System.EventHandler(this.studentField_Enter);
            this.studentField.Leave += new System.EventHandler(this.studentField_Leave);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.ForeColor = System.Drawing.Color.Black;
            this.formName.Location = new System.Drawing.Point(50, 25);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(251, 36);
            this.formName.TabIndex = 34;
            this.formName.Text = "Изменить оценку";
            this.formName.Click += new System.EventHandler(this.formName_Click);
            // 
            // dateNameField
            // 
            this.dateNameField.AutoSize = true;
            this.dateNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateNameField.ForeColor = System.Drawing.Color.Gray;
            this.dateNameField.Location = new System.Drawing.Point(76, 143);
            this.dateNameField.Name = "dateNameField";
            this.dateNameField.Size = new System.Drawing.Size(41, 19);
            this.dateNameField.TabIndex = 41;
            this.dateNameField.Text = "Дата";
            this.dateNameField.Click += new System.EventHandler(this.dateNameField_Click);
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.FormattingEnabled = true;
            this.dateField.Location = new System.Drawing.Point(71, 138);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(203, 27);
            this.dateField.TabIndex = 40;
            this.dateField.SelectedIndexChanged += new System.EventHandler(this.dateField_SelectedIndexChanged);
            this.dateField.Enter += new System.EventHandler(this.dateField_Enter);
            this.dateField.Leave += new System.EventHandler(this.dateField_Leave);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(93, 267);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(160, 35);
            this.buttonChange.TabIndex = 42;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // ChangeMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.dateNameField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.studentFieldName);
            this.Controls.Add(this.markName);
            this.Controls.Add(this.markField);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.studentField);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeMark";
            this.Activated += new System.EventHandler(this.ChangeMark_Activated);
            this.Load += new System.EventHandler(this.ChangeMark_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeMark_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentFieldName;
        private System.Windows.Forms.Label markName;
        private System.Windows.Forms.ComboBox markField;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.ComboBox studentField;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label dateNameField;
        private System.Windows.Forms.ComboBox dateField;
        private System.Windows.Forms.Button buttonChange;
    }
}