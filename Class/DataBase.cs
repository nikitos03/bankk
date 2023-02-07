using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Banking.UI
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-0088E2LD; Initial Catalog = Bank; Integrated Security = True");

        /// <summary>
        ///  Метод openConnection открывает доступ к БД;
        /// </summary>

        public void openConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }    
        }

        /// <summary>
        ///  Метод closeConnection закрывает доступ к БД;
        /// </summary>

        public void closeConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        ///  Устанавливает соединение с указанным адресом БД
        /// </summary>

        public SqlConnection getConnection() 
        {
            return sqlConnection;
        }


    }
}
