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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            pmain = new Panel();
            quantity = new TextBox();
            price = new TextBox();
            button2 = new Button();
            add = new Button();
            total = new TextBox();
            label8 = new Label();
            dgv = new DataGridView();
            coliteam = new DataGridViewTextBoxColumn();
            colqty = new DataGridViewTextBoxColumn();
            colprice = new DataGridViewTextBoxColumn();
            colsubtotal = new DataGridViewTextBoxColumn();
            label7 = new Label();
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
            error = new ErrorProvider(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // pmain
            // 
            pmain.Controls.Add(quantity);
            pmain.Controls.Add(price);
            pmain.Controls.Add(button2);
            pmain.Controls.Add(add);
            pmain.Controls.Add(total);
            pmain.Controls.Add(label8);
            pmain.Controls.Add(dgv);
            pmain.Controls.Add(label7);
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
            pmain.Location = new Point(10, 12);
            pmain.Name = "pmain";
            pmain.Size = new Size(1227, 881);
            pmain.TabIndex = 9;
            // 
            // quantity
            // 
            quantity.ForeColor = Color.Black;
            quantity.Location = new Point(646, 322);
            quantity.Name = "quantity";
            quantity.Size = new Size(196, 47);
            quantity.TabIndex = 40;
            quantity.Text = "0";
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.TextChanged += quantity_TextChanged;
            quantity.Enter += quantity_Enter;
            quantity.KeyDown += quantity_KeyDown_1;
            quantity.KeyPress += quantity_KeyPress;
            // 
            // price
            // 
            price.BackColor = Color.Green;
            price.ForeColor = Color.White;
            price.Location = new Point(257, 324);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(227, 47);
            price.TabIndex = 39;
            price.TextAlign = HorizontalAlignment.Center;
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
            button2.Click += button2_Click;
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
            // total
            // 
            total.BackColor = Color.DarkViolet;
            total.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.Gold;
            total.Location = new Point(848, 322);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(177, 51);
            total.TabIndex = 36;
            total.Text = "0";
            total.TextAlign = HorizontalAlignment.Center;
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
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { coliteam, colqty, colprice, colsubtotal });
            dgv.Location = new Point(8, 378);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1216, 500);
            dgv.TabIndex = 34;
            dgv.CellEndEdit += dgv_CellEndEdit;
            dgv.EditingControlShowing += dgv_EditingControlShowing;
            // 
            // coliteam
            // 
            coliteam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coliteam.HeaderText = "Iteam";
            coliteam.MinimumWidth = 6;
            coliteam.Name = "coliteam";
            coliteam.ReadOnly = true;
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
            colprice.ReadOnly = true;
            // 
            // colsubtotal
            // 
            colsubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colsubtotal.HeaderText = "SubTotal";
            colsubtotal.MinimumWidth = 6;
            colsubtotal.Name = "colsubtotal";
            colsubtotal.ReadOnly = true;
            // 
            // label7
            // 
            label7.Location = new Point(490, 325);
            label7.Name = "label7";
            label7.Size = new Size(150, 44);
            label7.TabIndex = 32;
            label7.Text = "Quantity";
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
            Category.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Category.AutoCompleteSource = AutoCompleteSource.ListItems;
            Category.FormattingEnabled = true;
            Category.Location = new Point(257, 267);
            Category.Name = "Category";
            Category.Size = new Size(585, 49);
            Category.TabIndex = 28;
            Category.SelectedIndexChanged += Category_SelectedIndexChanged;
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
            Date.Location = new Point(677, 107);
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
            Number_Invoice.Text = "00000312";
            Number_Invoice.TextAlign = HorizontalAlignment.Center;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1249, 905);
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
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
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
        private Label label6;
        private ComboBox Category;
        private Label label5;
        private DataGridView dgv;
        private Label label7;
        private TextBox total;
        private Label label8;
        private Button button2;
        private Button add;
        private TextBox price;
        private TextBox quantity;
        private DataGridViewTextBoxColumn coliteam;
        private DataGridViewTextBoxColumn colqty;
        private DataGridViewTextBoxColumn colprice;
        private DataGridViewTextBoxColumn colsubtotal;
        private ErrorProvider error;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
