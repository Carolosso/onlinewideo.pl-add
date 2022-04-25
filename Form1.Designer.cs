
namespace onlinewideo.pl_add
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFilm = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.labelWWWFilm = new System.Windows.Forms.Button();
            this.OpisFilmu = new System.Windows.Forms.TextBox();
            this.SEOfilm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdFilm = new System.Windows.Forms.Button();
            this.textBoxPlayer = new System.Windows.Forms.Button();
            this.textBoxOpis = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelTrailerFilm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdresFilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwaFilm = new System.Windows.Forms.TextBox();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.SEOSerial = new System.Windows.Forms.Button();
            this.textBoxOpisSerial = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelWWWSerial = new System.Windows.Forms.Button();
            this.textBoxIdSerial = new System.Windows.Forms.Button();
            this.OpisSerialu = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelNazwaSerial = new System.Windows.Forms.Label();
            this.textBoxNazwaSerial = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabFilm.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFilm);
            this.tabControl1.Controls.Add(this.tabSerial);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Oswald", 20.25F);
            this.tabControl1.ItemSize = new System.Drawing.Size(132, 40);
            this.tabControl1.Location = new System.Drawing.Point(11, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 596);
            this.tabControl1.TabIndex = 2;
            // 
            // tabFilm
            // 
            this.tabFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabFilm.Controls.Add(this.label10);
            this.tabFilm.Controls.Add(this.labelWWWFilm);
            this.tabFilm.Controls.Add(this.OpisFilmu);
            this.tabFilm.Controls.Add(this.SEOfilm);
            this.tabFilm.Controls.Add(this.label8);
            this.tabFilm.Controls.Add(this.textBoxIdFilm);
            this.tabFilm.Controls.Add(this.textBoxPlayer);
            this.tabFilm.Controls.Add(this.textBoxOpis);
            this.tabFilm.Controls.Add(this.checkBox1);
            this.tabFilm.Controls.Add(this.labelTrailerFilm);
            this.tabFilm.Controls.Add(this.textBox1);
            this.tabFilm.Controls.Add(this.label5);
            this.tabFilm.Controls.Add(this.label4);
            this.tabFilm.Controls.Add(this.label3);
            this.tabFilm.Controls.Add(this.textBoxAdresFilm);
            this.tabFilm.Controls.Add(this.label2);
            this.tabFilm.Controls.Add(this.comboBox1);
            this.tabFilm.Controls.Add(this.label1);
            this.tabFilm.Controls.Add(this.textBoxNazwaFilm);
            this.tabFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabFilm.Location = new System.Drawing.Point(4, 44);
            this.tabFilm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabFilm.Name = "tabFilm";
            this.tabFilm.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabFilm.Size = new System.Drawing.Size(943, 548);
            this.tabFilm.TabIndex = 0;
            this.tabFilm.Text = "Dodaj film";
            this.tabFilm.Click += new System.EventHandler(this.tabFilm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(515, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Opis filmu:";
            // 
            // labelWWWFilm
            // 
            this.labelWWWFilm.Font = new System.Drawing.Font("Oswald", 12.25F);
            this.labelWWWFilm.Location = new System.Drawing.Point(22, 234);
            this.labelWWWFilm.Name = "labelWWWFilm";
            this.labelWWWFilm.Size = new System.Drawing.Size(277, 35);
            this.labelWWWFilm.TabIndex = 28;
            this.labelWWWFilm.Text = "brak";
            this.labelWWWFilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWWWFilm.UseVisualStyleBackColor = true;
            this.labelWWWFilm.Click += new System.EventHandler(this.labelWWWFilm_Click_1);
            // 
            // OpisFilmu
            // 
            this.OpisFilmu.Font = new System.Drawing.Font("Oswald", 8F);
            this.OpisFilmu.Location = new System.Drawing.Point(510, 57);
            this.OpisFilmu.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OpisFilmu.Multiline = true;
            this.OpisFilmu.Name = "OpisFilmu";
            this.OpisFilmu.Size = new System.Drawing.Size(416, 113);
            this.OpisFilmu.TabIndex = 27;
            this.OpisFilmu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SEOfilm
            // 
            this.SEOfilm.Font = new System.Drawing.Font("Oswald", 8F);
            this.SEOfilm.Location = new System.Drawing.Point(606, 304);
            this.SEOfilm.Name = "SEOfilm";
            this.SEOfilm.Size = new System.Drawing.Size(319, 112);
            this.SEOfilm.TabIndex = 26;
            this.SEOfilm.Text = "-";
            this.SEOfilm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SEOfilm.UseVisualStyleBackColor = true;
            this.SEOfilm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(485, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "SEO opis filmu:";
            // 
            // textBoxIdFilm
            // 
            this.textBoxIdFilm.Font = new System.Drawing.Font("Oswald", 12F);
            this.textBoxIdFilm.Location = new System.Drawing.Point(22, 383);
            this.textBoxIdFilm.Name = "textBoxIdFilm";
            this.textBoxIdFilm.Size = new System.Drawing.Size(277, 46);
            this.textBoxIdFilm.TabIndex = 24;
            this.textBoxIdFilm.Text = "brak";
            this.textBoxIdFilm.UseVisualStyleBackColor = true;
            this.textBoxIdFilm.Click += new System.EventHandler(this.textBoxIdFilm_Click);
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Font = new System.Drawing.Font("Oswald", 8F);
            this.textBoxPlayer.Location = new System.Drawing.Point(607, 434);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(319, 105);
            this.textBoxPlayer.TabIndex = 23;
            this.textBoxPlayer.Text = "-";
            this.textBoxPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textBoxPlayer.UseVisualStyleBackColor = true;
            this.textBoxPlayer.Click += new System.EventHandler(this.textBoxPlayer_Click);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Oswald", 8F);
            this.textBoxOpis.Location = new System.Drawing.Point(606, 189);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(319, 109);
            this.textBoxOpis.TabIndex = 22;
            this.textBoxOpis.Text = "-";
            this.textBoxOpis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textBoxOpis.UseVisualStyleBackColor = true;
            this.textBoxOpis.Click += new System.EventHandler(this.textBoxOpis_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Oswald", 16.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.checkBox1.Location = new System.Drawing.Point(263, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 41);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Rejestracja";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelTrailerFilm
            // 
            this.labelTrailerFilm.AutoSize = true;
            this.labelTrailerFilm.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrailerFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.labelTrailerFilm.Location = new System.Drawing.Point(16, 291);
            this.labelTrailerFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrailerFilm.Name = "labelTrailerFilm";
            this.labelTrailerFilm.Size = new System.Drawing.Size(136, 32);
            this.labelTrailerFilm.TabIndex = 17;
            this.labelTrailerFilm.Text = "Trailer (YouTube):";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(22, 327);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 36);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(504, 472);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kod Player:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(479, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis filmu i kod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(16, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres obrazu:";
            // 
            // textBoxAdresFilm
            // 
            this.textBoxAdresFilm.Font = new System.Drawing.Font("Oswald", 12.25F);
            this.textBoxAdresFilm.Location = new System.Drawing.Point(22, 483);
            this.textBoxAdresFilm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxAdresFilm.Multiline = true;
            this.textBoxAdresFilm.Name = "textBoxAdresFilm";
            this.textBoxAdresFilm.Size = new System.Drawing.Size(365, 57);
            this.textBoxAdresFilm.TabIndex = 6;
            this.textBoxAdresFilm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plaforma:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "REJESTRACJA",
            "Player+",
            "HBO GO",
            "Amazon Prime Video",
            "Canal + Premium",
            "Netflix"});
            this.comboBox1.Location = new System.Drawing.Point(22, 168);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 40);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa:";
            // 
            // textBoxNazwaFilm
            // 
            this.textBoxNazwaFilm.Font = new System.Drawing.Font("Oswald", 16.25F);
            this.textBoxNazwaFilm.Location = new System.Drawing.Point(22, 57);
            this.textBoxNazwaFilm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxNazwaFilm.Name = "textBoxNazwaFilm";
            this.textBoxNazwaFilm.Size = new System.Drawing.Size(283, 40);
            this.textBoxNazwaFilm.TabIndex = 2;
            this.textBoxNazwaFilm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabSerial
            // 
            this.tabSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.tabSerial.Controls.Add(this.SEOSerial);
            this.tabSerial.Controls.Add(this.textBoxOpisSerial);
            this.tabSerial.Controls.Add(this.label12);
            this.tabSerial.Controls.Add(this.label11);
            this.tabSerial.Controls.Add(this.labelWWWSerial);
            this.tabSerial.Controls.Add(this.textBoxIdSerial);
            this.tabSerial.Controls.Add(this.OpisSerialu);
            this.tabSerial.Controls.Add(this.checkBox2);
            this.tabSerial.Controls.Add(this.label6);
            this.tabSerial.Controls.Add(this.textBox2);
            this.tabSerial.Controls.Add(this.label9);
            this.tabSerial.Controls.Add(this.label7);
            this.tabSerial.Controls.Add(this.comboBox2);
            this.tabSerial.Controls.Add(this.labelNazwaSerial);
            this.tabSerial.Controls.Add(this.textBoxNazwaSerial);
            this.tabSerial.Location = new System.Drawing.Point(4, 44);
            this.tabSerial.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabSerial.Size = new System.Drawing.Size(943, 548);
            this.tabSerial.TabIndex = 1;
            this.tabSerial.Text = "Dodaj serial";
            // 
            // SEOSerial
            // 
            this.SEOSerial.Font = new System.Drawing.Font("Oswald", 8F);
            this.SEOSerial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SEOSerial.Location = new System.Drawing.Point(577, 368);
            this.SEOSerial.Name = "SEOSerial";
            this.SEOSerial.Size = new System.Drawing.Size(328, 143);
            this.SEOSerial.TabIndex = 34;
            this.SEOSerial.Text = "-";
            this.SEOSerial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SEOSerial.UseVisualStyleBackColor = true;
            this.SEOSerial.Click += new System.EventHandler(this.SEOSerial_Click);
            // 
            // textBoxOpisSerial
            // 
            this.textBoxOpisSerial.Font = new System.Drawing.Font("Oswald", 8F);
            this.textBoxOpisSerial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxOpisSerial.Location = new System.Drawing.Point(577, 193);
            this.textBoxOpisSerial.Name = "textBoxOpisSerial";
            this.textBoxOpisSerial.Size = new System.Drawing.Size(328, 147);
            this.textBoxOpisSerial.TabIndex = 33;
            this.textBoxOpisSerial.Text = "-";
            this.textBoxOpisSerial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textBoxOpisSerial.UseVisualStyleBackColor = true;
            this.textBoxOpisSerial.Click += new System.EventHandler(this.textBoxOpisSerial_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label12.Location = new System.Drawing.Point(440, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "Opis serialu i kod:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label11.Location = new System.Drawing.Point(447, 421);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "SEO opis serialu:";
            // 
            // labelWWWSerial
            // 
            this.labelWWWSerial.Font = new System.Drawing.Font("Oswald", 12.25F);
            this.labelWWWSerial.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelWWWSerial.Location = new System.Drawing.Point(22, 255);
            this.labelWWWSerial.Name = "labelWWWSerial";
            this.labelWWWSerial.Size = new System.Drawing.Size(217, 35);
            this.labelWWWSerial.TabIndex = 30;
            this.labelWWWSerial.Text = "brak";
            this.labelWWWSerial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWWWSerial.UseVisualStyleBackColor = true;
            this.labelWWWSerial.Click += new System.EventHandler(this.labelWWWSerial_Click);
            // 
            // textBoxIdSerial
            // 
            this.textBoxIdSerial.Font = new System.Drawing.Font("Oswald", 12F);
            this.textBoxIdSerial.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxIdSerial.Location = new System.Drawing.Point(22, 447);
            this.textBoxIdSerial.Name = "textBoxIdSerial";
            this.textBoxIdSerial.Size = new System.Drawing.Size(277, 46);
            this.textBoxIdSerial.TabIndex = 29;
            this.textBoxIdSerial.Text = "brak";
            this.textBoxIdSerial.UseVisualStyleBackColor = true;
            this.textBoxIdSerial.Click += new System.EventHandler(this.textBoxIdSerial_Click);
            // 
            // OpisSerialu
            // 
            this.OpisSerialu.Font = new System.Drawing.Font("Oswald", 8F);
            this.OpisSerialu.Location = new System.Drawing.Point(512, 66);
            this.OpisSerialu.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OpisSerialu.Multiline = true;
            this.OpisSerialu.Name = "OpisSerialu";
            this.OpisSerialu.Size = new System.Drawing.Size(381, 70);
            this.OpisSerialu.TabIndex = 28;
            this.OpisSerialu.TextChanged += new System.EventHandler(this.OpisSerialu_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Oswald", 16.25F);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.checkBox2.Location = new System.Drawing.Point(261, 193);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 41);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Rejestracja";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(21, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trailer (YouTube):";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.textBox2.Location = new System.Drawing.Point(22, 404);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 36);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label9.Location = new System.Drawing.Point(506, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Opis serialu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(16, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Plaforma:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Oswald", 16.25F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "REJESTRACJA",
            "Player+",
            "HBO GO",
            "Amazon Prime Video",
            "Canal + Premium",
            "Netflix"});
            this.comboBox2.Location = new System.Drawing.Point(22, 191);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 45);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelNazwaSerial
            // 
            this.labelNazwaSerial.AutoSize = true;
            this.labelNazwaSerial.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.labelNazwaSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.labelNazwaSerial.Location = new System.Drawing.Point(16, 55);
            this.labelNazwaSerial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazwaSerial.Name = "labelNazwaSerial";
            this.labelNazwaSerial.Size = new System.Drawing.Size(63, 32);
            this.labelNazwaSerial.TabIndex = 14;
            this.labelNazwaSerial.Text = "Nazwa:";
            // 
            // textBoxNazwaSerial
            // 
            this.textBoxNazwaSerial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxNazwaSerial.Font = new System.Drawing.Font("Oswald", 16.25F);
            this.textBoxNazwaSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.textBoxNazwaSerial.Location = new System.Drawing.Point(22, 96);
            this.textBoxNazwaSerial.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxNazwaSerial.Name = "textBoxNazwaSerial";
            this.textBoxNazwaSerial.Size = new System.Drawing.Size(256, 40);
            this.textBoxNazwaSerial.TabIndex = 13;
            this.textBoxNazwaSerial.TextChanged += new System.EventHandler(this.textBoxNazwaSerial_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(391, 610);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "RESET";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(973, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Onlinewideo.pl - dodawanie filmow i seriali";
            this.tabControl1.ResumeLayout(false);
            this.tabFilm.ResumeLayout(false);
            this.tabFilm.PerformLayout();
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdresFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwaFilm;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelNazwaSerial;
        private System.Windows.Forms.TextBox textBoxNazwaSerial;
        private System.Windows.Forms.Label labelTrailerFilm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button textBoxOpis;
        private System.Windows.Forms.Button textBoxPlayer;
        private System.Windows.Forms.Button textBoxIdFilm;
        private System.Windows.Forms.TextBox OpisFilmu;
        private System.Windows.Forms.Button SEOfilm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button labelWWWFilm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox OpisSerialu;
        private System.Windows.Forms.Button textBoxIdSerial;
        private System.Windows.Forms.Button labelWWWSerial;
        private System.Windows.Forms.Button textBoxOpisSerial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SEOSerial;
    }
}

