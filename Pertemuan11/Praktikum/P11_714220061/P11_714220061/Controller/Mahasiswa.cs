using P11_714220061.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P11_714220061.Controller
{
    class Mahasiswa
    {
        Connect connect = new Connect();

        public bool Insert (M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" +mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +"','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_mahasiswa mahasiswa, string npm)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "'," + "angkatan='" + mahasiswa.Angkatan + "'," + "alamat='" + mahasiswa.Alamat + "'," + "email='" + mahasiswa.Email + "'," + "nohp='" + mahasiswa.Nohp + "'WHERE npm = '" + mahasiswa.Npm + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string npm)
        {
            Boolean status = false;
            try
            {
                connect.OpenConnection();
                connect.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
