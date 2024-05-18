using proiectmtp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proiectmtp
{
    public partial class Autentificare : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRtight, int nBottom, int nWidtEllipse, int nHeightEllipse);

        public Autentificare()
        {
            InitializeComponent();
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");
            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                comboBoxutilizator.Items.Add(inregistrare[0]);
            }
        }

        private int incercari = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");

            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                if ((comboBoxutilizator.Text).Equals(inregistrare[0]))
                {
                    if ((txtParola.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        Meniu f = new Meniu();
                        f.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        incercari++;
                        MessageBox.Show("Ati introdus o parola incorecta! Mai aveti " + (3 - incercari).ToString() + " incercari.");
                        txtParola.Text = String.Empty;
                    }
                }
                if (incercari == 3)
                {
                    MessageBox.Show("Ati depasit numarul de incercari!");
                    Application.Exit();
                }
            }

        }
        private void button3_Click(object sender, EventArgs e) 
        {
            Inregistrare f = new Inregistrare();
            f.ShowDialog();

        }

        private void SetBackgroundImage()
        {
            // calea spre imagine
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "poza.jpg");

            // Verificare
            if (File.Exists(imagePath))
            {
                //setare imagine de fundal
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Pot fi folosite si alte valori: None, Tile, Center, Zoom
            }
            else
            {
                MessageBox.Show("Imaginea de fundal nu a fost găsită.");
            }
        }


        private void Autentificare_Load(object sender, EventArgs e)
        {
            SetBackgroundImage();
            //button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 100, 100));
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxutilizator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}