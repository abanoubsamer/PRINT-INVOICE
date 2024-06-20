using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRINT_INVOICE
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.businessman_team_recruitment_employee_resources_human_resource_icon_210723;
            IntPtr iconHandle = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(iconHandle);

            Dictionary<int, string> data = new Dictionary<int, string>();
            data.Add(1000, "Labtop 11");
            data.Add(2000, "Iphone 13 promax");
            data.Add(3000, "Samsung S24 Alter");
            data.Add(4000, "Dell 58");
            data.Add(10400, "Bike binelly");
            data.Add(20054, "Iphone 14 pro");
            data.Add(30540, "Oppo A16K");
            data.Add(40540, "Oppo Reno 10");

            Category.DataSource = new BindingSource(data, null);
            Category.DisplayMember = "Value";
            Category.ValueMember = "Key";

            if (Category.SelectedValue != null)
            {
                price.Text = Category.SelectedValue.ToString();
            }

            dgv.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dgv.Columns[3].DefaultCellStyle.ForeColor = Color.Red;

            this.Icon = icon;

            name.Focus();
            name.Select();
            Date.Text = DateTime.Now.ToString("yyyy/MM/dd");

            // Read and display the last invoice number
            int lastInvoiceNumber = GetLastInvoiceNumber();
            Number_Invoice.Text = (lastInvoiceNumber + 1).ToString();
        }

        private void App_SizeChanged(object sender, EventArgs e)
        {
            int x = (this.Width - pmain.Width) / 2;
            int y = (this.Height - pmain.Height) / 2;
            pmain.Location = new Point(x, y);
        }

        private void label8_Click(object sender, EventArgs e) { }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Category.Focus();
            }
        }

        private void Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                quantity.Select();
                quantity.Focus();
            }
        }

        int qty = 1;
        int p;
        int sub;
        int t;

        private void add_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            // Check ID
            if (name.Text.Trim() == "")
            {
                error.SetError(name, "Please Enter Name");
                hasError = true;
            }
            else
            {
                error.SetError(name, "");
            }

            // Check Name
            if (Category.SelectedIndex <= -1)
            {
                error.SetError(Category, "Please Enter Catrgory");
                hasError = true;
            }
            else
            {
                error.SetError(Category, "");
            }

            // Check Address
            if (quantity.Text.Trim() == "" || quantity.Text == "0")
            {
                error.SetError(quantity, "Please Enter Quantity");
                hasError = true;
            }
            else
            {
                error.SetError(quantity, "");
            }

            if (hasError)
            {
                return;
            }

            string item = Category.Text;
            // Add the row to the DataGridView
            object[] row = { item, qty, p, sub };
            total.Text = (t += sub).ToString();
            dgv.Rows.Add(row);
            // Clear the input fields
            quantity.Text = "0";
           
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Category.SelectedValue != null)
            {
                price.Text = Category.SelectedValue.ToString();
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantity.Text) || string.IsNullOrEmpty(price.Text) || string.IsNullOrEmpty(name.Text))
            {
                return;
            }
            int temp = t;
            qty = Convert.ToInt32(quantity.Text);
            p = Convert.ToInt32(price.Text);
            sub = qty * p;
            total.Text = (temp += sub).ToString();
        }

        private void quantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                add.PerformClick();
                name.Focus();
                name.Select();
            }
        }

        private void quantity_Enter(object sender, EventArgs e)
        {
            quantity_TextChanged(sender, e);
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtEdit = e.Control as TextBox;
            if (txtEdit != null)
            {
                txtEdit.KeyPress -= new KeyPressEventHandler(txtEdit_KeyPress);
                txtEdit.KeyPress += new KeyPressEventHandler(txtEdit_KeyPress);
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ColumnIndex == 1)
            {
                int value1 = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
                int value2 = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value);

                // Perform the multiplication
                int result = value1 * value2;

                t += result - Convert.ToInt32(dgv.CurrentRow.Cells[3].Value);
                total.Text = t.ToString();

                // Set the result in cell 3
                dgv.CurrentRow.Cells[3].Value = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e) { }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define the fonts and brushes to use
            System.Drawing.Font font = this.Font;
            Brush redBrush = Brushes.Red;
            Brush blackBrush = Brushes.Black;
            Brush darkBlueBrush = Brushes.DarkBlue;

            // Define the strings to print
            string strNo = "#NO: " + Number_Invoice.Text;
            string date = "Date: " + Date.Text;
            string customer = "Customer: " + name.Text;
            string Total = "Total:" + total.Text;

            // Measure the string sizes
            SizeF strNoSize = e.Graphics.MeasureString(strNo, font);
            SizeF dateSize = e.Graphics.MeasureString(date, font);
            SizeF customerSize = e.Graphics.MeasureString(customer, font);
            SizeF Totalsize = e.Graphics.MeasureString(Total, font);

            // Draw the image
            e.Graphics.DrawImage(Properties.Resources.businessman_team_recruitment_employee_resources_human_resource_icon_210723, 370, 10);

            // Draw the strings with calculated positions
            e.Graphics.DrawString(Total, font, redBrush, (e.PageBounds.Width - Totalsize.Width) - 100, 180);
            e.Graphics.DrawString(strNo, font, redBrush, (e.PageBounds.Width - strNoSize.Width) / 2, 130);
            e.Graphics.DrawString(date, font, blackBrush, (e.PageBounds.Width - dateSize.Width) / 10, 160);
            e.Graphics.DrawString(customer, font, darkBlueBrush, (e.PageBounds.Width - customerSize.Width) / 10, 190);

            // Draw the table
            float startX = 20;
            float startY = 250;
            float tableWidth = e.PageBounds.Width - 2 * startX;
            float tableHeight = e.PageBounds.Height - 280;
            float colHeight = 60;
            float col1Width = 300;
            float col2Width = 120;
            float col3Width = 120;
            float col4Width = 120;

            // Draw the table rectangle
            e.Graphics.DrawRectangle(Pens.Black, startX, startY, tableWidth, tableHeight);

            // Draw the column header line
            float rowHeight = startY + colHeight;
            e.Graphics.DrawLine(Pens.Black, startX, rowHeight, startX + tableWidth, rowHeight);

            // Draw the column headers
            e.Graphics.DrawString("Item", font, blackBrush, startX + (col1Width - e.Graphics.MeasureString("Item", font).Width) / 2, startY + (colHeight - font.Height) / 2);
            e.Graphics.DrawString("Qty", font, blackBrush, startX + col1Width + (col2Width - e.Graphics.MeasureString("Qty", font).Width) / 2, startY + (colHeight - font.Height) / 2);
            e.Graphics.DrawString("Price", font, blackBrush, startX + col1Width + col2Width + (col3Width - e.Graphics.MeasureString("Price", font).Width) / 2, startY + (colHeight - font.Height) / 2);
            e.Graphics.DrawString("Subtotal", font, blackBrush, startX + col1Width + col2Width + col3Width + (col4Width - e.Graphics.MeasureString("Subtotal", font).Width) / 2, startY + (colHeight - font.Height) / 2);

            // Draw the vertical lines for the columns
            e.Graphics.DrawLine(Pens.Black, startX + col1Width, startY, startX + col1Width, startY + tableHeight);
            e.Graphics.DrawLine(Pens.Black, startX + col1Width + col2Width, startY, startX + col1Width + col2Width, startY + tableHeight);
            e.Graphics.DrawLine(Pens.Black, startX + col1Width + col2Width + col3Width, startY, startX + col1Width + col2Width + col3Width, startY + tableHeight);

            // You can continue to add rows and additional content as needed
            float currentY = rowHeight; // Starting y position for rows
            float rowHeightIncrement = 60; // Height of each row

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //if (dgv.Rows[i].IsNewRow) continue; // Skip the new row placeholder

                e.Graphics.DrawString(dgv.Rows[i].Cells[0].Value.ToString(), font, blackBrush, startX + (col1Width - e.Graphics.MeasureString(dgv.Rows[i].Cells[0].Value.ToString(), font).Width) / 2, currentY + (rowHeightIncrement - font.Height) / 2);
                e.Graphics.DrawString(dgv.Rows[i].Cells[1].Value.ToString(), font, blackBrush, startX + col1Width + (col2Width - e.Graphics.MeasureString(dgv.Rows[i].Cells[1].Value.ToString(), font).Width) / 2, currentY + (rowHeightIncrement - font.Height) / 2);
                e.Graphics.DrawString(dgv.Rows[i].Cells[2].Value.ToString(), font, blackBrush, startX + col1Width + col2Width + (col3Width - e.Graphics.MeasureString(dgv.Rows[i].Cells[2].Value.ToString(), font).Width) / 2, currentY + (rowHeightIncrement - font.Height) / 2);
                e.Graphics.DrawString(dgv.Rows[i].Cells[3].Value.ToString(), font, blackBrush, startX + col1Width + col2Width + col3Width + (col4Width - e.Graphics.MeasureString(dgv.Rows[i].Cells[3].Value.ToString(), font).Width) / 2, currentY + (rowHeightIncrement - font.Height) / 2);

                // Draw horizontal line to separate rows
                currentY += rowHeightIncrement;
                e.Graphics.DrawLine(Pens.Black, startX, currentY, startX + tableWidth, currentY);
            }
        }

        private int GetLastInvoiceNumber()
        {
            string filePath = "invoiceNumber.txt";
            if (File.Exists(filePath))
            {
                string lastInvoiceNumber = File.ReadAllText(filePath);
                if (int.TryParse(lastInvoiceNumber, out int invoiceNumber))
                {
                    return invoiceNumber;
                }
            }
            return 1000; // Default start value if file does not exist or contains invalid data
        }

        private void SaveCurrentInvoiceNumber(int currentInvoiceNumber)
        {
            string filePath = "invoiceNumber.txt";
            File.WriteAllText(filePath, currentInvoiceNumber.ToString());
        }
    }
}
