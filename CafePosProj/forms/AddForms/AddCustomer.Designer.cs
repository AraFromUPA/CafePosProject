namespace CafeApiProj
{
    partial class AddCustomer
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
            label1 = new Label();
            panel1 = new Panel();
            buttonSaveCusInfo = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSaveCusInfo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(32, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 299);
            panel1.TabIndex = 1;
            // 
            // buttonSaveCusInfo
            // 
            buttonSaveCusInfo.Location = new Point(101, 221);
            buttonSaveCusInfo.Name = "buttonSaveCusInfo";
            buttonSaveCusInfo.Size = new Size(167, 51);
            buttonSaveCusInfo.TabIndex = 2;
            buttonSaveCusInfo.Text = "Save customer info";
            buttonSaveCusInfo.UseVisualStyleBackColor = true;
            buttonSaveCusInfo.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 120);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 3;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 2;
            label2.Text = "First name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(440, 371);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button buttonSaveCusInfo;
    }
}