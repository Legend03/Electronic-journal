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
    public partial class CheckMark : Form
    {
        public CheckMark()
        {
            InitializeComponent();

            subjectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            MenuStudent menuStudent = new MenuStudent();
            this.Hide();
            menuStudent.Show();
        }

        private void buttonBack_MouseMove(object sender, MouseEventArgs e)
        {
            buttonBack.BackColor = Color.Teal;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.CornflowerBlue;
        }

        private void CheckMark_Load(object sender, EventArgs e)
        {
            formName.Text = "Электронный журнал " + DataBank.Klass + " класса";

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "select subject from списокпредметов" + DataBank.Klass;

            connection.Open();

            MySqlCommand command2 = new MySqlCommand(sel, connection);

            MySqlDataReader myReader = command2.ExecuteReader();

            while (myReader.Read())
            {
                string sName = myReader.GetString("subject");
                subjectField.Items.Add(sName);
            }

            connection.Close();
        }

        private void subjectField_Enter(object sender, EventArgs e)
        {
            subjectFieldName.Visible = false;
            subjectField.ForeColor = Color.Black;
        }

        private void subjectField_Leave(object sender, EventArgs e)
        {
            if (subjectField.Text == "")
            {
                subjectFieldName.Visible = true;
            }
        }

        private void subjectField_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "select * from " + subjectField.Text + DataBank.Klass;

            connection.Open();

            MySqlCommand command = new MySqlCommand(sel, connection);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            markTable.DataSource = table;

            connection.Close();
        }
    }
}
