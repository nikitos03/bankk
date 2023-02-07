using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking.UI
{
    public partial class AdminPanelForm : Form
    {
        private readonly checkUser _user;

        DataBase dataBase = new DataBase();

        public AdminPanelForm(checkUser user)
        {
            InitializeComponent();

            _user = user;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDataGrid();
        }

        /// <summary>
        /// Этот метод строит таблицу в DGV, а псоле этого отобраает данные из БД;
        /// </summary>
        private void CreateColumn()
        {
            RoleList.Columns.Add("id_user", "id");
            RoleList.Columns.Add("Login", "Логин");
            RoleList.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            RoleList.Columns.Add(checkColumn);
        }

        /// <summary>
        /// Этот метод добавляет строки и заполняет ячейки данными из БД;
        /// </summary>

        private void ReadSingleRow(IDataRecord record)
        {
            RoleList.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }

        /// <summary>
        /// Этот метод обновляет данные в DGV;
        /// </summary>

        private void RefreshDataGrid()
        {
            RoleList.Rows.Clear();

            string str = $"select * from register";

            SqlCommand command = new SqlCommand(str, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }

            reader.Close();

            dataBase.closeConnection();
        }

        /// <summary>
        /// Этот метод позволяет администратору сохранить роль у пользователя после изменения;
        /// </summary>

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            for (int index = 0; index < RoleList.Rows.Count; index++)
            {
                var id = RoleList.Rows[index].Cells[0].Value.ToString();
                var isadmin = RoleList.Rows[index].Cells[3].Value.ToString();

                using (SqlCommand command = new SqlCommand($"update register set is_admin = @is_admin where id_user = @id_user", dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@id_user", id);
                    command.Parameters.AddWithValue("@is_admin", isadmin);

                    command.ExecuteNonQuery();
                }          
            }
            dataBase.closeConnection();

            RefreshDataGrid();
        }

        /// <summary>
        /// Этот метод позволяет администратору удалить пользователя из БД с помощью id;
        /// </summary>

        private void Delete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var selectRowIndex = RoleList.CurrentCell.RowIndex;

            var id = Convert.ToInt32(RoleList.Rows[selectRowIndex].Cells[0].Value);

            using (SqlCommand command = new SqlCommand($"delete from register where id_user = @id_user", dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@id_user", id);

                command.ExecuteNonQuery();         
            }
            dataBase.closeConnection();

            RefreshDataGrid();
        }

        /// <summary>
        /// Этот метод предназначен для перехода из одной формы в другую;
        /// </summary>

        private void Exit_Click(object sender, EventArgs e)
        {
            MenuForm menuform = new MenuForm(_user);
            this.Hide();
            menuform.ShowDialog();
            this.Show();
        }
    }
}
