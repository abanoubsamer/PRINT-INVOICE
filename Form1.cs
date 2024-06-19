

using System.Xml.Linq;

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

            this.Icon = icon;

            name.Focus();
            name.Select();
            Date.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void App_SizeChanged(object sender, EventArgs e)
        {
            int x = (this.Width - pmain.Width) / 2;
            int y = (this.Height - pmain.Height) / 2;
            pmain.Location = new Point(x, y);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

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
                quantity.Text = string.Empty;
                quantity.Select();
                quantity.Focus();
            }
        }

        private void quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //add_Click(sender, e);
                add.PerformClick();
                name.Focus();
                name.Select();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("add");
        }
    }
}
