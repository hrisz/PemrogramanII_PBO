using MySql.Data.MySqlClient;
using P11_714220061.Controller;
using P11_714220061.Model;
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

namespace P11_714220061.View
{
    public partial class FormTransaksiBarang : Form
    {
        Connect connect = new Connect();
        string id_transaksi;
        M_transaksi_barang mtf = new M_transaksi_barang();
        M_barang m_barang = new M_barang();

        public void View()
        {
            DataTransaksi.DataSource = connect.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "QTY";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }

        public void resetForm()
        {
            id_barang.Text = "";
            nama_barang.Text = "";
            harga.Text = "";
            qty.Text = "";
            total.Text = "";
            tbCariData.Text = "";
        }

        public void GetDataBarang(int selectIdBarang)
        {
            connect.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = connect.reader(query);

            if (reader.Read())
            {
                nama_barang.Text = reader["nama_barang"].ToString();
                harga.Text = reader["harga"].ToString();
            }

            reader.Close();
            connect.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(qty.Text, out double qty_barang) && double.TryParse(harga.Text.Replace(".", ""), out double harga_barang))
            {
                double totals = qty_barang * harga_barang;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                total.Text = formattedTotal;
            }
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        public FormTransaksiBarang()
        {
            InitializeComponent();
            nama_barang.ReadOnly = true;
            nama_barang.Enabled = false;
            harga.Enabled = false;
            harga.ReadOnly = true;
            total.Enabled = false;
            total.ReadOnly = true;

            LoadIdBarang();
        }

        public void LoadIdBarang()
        {
            connect.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = connect.ShowData(query);

            id_barang.DisplayMember = "id_barang";
            id_barang.ValueMember = "id_barang";
            id_barang.DataSource = dataTable;

            connect.CloseConnection();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            View();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (id_barang.Text == "" || nama_barang.Text == "" || harga.Text == "" || qty.Text == "" || total.Text == "" || id_barang.Text.Any(Char.IsLetter) || qty.Text.Any(Char.IsLetter) || id_barang.SelectedItem == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tf = new TransaksiBarang();
                mtf.Id_barang = id_barang.Text;
                mtf.Qty = qty.Text;

                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtf.Total = numericTotal.ToString();
                }

                tf.Insert(mtf);
                resetForm();
                View();
            }
        }

        private void id_barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_barang.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(id_barang.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }

        private void harga_TextChanged(object sender, EventArgs e)
        {
            FormatDigit(harga);
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_barang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama_barang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            harga.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            qty.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();

            TotalHarga();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_barang.Text != "" || nama_barang.Text != "" || harga.Text != "" || qty.Text != "" || total.Text != "" || !id_barang.Text.Any(Char.IsLetter) || !qty.Text.Any(Char.IsLetter) || id_barang.SelectedItem != null)
            {
                TransaksiBarang tf = new TransaksiBarang();
                mtf.Id_barang = id_barang.Text;
                mtf.Qty = qty.Text;

                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    mtf.Total = numericTotal.ToString();
                }

                tf.Update(mtf, id_transaksi);
                resetForm();
                View();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = connect.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang tf = new TransaksiBarang();
                tf.Delete(id_transaksi);
                resetForm();
                View();
            }
        }
    }
}
