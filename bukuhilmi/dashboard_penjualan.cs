using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bukuhilmi
{
    public partial class dashboard_penjualan : UserControl
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataSet;
        public SqlDataReader reader;
        public dashboard_penjualan()
        {
            InitializeComponent();

            showBukuInComboBox();
            showDetailBuku_label();
        }

        public void showBukuInComboBox()
        {
            connection.Close();
            connection.Open();

            string sql = "SELECT * FROM buku";
            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            command.ExecuteNonQuery();
            connection.Close();

            combo_buku.DataSource = dataSet.Tables[0];
            combo_buku.DisplayMember = "judul";
            combo_buku.ValueMember = "id_buku";
        }

        public void showDetailBuku_label()
        {
            if (combo_buku.SelectedIndex != -1)
            {
                if (int.TryParse(combo_buku.SelectedValue.ToString(), out int selectedBookId))
                {
                    string sql1 = "SELECT * FROM buku WHERE id_buku = @id_buku";

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@id_buku", selectedBookId);
                        using (SqlDataAdapter detail_adapter = new SqlDataAdapter(command))
                        {
                            DataSet detail_dataSet = new DataSet();
                            detail_adapter.Fill(detail_dataSet);
                            if (detail_dataSet.Tables[0].Rows.Count > 0)
                            {
                                DataRow row = detail_dataSet.Tables[0].Rows[0];
                                string hargaFormatted = Convert.ToDecimal(row["harga_buku"]).ToString("C0", new CultureInfo("id-ID"));
                                string detailBuku = $"Judul: {row["judul"]}\nPenulis: {row["penulis"]}\nPenerbit: {row["penerbit"]}\nTahun Terbit: {row["tahun"]}\nStok: {row["stok"]}\nHarga: {hargaFormatted}";
                                label_detailBuku.Text = detailBuku;
                            }
                        }
                    }
                }
            }
        }

        private void combo_buku_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_penjualan_Load(object sender, EventArgs e)
        {

        }

        private void combo_buku_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDetailBuku_label();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showBukuInComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
