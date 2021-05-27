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

namespace MasterBarang018
{
    public partial class MasterBarang018 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog = QuizMahasiswa;Integrated Security = True;");

        public MasterBarang018()
        {
            InitializeComponent();
        }
        barangQDataContext db = new barangQDataContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string barang = txtNamaBarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stock = int.Parse(txtStock.Text);
            int col = int.Parse(cbSupp.Text);

            var data = new tbl_barang
            {
                id_barang = id,
                nama_barang = barang,
                harga = harga,
                stok = stock,
                nama_supplier = col
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Sukses Menambahkan Barang");
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStock.Clear();
            cbSupp.Items.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbSupp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MasterBarang018_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)),0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();         
        }
    }
}
