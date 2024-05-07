namespace SpAdo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            nameInput = new TextBox();
            surnameInput = new TextBox();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(651, 34);
            button1.Name = "button1";
            button1.Size = new Size(137, 55);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 48);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(156, 27);
            nameInput.TabIndex = 1;
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(242, 48);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(158, 27);
            surnameInput.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(692, 262);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(433, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "qadin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(549, 53);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "kisi";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(surnameInput);
            Controls.Add(nameInput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nameInput;
        private TextBox surnameInput;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
