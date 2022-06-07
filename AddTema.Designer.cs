
namespace Электронный_журнал
{
    partial class AddTema
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
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.temaField = new System.Windows.Forms.RichTextBox();
            this.kolHoursField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateField
            // 
            this.dateField.Enabled = false;
            this.dateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateField.Location = new System.Drawing.Point(70, 89);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(203, 26);
            this.dateField.TabIndex = 37;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(92, 271);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 35);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(309, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 39;
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
            this.formName.Location = new System.Drawing.Point(64, 25);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(215, 36);
            this.formName.TabIndex = 38;
            this.formName.Text = "Добавить тему";
            // 
            // temaField
            // 
            this.temaField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temaField.ForeColor = System.Drawing.Color.Gray;
            this.temaField.Location = new System.Drawing.Point(70, 133);
            this.temaField.Name = "temaField";
            this.temaField.Size = new System.Drawing.Size(203, 66);
            this.temaField.TabIndex = 41;
            this.temaField.Text = "Тема урока";
            this.temaField.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.temaField.Leave += new System.EventHandler(this.temaField_Leave);
            // 
            // kolHoursField
            // 
            this.kolHoursField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kolHoursField.ForeColor = System.Drawing.Color.Gray;
            this.kolHoursField.Location = new System.Drawing.Point(70, 216);
            this.kolHoursField.Name = "kolHoursField";
            this.kolHoursField.Size = new System.Drawing.Size(203, 26);
            this.kolHoursField.TabIndex = 42;
            this.kolHoursField.Text = "Количество часов";
            this.kolHoursField.Enter += new System.EventHandler(this.textBox1_Enter);
            this.kolHoursField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolHoursField_KeyPress);
            this.kolHoursField.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // AddTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(333, 340);
            this.Controls.Add(this.kolHoursField);
            this.Controls.Add(this.temaField);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.dateField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTema";
            this.Load += new System.EventHandler(this.AddTema_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTema_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label buttonClose;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.RichTextBox temaField;
        private System.Windows.Forms.TextBox kolHoursField;
    }
}