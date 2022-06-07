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
    public partial class ChangeTema : Form
    {
        public Tema tema = new Tema();

        public ChangeTema()
        {
            InitializeComponent();

            dateField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Tema form = new Tema();
            tema.Close();
            form.Show();
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

        private void dateField_Enter(object sender, EventArgs e)
        {
            dateFieldName.Visible = false;
            dateField.ForeColor = Color.Black;
        }

        private void ChangeTema_Activated(object sender, EventArgs e)
        {
            formName.Focus();
        }

        private void dateField_Leave(object sender, EventArgs e)
        {
            if(dateField.Text == "")
            {
                dateFieldName.Visible = true;
                dateField.ForeColor = Color.Gray;
            }            
        }

        private void ChangeTema_Load(object sender, EventArgs e)
        {
            tema.Show();
            tema.Enabled = false;
            this.Show();

            string s = "SELECT date FROM тема" + DataBank.SubjectField + DataBank.KlassField;

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command = new MySqlCommand(s, connection);

            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                string sName = myReader.GetString("date");
                dateField.Items.Add(sName);
            }

            connection.Close();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (temaField.Text == "Тема урока")
            {
                temaField.Text = null;
            }
            temaField.ForeColor = Color.Black;
        }

        private void temaField_Leave(object sender, EventArgs e)
        {
            if (temaField.Text == "")
            {
                temaField.Text = "Тема урока";
                temaField.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (kolHoursField.Text == "Количество часов")
            {
                kolHoursField.Text = null;
            }
            kolHoursField.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (temaField.Text == "")
            {
                temaField.Text = "Количество часов";
                temaField.ForeColor = Color.Gray;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (temaField.Text == "Тема урока" || kolHoursField.Text == "Количество часов" || dateField.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            string sel = "UPDATE тема" + DataBank.SubjectField + DataBank.KlassField + " SET tema = '" + temaField.Text + "', kol_hours = " + kolHoursField.Text + " where date = '" + dateField.Text + "'";

            connection.Open();

            MySqlCommand command = new MySqlCommand(sel, connection);

            command.ExecuteNonQuery();
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Желаете изменить ещё тему?", "тема изменена!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                Tema form = new Tema();
                tema.Close();
                form.Show();
            }
        }

        private void ChangeTema_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void ChangeTema_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
