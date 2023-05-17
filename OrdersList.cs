using ELMA.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMA
{
    public partial class OrdersList : Form
    {
        private DBAdapter dBAdapter = new DBAdapter();
        private DataTable ordersList;
        public OrdersList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            dBAdapter.Connect();
            ordersList = dBAdapter.GetOrders();
            orderListView.DataSource = ordersList;
        }

        private void orderListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(ordersList.Rows[e.RowIndex]["id"]);
            new OrderEdit(orderId).Show();
        }
    }
}
