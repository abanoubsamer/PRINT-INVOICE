namespace PRINT_INVOICE
{
    partial class App
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
            pmain = new Panel();
            button2 = new Button();
            add = new Button();
            textBox2 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            coliteam = new DataGridViewTextBoxColumn();
            colqty = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            colsubtotal = new DataGridViewTextBoxColumn();
            quantity = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            Category = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            Date = new TextBox();
            name = new TextBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lable2 = new Label();
            label2 = new Label();
            Number_Invoice = new TextBox();
            pmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pmain
            // 
            pmain.Controls.Add(button2);
            pmain.Controls.Add(add);
            pmain.Controls.Add(textBox2);
            pmain.Controls.Add(label8);
            pmain.Controls.Add(dataGridView1);
            pmain.Controls.Add(quantity);
            pmain.Controls.Add(label7);
            pmain.Controls.Add(numericUpDown1);
            pmain.Controls.Add(label6);
            pmain.Controls.Add(Category);
            pmain.Controls.Add(label5);
            pmain.Controls.Add(label4);
            pmain.Controls.Add(Date);
            pmain.Controls.Add(name);
            pmain.Controls.Add(label1);
            pmain.Controls.Add(label3);
            pmain.Controls.Add(pictureBox1);
            pmain.Controls.Add(lable2);
            pmain.Controls.Add(label2);
            pmain.Controls.Add(Number_Invoice);
            pmain.Location = new Point(4, 12);
            pmain.Name = "pmain";
            pmain.Size = new Size(1227, 684);
            pmain.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1129, 322);
            button2.Name = "button2";
            button2.Size = new Size(92, 51);
            button2.TabIndex = 38;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(1031, 322);
            add.Name = "add";
            add.Size = new Size(92, 51);
            add.TabIndex = 37;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkViolet;
            textBox2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Gold;
            textBox2.Location = new Point(848, 322);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(177, 51);
            textBox2.TabIndex = 36;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Location = new Point(848, 275);
            label8.Name = "label8";
            label8.Size = new Size(163, 44);
            label8.TabIndex = 35;
            label8.Text = "#Total#";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coliteam, colqty, colprice, colsubtotal });
            dataGridView1.Location = new Point(8, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1216, 282);
            dataGridView1.TabIndex = 34;
            // 
            // coliteam
            // 
            coliteam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coliteam.HeaderText = "Iteam";
            coliteam.MinimumWidth = 6;
            coliteam.Name = "coliteam";
            // 
            // colqty
            // 
            colqty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colqty.HeaderText = "Quantity";
            colqty.MinimumWidth = 6;
            colqty.Name = "colqty";
            // 
            // colprice
            // 
            colprice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colprice.HeaderText = "Price";
            colprice.MinimumWidth = 6;
            colprice.Name = "colprice";
            // 
            // colsubtotal
            // 
            colsubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colsubtotal.HeaderText = "SubTotal";
            colsubtotal.MinimumWidth = 6;
            colsubtotal.Name = "colsubtotal";
            // 
            // quantity
            // 
            quantity.Location = new Point(646, 325);
            quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantity.Name = "quantity";
            quantity.Size = new Size(196, 47);
            quantity.TabIndex = 33;
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantity.KeyDown += quantity_KeyDown;
            // 
            // label7
            // 
            label7.Location = new Point(490, 325);
            label7.Name = "label7";
            label7.Size = new Size(150, 44);
            label7.TabIndex = 32;
            label7.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(257, 322);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(227, 47);
            numericUpDown1.TabIndex = 31;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Location = new Point(8, 322);
            label6.Name = "label6";
            label6.Size = new Size(225, 44);
            label6.TabIndex = 29;
            label6.Text = "Price:";
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Location = new Point(257, 267);
            Category.Name = "Category";
            Category.Size = new Size(585, 49);
            Category.TabIndex = 28;
            Category.KeyDown += Category_KeyDown;
            // 
            // label5
            // 
            label5.Location = new Point(8, 267);
            label5.Name = "label5";
            label5.Size = new Size(255, 44);
            label5.TabIndex = 27;
            label5.Text = "Category:";
            // 
            // label4
            // 
            label4.Location = new Point(8, 226);
            label4.Name = "label4";
            label4.Size = new Size(1213, 41);
            label4.TabIndex = 26;
            label4.Text = "=======================================================================";
            // 
            // Date
            // 
            Date.ForeColor = SystemColors.Highlight;
            Date.Location = new Point(686, 104);
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Size = new Size(404, 47);
            Date.TabIndex = 23;
            Date.TextAlign = HorizontalAlignment.Center;
            // 
            // name
            // 
            name.ForeColor = SystemColors.ActiveCaptionText;
            name.Location = new Point(257, 162);
            name.Name = "name";
            name.Size = new Size(833, 47);
            name.TabIndex = 25;
            name.TextAlign = HorizontalAlignment.Center;
            name.KeyDown += name_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(490, 24);
            label1.Name = "label1";
            label1.Size = new Size(222, 43);
            label1.TabIndex = 18;
            label1.Text = "Screen Invoice";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(8, 162);
            label3.Name = "label3";
            label3.Size = new Size(243, 44);
            label3.TabIndex = 24;
            label3.Text = "Custmer Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.businessman_team_recruitment_employee_resources_human_resource_icon_210723;
            pictureBox1.Location = new Point(1096, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lable2
            // 
            lable2.Location = new Point(8, 107);
            lable2.Name = "lable2";
            lable2.Size = new Size(255, 44);
            lable2.TabIndex = 20;
            lable2.Text = "Number Invoice:";
            // 
            // label2
            // 
            label2.Location = new Point(567, 107);
            label2.Name = "label2";
            label2.Size = new Size(104, 41);
            label2.TabIndex = 22;
            label2.Text = "Date:";
            // 
            // Number_Invoice
            // 
            Number_Invoice.ForeColor = Color.Red;
            Number_Invoice.Location = new Point(257, 104);
            Number_Invoice.Name = "Number_Invoice";
            Number_Invoice.Size = new Size(290, 47);
            Number_Invoice.TabIndex = 21;
            Number_Invoice.TextAlign = HorizontalAlignment.Center;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1249, 708);
            Controls.Add(pmain);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            Load += App_Load;
            SizeChanged += App_SizeChanged;
            pmain.ResumeLayout(false);
            pmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pmain;
        private Label label4;
        private TextBox Date;
        private TextBox name;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lable2;
        private Label label2;
        private TextBox Number_Invoice;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private ComboBox Category;
        private Label label5;
        private DataGridView dataGridView1;
        private NumericUpDown quantity;
        private Label label7;
        private DataGridViewTextBoxColumn coliteam;
        private DataGridViewTextBoxColumn colqty;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn colsubtotal;
        private TextBox textBox2;
        private Label label8;
        private Button button2;
        private Button add;
    }
}
