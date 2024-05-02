namespace CafeApiProj
{
    partial class AddProduct
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 305);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 30);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 217);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 4;
            label4.Text = "Choose category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 31);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 145);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 85);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Article";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(133, 365);
            button1.Name = "button1";
            button1.Size = new Size(200, 52);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 9);
            label5.Name = "label5";
            label5.Size = new Size(145, 23);
            label5.TabIndex = 2;
            label5.Text = "Add New Product";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 241);
            button2.Name = "button2";
            button2.Size = new Size(125, 32);
            button2.TabIndex = 8;
            button2.Text = "add category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(474, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "AddProduct";
            Text = "AddProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label5;
        private Button button2;
    }
}