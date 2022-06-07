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
    public partial class ChangeSubjectField : Form
    {
        public ChangeSubjectField()
        {
            InitializeComponent();

            subjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            MenuTeacher menuTeacher = new MenuTeacher();
            this.Close();
            menuTeacher.Show();
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
            this.Close();
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

        private void ChangeSubjectField_Load(object sender, EventArgs e)
        {
            formName.Text = "Электронный журнал " + DataBank.KlassField + " класса";

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            string sel = "Select * From списокпредметов" + DataBank.KlassField;

            MySqlCommand command = new MySqlCommand(sel, connection);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            subjectTable.DataSource = table;

            connection.Close();
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            ChangeSubject subject = new ChangeSubject();
            this.Close();
            subject.Show();
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            DeleteSubject subject = new DeleteSubject();
            this.Close();
            subject.Show();
        }

        private void addTeacher_MouseMove(object sender, MouseEventArgs e)
        {
            addTeacher.BackColor = Color.Teal;
        }

        private void addTeacher_MouseLeave(object sender, EventArgs e)
        {
            addTeacher.BackColor = Color.FromArgb(192, 255, 255);
        }
    }
}
