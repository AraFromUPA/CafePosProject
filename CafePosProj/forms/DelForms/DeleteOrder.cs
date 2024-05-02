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

namespace CafeApiProj.DelForms
{
    public partial class DeleteOrder : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;

        public DeleteOrder(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (Guid.TryParse(textBox1.Text, out Guid Id))
            {
                

                success = await _orderController.DeleteOrder(Id);

                if (success)
                {
                    MessageBox.Show($"Success");
                }
                else
                {
                    MessageBox.Show($"Error while deleting");
                }
            }
            
            
        }
    }
}
