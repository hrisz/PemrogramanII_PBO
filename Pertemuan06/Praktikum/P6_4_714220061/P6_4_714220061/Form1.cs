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

namespace P6_4_714220061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.inputServer.SelectedIndexChanged += new System.EventHandler(this.inputServer_Leave);
            this.inputRank.TextChanged += new System.EventHandler(this.inputUID_Leave);
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pesanan Dibatalkan, Tekan 'OK' untuk keluar!", "Pesanan Dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            this.Close();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string showName = inputName.Text;
            string showEmail = inputEmail.Text;
            string showServer = inputServer.GetItemText(inputServer.SelectedItem);
            string showUID = inputUID.Text;
            string showRank = inputRank.Value.ToString();
            string validasi1 = confirm01.Text;
            string validasi2 = confirm02.Text;
            string serverSelection = inputServer.SelectedItem?.ToString();

            bool validserver = (serverSelection == "Asia" && showUID.Length > 0 && showUID[0] == '8') ||
                               (serverSelection == "America (NA)" && showUID.Length > 0 && showUID[0] == '6') ||
                               (serverSelection == "Europe (EU)" && showUID.Length > 0 && showUID[0] == '7') ||
                               (serverSelection == "TW/HK/MO (SAR)" && showUID.Length > 0 && showUID[0] == '9');

            if (showName != "" && showEmail != "" && validserver && inputRank.Value >= 15 && inputUID.Text.Length == 9 && validasi1.All(Char.IsUpper) && validasi1 == "SETUJU" && validasi2.All(Char.IsLower) && validasi2 == "setuju")
            {
                MessageBox.Show("Name: " + showName + "\nEmail: " + showEmail + "\nServer: " + showServer + "\nUID: " + showUID + "\nAdventure Rank: " + showRank, "Data Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((confirm01.Text).Any(Char.IsLower))
            {
                MessageBox.Show("Textbox Confirm #1 perlu diperbaiki, kalimat harus terdiri dari uppercase!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((confirm01.Text != "SETUJU"))
            {
                MessageBox.Show("Textbox Confirm #1 perlu diperbaiki, ketik 'SETUJU' dalam uppercase!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((confirm02.Text).Any(Char.IsUpper))
            {
                MessageBox.Show("Textbox Confirm #2 perlu diperbaiki, kalimat harus terdiri dari lowercase!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((confirm02.Text != "setuju"))
            {
                MessageBox.Show("Textbox Confirm #2 perlu diperbaiki, ketik 'setuju' dalam lowercase!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Isi dan perbaiki semua form terlebih dahulu!", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inputName_Leave(object sender, EventArgs e)
        {
            if ((inputName.Text).All(Char.IsLetter))
            {
                sysCorrect.SetError(inputName, "Correct");
                sysWarning.SetError(inputName, "");
                sysWrong.SetError(inputName, "");
            }
            else
            {
                sysCorrect.SetError(inputName, "");
                sysWarning.SetError(inputName, "");
                sysWrong.SetError(inputName, "Hanya boleh menerima huruf!");
            }
            if (inputName.Text == "")
            {
                sysCorrect.SetError(inputName, "");
                sysWarning.SetError(inputName, "Box wajib diisi!");
                sysWrong.SetError(inputName, "");
            }
        }

        private void inputEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(inputEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                sysCorrect.SetError(inputEmail, "Correct");
                sysWarning.SetError(inputEmail, "");
                sysWrong.SetError(inputEmail, "");
            }
            else
            {
                sysCorrect.SetError(inputEmail, "");
                sysWarning.SetError(inputEmail, "");
                sysWrong.SetError(inputEmail, "Format email salah!\nContoh: devs_account@hoyoverse.com");
            }
            if (inputEmail.Text == "")
            {
                sysCorrect.SetError(inputEmail, "");
                sysWarning.SetError(inputEmail, "Box wajib diisi!");
                sysWrong.SetError(inputEmail, "");
            }
        }

        private void inputServer_Leave(object sender, EventArgs e)
        {
            if (inputServer.SelectedItem != null)
            {
                string selectedServer = inputServer.SelectedItem.ToString();
                sysCorrect.SetError(inputServer, "Correct");
                sysWarning.SetError(inputServer, "");
                sysWrong.SetError(inputServer, "");

                inputUID.Text = "";

                if (selectedServer == "Asia" || selectedServer == "America (NA)" || selectedServer == "Europe (EU)" || selectedServer == "TW/HK/MO (SAR)")
                {
                    inputUID.Focus();
                }
            }
            else
            {
                sysCorrect.SetError(inputServer, "");
                sysWarning.SetError(inputServer, "Wajib pilih salah satu server!");
                sysWrong.SetError(inputServer, "");
            }
        }

        private void inputUID_Leave(object sender, EventArgs e)
        {
            if (inputServer.SelectedItem != null)
            {

                string selectedServer = inputServer.SelectedItem.ToString();

                if ((inputUID.Text).All(Char.IsNumber) && inputUID.Text.Length == 9)
                {
                    sysCorrect.SetError(inputUID, "Correct");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "");
                }
                else
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "Hanya boleh menerima angka!");
                }
                if (inputUID.Text == "")
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "Box wajib diisi!");
                    sysWrong.SetError(inputUID, "");
                }
                if (inputUID.Text.Length != 9)
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "UID harus terdiri dari 9 angka");
                }
                if (selectedServer == "Asia" && inputUID.Text.Length < 1)
                {
                    inputUID.Text = "8";
                    inputUID.SelectionStart = inputUID.Text.Length;
                }
                else if (selectedServer == "Asia" && inputUID.Text[0] != '8')
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "Server Asia harus diawali dengan angka UID 8!");
                }

                if (selectedServer == "America (NA)" && inputUID.Text.Length < 1)
                {
                    inputUID.Text = "6";
                    inputUID.SelectionStart = inputUID.Text.Length;
                }
                else if (selectedServer == "America (NA)" && inputUID.Text[0] != '6')
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "Server Asia harus diawali dengan angka UID 6!");
                }

                if (selectedServer == "Europe (EU)" && inputUID.Text.Length < 1)
                {
                    inputUID.Text = "7";
                    inputUID.SelectionStart = inputUID.Text.Length;
                }
                else if (selectedServer == "Europe (EU)" && inputUID.Text[0] != '7')
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "Server Asia harus diawali dengan angka UID 7!");
                }

                if (selectedServer == "TW/HK/MO (SAR)" && inputUID.Text.Length < 1)
                {
                    inputUID.Text = "9";
                    inputUID.SelectionStart = inputUID.Text.Length;
                }
                else if (selectedServer == "TW/HK/MO (SAR)" && inputUID.Text[0] != '9')
                {
                    sysCorrect.SetError(inputUID, "");
                    sysWarning.SetError(inputUID, "");
                    sysWrong.SetError(inputUID, "Server Asia harus diawali dengan angka UID 9!");
                }
            }

            if (inputUID.MaxLength > 9)
            {
                MessageBox.Show("Nomor UID tidak boleh lebih dari 9!","Maxlength UID mencapai batas!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inputRank_Leave(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;

            if (numericUpDown.Value == 0)
            {
                sysCorrect.SetError(inputRank, "");
                sysWarning.SetError(inputRank, "Adventure Rank Tidak boleh 0");
                sysWrong.SetError(inputRank, "");
            }
            if (numericUpDown.Value <= 15)
            {
                sysCorrect.SetError(inputRank, "");
                sysWarning.SetError(inputRank, "");
                sysWrong.SetError(inputRank, "Adventure Rank tidak boleh kurang dari 16");
            }
            else
            {
                sysCorrect.SetError(inputRank, "Correct");
                sysWarning.SetError(inputRank, "");
                sysWrong.SetError(inputRank, "");
            }
        }

        private void confirm02_Leave(object sender, EventArgs e)
        {
            if ((confirm02.Text).All(Char.IsLower) && (confirm02.Text == "setuju"))
            {
                sysCorrect.SetError(confirm02, "Correct");
                sysWarning.SetError(confirm02, "");
                sysWrong.SetError(confirm02, "");
            }
            else if ((confirm02.Text).Any(Char.IsUpper) && (confirm02.Text == "SETUJU"))
            {
                sysWarning.SetError(confirm02, "");
                sysWrong.SetError(confirm02, "Kata harus seluruhnya dalam lowercase");
                sysCorrect.SetError(confirm02, "");
            }
            else if (confirm02.Text == "")
            {
                sysWarning.SetError(confirm02, "Input tidak boleh kosong");
                sysWrong.SetError(confirm02, "");
                sysCorrect.SetError(confirm02, "");
            }
            else
            {
                sysCorrect.SetError(confirm02, "");
                sysWarning.SetError(confirm02, "");
                sysWrong.SetError(confirm02, "Kata harus dalam lowercase dan kalimat 'setuju'");
            }
        }

        private void confirm01_Leave(object sender, EventArgs e)
        {
            if ((confirm01.Text).All(Char.IsUpper) && (confirm01.Text == "SETUJU"))
            {
                sysCorrect.SetError(confirm01, "Correct");
                sysWarning.SetError(confirm01, "");
                sysWrong.SetError(confirm01, "");
            }
            else if ((confirm01.Text).Any(Char.IsLower) && (confirm01.Text == "setuju"))
            {
                sysWarning.SetError(confirm01, "");
                sysWrong.SetError(confirm01, "Kata harus seluruhnya dalam uppercase");
                sysCorrect.SetError(confirm01, "");
            }
            else if (confirm01.Text == "")
            {
                sysWarning.SetError(confirm01, "Input tidak boleh kosong");
                sysWrong.SetError(confirm01, "");
                sysCorrect.SetError(confirm01, "");
            }
            else
            {
                sysCorrect.SetError(confirm01, "");
                sysWarning.SetError(confirm01, "");
                sysWrong.SetError(confirm01, "Kata harus dalam uppercase dan kalimat 'SETUJU'");
            }
        }
    }
}