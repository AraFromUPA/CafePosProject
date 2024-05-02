using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeApiProj.forms.DelForms
{
    public partial class DeleteProduct : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;

        public DeleteProduct(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
            LoadProductsToComboBox();
        }
        private void LoadProductsToComboBox()
        {

            var productData = _appDbContext.Products.Select(c => new KeyValuePair<string, Guid>(c.Name, c.Id)).ToList();
            comboBox1.DataSource = productData;
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "Value";




        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            var selectedProduct = (KeyValuePair<string, Guid>)comboBox1.SelectedItem;

            
                success = await _orderController.DeleteProduct(selectedProduct.Value);

                if (success)
                {
                    MessageBox.Show("Продукт успешно удалён");
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении продукта");
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

