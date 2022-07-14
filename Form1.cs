using System;
using System.Diagnostics;
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
            textBoxNazwaFilm.Text = textBoxNazwaFilm.Text.Trim(); 
        }
        public void wprowadz_tekst_do_opisu_serial()
        {
            string tekst = String.Format(@"
            <h3 style=""text-align: center; "">Serial {0}:</h3>

               <a href = ""{1}"" target=""_blank"" rel=""noopener"" ><img class=""aligncenter wp-image-24 size-medium"" title =""Serial {2}"" src=""https://onlinewideo.pl/wp-content/uploads/2018/02/oglądaj-online-300x86.png"" alt=""Serial {3} online"" width=""300"" height=""86"" /></a>
            ", textBoxNazwaSerial.Text.Trim(), labelWWWSerial.Text, textBoxNazwaSerial.Text.Trim(), textBoxNazwaSerial.Text.Trim());

            textBoxOpisSerial.Text = textBoxNazwaSerial.Text + " - " + OpisSerialu.Text + tekst;
        }
        public void wprowadz_tekst_do_opisu_film()
        {
            string tekst = String.Format(@"
            <h3 style=""text-align: center; "">Film {0}:</h3>

               <a href = ""{1}"" target=""_blank"" rel=""noopener"" ><img class=""aligncenter wp-image-24 size-medium"" title =""Film {2}"" src=""https://onlinewideo.pl/wp-content/uploads/2018/02/oglądaj-online-300x86.png"" alt=""Film {3} online"" width=""300"" height=""86"" /></a>
            ", textBoxNazwaFilm.Text.Trim(), labelWWWFilm.Text, textBoxNazwaFilm.Text.Trim(), textBoxNazwaFilm.Text.Trim());

            textBoxOpis.Text = textBoxNazwaFilm.Text + " - " + OpisFilmu.Text + tekst;
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
            //viaplay
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
            textBoxNazwaSerial.Text = textBoxNazwaSerial.Text.Trim();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string wynik = "";
            if (id.Contains("youtu.be"))
            {
                wynik = "[" + id.Substring(id.LastIndexOf("e") + 2) + "]";

            }
            else
            {
                wynik = "[" + id.Substring(id.LastIndexOf("=") + 1) + "]";

            }
            textBoxIdFilm.Text = wynik;
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

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string id = textBox2.Text.Trim();
            string wynik = "";
            if (id.Contains("youtu.be"))
            {
                 wynik = "[" + id.Substring(id.LastIndexOf("e") + 2) + "]";

            }
            else
            {
                 wynik = "[" + id.Substring(id.LastIndexOf("=") + 1) + "]";

            }
            textBoxIdSerial.Text = wynik;
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNazwaFilm.Text = "";
            textBox1.Text = "";
            textBoxAdresFilm.Text = "";
            OpisFilmu.Text = "";
            textBoxNazwaSerial.Text = "";
            textBox2.Text = "";
            OpisSerialu.Text = "";
            if (do_wrzucenia.Value > 1) do_wrzucenia.Value -= 1;
            else {
                MessageBox.Show("Na dzisiaj wystarczy! \uD83D\uDDF8", "Koniec!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                do_wrzucenia.Value = 0;
            }
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
            textBoxOpis.Text = textBoxNazwaFilm.Text + " - " + OpisFilmu.Text;
            if ((OpisFilmu.Text.Length + textBoxNazwaFilm.Text.Length)>138-17) SEOfilm.Text = " " + OpisFilmu.Text.Substring(0, 138-textBoxNazwaFilm.Text.Length-11);
            else SEOfilm.Text = " "+ OpisFilmu.Text;
            wprowadz_tekst_do_opisu_film();
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
            textBoxOpisSerial.Text = textBoxNazwaSerial.Text + " - " + OpisSerialu.Text;
            if ((OpisSerialu.Text.Length+textBoxNazwaSerial.Text.Length) > 138- 17) SEOSerial.Text = " " + OpisSerialu.Text.Substring(0, 138 - textBoxNazwaSerial.Text.Length-11);
            else SEOSerial.Text = " " + OpisSerialu.Text;
            wprowadz_tekst_do_opisu_serial();
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
                //---zamiana latin na plain text
                byte[] tempBytes;
                tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaFilm.Text);
                //---
                string path = @"skrypt.bat";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(@"start chrome "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes) + " trailer");
                }
                System.Diagnostics.Process.Start("skrypt.bat"); 
                Thread.Sleep(2000); //za szybko był usuwany plik
                File.Delete(path);
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
                //---zamiana latin na plain text
                byte[] tempBytes;
                tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(textBoxNazwaSerial.Text);
                //---
                string path = @"skrypt.bat";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(@"start chrome "" ? {0}""", System.Text.Encoding.UTF8.GetString(tempBytes) + " trailer");
                }
                System.Diagnostics.Process.Start("skrypt.bat");
                Thread.Sleep(2000); //za szybko był usuwany plik
                File.Delete(path);
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
    }
}
