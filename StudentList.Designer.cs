
namespace Электронный_журнал
{
    partial class StudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDeleteTema = new System.Windows.Forms.Button();
            this.ChangeField = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteTema
            // 
            this.buttonDeleteTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDeleteTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteTema.Location = new System.Drawing.Point(402, 397);
            this.buttonDeleteTema.Name = "buttonDeleteTema";
            this.buttonDeleteTema.Size = new System.Drawing.Size(160, 35);
            this.buttonDeleteTema.TabIndex = 47;
            this.buttonDeleteTema.Text = "Удалить";
            this.buttonDeleteTema.UseVisualStyleBackColor = false;
            this.buttonDeleteTema.Click += new System.EventHandler(this.buttonDeleteTema_Click);
            this.buttonDeleteTema.MouseLeave += new System.EventHandler(this.buttonDeleteTema_MouseLeave);
            this.buttonDeleteTema.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDeleteTema_MouseMove);
            // 
            // ChangeField
            // 
            this.ChangeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChangeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeField.Location = new System.Drawing.Point(226, 397);
            this.ChangeField.Name = "ChangeField";
            this.ChangeField.Size = new System.Drawing.Size(160, 35);
            this.ChangeField.TabIndex = 46;
            this.ChangeField.Text = "Изменить";
            this.ChangeField.UseVisualStyleBackColor = false;
            this.ChangeField.Click += new System.EventHandler(this.buttonAddTema_Click);
            this.ChangeField.MouseLeave += new System.EventHandler(this.ChangeField_MouseLeave);
            this.ChangeField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeField_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(776, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 44;
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
            this.formName.TabIndex = 43;
            this.formName.Text = "Электронный журнал";
            // 
            // studentTable
            // 
            this.studentTable.BackgroundColor = System.Drawing.Color.White;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentTable.Location = new System.Drawing.Point(190, 60);
            this.studentTable.Name = "studentTable";
            this.studentTable.ReadOnly = true;
            this.studentTable.Size = new System.Drawing.Size(401, 319);
            this.studentTable.TabIndex = 48;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::Электронный_журнал.Properties.Resources._8445624_left_return_arrow_icon;
            this.buttonBack.Location = new System.Drawing.Point(-1, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 30);
            this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBack.TabIndex = 45;
            this.buttonBack.TabStop = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            this.buttonBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonBack_MouseMove);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentTable);
            this.Controls.Add(this.buttonDeleteTema);
            this.Controls.Add(this.ChangeField);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteTema;
        private System.Windows.Forms.Button ChangeField;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.DataGridView studentTable;
    }
}