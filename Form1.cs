using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace onlinewideo.pl_add
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wprowadz_tekst_do_opisu_film();
            textBoxNazwaFilm.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
        }
        public void wprowadz_tekst_do_opisu_serial()
        {
            string tekst = String.Format(@"
            <h3 style=""text-align: center; "">Serial {0}:</h3>

               <a href = ""{1}"" target=""_blank"" rel=""noopener"" ><img class=""aligncenter wp-image-24 size-medium"" title =""Serial {2}"" src=""https://onlinewideo.pl/wp-content/uploads/2018/02/oglądaj-online-300x86.png"" alt=""Serial {3} online"" width=""300"" height=""86"" /></a>
            ", textBoxNazwaSerial.Text.Trim(), labelWWWSerial.Text, textBoxNazwaSerial.Text.Trim(), textBoxNazwaSerial.Text.Trim());

            textBoxOpisSerial.Text = textBoxNazwaSerial.Text.Trim() + " - " + OpisSerialu.Text + tekst;
        }
        public void wprowadz_tekst_do_opisu_film()
        {
            string tekst = String.Format(@"
            <h3 style=""text-align: center; "">Film {0}:</h3>

               <a href = ""{1}"" target=""_blank"" rel=""noopener"" ><img class=""aligncenter wp-image-24 size-medium"" title =""Film {2}"" src=""https://onlinewideo.pl/wp-content/uploads/2018/02/oglądaj-online-300x86.png"" alt=""Film {3} online"" width=""300"" height=""86"" /></a>
            ", textBoxNazwaFilm.Text.Trim(), labelWWWFilm.Text, textBoxNazwaFilm.Text.Trim(), textBoxNazwaFilm.Text.Trim());

            textBoxOpis.Text = textBoxNazwaFilm.Text.Trim() + " - " + OpisFilmu.Text + tekst;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Link do rejestracji
            // Player+
            // HBO GO
            // Amazon Prime Video
            // Canal + Premium
            // Netflix
            // Viaplay
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/rejestracja/";
                    break;
                case 1:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/player/";
                    break;
                case 2:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/hbo/";
                    break;
                case 3:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/amazon-prime-video/";
                    break;
                case 4:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/canal/";
                    break;
                case 5:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/netflix/";
                    break;
                case 6:
                    labelWWWFilm.Text = @"https://onlinewideo.pl/online/viaplay/";
                    break;
                default:
                    MessageBox.Show("Błąd!");
                    break;
            }
            wprowadz_tekst_do_opisu_film();
            wprowadz_tekst_do_playera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOpis.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            wprowadz_tekst_do_playera();
            textBoxAdresFilm.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);

        }
        public void wprowadz_tekst_do_playera()
        {
            string tekst = String.Format(@"
            <iframe style=""
                 width: 100%;
                 height: 100%;
                 position: absolute;
                 top:0; left:0;
                 background-image: url('{0}');
                 background-repeat: no-repeat;
                 background-size: contain;
                 background-position: center; ""
                 scrolling=""no"" frameborder=""0"" allowtransparency = ""true"" allowfullscreen="""" src=""https://player.onlinewideo.pl/player/player.php"" >
             </iframe>"
            , textBoxAdresFilm.Text.Trim());

            textBoxPlayer.Text = tekst;
        }

        private void kopiujPlayerFilm_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxPlayer.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");

            }

        }

        private void kopiujOpisSerial_Click(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // link do rejestracji
            // Player+
            // HBO GO
            // Amazon Prime Video
            // Canal + Premium
            // Netlix
            // Viaplay
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/rejestracja/";
                    break;
                case 1:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/player/";
                    break;
                case 2:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/hbo/";
                    break;
                case 3:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/amazon-prime-video/";
                    break;
                case 4:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/canal/";
                    break;
                case 5:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/netflix/";
                    break;
                case 6:
                    labelWWWSerial.Text = @"https://onlinewideo.pl/online/viaplay/";
                    break;
                default:
                    MessageBox.Show("Błąd!");
                    break;
            }
            wprowadz_tekst_do_opisu_serial();
        }

        private void textBoxNazwaSerial_TextChanged(object sender, EventArgs e)
        {
            wprowadz_tekst_do_opisu_serial();
            textBoxNazwaSerial.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Contains("youtube.com") || textBox1.Text.Contains("youtu.be")|| textBox1.Text.Equals(" "))
                {
                    textBoxIdFilm.Text = Yt_id(textBox1.Text);
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Zły link!");
                textBox1.Text = " ";
            }
        }

        private void kopiujIdSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxIdSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }


        }
        private String Yt_id(String link)
        {
            string wynik = " ";
            if (link.Contains("youtu.be"))
            {
                wynik = "[" + link.Substring(link.LastIndexOf("e") + 2) + "]";

            }
            else
            {
                wynik = "[" + link.Substring(link.LastIndexOf("=") + 1) + "]";

            }
            return wynik;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Contains("youtube.com") || textBox2.Text.Contains("youtu.be") || textBox2.Text.Equals(" "))
                {
                    textBoxIdSerial.Text = Yt_id(textBox2.Text);
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Zły link!");
                textBox2.Text = "";
            }

        }

        private void labelWWWFilm_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(labelWWWFilm.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }
        private void reset()
        {
            textBoxNazwaFilm.Text = ""; textBoxNazwaFilm2.Text = "";
            textBoxAdresFilm.Text = "";
            OpisFilmu.Text = "";
            textBoxNazwaSerial.Text = ""; textBoxNazwaSerial2.Text = "";
            textBox1.Text = textBox2.Text = " ";
            OpisSerialu.Text = "";

            textBoxNazwaFilm.BackColor = System.Drawing.Color.White;
            textBoxNazwaSerial.BackColor = System.Drawing.Color.White;
            OpisFilmu.BackColor = System.Drawing.Color.White;
            OpisSerialu.BackColor = System.Drawing.Color.White;
            textBoxAdresFilm.BackColor = System.Drawing.Color.White;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            if (do_wrzucenia.Value > 1) do_wrzucenia.Value -= 1;
            else
            {
                MessageBox.Show("Na dzisiaj koniec! \uD83D\uDDF8", "Koniec!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                do_wrzucenia.Value = 0;
            }
            notifyIcon1.Text = "Zostało do wrzucenia: "+do_wrzucenia.Value.ToString();
        }

        private void textBoxOpis_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOpis.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void textBoxPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxPlayer.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");

            }
        }

        private void textBoxIdFilm_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxIdFilm.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(SEOfilm.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxOpis.Text = textBoxNazwaFilm.Text.Trim() + " - " + OpisFilmu.Text;
                if ((OpisFilmu.Text.Length + textBoxNazwaFilm.Text.Length) > 138 - 17) SEOfilm.Text = " " + OpisFilmu.Text.Substring(0, 138 - textBoxNazwaFilm.Text.Length - 11);
                else SEOfilm.Text = " " + OpisFilmu.Text;
                wprowadz_tekst_do_opisu_film();
                OpisFilmu.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd!");
                reset();
            }
        }

        private void labelWWWFilm_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(labelWWWFilm.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void textBoxIdSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxIdSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void textBoxOpisSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOpisSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }

        }

        private void labelWWWSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(labelWWWSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void OpisSerialu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxOpisSerial.Text = textBoxNazwaSerial.Text.Trim() + " - " + OpisSerialu.Text;
                if ((OpisSerialu.Text.Length + textBoxNazwaSerial.Text.Length) > 138 - 17) SEOSerial.Text = " " + OpisSerialu.Text.Substring(0, 138 - textBoxNazwaSerial.Text.Length - 11);
                else SEOSerial.Text = " " + OpisSerialu.Text;
                wprowadz_tekst_do_opisu_serial();
                OpisSerialu.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            }
            catch (Exception)
            {
                reset();
                MessageBox.Show("Error!");
            }
            
        }

        private void SEOSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(SEOSerial.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNazwaFilm.Text == "") throw new Exception();
                //---zamiana latin na plain text
                byte[] tempBytes;
                tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaFilm.Text.Trim());
                //---
                byte[] tempBytes2;
                tempBytes2 = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaFilm2.Text.Trim());
                string path = @"skrypt.bat"; string path2 = @"skrypt2.bat";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(@"start chrome --incognito "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes) + " trailer");
                }
                using (StreamWriter sw2 = File.CreateText(path2))
                {
                    sw2.WriteLine(@"start chrome --incognito "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes2) + " trailer");
                }
                System.Diagnostics.Process.Start("skrypt.bat"); System.Diagnostics.Process.Start("skrypt2.bat");
                Thread.Sleep(2500); //za szybko był usuwany plik
                File.Delete(path); File.Delete(path2);

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNazwaSerial.Text == "") throw new Exception();

                //---zamiana latin na plain text
                byte[] tempBytes;
                tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaSerial.Text.Trim());
                //---
                //---zamiana latin na plain text
                byte[] tempBytes2;
                tempBytes2 = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaSerial2.Text.Trim());
                //---
                string path = @"skrypt.bat"; string path2 = @"skrypt2.bat";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(@"start chrome --incognito "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes) + " trailer");
                }
                using (StreamWriter sw2 = File.CreateText(path2))
                {
                    sw2.WriteLine(@"start chrome --incognito "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes2) + " trailer");
                }
                System.Diagnostics.Process.Start("skrypt.bat"); System.Diagnostics.Process.Start("skrypt2.bat");
                Thread.Sleep(2500); //za szybko był usuwany plik
                File.Delete(path); File.Delete(path2);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label_opis_serialu_i_kod_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOpisSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label_seo_opis_serialu_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(SEOSerial.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label_opis_filmu_i_kod_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOpis.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label_seo_opis_filmu_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(SEOfilm.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label_kod_player_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxPlayer.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxNazwaFilm.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void labelNazwaSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxNazwaSerial.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            //zdarzenie Resize do minimalizeToTray
            this.Resize += new System.EventHandler(this.Form1_Resize);
            
            do_wrzucenia.Value = 8;
            notifyIcon1.Text = "Zostało do wrzucenia:  "+do_wrzucenia.Value.ToString();

            //uruchamianie programu w prawym dolnym rogu monitora
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }



        private void do_wrzucenia_ValueChanged(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Zostało do wrzucenia:  " + do_wrzucenia.Value.ToString();

        }

        //minimalize to tray
        //
        //
        private void Form1_Resize(object sender, EventArgs e)
        {

            if (FormWindowState.Minimized == WindowState)
            {

                notifyIcon1.Visible = true;
                this.Hide();
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNazwaFilm.Text=textBoxNazwaFilm.Text.Trim();
                String temp = textBoxNazwaFilm.Text.Substring(0, 1);
                textBoxNazwaFilm.Text = temp + textBoxNazwaFilm.Text.Substring(1, textBoxNazwaFilm.Text.Length - 1).ToLower();
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNazwaFilm2.Text=textBoxNazwaFilm2.Text.Trim();
                String temp = textBoxNazwaFilm2.Text.Substring(0, 1);
                textBoxNazwaFilm2.Text = temp + textBoxNazwaFilm2.Text.Substring(1, textBoxNazwaFilm2.Text.Length - 1).ToLower();
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNazwaSerial.Text=textBoxNazwaSerial.Text.Trim();
                String temp = textBoxNazwaSerial.Text.Substring(0, 1);
                textBoxNazwaSerial.Text = temp + textBoxNazwaSerial.Text.Substring(1, textBoxNazwaSerial.Text.Length - 1).ToLower();
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }

        }

        private void textBoxNazwaSerial2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNazwaSerial2.Text=textBoxNazwaSerial2.Text.Trim();
                String temp = textBoxNazwaSerial2.Text.Substring(0, 1);
                textBoxNazwaSerial2.Text = temp + textBoxNazwaSerial2.Text.Substring(1, textBoxNazwaSerial2.Text.Length - 1).ToLower();
            }
            catch (Exception)
            {

                MessageBox.Show("Błąd!");
            }
        }
        //

    }
}
