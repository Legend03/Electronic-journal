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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();

            studentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.Red;
            buttonClose.ForeColor = Color.White;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.CornflowerBlue;
            buttonClose.ForeColor = Color.Red;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuTeacher menuTeacher = new MenuTeacher();
            this.Hide();
            menuTeacher.Show();
        }

        private void buttonBack_MouseMove(object sender, MouseEventArgs e)
        {
            buttonBack.BackColor = Color.Teal;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.CornflowerBlue;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            formName.Text = "Электронный журнал " + DataBank.KlassField + " класса";

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            string sel = "Select FIO as 'ФИО', birthday as 'День рождения', city as 'Город' From списокучеников" + DataBank.KlassField;

            MySqlCommand command = new MySqlCommand(sel, connection);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            studentTable.DataSource = table;

            connection.Close();
        }

        private void buttonAddTema_Click(object sender, EventArgs e)
        {
            AddStudentField student = new AddStudentField();
            this.Close();
            student.Show();
        }

        private void buttonDeleteTema_Click(object sender, EventArgs e)
        {
            DeleteStudentField student = new DeleteStudentField();
            this.Close();
            student.Show();
        }

        private void ChangeField_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeField.BackColor = Color.Teal;
        }

        private void ChangeField_MouseLeave(object sender, EventArgs e)
        {
            ChangeField.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void buttonDeleteTema_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDeleteTema.BackColor = Color.Teal;
        }

        private void buttonDeleteTema_MouseLeave(object sender, EventArgs e)
        {
            buttonDeleteTema.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void StudentList_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void StudentList_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
