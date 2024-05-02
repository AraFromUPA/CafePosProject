namespace CafeApiProj
{
    partial class AddEmployee
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonSave = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 303);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 102);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(83, 224);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(146, 44);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save Info";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 1;
            label1.Text = "Add new Employee";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(344, 345);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSave;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}