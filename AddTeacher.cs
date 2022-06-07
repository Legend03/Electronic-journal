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
    public partial class AddTeacher : Form
    {
        public TeacherList list = new TeacherList();

        public AddTeacher()
        {
            InitializeComponent();

            teacherField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            subjectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            list.Close();
            TeacherList list2 = new TeacherList();
            list2.Show();
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

        private void teacherField_Enter(object sender, EventArgs e)
        {
            teacherName.Visible = false;
            teacherField.ForeColor = Color.Black;
        }

        private void teacherField_Leave(object sender, EventArgs e)
        {
            if (teacherField.Text == "")
            {
                teacherName.Visible = true;
            }
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

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            list.Show();
            list.Enabled = false;
            this.Show();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command2 = new MySqlCommand("SELECT `subj` from `teacher_keys`", connection);

            MySqlDataReader myReader2 = command2.ExecuteReader();

            while (myReader2.Read())
            {
                string sName = myReader2.GetString("subj");
                subjectField.Items.Add(sName);
            }

            connection.Close();
        }

        private void AddTeacher_Activated_1(object sender, EventArgs e)
        {
            formName.Focus();
        }

        private void subjectField_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherField.Items.Clear();

            teacherField.Enabled = true;

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command2 = new MySqlCommand("SELECT CONCAT(user.surname, ' ', LEFT(user.name, 1), '.', LEFT(user.fullname, 1), '.') as FIO FROM user join teacher_keys where user.key_accept = teacher_keys.key_accept and teacher_keys.subj = '" + subjectField.Text +"'", connection);

            MySqlDataReader myReader2 = command2.ExecuteReader();

            while (myReader2.Read())
            {
                string sName = myReader2.GetString("FIO");
                teacherField.Items.Add(sName);
            }

            connection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(subjectField.Text == "" || teacherField.Text == "" || teacherField.Text == "Фамилия")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            string s = "SELECT COUNT(subject) FROM списокучителей" + DataBank.KlassField + " WHERE subject = '" + subjectField.Text + "'";

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command = new MySqlCommand(s, connection);

            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                if (myReader.GetInt32(0) != 0)
                {
                    MessageBox.Show("Учитель по этому предмету уже есть!");
                    return;
                }
            }

            connection.Close();

            string sel = "Insert into списокучителей" + DataBank.KlassField + " Values('" + teacherField.Text + "', '" + subjectField.Text + "')";

            connection.Open();

            MySqlCommand command1 = new MySqlCommand(sel, connection);

            command1.ExecuteNonQuery();
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Желаете добавить ещё?", "Учитель добавлена!", MessageBoxButtons.YesNo);
                  
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                list.Close();
                TeacherList list2 = new TeacherList();
                list2.Show();
            }
        }

        private void AddTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AddTeacher_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
