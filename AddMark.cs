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
    public partial class AddMark : Form
    {
        public Mark mark = new Mark();

        public AddMark()
        {
            InitializeComponent();

            studentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            markField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dateField.Format = DateTimePickerFormat.Custom;
            dateField.CustomFormat = "dd_MM";
        }

        

        private void AddMark_Load(object sender, EventArgs e)
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

        private void AddMark_Activated(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (studentField.Text == "" || markField.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            try
            {
                string s = "SELECT COUNT(" + dateField.Text + ") FROM " + DataBank.SubjectField + DataBank.KlassField + " WHERE FIO = '" + studentField.Text + "' and " + dateField.Text + " = ''";

                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

                connection.Open();

                MySqlCommand command = new MySqlCommand(s, connection);

                MySqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.GetInt32(0) == 0)
                    {
                        MessageBox.Show("Оценка уже стоит!");
                        return;
                    }
                }

                connection.Close();
                                
                try
                {
                    string sel = "ALTER TABLE " + DataBank.SubjectField + DataBank.KlassField + " ADD COLUMN " + dateField.Text + " VARCHAR (5) NOT NULL";

                    connection.Open();

                    MySqlCommand command1 = new MySqlCommand(sel, connection);

                    command1.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();

                    string sel2 = "Insert Into " + DataBank.SubjectField + DataBank.KlassField + "(" + dateField.Text + ")" + "Values(" + dateField.Text + ") where FIO = " + studentField.Text;

                    MySqlCommand command2 = new MySqlCommand(sel2, connection);

                    command2.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Оценка добавлена!");
                }
                catch
                {
                    string sel3 = "UPDATE " + DataBank.SubjectField + DataBank.KlassField + " SET " + dateField.Text + " = " + markField.Text + " WHERE FIO = '" + studentField.Text + "'";

                    MySqlCommand command3 = new MySqlCommand(sel3, connection);

                    command3.ExecuteNonQuery();
                    connection.Close();

                    DialogResult dialogResult = MessageBox.Show("Желаете выставить ещё оценку?", "Оценка выставлена!", MessageBoxButtons.YesNo);

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
            }
            catch
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

                    string sel = "ALTER TABLE " + DataBank.SubjectField + DataBank.KlassField + " ADD COLUMN " + dateField.Text + " VARCHAR (5) NOT NULL";

                    connection.Open();

                    MySqlCommand command1 = new MySqlCommand(sel, connection);

                    command1.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();

                    string sel2 = "Insert Into " + DataBank.SubjectField + DataBank.KlassField + "(" + dateField.Text + ")" + "Values(" + dateField.Text + ") where FIO = " + studentField.Text;

                    MySqlCommand command2 = new MySqlCommand(sel2, connection);

                    command2.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Оценка добавлена!");
                }
                catch
                {
                    MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

                    string sel3 = "UPDATE " + DataBank.SubjectField + DataBank.KlassField + " SET " + dateField.Text + " = " + markField.Text + " WHERE FIO = '" + studentField.Text + "'";

                    connection.Open();

                    MySqlCommand command3 = new MySqlCommand(sel3, connection);

                    command3.ExecuteNonQuery();
                    connection.Close();

                    DialogResult dialogResult = MessageBox.Show("Желаете выставить ещё оценку?", "Оценка выставлена!", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Mark mark2 = new Mark();
                        mark.Close();
                        mark2.Show();
                        mark2.Enabled = false;
                        this.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                        mark.Show();
                    }
                }
            }
        }

        private void AddMark_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

    }
}
