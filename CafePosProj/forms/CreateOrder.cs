using CafeApiProj.DelForms;
using CafeApiProj.forms.DelForms;
using CafeApiProj.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class CreateOrder : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;

        private List<OrderProduct> productList;
        public CreateOrder()
        {
            InitializeComponent();
        }
        public CreateOrder(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);

            productList = new List<OrderProduct>();

            InitializeComponent();
            FillCustomerComboBox();
            FillEmployeeComboBox();
            LoadProductsToComboBox();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillCustomerComboBox()
        {

            var clientData = _appDbContext.Customers.Select(c => new KeyValuePair<string, Guid>(c.LastName, c.Id)).ToList();


            comboBox1.DataSource = clientData;


            comboBox1.DisplayMember = "Key"; // Фамилия
            comboBox1.ValueMember = "Value"; // GUID



        }



        private void FillEmployeeComboBox()
        {

            var employeeNames = _appDbContext.Employees.Select(c => new KeyValuePair<string, Guid>(c.LastName, c.Id)).ToList();


            comboBox2.DataSource = employeeNames;
            comboBox2.DisplayMember = "Key"; // name
            comboBox2.ValueMember = "Value"; // GUID
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is KeyValuePair<string, Guid> selectedClient)
            {
                Guid selectedClientId = selectedClient.Value;

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is KeyValuePair<string, Guid> selectedClient)
            {
                Guid selectedClientId = selectedClient.Value;

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MainMenu mainMenu = new MainMenu();
            //mainMenu.Show();
            //this.Close();
            AppDbContext context = new AppDbContext();
            AddProduct addProduct = new AddProduct(context);
            addProduct.Show();

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            var selectedProduct = (KeyValuePair<string, Guid>)comboBoxProducts.SelectedItem;

            if (comboBoxProducts.SelectedItem is KeyValuePair<string, Guid> selectedProductItem)
            {
                int quantity;

                if (!int.TryParse(textBoxQuantity.Text, out quantity))
                {
                    MessageBox.Show("Введите корректное количество товара.");
                    return;
                }


                OrderProduct orderProduct = new OrderProduct
                {
                    ProductId = selectedProductItem.Value,
                    Quantity = quantity
                };
                productList.Add(orderProduct);

                textBoxQuantity.Clear();

                UpdateProductDataGridView();
            }
            else
            {
                MessageBox.Show("Выберите продукт.");
            }
        }
        private void UpdateProductDataGridView()
        {

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productList;
            dataGridViewProducts.Columns["Order"].Visible = false;
            dataGridViewProducts.Columns["Product"].Visible = false;


        }
        private void LoadProductsToComboBox()
        {

            var productData = _appDbContext.Products.Select(c => new KeyValuePair<string, Guid>(c.Name, c.Id)).ToList();
            comboBoxProducts.DataSource = productData;
            comboBoxProducts.DisplayMember = "key";
            comboBoxProducts.ValueMember = "Value";




        }


        private async void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Guid customerId = (Guid)comboBox1.SelectedValue;
                Guid employeeId = (Guid)comboBox2.SelectedValue;



                Guid orderId = await _orderController.CreateOrderAsync(customerId, employeeId, productList);


                MessageBox.Show($"Заказ создан ID заказа: {orderId}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка при создании заказа: {ex.ToString()}");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCustomer addCustomer = new AddCustomer(context);
            addCustomer.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddEmployee addEmployee = new AddEmployee(context);
            addEmployee.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteOrder deleteOrder = new DeleteOrder(context);
            deleteOrder.Show();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteOrder deleteOrder = new DeleteOrder(context);
            deleteOrder.Show();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddProduct addProduct = new AddProduct(context);
            addProduct.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCustomer addCustomer = new AddCustomer(context);
            addCustomer.Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddEmployee addEmployee = new AddEmployee(context);
            addEmployee.Show();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCategory addCategory = new AddCategory(context);
            addCategory.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteCustomer deleteCustomer = new DeleteCustomer(context);
            deleteCustomer.Show();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteProduct deleteProduct = new DeleteProduct(context);
            deleteProduct.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteEmployee deleteEmployee = new DeleteEmployee(context);
            deleteEmployee.Show();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteCategory deleteCategory = new DeleteCategory(context);
            deleteCategory.Show();
        }
    }
}
