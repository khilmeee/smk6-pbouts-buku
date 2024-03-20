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
    public partial class Penjualan_QuestionAdd : UserControl
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public Penjualan_QuestionAdd()
        {
            InitializeComponent();
        }

        public void insertPenjualan()
        {
            if (!string.IsNullOrEmpty(input_penjualanQuestion_add.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    int jumlah = Convert.ToInt32(input_penjualanQuestion_add.Text);
                    int total = jumlah * Model.global_harga;

                    int currentStock = Model.global_stok_buku;
                    if (currentStock >= jumlah)
                    {
                        connection.Close();
                        connection.Open();
                        int finalStock = currentStock - jumlah;
                        string sql = $"UPDATE buku SET stok = '{finalStock}'" +
                            $" WHERE id_buku = '{Model.idbuku}'";

                        string sql1 = $"INSERT INTO penjualan (id_kasir,id_buku,tgl_jual,jumlah,harga)" +
                        $"VALUES (@id_kasir,@id_buku,@tgl_jual,@jumlah,@harga)";
                        command = new SqlCommand(sql, connection);
                        command1 = new SqlCommand(sql1, connection);

                        command1.Parameters.AddWithValue("@id_kasir", Model.idkasir);
                        command1.Parameters.AddWithValue("@id_buku", Model.idbuku);
                        command1.Parameters.AddWithValue("@tgl_jual", DateTime.Now);
                        command1.Parameters.AddWithValue("@jumlah", jumlah);
                        command1.Parameters.AddWithValue("@harga", total);

                        command1.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Stock tidak mencukupi");
                    }
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

        private void button_penjualanQuestion_add_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(input_penjualanQuestion_add.Text))
            {
                Model.penjualan_total_buku = input_penjualanQuestion_add.Text;
                insertPenjualan();
                this.Hide();
            }
            else
            {
                MessageBox.Show("harap isi");
            }
        }

        private void input_penjualanQuestion_add_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button_question_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
