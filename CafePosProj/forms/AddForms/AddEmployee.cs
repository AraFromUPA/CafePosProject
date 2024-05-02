using CafeApiProj.DelForms;
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

namespace CafeApiProj
{
    public partial class AddEmployee : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public AddEmployee(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {



            try
            {
                string FirstName = textBox1.Text;
                string LastName = textBox2.Text;

                Guid employeeId = await _orderController.AddEmployeeAsync(FirstName, LastName);

                MessageBox.Show($"Employee created ID employee: {employeeId}");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Airwell creating employee: {ex.ToString()}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            DeleteEmployee deleteEmployee = new DeleteEmployee(context);
            deleteEmployee.Show();
            
        }
    }
}
