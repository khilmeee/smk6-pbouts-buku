using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
        public string id_penjualan;
        public dashboard_penjualan()
        {
            InitializeComponent();

            reload(); // nampilin semua data
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
                        Model.penjualan_selectedBuku = selectedBookId;
                        using (SqlDataAdapter detail_adapter = new SqlDataAdapter(command))
                        {
                            DataSet detail_dataSet = new DataSet();
                            detail_adapter.Fill(detail_dataSet);
                            if (detail_dataSet.Tables[0].Rows.Count > 0)
                            {
                                DataRow row = detail_dataSet.Tables[0].Rows[0];
                                string _idbuku = $"{row["id_buku"]}";
                                string _harga = $"{row["harga_buku"]}";
                                string _stok = $"{row["stok"]}";
                                Model.idbuku = Convert.ToInt32(_idbuku);
                                Model.global_harga = Convert.ToInt32(_harga);
                                Model.global_stok_buku = Convert.ToInt32(_stok);
                                string hargaFormatted = Convert.ToDecimal(row["harga_buku"]).ToString("C0", new CultureInfo("id-ID"));
                                string detailBuku = $"Judul: {row["judul"]}\nPenulis: {row["penulis"]}\nPenerbit: {row["penerbit"]}\nTahun Terbit: {row["tahun"]}\nStok: {row["stok"]}\nHarga: {hargaFormatted}";
                                label_detailBuku.Text = detailBuku;
                            }
                        }
                    }
                }
            }
        }

        public void showDialogQuestion()
        {
            Penjualan_QuestionAdd penjualanQuestionMenu = this.Controls.OfType<Penjualan_QuestionAdd>().FirstOrDefault();
            if (penjualanQuestionMenu == null)
            {
                penjualanQuestionMenu = new Penjualan_QuestionAdd();
                penjualanQuestionMenu.Anchor = AnchorStyles.None; // agar user control tetap di tengah saat ukuran form berubah
                penjualanQuestionMenu.Location = new Point((this.ClientSize.Width - penjualanQuestionMenu.Width) / 2, (this.ClientSize.Height - penjualanQuestionMenu.Height) / 2);
                this.Controls.Add(penjualanQuestionMenu);
            }
            penjualanQuestionMenu.BringToFront();
            penjualanQuestionMenu.Show();
        }

        public void reload()
        {
            showData();
            showBukuInComboBox();
            showDetailBuku_label();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql_showData = "SELECT * FROM penjualan JOIN kasir ON penjualan.id_kasir = kasir.id_kasir " +
                    "JOIN buku ON penjualan.id_buku = buku.id_buku";
                SqlCommand command_showData = new SqlCommand(sql_showData, connection);
                SqlDataAdapter adapter_showData = new SqlDataAdapter(command_showData);
                DataTable tabel_showData = new DataTable();
                adapter_showData.Fill(tabel_showData);

                dataGridView1.DataSource = tabel_showData;
                dataGridView1.Columns[0].HeaderText = "ID Transaksi";
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Tanggal";
                dataGridView1.Columns[4].HeaderText = "Total Harga";
                dataGridView1.Columns[5].HeaderText = "Jumlah";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Nama Kasir";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].HeaderText = "Judul Buku";
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].HeaderText = "Harga Satuan";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(id_penjualan))
                {
                    DialogResult result = MessageBox.Show($"Anda yakin ingin menghapus penjualan (ID: {id_penjualan})?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = $"DELETE FROM penjualan WHERE id_penjualan = {id_penjualan}";
                        command = new SqlCommand(sql, connection);
                        try
                        {
                            connection.Close();
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Penjualan (ID: {id_penjualan}) berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("pilih datanya");
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(input_search.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string sql = $"SELECT * FROM penjualan JOIN kasir ON penjualan.id_kasir = kasir.id_kasir " +
                    $"JOIN buku ON penjualan.id_buku = buku.id_buku" +
                    $" WHERE penjualan.id_buku LIKE '%{input_search.Text}%' OR " +
                    $"id_penjualan LIKE '%{input_search.Text}%' OR " +
                    $"judul LIKE '%{input_search.Text}%' OR " +
                    $"penulis LIKE '%{input_search.Text}%' OR " +
                    $"penerbit LIKE '%{input_search.Text}%'";

                    command = new SqlCommand(sql, connection);
                    adapter = new SqlDataAdapter(command);
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;
                    dataGridView1.Columns[0].HeaderText = "ID Transaksi";
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].HeaderText = "Tanggal";
                    dataGridView1.Columns[4].HeaderText = "Total Harga";
                    dataGridView1.Columns[5].HeaderText = "Jumlah";
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].HeaderText = "Nama Kasir";
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[13].HeaderText = "Judul Buku";
                    dataGridView1.Columns[14].Visible = false;
                    dataGridView1.Columns[15].Visible = false;
                    dataGridView1.Columns[16].Visible = false;
                    dataGridView1.Columns[17].HeaderText = "Stok";
                    dataGridView1.Columns[18].HeaderText = "Harga Satuan";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex);
                }
                finally
                {
                    connection.Close();
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
            showData();
            showDetailBuku_label();
        }

        private void button_penjualan_add_Click(object sender, EventArgs e)
        {
            if (combo_buku.SelectedIndex != -1)
            {
                showDialogQuestion();
            }
            else
            {
                MessageBox.Show("silahkan pilih bukunya");
            }
        }

        private void button_penjualan_edit_Click(object sender, EventArgs e)
        {
            if (combo_buku.SelectedIndex != -1 && dataGridView1.CurrentRow.Selected)
            {
                Penjualan_DialogEdit penjualEditMenu = this.Controls.OfType<Penjualan_DialogEdit>().FirstOrDefault();
                if (penjualEditMenu == null)
                {
                    penjualEditMenu = new Penjualan_DialogEdit();
                    penjualEditMenu.Anchor = AnchorStyles.None; // agar user control tetap di tengah saat ukuran form berubah
                    penjualEditMenu.Location = new Point((this.ClientSize.Width - penjualEditMenu.Width) / 2, (this.ClientSize.Height - penjualEditMenu.Height) / 2);
                    this.Controls.Add(penjualEditMenu);
                }
                penjualEditMenu.BringToFront();
                penjualEditMenu.Show();

            }
            else
            {
                MessageBox.Show("silahkan pilih bukunya");
            }
        }

        private void button_penjualan_delete_Click(object sender, EventArgs e)
        {
            if (combo_buku.SelectedIndex != -1)
            {
                deleteData();
            }
            else
            {
                MessageBox.Show("silahkan pilih bukunya");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            id_penjualan = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Model.penjualan_selectedBuku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            Model.idpenjualan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);        }

        private void input_search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
