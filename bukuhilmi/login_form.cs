using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bukuhilmi
{
    public partial class login_form : Form
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public login_form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"SELECT * FROM kasir WHERE username = '{username_input.Text}' AND password = '{password_input.Text}'";
            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);
            if (tabel.Rows.Count > 0)
            {
                reader = command.ExecuteReader();
                reader.Read();
                Model.username = reader.GetString(4);
                Model.name = reader.GetString(1);
                Model.idkasir = reader.GetInt32(0);

                this.Hide();
                dashboard dashmenu = new dashboard();
                dashmenu.Show();
            } 
            else
            {
                MessageBox.Show("Invalid login");
            }
        }

        private void exitApp_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
