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
    public partial class ChangeMark : Form
    {
        public Mark mark = new Mark();
        public ChangeMark()
        {
            InitializeComponent();

            studentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            markField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dateField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Mark mark2 = new Mark();
            mark.Close();
            mark2.Show();
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

        private void studentField_Enter(object sender, EventArgs e)
        {
            studentFieldName.Visible = false;
            studentField.ForeColor = Color.Black;
        }

        private void studentField_Leave(object sender, EventArgs e)
        {
            if (studentField.Text == "")
            {
                studentFieldName.Visible = true;
            }
        }

        private void ChangeMark_Activated(object sender, EventArgs e)
        {
            formName.Focus();
        }

        private void mark_Enter(object sender, EventArgs e)
        {
            markName.Visible = false;
            markField.ForeColor = Color.Black;
        }

        private void mark_Leave(object sender, EventArgs e)
        {
            if (markField.Text == "")
            {
                markName.Visible = true;
            }
        }

        private void dateField_Enter(object sender, EventArgs e)
        {
            dateNameField.Visible = false;
            dateField.ForeColor = Color.Black;
        }

        private void dateField_Leave(object sender, EventArgs e)
        {
            if (dateField.Text == "")
            {
                dateNameField.Visible = true;
            }
        }

        private void ChangeMark_Load(object sender, EventArgs e)
        {
            mark.Show();
            mark.Enabled = false;
            this.Show();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "Select * From " + DataBank.SubjectField + DataBank.KlassField;

            connection.Open();

            MySqlCommand command = new MySqlCommand(sel, connection);

            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                string sName = myReader.GetString("FIO");
                studentField.Items.Add(sName);
            }

            connection.Close();

            MySqlConnection connection2 = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=information_schema");

            string sel2 = "SELECT Column_name FROM COLUMNS WHERE TABLE_NAME = '" + DataBank.SubjectField + DataBank.KlassField + "' and COLUMN_NAME <> 'FIO'";

            connection2.Open();

            MySqlCommand command2 = new MySqlCommand(sel2, connection2);

            MySqlDataReader myReader2 = command2.ExecuteReader();

            while (myReader2.Read())
            {
                string sName2 = myReader2.GetString("Column_name");
                dateField.Items.Add(sName2);
            }

            connection2.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(studentField.Text == "" || dateField.Text == "" || markField.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "UPDATE " + DataBank.SubjectField + DataBank.KlassField + " SET " + dateField.Text + " = " + markField.Text + " WHERE FIO = '" + studentField.Text + "'";

            connection.Open();

            MySqlCommand command = new MySqlCommand(sel, connection);

            command.ExecuteNonQuery();
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Желаете изменить ещё оценку?", "Оценка изменена!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                Mark mark2 = new Mark();
                mark.Close();
                mark2.Show();
            }
        }

        private void ChangeMark_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void formName_Click(object sender, EventArgs e)
        {

        }

        private void studentField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentFieldName_Click(object sender, EventArgs e)
        {

        }

        private void dateNameField_Click(object sender, EventArgs e)
        {

        }

        private void ChangeMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
