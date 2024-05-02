using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApiProj.DelForms
{
    public partial class DeleteCustomer : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public DeleteCustomer(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
            LoadCustomerToComboBox();  
        }
        private void LoadCustomerToComboBox()
        {

            var CustomerData = _appDbContext.Customers.Select(c => new KeyValuePair<string, Guid>(c.LastName, c.Id)).ToList();
            comboBox1.DataSource = CustomerData;
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "Value";




        }
        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            var selectedCustomer = (KeyValuePair<string, Guid>)comboBox1.SelectedItem;


            success = await _orderController.DeleteCustomer(selectedCustomer.Value);

            if (success)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error while deleting");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
