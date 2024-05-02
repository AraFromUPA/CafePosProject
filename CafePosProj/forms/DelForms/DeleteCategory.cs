using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApiProj.forms.DelForms
{
    public partial class DeleteCategory : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public DeleteCategory(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
            LoadCategoryToComboBox();
        }
        private void LoadCategoryToComboBox()
        {

            var CategoryData = _appDbContext.ProductCategories.Select(c => new KeyValuePair<string, Guid>(c.Name, c.Id)).ToList();
            comboBox1.DataSource = CategoryData;
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "Value";




        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            var selectedCategory = (KeyValuePair<string, Guid>)comboBox1.SelectedItem;


            success = await _orderController.DeleteCategory(selectedCategory.Value);

            if (success)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error while deleting");
            }
        }
    }
}
