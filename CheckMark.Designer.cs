
namespace Электронный_журнал
{
    partial class CheckMark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.markTable = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.ComboBox();
            this.subjectFieldName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.markTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // markTable
            // 
            this.markTable.BackgroundColor = System.Drawing.Color.White;
            this.markTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.markTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.markTable.Location = new System.Drawing.Point(0, 76);
            this.markTable.Name = "markTable";
            this.markTable.ReadOnly = true;
            this.markTable.Size = new System.Drawing.Size(801, 376);
            this.markTable.TabIndex = 40;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::Электронный_журнал.Properties.Resources._8445624_left_return_arrow_icon;
            this.buttonBack.Location = new System.Drawing.Point(-1, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 30);
            this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonBack.TabIndex = 39;
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
            this.buttonClose.TabIndex = 38;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.buttonclose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.Location = new System.Drawing.Point(106, -1);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(355, 42);
            this.formName.TabIndex = 37;
            this.formName.Text = "Электронный журнал";
            // 
            // subjectField
            // 
            this.subjectField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectField.FormattingEnabled = true;
            this.subjectField.Location = new System.Drawing.Point(29, 43);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(140, 27);
            this.subjectField.TabIndex = 41;
            this.subjectField.SelectedIndexChanged += new System.EventHandler(this.subjectField_SelectedIndexChanged);
            this.subjectField.Enter += new System.EventHandler(this.subjectField_Enter);
            this.subjectField.Leave += new System.EventHandler(this.subjectField_Leave);
            // 
            // subjectFieldName
            // 
            this.subjectFieldName.AutoSize = true;
            this.subjectFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectFieldName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectFieldName.ForeColor = System.Drawing.Color.Gray;
            this.subjectFieldName.Location = new System.Drawing.Point(34, 46);
            this.subjectFieldName.Name = "subjectFieldName";
            this.subjectFieldName.Size = new System.Drawing.Size(67, 19);
            this.subjectFieldName.TabIndex = 42;
            this.subjectFieldName.Text = "Предмет";
            // 
            // CheckMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectFieldName);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.markTable);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckMark";
            this.Load += new System.EventHandler(this.CheckMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView markTable;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.ComboBox subjectField;
        private System.Windows.Forms.Label subjectFieldName;
    }
}