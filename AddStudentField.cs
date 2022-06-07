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
    public partial class AddStudentField : Form
    {
        public StudentList list = new StudentList();

        public AddStudentField()
        {
            InitializeComponent();

            studentField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text == "Город")
            {
                cityField.Text = null;
            }
            cityField.ForeColor = Color.Black;
        }

        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text == "")
            {
                cityField.Text = "Город";
                cityField.ForeColor = Color.Gray;
            }
        }

        private void studentField_Enter(object sender, EventArgs e)
        {
            studentNameField.Visible = false;
            studentField.ForeColor = Color.Black;
        }

        private void studentField_Leave(object sender, EventArgs e)
        {
            if (studentField.Text == "")
            {
                studentNameField.Visible = true;
                studentField.ForeColor = Color.Gray;
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            list.Close();
            StudentList list2 = new StudentList();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (studentField.Text == "" || cityField.Text == "" || cityField.Text == "Город")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "UPDATE списокучеников" + DataBank.KlassField + " SET birthday = '" + dateField.Text + "', city = '" + cityField.Text + "' where FIO = '" + studentField.Text + "'";

            connection.Open();

            MySqlCommand command1 = new MySqlCommand(sel, connection);

            command1.ExecuteNonQuery();
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Желаете изменить ещё данные?", "Данные изменены!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                list.Close();
                StudentList list2 = new StudentList();
                list2.Show();
            }
        }

        private void AddStudentField_Load(object sender, EventArgs e)
        {
            list.Show();
            list.Enabled = false;
            this.Show();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "Select FIO From списокучеников" + DataBank.KlassField;

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

        private void AddStudentField_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
