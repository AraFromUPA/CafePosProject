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
    public partial class DeleteEmployee : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly OrderController _orderController;
        public DeleteEmployee(AppDbContext context)
        {
            _appDbContext = context;
            _orderController = new OrderController(_appDbContext);
            InitializeComponent();
            LoadEmployeesToComboBox();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadEmployeesToComboBox()
        {

            var employeeData = _appDbContext.Employees.Select(c => new KeyValuePair<string, Guid>(c.LastName, c.Id)).ToList();
            comboBox1.DataSource = employeeData;
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "Value";




        }
        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            var selectedEmployee = (KeyValuePair<string, Guid>)comboBox1.SelectedItem;


            success = await _orderController.DeleteEmployee(selectedEmployee.Value);

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
