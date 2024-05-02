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
    public partial class AddCategory : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public AddCategory(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {




            try
            {
                string Name = textBox1.Text;


                Guid employeeId = await _orderController.AddCategoryAsync(Name);

                MessageBox.Show($"Category created ID category: {employeeId}");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while creating category: {ex.ToString()}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
