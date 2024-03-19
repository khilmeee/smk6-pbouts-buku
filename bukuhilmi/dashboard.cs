using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bukuhilmi
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            logged_as.Text = $"{Model.username}({Model.idkasir})";
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form loginmenu = new login_form();
            loginmenu.Show();
        }

        private void dashboard_buku1_Load(object sender, EventArgs e)
        {
            
        }

        private void penjualan_button_open_Click(object sender, EventArgs e)
        {
            dashboard_penjualan penjualanMenu = this.Controls.OfType<dashboard_penjualan>().FirstOrDefault();
            if (penjualanMenu == null)
            {
                penjualanMenu = new dashboard_penjualan();
                this.Controls.Add(penjualanMenu);
            }
            penjualanMenu.BringToFront();

        }

        private void buku_button_open_Click(object sender, EventArgs e)
        {
            dashboard_buku bukuMenu = this.Controls.OfType<dashboard_buku>().FirstOrDefault();
            if(bukuMenu == null)
            {
                bukuMenu = new dashboard_buku();
                this.Controls.Add(bukuMenu);
            }
            bukuMenu.BringToFront();
        }
    }
}
