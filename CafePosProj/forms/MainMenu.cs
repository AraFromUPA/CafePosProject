using CafeApiProj.DelForms;
using CafeApiProj.forms.DelForms;
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
using Microsoft.EntityFrameworkCore;
using CafeApiProj.ViewModels;

namespace CafeApiProj
{
    public partial class MainMenu : Form
    {
        private readonly AppDbContext _appDbContext;


        public MainMenu(AppDbContext context)
        {
            _appDbContext = context;
            InitializeComponent();
            LoadOrdersData();
        }
        private void LoadOrdersData()
        {

            var ordersData = _appDbContext.Orders
                .Include(l => l.Customer)
                .Include(l => l.Employee)
                .Select(l => new OrdersViewModel
                {
                    Id = l.Id,
                    Customer = l.Customer.LastName,
                    Employee = l.Employee.LastName,

                })
                .ToList();


            dataGridView1.DataSource = ordersData;
        }






        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            CreateOrder CreateOrder = new CreateOrder(context);
            CreateOrder.Show();
        }

        private void newProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddProduct addProduct = new AddProduct(context);
            addProduct.Show();
        }
        private void newCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCustomer addCustomer = new AddCustomer(context);
            addCustomer.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            CreateOrder CreateOrder = new CreateOrder(context);
            CreateOrder.Show();
        }

        private void newEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddEmployee addEmployee = new AddEmployee(context);
            addEmployee.Show();
        }

        private void newCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCategory addCategory = new AddCategory(context);
            addCategory.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteCustomer deleteCustomer = new DeleteCustomer(context);
            deleteCustomer.Show();
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteOrder deleteOrder = new DeleteOrder(context);
            deleteOrder.Show();
        }

        private void deleteProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteProduct deleteProduct = new DeleteProduct(context);
            deleteProduct.Show();
        }

        private void deleteCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteCategory deleteCategory = new DeleteCategory(context);
            deleteCategory.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteEmployee deleteEmployee = new DeleteEmployee(context);
            deleteEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadOrdersData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                Guid orderId = (Guid)dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value;

                
                var orderProducts = _appDbContext.OrderProducts
                    .Where(op => op.OrderId == orderId)
                    .Include(op => op.Product) 
                    .ToList();

                
                dataGridView2.Rows.Clear();

               
                if (dataGridView2.Columns.Count == 0)
                {
                    dataGridView2.Columns.Add("Product", "Product");
                    dataGridView2.Columns.Add("Quantity", "Quantity");
                }

              
                foreach (var orderProduct in orderProducts)
                {
                    dataGridView2.Rows.Add( orderProduct.Product.Name, orderProduct.Quantity);
                }
            }
        }
    }
}
