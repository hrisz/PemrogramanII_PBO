﻿namespace P9_714220061
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMhs = new System.Windows.Forms.GroupBox();
            this.formMhs = new System.Windows.Forms.GroupBox();
            this.actionBtn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nohp = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.tbMhs.SuspendLayout();
            this.formMhs.SuspendLayout();
            this.actionBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMhs
            // 
            this.tbMhs.Controls.Add(this.DataMahasiswa);
            this.tbMhs.Location = new System.Drawing.Point(12, 12);
            this.tbMhs.Name = "tbMhs";
            this.tbMhs.Size = new System.Drawing.Size(1047, 372);
            this.tbMhs.TabIndex = 0;
            this.tbMhs.TabStop = false;
            this.tbMhs.Text = "Table Mahasiswa";
            // 
            // formMhs
            // 
            this.formMhs.Controls.Add(this.comboBox1);
            this.formMhs.Controls.Add(this.nohp);
            this.formMhs.Controls.Add(this.label6);
            this.formMhs.Controls.Add(this.email);
            this.formMhs.Controls.Add(this.label5);
            this.formMhs.Controls.Add(this.alamat);
            this.formMhs.Controls.Add(this.label4);
            this.formMhs.Controls.Add(this.label3);
            this.formMhs.Controls.Add(this.nama);
            this.formMhs.Controls.Add(this.label2);
            this.formMhs.Controls.Add(this.npm);
            this.formMhs.Controls.Add(this.label1);
            this.formMhs.Location = new System.Drawing.Point(12, 407);
            this.formMhs.Name = "formMhs";
            this.formMhs.Size = new System.Drawing.Size(655, 358);
            this.formMhs.TabIndex = 1;
            this.formMhs.TabStop = false;
            this.formMhs.Text = "Form Data Mahasiswa";
            // 
            // actionBtn
            // 
            this.actionBtn.Controls.Add(this.btnHapus);
            this.actionBtn.Controls.Add(this.btnUbah);
            this.actionBtn.Controls.Add(this.btnSimpan);
            this.actionBtn.Controls.Add(this.btnRefresh);
            this.actionBtn.Location = new System.Drawing.Point(705, 538);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(354, 227);
            this.actionBtn.TabIndex = 2;
            this.actionBtn.TabStop = false;
            this.actionBtn.Text = "Tombol Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(123, 45);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(352, 22);
            this.npm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(123, 82);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(352, 22);
            this.nama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angkatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(123, 162);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(352, 66);
            this.alamat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(123, 249);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(352, 22);
            this.email.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. HP";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(123, 291);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(352, 22);
            this.nohp.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(342, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 82);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(342, 34);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(6, 130);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(342, 34);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(6, 178);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(342, 34);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(6, 21);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 51;
            this.DataMahasiswa.RowTemplate.Height = 24;
            this.DataMahasiswa.Size = new System.Drawing.Size(1035, 345);
            this.DataMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 776);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.formMhs);
            this.Controls.Add(this.tbMhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbMhs.ResumeLayout(false);
            this.formMhs.ResumeLayout(false);
            this.formMhs.PerformLayout();
            this.actionBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbMhs;
        private System.Windows.Forms.GroupBox formMhs;
        private System.Windows.Forms.GroupBox actionBtn;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

