using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(397, 242);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(formName.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(formStudy.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }
            else if (!Regex.IsMatch(formStudy.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }
            if (string.IsNullOrWhiteSpace(formClass.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if(string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap","Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                this.Size = new Size(397, 492);
            }
            else
            {
                MessageBox.Show(
                    errorMessage, "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Size = new Size(397, 242);

            foreach (Control control in Controls)
            {
                if (control is TextBox) ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton) ((RadioButton)control).Checked = false;
                else if (control is CheckBox) ((CheckBox)control).Checked = false;
                else if (control is ComboBox) ((ComboBox)control).SelectedIndex = -1;
            }

        }

        private void radMonday_CheckedChanged(object sender, EventArgs e)
        {
            if (radMonday.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTravel.Enabled = false; cbTravel.Checked = false;
                cbTuru.Enabled = true; cbTuru.Checked = true;
            }
        }

        private void radSunday_CheckedChanged(object sender, EventArgs e)
        {
            if (radSunday.Checked)
            {
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
                cbTravel.Enabled = true; cbTravel.Checked = true;
                cbTuru.Enabled = true; cbTuru.Checked = true;
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            bool day = radMonday.Checked || radSunday.Checked;
            bool activity = cbKuliah.Checked || cbTravel.Checked || cbTuru.Checked;

            string days = string.Empty;
            string activities = string.Empty;

            if (radMonday.Checked)
            {
                days += "Senin";
            }
            else if (radSunday.Checked)
            {
                days += "Minggu";
            }

            if (cbKuliah.Checked)
            {
                activities += "Kuliah, ";
            }
            if (cbTravel.Checked)
            {
                activities += "Traveling, ";
            }
            if (cbTuru.Checked)
            {
                activities += "Tidur";
            }
            if (!string.IsNullOrEmpty(activities))
            {
                activities = activities.TrimEnd(' ', ',');
            }

            if (formName.Text != "" && formStudy.Text != "" && formClass.Text != "" && Regex.IsMatch(formStudy.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$") && day && activity)
            {
                MessageBox.Show("Nama: " + formName.Text + "\nProdi: " + formStudy.Text + "\nKelas: " + formClass.Text + "\nHari: " + days + "\nActivities: " + activities,"Hasil output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Isi form terlebih dahulu dengan benar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
