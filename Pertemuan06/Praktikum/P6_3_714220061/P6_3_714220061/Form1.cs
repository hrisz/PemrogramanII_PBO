using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul!");
            }

            else
            {
                epWrong.SetError(txtHuruf, "Input hanya boleh huruf!");
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }

            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Input kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
            }

            else
            {
                epWrong.SetError(txtAngka, "Input hanya boleh angka!");
                epWarning.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }

            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Input kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }

            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: devs_account@hoyoverse.com");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }

            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Input kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul!");
                    epCorrect.SetError(txtAngka2, "Betul!");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah");
                    epWrong.SetError(txtAngka2, "Input salah");
                }
            }

            else if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                //epWarning.SetError(txtAngka2, "Input kosong!");
                //epWrong.SetError(txtAngka2, "");
                //epCorrect.SetError(txtAngka2, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Input kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka1, "Input hanya boleh angka!");
                epWarning.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul!");
                    epCorrect.SetError(txtAngka2, "Betul!");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah");
                    epWrong.SetError(txtAngka2, "Input salah");
                }
            }

            else if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Input kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

                //epWarning.SetError(txtAngka1, "Input kosong!");
                //epWrong.SetError(txtAngka1, "");
                //epCorrect.SetError(txtAngka1, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input kosong!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Input kosong!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka2, "Input hanya boleh angka!");
                epWarning.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
