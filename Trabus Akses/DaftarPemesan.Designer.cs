namespace Trabus_Akses
{
    partial class DaftarPemesan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonHapusNama = new System.Windows.Forms.Button();
            this.buttonHapusId = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSemua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCariJam = new System.Windows.Forms.Button();
            this.buttonCariId = new System.Windows.Forms.Button();
            this.comboBoxMenit = new System.Windows.Forms.ComboBox();
            this.comboBoxJam = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdCari = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCariKode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonHapusNama);
            this.panel1.Controls.Add(this.buttonHapusId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Location = new System.Drawing.Point(2, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 183);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Hapus Berdasarkan :";
            // 
            // buttonHapusNama
            // 
            this.buttonHapusNama.Location = new System.Drawing.Point(103, 125);
            this.buttonHapusNama.Name = "buttonHapusNama";
            this.buttonHapusNama.Size = new System.Drawing.Size(75, 37);
            this.buttonHapusNama.TabIndex = 5;
            this.buttonHapusNama.Text = "id_bus";
            this.buttonHapusNama.UseVisualStyleBackColor = true;
            this.buttonHapusNama.Click += new System.EventHandler(this.buttonHapusNama_Click);
            // 
            // buttonHapusId
            // 
            this.buttonHapusId.Location = new System.Drawing.Point(9, 125);
            this.buttonHapusId.Name = "buttonHapusId";
            this.buttonHapusId.Size = new System.Drawing.Size(69, 37);
            this.buttonHapusId.TabIndex = 4;
            this.buttonHapusId.Text = "ID";
            this.buttonHapusId.UseVisualStyleBackColor = true;
            this.buttonHapusId.Click += new System.EventHandler(this.buttonHapusId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hapus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id_bus";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(50, 64);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(107, 20);
            this.textBoxNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(50, 36);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(107, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daftar Pemesan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonCariKode);
            this.panel2.Controls.Add(this.buttonPrint);
            this.panel2.Controls.Add(this.textBoxKode);
            this.panel2.Controls.Add(this.buttonSemua);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonCariJam);
            this.panel2.Controls.Add(this.buttonCariId);
            this.panel2.Controls.Add(this.comboBoxMenit);
            this.panel2.Controls.Add(this.comboBoxJam);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxIdCari);
            this.panel2.Location = new System.Drawing.Point(397, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 183);
            this.panel2.TabIndex = 3;
            // 
            // buttonSemua
            // 
            this.buttonSemua.Location = new System.Drawing.Point(297, 131);
            this.buttonSemua.Name = "buttonSemua";
            this.buttonSemua.Size = new System.Drawing.Size(88, 31);
            this.buttonSemua.TabIndex = 40;
            this.buttonSemua.Text = "Semua Data";
            this.buttonSemua.UseVisualStyleBackColor = true;
            this.buttonSemua.Click += new System.EventHandler(this.buttonSemua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cari Berdasarkan :";
            // 
            // buttonCariJam
            // 
            this.buttonCariJam.Location = new System.Drawing.Point(96, 131);
            this.buttonCariJam.Name = "buttonCariJam";
            this.buttonCariJam.Size = new System.Drawing.Size(88, 31);
            this.buttonCariJam.TabIndex = 38;
            this.buttonCariJam.Text = "Jam Berangkat";
            this.buttonCariJam.UseVisualStyleBackColor = true;
            this.buttonCariJam.Click += new System.EventHandler(this.buttonCariJam_Click);
            // 
            // buttonCariId
            // 
            this.buttonCariId.Location = new System.Drawing.Point(12, 131);
            this.buttonCariId.Name = "buttonCariId";
            this.buttonCariId.Size = new System.Drawing.Size(76, 32);
            this.buttonCariId.TabIndex = 6;
            this.buttonCariId.Text = "ID";
            this.buttonCariId.UseVisualStyleBackColor = true;
            this.buttonCariId.Click += new System.EventHandler(this.buttonCariId_Click);
            // 
            // comboBoxMenit
            // 
            this.comboBoxMenit.FormattingEnabled = true;
            this.comboBoxMenit.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboBoxMenit.Location = new System.Drawing.Point(164, 67);
            this.comboBoxMenit.Name = "comboBoxMenit";
            this.comboBoxMenit.Size = new System.Drawing.Size(48, 21);
            this.comboBoxMenit.TabIndex = 37;
            // 
            // comboBoxJam
            // 
            this.comboBoxJam.FormattingEnabled = true;
            this.comboBoxJam.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxJam.Location = new System.Drawing.Point(91, 66);
            this.comboBoxJam.Name = "comboBoxJam";
            this.comboBoxJam.Size = new System.Drawing.Size(48, 21);
            this.comboBoxJam.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(147, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cari Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Jam berangkat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id";
            // 
            // textBoxIdCari
            // 
            this.textBoxIdCari.Location = new System.Drawing.Point(91, 33);
            this.textBoxIdCari.Name = "textBoxIdCari";
            this.textBoxIdCari.Size = new System.Drawing.Size(93, 20);
            this.textBoxIdCari.TabIndex = 6;
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(231, 33);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(96, 20);
            this.textBoxKode.TabIndex = 41;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(333, 32);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(51, 35);
            this.buttonPrint.TabIndex = 42;
            this.buttonPrint.Text = "Print Ulang";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCariKode
            // 
            this.buttonCariKode.Location = new System.Drawing.Point(199, 131);
            this.buttonCariKode.Name = "buttonCariKode";
            this.buttonCariKode.Size = new System.Drawing.Size(88, 31);
            this.buttonCariKode.TabIndex = 43;
            this.buttonCariKode.Text = "Kode Pesan";
            this.buttonCariKode.UseVisualStyleBackColor = true;
            this.buttonCariKode.Click += new System.EventHandler(this.buttonCariKode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Kode";
            // 
            // DaftarPemesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DaftarPemesan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaftarPemesan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapusNama;
        private System.Windows.Forms.Button buttonHapusId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIdCari;
        private System.Windows.Forms.Button buttonCariJam;
        private System.Windows.Forms.Button buttonCariId;
        private System.Windows.Forms.ComboBox comboBoxMenit;
        private System.Windows.Forms.ComboBox comboBoxJam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSemua;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.Button buttonCariKode;
        private System.Windows.Forms.Label label6;
    }
}