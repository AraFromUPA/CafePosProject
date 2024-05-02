namespace CafeApiProj
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersViewModelBindingSource = new BindingSource(components);
            orderBindingSource1 = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            addNewItemToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            newCustomerToolStripMenuItem = new ToolStripMenuItem();
            newEmployeeToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            deleteItemsToolStripMenuItem = new ToolStripMenuItem();
            deleteOrderToolStripMenuItem = new ToolStripMenuItem();
            deleteCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteEmployeeToolStripMenuItem = new ToolStripMenuItem();
            deleteCategoryToolStripMenuItem = new ToolStripMenuItem();
            deleteProductToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ordersViewModelBindingSource;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(722, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 7;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 140;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 7;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.Width = 140;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 7;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.Width = 140;
            // 
            // ordersViewModelBindingSource
            // 
            ordersViewModelBindingSource.DataSource = typeof(ViewModels.OrdersViewModel);
            // 
            // orderBindingSource1
            // 
            orderBindingSource1.DataSource = typeof(Models.Order);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Models.Order);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(22, 22);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewItemToolStripMenuItem, deleteItemsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(952, 31);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewItemToolStripMenuItem
            // 
            addNewItemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProductToolStripMenuItem, newCustomerToolStripMenuItem, newEmployeeToolStripMenuItem, newCategoryToolStripMenuItem, newOrderToolStripMenuItem });
            addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            addNewItemToolStripMenuItem.Size = new Size(133, 27);
            addNewItemToolStripMenuItem.Text = "Add new Item";
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(217, 30);
            newProductToolStripMenuItem.Text = "New Product";
            newProductToolStripMenuItem.Click += newProductToolStripMenuItem_Click_1;
            // 
            // newCustomerToolStripMenuItem
            // 
            newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            newCustomerToolStripMenuItem.Size = new Size(217, 30);
            newCustomerToolStripMenuItem.Text = "New Customer";
            newCustomerToolStripMenuItem.Click += newCustomerToolStripMenuItem_Click_1;
            // 
            // newEmployeeToolStripMenuItem
            // 
            newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            newEmployeeToolStripMenuItem.Size = new Size(217, 30);
            newEmployeeToolStripMenuItem.Text = "New Employee";
            newEmployeeToolStripMenuItem.Click += newEmployeeToolStripMenuItem_Click_1;
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(217, 30);
            newCategoryToolStripMenuItem.Text = "New Category";
            newCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click_1;
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(217, 30);
            newOrderToolStripMenuItem.Text = "New Order";
            newOrderToolStripMenuItem.Click += newOrderToolStripMenuItem_Click;
            // 
            // deleteItemsToolStripMenuItem
            // 
            deleteItemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteOrderToolStripMenuItem, deleteCustomerToolStripMenuItem, deleteEmployeeToolStripMenuItem, deleteCategoryToolStripMenuItem, deleteProductToolStripMenuItem });
            deleteItemsToolStripMenuItem.Name = "deleteItemsToolStripMenuItem";
            deleteItemsToolStripMenuItem.Size = new Size(122, 27);
            deleteItemsToolStripMenuItem.Text = "Delete Items";
            // 
            // deleteOrderToolStripMenuItem
            // 
            deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            deleteOrderToolStripMenuItem.Size = new Size(232, 30);
            deleteOrderToolStripMenuItem.Text = "Delete Order";
            deleteOrderToolStripMenuItem.Click += deleteOrderToolStripMenuItem_Click;
            // 
            // deleteCustomerToolStripMenuItem
            // 
            deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            deleteCustomerToolStripMenuItem.Size = new Size(232, 30);
            deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            deleteCustomerToolStripMenuItem.Click += deleteCustomerToolStripMenuItem_Click_1;
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            deleteEmployeeToolStripMenuItem.Size = new Size(232, 30);
            deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            deleteEmployeeToolStripMenuItem.Click += deleteEmployeeToolStripMenuItem_Click_1;
            // 
            // deleteCategoryToolStripMenuItem
            // 
            deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            deleteCategoryToolStripMenuItem.Size = new Size(232, 30);
            deleteCategoryToolStripMenuItem.Text = "Delete Category";
            deleteCategoryToolStripMenuItem.Click += deleteCategoryToolStripMenuItem_Click_1;
            // 
            // deleteProductToolStripMenuItem
            // 
            deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            deleteProductToolStripMenuItem.Size = new Size(232, 30);
            deleteProductToolStripMenuItem.Text = "Delete Product";
            deleteProductToolStripMenuItem.Click += deleteProductToolStripMenuItem_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(728, 34);
            button1.Name = "button1";
            button1.Size = new Size(180, 116);
            button1.TabIndex = 12;
            button1.Text = "Create new order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 368);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 57;
            dataGridView2.Size = new Size(335, 214);
            dataGridView2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 342);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 14;
            label1.Text = "Products in selected order";
            // 
            // button2
            // 
            button2.Location = new Point(547, 310);
            button2.Name = "button2";
            button2.Size = new Size(175, 55);
            button2.TabIndex = 15;
            button2.Text = "Update info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(952, 640);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addNewItemToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem newCustomerToolStripMenuItem;
        private ToolStripMenuItem newEmployeeToolStripMenuItem;
        private ToolStripMenuItem newCategoryToolStripMenuItem;
        private ToolStripMenuItem deleteItemsToolStripMenuItem;
        private ToolStripMenuItem deleteOrderToolStripMenuItem;
        private ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private ToolStripMenuItem deleteProductToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label1;
        private BindingSource orderBindingSource1;
        private Button button2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private BindingSource ordersViewModelBindingSource;
    }
}