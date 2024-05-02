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
    public partial class AddProduct : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public AddProduct(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
            LoadProductsToComboBox();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is KeyValuePair<string, Guid> selectedCategory)
            {
                Guid selectedCategoryId = selectedCategory.Value;

            }
        }

        private void LoadProductsToComboBox()
        {

            var productCategotyData = _appDbContext.ProductCategories.Select(c => new KeyValuePair<string, Guid>(c.Name, c.Id)).ToList();
            comboBox1.DataSource = productCategotyData;
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "Value";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Guid categoryId = (Guid)comboBox1.SelectedValue;
                int price = Int32.Parse(textBox1.Text);
                int article = Int32.Parse(textBox2.Text);
                string name = textBox3.Text;

                Guid productId = await _orderController.AddProductAsync(name, price, article, categoryId);
                MessageBox.Show($"Order created order ID: {productId}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while creating order: {ex.ToString()}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            AddCategory addCategory = new AddCategory(context);
            addCategory.Show();
            
        }
    }
}
