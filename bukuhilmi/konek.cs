using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bukuhilmi
{
    class konek
    {
        public static string conn = "Data Source=MIWON\\SQLEXPRESS;Initial Catalog=bukuhilmidb;Integrated Security=True;";
    }

    public class Model
    {
        public static string username { get; set; }
        public static string name { get; set; }
        public static int idkasir {  get; set; }
        public static string penjualan_total_buku { get; set; }
        public static int idbuku { get; set; }
        public static int global_harga { get; set; }
        public static int global_stok_buku { get; set; }
        public static int idpenjualan { get; set; }
        public static int penjualan_selectedBuku { get; set; }
    }
}
