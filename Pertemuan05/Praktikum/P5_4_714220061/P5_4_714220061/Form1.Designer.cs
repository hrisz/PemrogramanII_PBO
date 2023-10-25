namespace P5_4_714220061
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.judulform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.checkKomposer = new System.Windows.Forms.CheckBox();
            this.checkVokal = new System.Windows.Forms.CheckBox();
            this.checkDrum = new System.Windows.Forms.CheckBox();
            this.checkPiano = new System.Windows.Forms.CheckBox();
            this.checkKonduktor = new System.Windows.Forms.CheckBox();
            this.checkSaxophone = new System.Windows.Forms.CheckBox();
            this.checkGitar = new System.Windows.Forms.CheckBox();
            this.checkBiola = new System.Windows.Forms.CheckBox();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.pilihanJadwal4 = new System.Windows.Forms.RadioButton();
            this.pilihanJadwal3 = new System.Windows.Forms.RadioButton();
            this.pilihanJadwal2 = new System.Windows.Forms.RadioButton();
            this.pilihanJadwal1 = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.Box1.SuspendLayout();
            this.Box2.SuspendLayout();
            this.SuspendLayout();
            // 
            // judulform
            // 
            this.judulform.AutoSize = true;
            this.judulform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.judulform.Cursor = System.Windows.Forms.Cursors.Default;
            this.judulform.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulform.ForeColor = System.Drawing.SystemColors.Control;
            this.judulform.Location = new System.Drawing.Point(502, 49);
            this.judulform.Name = "judulform";
            this.judulform.Size = new System.Drawing.Size(391, 44);
            this.judulform.TabIndex = 0;
            this.judulform.Text = "FORM PENDAFTARAN";
            this.judulform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // formNama
            // 
            this.formNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formNama.Location = new System.Drawing.Point(630, 137);
            this.formNama.Name = "formNama";
            this.formNama.Size = new System.Drawing.Size(242, 27);
            this.formNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(438, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jenis Kelamin";
            // 
            // formJenisKelamin
            // 
            this.formJenisKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formJenisKelamin.FormattingEnabled = true;
            this.formJenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.formJenisKelamin.Location = new System.Drawing.Point(630, 182);
            this.formJenisKelamin.Name = "formJenisKelamin";
            this.formJenisKelamin.Size = new System.Drawing.Size(198, 28);
            this.formJenisKelamin.TabIndex = 4;
            this.formJenisKelamin.Text = "--Pilih Jenis Kelamin--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(438, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal Lahir";
            // 
            // formTanggalLahir
            // 
            this.formTanggalLahir.CustomFormat = "dd MMMM yyyy";
            this.formTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.formTanggalLahir.Location = new System.Drawing.Point(630, 228);
            this.formTanggalLahir.Name = "formTanggalLahir";
            this.formTanggalLahir.Size = new System.Drawing.Size(242, 24);
            this.formTanggalLahir.TabIndex = 6;
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Box1.Controls.Add(this.checkKomposer);
            this.Box1.Controls.Add(this.checkVokal);
            this.Box1.Controls.Add(this.checkDrum);
            this.Box1.Controls.Add(this.checkPiano);
            this.Box1.Controls.Add(this.checkKonduktor);
            this.Box1.Controls.Add(this.checkSaxophone);
            this.Box1.Controls.Add(this.checkGitar);
            this.Box1.Controls.Add(this.checkBiola);
            this.Box1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.ForeColor = System.Drawing.SystemColors.Control;
            this.Box1.Location = new System.Drawing.Point(236, 285);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(369, 305);
            this.Box1.TabIndex = 7;
            this.Box1.TabStop = false;
            this.Box1.Text = "Pilihan Kelas";
            // 
            // checkKomposer
            // 
            this.checkKomposer.AutoSize = true;
            this.checkKomposer.Location = new System.Drawing.Point(213, 228);
            this.checkKomposer.Name = "checkKomposer";
            this.checkKomposer.Size = new System.Drawing.Size(100, 23);
            this.checkKomposer.TabIndex = 7;
            this.checkKomposer.Text = "Komposer";
            this.checkKomposer.UseVisualStyleBackColor = true;
            // 
            // checkVokal
            // 
            this.checkVokal.AutoSize = true;
            this.checkVokal.Location = new System.Drawing.Point(213, 170);
            this.checkVokal.Name = "checkVokal";
            this.checkVokal.Size = new System.Drawing.Size(69, 23);
            this.checkVokal.TabIndex = 6;
            this.checkVokal.Text = "Vokal";
            this.checkVokal.UseVisualStyleBackColor = true;
            // 
            // checkDrum
            // 
            this.checkDrum.AutoSize = true;
            this.checkDrum.Location = new System.Drawing.Point(213, 112);
            this.checkDrum.Name = "checkDrum";
            this.checkDrum.Size = new System.Drawing.Size(68, 23);
            this.checkDrum.TabIndex = 5;
            this.checkDrum.Text = "Drum";
            this.checkDrum.UseVisualStyleBackColor = true;
            // 
            // checkPiano
            // 
            this.checkPiano.AutoSize = true;
            this.checkPiano.Location = new System.Drawing.Point(213, 54);
            this.checkPiano.Name = "checkPiano";
            this.checkPiano.Size = new System.Drawing.Size(69, 23);
            this.checkPiano.TabIndex = 4;
            this.checkPiano.Text = "Piano";
            this.checkPiano.UseVisualStyleBackColor = true;
            // 
            // checkKonduktor
            // 
            this.checkKonduktor.AutoSize = true;
            this.checkKonduktor.Location = new System.Drawing.Point(53, 228);
            this.checkKonduktor.Name = "checkKonduktor";
            this.checkKonduktor.Size = new System.Drawing.Size(102, 23);
            this.checkKonduktor.TabIndex = 3;
            this.checkKonduktor.Text = "Konduktor";
            this.checkKonduktor.UseVisualStyleBackColor = true;
            // 
            // checkSaxophone
            // 
            this.checkSaxophone.AutoSize = true;
            this.checkSaxophone.Location = new System.Drawing.Point(53, 170);
            this.checkSaxophone.Name = "checkSaxophone";
            this.checkSaxophone.Size = new System.Drawing.Size(106, 23);
            this.checkSaxophone.TabIndex = 2;
            this.checkSaxophone.Text = "Saxophone";
            this.checkSaxophone.UseVisualStyleBackColor = true;
            // 
            // checkGitar
            // 
            this.checkGitar.AutoSize = true;
            this.checkGitar.Location = new System.Drawing.Point(53, 112);
            this.checkGitar.Name = "checkGitar";
            this.checkGitar.Size = new System.Drawing.Size(64, 23);
            this.checkGitar.TabIndex = 1;
            this.checkGitar.Text = "Gitar";
            this.checkGitar.UseVisualStyleBackColor = true;
            // 
            // checkBiola
            // 
            this.checkBiola.AutoSize = true;
            this.checkBiola.Location = new System.Drawing.Point(53, 54);
            this.checkBiola.Name = "checkBiola";
            this.checkBiola.Size = new System.Drawing.Size(65, 23);
            this.checkBiola.TabIndex = 0;
            this.checkBiola.Text = "Biola";
            this.checkBiola.UseVisualStyleBackColor = true;
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Box2.Controls.Add(this.pilihanJadwal4);
            this.Box2.Controls.Add(this.pilihanJadwal3);
            this.Box2.Controls.Add(this.pilihanJadwal2);
            this.Box2.Controls.Add(this.pilihanJadwal1);
            this.Box2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.ForeColor = System.Drawing.SystemColors.Control;
            this.Box2.Location = new System.Drawing.Point(705, 285);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(369, 305);
            this.Box2.TabIndex = 8;
            this.Box2.TabStop = false;
            this.Box2.Text = "Pilihan Jadwal";
            // 
            // pilihanJadwal4
            // 
            this.pilihanJadwal4.AutoSize = true;
            this.pilihanJadwal4.Location = new System.Drawing.Point(47, 231);
            this.pilihanJadwal4.Name = "pilihanJadwal4";
            this.pilihanJadwal4.Size = new System.Drawing.Size(175, 23);
            this.pilihanJadwal4.TabIndex = 3;
            this.pilihanJadwal4.TabStop = true;
            this.pilihanJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.pilihanJadwal4.UseVisualStyleBackColor = true;
            // 
            // pilihanJadwal3
            // 
            this.pilihanJadwal3.AutoSize = true;
            this.pilihanJadwal3.Location = new System.Drawing.Point(47, 171);
            this.pilihanJadwal3.Name = "pilihanJadwal3";
            this.pilihanJadwal3.Size = new System.Drawing.Size(233, 23);
            this.pilihanJadwal3.TabIndex = 2;
            this.pilihanJadwal3.TabStop = true;
            this.pilihanJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.pilihanJadwal3.UseVisualStyleBackColor = true;
            // 
            // pilihanJadwal2
            // 
            this.pilihanJadwal2.AutoSize = true;
            this.pilihanJadwal2.Location = new System.Drawing.Point(47, 111);
            this.pilihanJadwal2.Name = "pilihanJadwal2";
            this.pilihanJadwal2.Size = new System.Drawing.Size(226, 23);
            this.pilihanJadwal2.TabIndex = 1;
            this.pilihanJadwal2.TabStop = true;
            this.pilihanJadwal2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.pilihanJadwal2.UseVisualStyleBackColor = true;
            // 
            // pilihanJadwal1
            // 
            this.pilihanJadwal1.AutoSize = true;
            this.pilihanJadwal1.Location = new System.Drawing.Point(47, 51);
            this.pilihanJadwal1.Name = "pilihanJadwal1";
            this.pilihanJadwal1.Size = new System.Drawing.Size(214, 23);
            this.pilihanJadwal1.TabIndex = 0;
            this.pilihanJadwal1.TabStop = true;
            this.pilihanJadwal1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.pilihanJadwal1.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkan.Location = new System.Drawing.Point(493, 631);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(112, 33);
            this.btnTampilkan.TabIndex = 9;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(705, 631);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(108, 33);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1311, 736);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.formTanggalLahir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formJenisKelamin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judulform);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Pendaftaran Kelas Melody of Teyvat";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.Box2.ResumeLayout(false);
            this.Box2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judulform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formJenisKelamin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker formTanggalLahir;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.RadioButton pilihanJadwal1;
        private System.Windows.Forms.RadioButton pilihanJadwal3;
        private System.Windows.Forms.RadioButton pilihanJadwal2;
        private System.Windows.Forms.RadioButton pilihanJadwal4;
        private System.Windows.Forms.CheckBox checkDrum;
        private System.Windows.Forms.CheckBox checkPiano;
        private System.Windows.Forms.CheckBox checkKonduktor;
        private System.Windows.Forms.CheckBox checkSaxophone;
        private System.Windows.Forms.CheckBox checkGitar;
        private System.Windows.Forms.CheckBox checkBiola;
        private System.Windows.Forms.CheckBox checkKomposer;
        private System.Windows.Forms.CheckBox checkVokal;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

