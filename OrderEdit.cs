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
    public partial class OrderEdit : Form
    {
        private int orderId;
        private DBAdapter dbAdapter = new DBAdapter();
        public OrderEdit(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            dbAdapter.Connect();

            var order = dbAdapter.GetOrderById(orderId);
            orderIdTextBox.Text = order["id"].ToString();
            createdAtTextBox.Text = order["orderDate"].ToString();
            statusComboBox.Text = order["status"].ToString();
            descriptionTextBox.Text = order["description"].ToString();
            clientComboBox.Text = order["clientId"].ToString();
            vesselNumberTextBox.Text = order["sosudNo"].ToString();

            var statuses = dbAdapter.GetStatuses();
            statusComboBox.DataSource = statuses.Select().Select(status => status["status"]).ToList();
   
            var users = dbAdapter.GetPersons();
            clientComboBox.DataSource = users;
            clientComboBox.DisplayMember = "personName";

            var orderDetails = dbAdapter.GetOrderDetails(orderId);
            orderDetailsView.DataSource = orderDetails;
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            string status = statusComboBox.Text;
            string description = descriptionTextBox.Text;

            DataRowView selectedClient = (DataRowView)clientComboBox.SelectedItem;
            int clientId = Convert.ToInt32(selectedClient["id"]);
            int sosudNo = Convert.ToInt32(vesselNumberTextBox.Text);
            dbAdapter.SaveOrder(this.orderId, status, description, clientId, sosudNo);
        }
    }
}
