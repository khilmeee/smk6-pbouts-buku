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
    public partial class dashboard_buku : UserControl
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public int id_buku;
        public string judul_buku;
        public dashboard_buku()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT * FROM buku";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.Columns[0].Visible=false;
                dataGridView1.Columns[1].HeaderText = "Judul";
                dataGridView1.Columns[2].HeaderText = "Penulis";
                dataGridView1.Columns[3].HeaderText = "Penerbit";
                dataGridView1.Columns[4].HeaderText = "Tahun";
                dataGridView1.Columns[5].HeaderText = "Stok";
                dataGridView1.Columns[6].HeaderText = "Harga";
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:"+ex);
            }
        }

        public void insertData()
        {
            if (!string.IsNullOrEmpty(input_buku_judul.Text) && !string.IsNullOrEmpty(input_buku_penulis.Text)
                && !string.IsNullOrEmpty(input_buku_penerbit.Text) && !string.IsNullOrEmpty(input_buku_tahun.Text)
                && !string.IsNullOrEmpty(input_buku_stok.Text) && !string.IsNullOrEmpty(input_buku_harga.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string sql = $"INSERT INTO buku (judul,penulis,penerbit,tahun,stok,harga_buku) " +
                        $"VALUES ('{input_buku_judul.Text}', '{input_buku_penulis.Text}', '{input_buku_penerbit.Text}', " +
                        $"'{input_buku_tahun.Text}', '{input_buku_stok.Text}', '{input_buku_harga.Text}')";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("isi datanya");
            }
        }

        public void editData()
        {
            if(dataGridView1.CurrentRow.Selected)
            {
                if(!string.IsNullOrEmpty(input_buku_judul.Text) && !string.IsNullOrEmpty(input_buku_penulis.Text)
                && !string.IsNullOrEmpty(input_buku_penerbit.Text) && !string.IsNullOrEmpty(input_buku_tahun.Text)
                && !string.IsNullOrEmpty(input_buku_stok.Text) && !string.IsNullOrEmpty(input_buku_harga.Text))
                {
                    DialogResult result = MessageBox.Show($"anda yakin ingin mengubah data buku (ID: {id_buku} - {judul_buku})?","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        string sql = $"UPDATE buku SET judul = '{input_buku_judul.Text}', penulis = '{input_buku_penulis.Text}'," +
                            $"penerbit = '{input_buku_penerbit.Text}', tahun = '{input_buku_tahun.Text}'," +
                            $"stok = '{Convert.ToInt32(input_buku_stok.Text)}', harga_buku = '{Convert.ToInt32(input_buku_harga.Text)}'" +
                            $"WHERE id_buku = '{id_buku}'";

                        command = new SqlCommand(sql, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show($"buku (ID: {id_buku} - {judul_buku}) berhasil update", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                            showData();
                        } 
                        catch(Exception ex)
                        {
                            MessageBox.Show("error: " + ex);
                        }
                    }
                } 
                else
                {
                    MessageBox.Show("isi datanya");
                }
            } 
            else
            {
                MessageBox.Show("pilih datanya", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteData()
        {
            if(dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(input_buku_judul.Text) && !string.IsNullOrEmpty(input_buku_penulis.Text)
                && !string.IsNullOrEmpty(input_buku_penerbit.Text) && !string.IsNullOrEmpty(input_buku_tahun.Text)
                && !string.IsNullOrEmpty(input_buku_stok.Text) && !string.IsNullOrEmpty(input_buku_harga.Text))
                {
                    DialogResult result = MessageBox.Show($"Anda yakin ingin menghapus buku (ID: {id_buku} - {judul_buku})?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = $"DELETE FROM buku WHERE id_buku = {id_buku}";
                        command = new SqlCommand(sql, connection);
                        try
                        {
                            connection.Close();
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Buku (ID: {id_buku} - {judul_buku}) berhasil dihapus","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("isi datanya");
                }
            }
            else
            {
                MessageBox.Show("pilih datanya");
            }
        }

        public void searchData()
        {
            if(!string.IsNullOrEmpty(input_search.Text))
            {
                try
                {
                    connection.Open();
                    string sql = $"SELECT * FROM buku WHERE id_buku LIKE '%{input_search.Text}%' OR" +
                        $" judul LIKE '%{input_search.Text}%' OR" +
                        $" penulis LIKE '%{input_search.Text}%' OR" +
                        $" penerbit LIKE '%{input_search.Text}%' OR" +
                        $" tahun LIKE '%{input_search.Text}%'";

                    command = new SqlCommand(sql, connection);
                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Judul";
                    dataGridView1.Columns[2].HeaderText = "Penulis";
                    dataGridView1.Columns[3].HeaderText = "Penerbit";
                    dataGridView1.Columns[4].HeaderText = "Tahun";
                    dataGridView1.Columns[5].HeaderText = "Stok";
                    dataGridView1.Columns[6].HeaderText = "Harga";
                    
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

        public void clear()
        {
            input_buku_judul.Clear();
            input_buku_penulis.Clear();
            input_buku_penerbit.Clear();
            input_buku_tahun.Clear();
            input_buku_stok.Clear();
            input_buku_harga.Clear();
        }

        public void reload()
        {
            clear();
            showData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_buku_add_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void button_buku_edit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            
            id_buku = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            judul_buku = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            input_buku_judul.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_buku_penulis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            input_buku_penerbit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            input_buku_tahun.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            input_buku_stok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            input_buku_harga.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_buku_delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void input_search_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void input_buku_tahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Jika karakter pertama adalah angka 0 dan belum ada angka lain dimasukkan sebelumnya
            else if (e.KeyChar == '0' && textBox.TextLength == 0)
            {
                e.Handled = true;
            }
        }

        private void input_buku_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Jika karakter pertama adalah angka 0 dan belum ada angka lain dimasukkan sebelumnya
            else if (e.KeyChar == '0' && textBox.TextLength == 0)
            {
                e.Handled = true;
            }
        }

        private void input_buku_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Jika karakter pertama adalah angka 0 dan belum ada angka lain dimasukkan sebelumnya
            else if (e.KeyChar == '0' && textBox.TextLength == 0)
            {
                e.Handled = true;
            }
        }
    }
}
