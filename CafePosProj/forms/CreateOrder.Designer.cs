namespace CafeApiProj
{
    partial class CreateOrder
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dataGridViewProducts = new DataGridView();
            buttonAddProduct = new Button();
            comboBoxProducts = new ComboBox();
            textBoxQuantity = new TextBox();
            buttonSaveOrder = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            addNewItemToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            newCustomerToolStripMenuItem = new ToolStripMenuItem();
            newEmployeeToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            deleteItemsToolStripMenuItem = new ToolStripMenuItem();
            deleteOrderToolStripMenuItem = new ToolStripMenuItem();
            deleteCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteEmployeeToolStripMenuItem = new ToolStripMenuItem();
            deleteCategoryToolStripMenuItem = new ToolStripMenuItem();
            deleteProductToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(23, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 133);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(31, 81);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 2;
            button2.Text = "to create new";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 1;
            label1.Text = "Choose Customer";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 140);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(31, 83);
            button3.Name = "button3";
            button3.Size = new Size(123, 32);
            button3.TabIndex = 3;
            button3.Text = "to create new";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 31);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 0;
            label2.Text = "Choose Employee";
            // 
            // button1
            // 
            button1.Location = new Point(644, 51);
            button1.Name = "button1";
            button1.Size = new Size(137, 57);
            button1.TabIndex = 3;
            button1.Text = "Create new product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(303, 51);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 57;
            dataGridViewProducts.Size = new Size(335, 215);
            dataGridViewProducts.TabIndex = 4;
            dataGridViewProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(514, 272);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(124, 41);
            buttonAddProduct.TabIndex = 5;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(303, 277);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(169, 31);
            comboBoxProducts.TabIndex = 6;
            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(303, 314);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(169, 30);
            textBoxQuantity.TabIndex = 7;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.BackColor = Color.ForestGreen;
            buttonSaveOrder.Location = new Point(303, 373);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(205, 41);
            buttonSaveOrder.TabIndex = 8;
            buttonSaveOrder.Text = "save order";
            buttonSaveOrder.UseVisualStyleBackColor = false;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(23, 360);
            button4.Name = "button4";
            button4.Size = new Size(68, 54);
            button4.TabIndex = 9;
            button4.Text = "delete order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(22, 22);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewItemToolStripMenuItem, deleteItemsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 31);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewItemToolStripMenuItem
            // 
            addNewItemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProductToolStripMenuItem, newCustomerToolStripMenuItem, newEmployeeToolStripMenuItem, newCategoryToolStripMenuItem });
            addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            addNewItemToolStripMenuItem.Size = new Size(133, 27);
            addNewItemToolStripMenuItem.Text = "Add new Item";
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(252, 30);
            newProductToolStripMenuItem.Text = "New Product";
            newProductToolStripMenuItem.Click += newProductToolStripMenuItem_Click;
            // 
            // newCustomerToolStripMenuItem
            // 
            newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            newCustomerToolStripMenuItem.Size = new Size(252, 30);
            newCustomerToolStripMenuItem.Text = "New Customer";
            newCustomerToolStripMenuItem.Click += newCustomerToolStripMenuItem_Click;
            // 
            // newEmployeeToolStripMenuItem
            // 
            newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            newEmployeeToolStripMenuItem.Size = new Size(252, 30);
            newEmployeeToolStripMenuItem.Text = "New Employee";
            newEmployeeToolStripMenuItem.Click += newEmployeeToolStripMenuItem_Click;
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(252, 30);
            newCategoryToolStripMenuItem.Text = "New Category";
            newCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
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
            deleteOrderToolStripMenuItem.Size = new Size(252, 30);
            deleteOrderToolStripMenuItem.Text = "Delete Order";
            deleteOrderToolStripMenuItem.Click += deleteOrderToolStripMenuItem_Click;
            // 
            // deleteCustomerToolStripMenuItem
            // 
            deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            deleteCustomerToolStripMenuItem.Size = new Size(252, 30);
            deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            deleteCustomerToolStripMenuItem.Click += deleteCustomerToolStripMenuItem_Click;
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            deleteEmployeeToolStripMenuItem.Size = new Size(252, 30);
            deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            deleteEmployeeToolStripMenuItem.Click += deleteEmployeeToolStripMenuItem_Click;
            // 
            // deleteCategoryToolStripMenuItem
            // 
            deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            deleteCategoryToolStripMenuItem.Size = new Size(252, 30);
            deleteCategoryToolStripMenuItem.Text = "Delete Category";
            deleteCategoryToolStripMenuItem.Click += deleteCategoryToolStripMenuItem_Click;
            // 
            // deleteProductToolStripMenuItem
            // 
            deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            deleteProductToolStripMenuItem.Size = new Size(252, 30);
            deleteProductToolStripMenuItem.Text = "Delete Product";
            deleteProductToolStripMenuItem.Click += deleteProductToolStripMenuItem_Click;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(856, 519);
            Controls.Add(button4);
            Controls.Add(buttonSaveOrder);
            Controls.Add(textBoxQuantity);
            Controls.Add(comboBoxProducts);
            Controls.Add(buttonAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CreateOrder";
            Text = "CreateOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label2;
        private Button button1;
        private DataGridView dataGridViewProducts;
        private Button buttonAddProduct;
        private ComboBox comboBoxProducts;
        private TextBox textBoxQuantity;
        private Button buttonSaveOrder;
        private Button button2;
        private Button button3;
        private Button button4;
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
    }
}