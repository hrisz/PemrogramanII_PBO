using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5_3_714220061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "iOS";
            }

            if (cbYA.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }
            else
            {
                status = "Belum diperbaiki";
            }
            MessageBox.Show("Merk HP: " + txtMerkHP.Text + "\nSistem Operasi: " + os + "\nStatus Perbaikan: " + status, "Informasi Service HP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
