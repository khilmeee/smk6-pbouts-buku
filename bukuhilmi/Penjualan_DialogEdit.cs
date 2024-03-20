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
    public partial class Penjualan_DialogEdit : UserControl
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public Penjualan_DialogEdit()
        {
            InitializeComponent();

            reload();
        }

        public void reload()
        {
            loadData();
        }
        public void loadData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = $"SELECT * FROM penjualan WHERE id_penjualan = '{Model.idpenjualan}'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                
                dateTimePicker_tanggal.Value = reader.GetDateTime(3);
                input_jumlah.Text = reader.GetInt32(5).ToString();
                showBukuInComboBox(reader.GetInt32(2));

            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public void showBukuInComboBox(int idbuku)
        {
            connection.Close();
            connection.Open();

            string sql = "SELECT * FROM buku";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            command.ExecuteNonQuery();
            connection.Close();

            comboBox_buku.DataSource = dataSet.Tables[0];
            comboBox_buku.DisplayMember = "judul";
            comboBox_buku.ValueMember = "id_buku";
            comboBox_buku.SelectedValue = idbuku;
        }

        public SqlCommand command;
        public void editData()
        {
            try
            {
                if(!string.IsNullOrEmpty(dateTimePicker_tanggal.Text) && !string.IsNullOrEmpty(input_jumlah.Text)
                    && !string.IsNullOrEmpty(comboBox_buku.Text))
                {
                    DialogResult result = MessageBox.Show($"anda yakin ingin mengubah data penjualan (ID: {Model.idpenjualan})?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Close();
                            connection.Open();
                            
                            string sql = $"UPDATE penjualan SET id_buku = '{comboBox_buku.SelectedValue}', jumlah = '{input_jumlah.Text}', " +
                            $"tgl_jual = '{dateTimePicker_tanggal.Value.ToString("yyyy-MM-dd")}', " +
                            $"harga = '{Convert.ToInt32(input_jumlah.Text)*Model.global_harga}'" +
                            $"WHERE id_penjualan = '{Model.idpenjualan}'";

                            command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"penjualan (ID: {Model.idpenjualan}) berhasil update", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            reload();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
            finally
            {

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
