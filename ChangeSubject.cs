using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Электронный_журнал
{
    public partial class ChangeSubject : Form
    {
        public ChangeSubjectField form = new ChangeSubjectField();

        public ChangeSubject()
        {
            InitializeComponent();

            subjectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void subjectField_Enter(object sender, EventArgs e)
        {
            subjectName.Visible = false;
            subjectField.ForeColor = Color.Black;
        }

        private void subjectField_Leave(object sender, EventArgs e)
        {
            if (subjectField.Text == "")
            {
                subjectName.Visible = true;
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeSubjectField form2 = new ChangeSubjectField();
            form.Close();
            form2.Show();
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.Red;
            buttonClose.ForeColor = Color.White;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(255, 192, 0);
            buttonClose.ForeColor = Color.Red;
        }

        private void kolHours_Enter(object sender, EventArgs e)
        {
            if (kolHours.Text == "Количество часов")
            {
                kolHours.Text = null;
            }
            kolHours.ForeColor = Color.Black;
        }

        private void kolHours_Leave(object sender, EventArgs e)
        {
            if (kolHours.Text == "")
            {
                kolHours.Text = "Количество часов";
                kolHours.ForeColor = Color.Gray;
            }
        }

        private void ChangeSubject_Load(object sender, EventArgs e)
        {
            form.Show();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command2 = new MySqlCommand("SELECT subject from списокпредметов" + DataBank.KlassField, connection);

            MySqlDataReader myReader2 = command2.ExecuteReader();

            while (myReader2.Read())
            {
                string sName = myReader2.GetString("subject");
                subjectField.Items.Add(sName);
            }

            connection.Close();
        }

        private void ChangeSubject_Activated(object sender, EventArgs e)
        {
            formName.Focus();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (subjectField.Text == "" || kolHours.Text == "" || kolHours.Text == "Количество часов")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }    
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "UPDATE списокпредметов" + DataBank.KlassField + " SET kol_hours = '" + kolHours.Text + "' where subject = '" + subjectField.Text + "'";

            connection.Open();

            MySqlCommand command = new MySqlCommand(sel, connection);

            command.ExecuteNonQuery();
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Желаете изменить ещё?", "тема изменена!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
             
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                ChangeSubjectField form2 = new ChangeSubjectField();
                form.Close();
                form2.Show();
            }
        }

        private void subjectField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectName_Click(object sender, EventArgs e)
        {

        }

        private void formName_Click(object sender, EventArgs e)
        {

        }

        private void ChangeSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void ChangeSubject_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
