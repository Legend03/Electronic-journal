
namespace Электронный_журнал
{
    partial class ChangeSubjectField
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteTeacher = new System.Windows.Forms.Button();
            this.addTeacher = new System.Windows.Forms.Button();
            this.subjectTable = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteTeacher
            // 
            this.deleteTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTeacher.Location = new System.Drawing.Point(403, 397);
            this.deleteTeacher.Name = "deleteTeacher";
            this.deleteTeacher.Size = new System.Drawing.Size(160, 35);
            this.deleteTeacher.TabIndex = 60;
            this.deleteTeacher.Text = "Удалить";
            this.deleteTeacher.UseVisualStyleBackColor = false;
            this.deleteTeacher.Click += new System.EventHandler(this.deleteTeacher_Click);
            // 
            // addTeacher
            // 
            this.addTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacher.Location = new System.Drawing.Point(216, 397);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(160, 35);
            this.addTeacher.TabIndex = 59;
            this.addTeacher.Text = "Изменить";
            this.addTeacher.UseVisualStyleBackColor = false;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            this.addTeacher.MouseLeave += new System.EventHandler(this.addTeacher_MouseLeave);
            this.addTeacher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addTeacher_MouseMove);
            // 
            // subjectTable
            // 
            this.subjectTable.BackgroundColor = System.Drawing.Color.White;
            this.subjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.subjectTable.Location = new System.Drawing.Point(190, 60);
            this.subjectTable.Name = "subjectTable";
            this.subjectTable.ReadOnly = true;
            this.subjectTable.Size = new System.Drawing.Size(401, 319);
            this.subjectTable.TabIndex = 58;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::Электронный_журнал.Properties.Resources._8445624_left_return_arrow_icon;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 30);
            this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBack.TabIndex = 57;
            this.buttonBack.TabStop = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            this.buttonBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonBack_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(776, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 56;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.Location = new System.Drawing.Point(129, -1);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(355, 42);
            this.formName.TabIndex = 55;
            this.formName.Text = "Электронный журнал";
            // 
            // ChangeSubjectField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteTeacher);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.subjectTable);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeSubjectField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeSubjectField";
            this.Load += new System.EventHandler(this.ChangeSubjectField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteTeacher;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.DataGridView subjectTable;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label formName;
    }
}