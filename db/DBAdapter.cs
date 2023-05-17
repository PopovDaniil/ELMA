using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMA.db
{
    internal class DBAdapter
    {
        private MySqlConnection connection;
        public void Connect()
        {
            string connectionString = "server=localhost; user=root; password=123; database=elma";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            } 
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка подключения к БД: {e.Message}", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetOrders()
        {
            return GetDataTable("SELECT * FROM orders");
        }

        public DataRow GetOrderById(int id)
        {
            return GetDataTable($"SELECT * FROM orders WHERE id={id}").Rows[0];
        }

        public DataTable GetStatuses()
        {
            return GetDataTable($"SELECT * FROM order_statuses");
        }

        public DataTable GetOrderDetails(int orderId)
        {
            return GetDataTable($"SELECT * FROM order_detail WHERE orderId = {orderId}");
        }

        public DataTable GetPersons()
        {
            return GetDataTable($"SELECT * FROM persons");
        }
        
        public DataTable SaveOrder(int orderId, string status, string description, int clientId, int sosudNo)
        {
            return GetDataTable($"UPDATE orders SET status = '{status}', description = '{description}', clientId = {clientId}, sosudNo = {sosudNo} WHERE id = {orderId}");
        }

        private DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                var result = new MySqlDataAdapter(query, connection);
                result.Fill(dataTable);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {e.Message}", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

    }
}
