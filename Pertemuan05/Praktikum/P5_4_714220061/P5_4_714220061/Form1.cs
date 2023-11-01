using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string jenisKelamin = formJenisKelamin.GetItemText(formJenisKelamin.SelectedItem);
            DateTime getTanggalLahir = formTanggalLahir.Value;
            string tanggalLahir = getTanggalLahir.ToString("dd MMMM yyyy");
            string pilihanKelas = "";
            string pilihanJadwal = "";

            if (checkBiola.Checked)
            {
                pilihanKelas += "Biola, ";
            }
            if (checkGitar.Checked)
            {
                pilihanKelas += "Gitar, ";
            }
            if (checkSaxophone.Checked)
            {
                pilihanKelas += "Saxophone, ";
            }
            if (checkKonduktor.Checked)
            {
                pilihanKelas += "Konduktor, ";
            }
            if (checkPiano.Checked)
            {
                pilihanKelas += "Piano, ";
            }
            if (checkDrum.Checked)
            {
                pilihanKelas += "Drum, ";
            }
            if (checkVokal.Checked)
            {
                pilihanKelas += "Vokal, ";
            }
            if (checkKomposer.Checked)
            {
                pilihanKelas = "Komposer";
            }
            if (!string.IsNullOrEmpty(pilihanKelas))
            {
                pilihanKelas = pilihanKelas.TrimEnd(' ', ',');
            }

            if (pilihanJadwal1.Checked)
            {
                pilihanJadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            
            else if (pilihanJadwal2.Checked)
            {
                pilihanJadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (pilihanJadwal3.Checked)
            {
                pilihanJadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (pilihanJadwal4.Checked)
            {
                pilihanJadwal = "Minggu, 13.00 - 17.00";
            }
            if (pilihanKelas != "" && pilihanJadwal != "")
            {
                MessageBox.Show("Nama : " + formNama.Text + "\nJenis Kelamin : " + jenisKelamin + "\nTanggal Lahir : " + tanggalLahir + "\nPilihan Kelas : " + pilihanKelas + "\nPilihan Jadwal : " + pilihanJadwal, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (formNama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jenisKelamin == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pilihanKelas == "")
            {
                MessageBox.Show("Harus memilih satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pilihanJadwal == "")
            {
                MessageBox.Show("Harus memilih satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
