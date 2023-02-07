using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking.UI
{
    public partial class AuthorizationForm : Form
    {
        DataBase dataBase = new DataBase();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Этот метод позволяет пользователю при нажатии кнопки "Войти", 
        /// перейти на следующую форму за счет его логина и пароля;
        /// </summary>

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var loginUser = Login.Text; 
            var passwordUser = Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand($"select login_user, password_user, is_admin from register where '{loginUser}' = @login_user AND '{passwordUser}' = @password_user", dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@login_user", loginUser);
                command.Parameters.AddWithValue("@password_user", passwordUser);
                
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }


            if (table.Rows.Count == 1) 
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[2]));

                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuForm menuform = new MenuForm(user);
                this.Hide();
                menuform.ShowDialog();
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Этот метод позволяет пользователю выйти из программы;
        /// </summary>

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
