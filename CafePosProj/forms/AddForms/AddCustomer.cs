using CafeApiProj.DelForms;
using CafeApiProj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApiProj
{
    public partial class AddCustomer : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public AddCustomer(AppDbContext context)
        {

            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = textBox1.Text;
                string LastName = textBox2.Text;

                Guid customerId = await _orderController.AddCustomerAsync(FirstName, LastName);

                MessageBox.Show($"Customer created Customer ID: {customerId}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while creating customer: {ex.ToString()}");
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteCustomer deleteCustomer = new DeleteCustomer(context);
            deleteCustomer.Show();
            
        }
    }
}
