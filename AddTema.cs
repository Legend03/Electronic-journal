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
    public partial class AddTema : Form
    {
        Tema tema = new Tema();

        public AddTema()
        {
            InitializeComponent();

            dateField.Format = DateTimePickerFormat.Custom;
            dateField.CustomFormat = "dd_MM";
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
            if (kolHoursField.Text == "")
            {
                kolHoursField.Text = "Количество часов";
                kolHoursField.ForeColor = Color.Gray;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (temaField.Text == "Тема урока" || kolHoursField.Text == "Количество часов")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            string s = "SELECT COUNT(date) FROM тема" + DataBank.SubjectField + DataBank.KlassField + " WHERE date = '" + dateField.Text + "'";

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=electronic_journal");

            connection.Open();

            MySqlCommand command = new MySqlCommand(s, connection);

            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                if (myReader.GetInt32(0) != 0)
                {
                    MessageBox.Show("Тема на эту дату уже стоит!");
                    return;
                }
            }

            connection.Close();

            try
            {
                string sel = "Insert into тема" + DataBank.SubjectField + DataBank.KlassField + " Values('" + dateField.Text + "', '" + temaField.Text + "', " + kolHoursField.Text + ")";

                connection.Open();

                MySqlCommand command1 = new MySqlCommand(sel, connection);

                command1.ExecuteNonQuery();
                connection.Close();

                DialogResult dialogResult = MessageBox.Show("Желаете добавить ещё тему?", "Тема добавлена!", MessageBoxButtons.YesNo);

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
               catch
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void kolHoursField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddTema_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AddTema_Load(object sender, EventArgs e)
        {
            tema.Show();
            tema.Enabled = false;
            this.Show();
        }
    }
}
