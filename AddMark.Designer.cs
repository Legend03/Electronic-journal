
namespace Электронный_журнал
{
    partial class AddMark
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
            this.formName = new System.Windows.Forms.Label();
            this.studentField = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.studentFieldName = new System.Windows.Forms.Label();
            this.markName = new System.Windows.Forms.Label();
            this.markField = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.ForeColor = System.Drawing.Color.Black;
            this.formName.Location = new System.Drawing.Point(49, 26);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(247, 36);
            this.formName.TabIndex = 0;
            this.formName.Text = "Добавить оценку";
            // 
            // studentField
            // 
            this.studentField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentField.FormattingEnabled = true;
            this.studentField.Location = new System.Drawing.Point(70, 82);
            this.studentField.Name = "studentField";
            this.studentField.Size = new System.Drawing.Size(203, 27);
            this.studentField.TabIndex = 1;
            this.studentField.Enter += new System.EventHandler(this.studentField_Enter);
            this.studentField.Leave += new System.EventHandler(this.studentField_Leave);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(310, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // studentFieldName
            // 
            this.studentFieldName.AutoSize = true;
            this.studentFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentFieldName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentFieldName.ForeColor = System.Drawing.Color.Gray;
            this.studentFieldName.Location = new System.Drawing.Point(75, 85);
            this.studentFieldName.Name = "studentFieldName";
            this.studentFieldName.Size = new System.Drawing.Size(130, 19);
            this.studentFieldName.TabIndex = 31;
            this.studentFieldName.Text = "Фамилия ученика";
            // 
            // markName
            // 
            this.markName.AutoSize = true;
            this.markName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.markName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markName.ForeColor = System.Drawing.Color.Gray;
            this.markName.Location = new System.Drawing.Point(75, 201);
            this.markName.Name = "markName";
            this.markName.Size = new System.Drawing.Size(60, 19);
            this.markName.TabIndex = 33;
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
            this.markField.Location = new System.Drawing.Point(70, 198);
            this.markField.Name = "markField";
            this.markField.Size = new System.Drawing.Size(203, 27);
            this.markField.TabIndex = 32;
            this.markField.Enter += new System.EventHandler(this.mark_Enter);
            this.markField.Leave += new System.EventHandler(this.mark_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(93, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 35);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateField
            // 
            this.dateField.Enabled = false;
            this.dateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateField.Location = new System.Drawing.Point(70, 142);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(203, 26);
            this.dateField.TabIndex = 36;
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.studentFieldName);
            this.Controls.Add(this.markName);
            this.Controls.Add(this.markField);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.studentField);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMark";
            this.Activated += new System.EventHandler(this.AddMark_Activated);
            this.Load += new System.EventHandler(this.AddMark_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddMark_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.ComboBox studentField;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label studentFieldName;
        private System.Windows.Forms.Label markName;
        private System.Windows.Forms.ComboBox markField;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateField;
    }
}