using System;
using System.Windows.Forms;
using WMPLib;
namespace Jurassic_Command_Line
{
    public partial class Seleccióm : Form
    {
        public static bool HasBeenOpened = false;

        public static WindowsMediaPlayer Sonido = new WindowsMediaPlayer(); 
        public static bool MusicEnabled = true;
        public Seleccióm()
        {
            InitializeComponent();
        }
        public void Seleccióm_Load(object sender, EventArgs e)
        {
            if (MusicEnabled)
            {

                button3.Image = Properties.Resources.musica;

                if (!HasBeenOpened)
                {
                    try
                    {
                        Sonido.URL = @"C:\Users\Public\Documents\Jurassic Command Line\Sound\ST\ST.mp3";
                        Sonido.controls.play();
                        Sonido.settings.volume = 100;
                        HasBeenOpened = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Código de error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                button3.Image = Properties.Resources.barra_de_musica;
            }

            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = comboBox1.Text.ToString();
            String selected;

            //Selected = s.ToString();



            if (s == "Consultar datos de dinosaurio")
            {

                ConsultarDatosDeDinosaurios consultar = new ConsultarDatosDeDinosaurios();
                consultar.Show();
                this.Hide();

            }
            else if (s == "Agregar Dinosaurio")
            {
                AddDino add = new AddDino();
                add.Show();
                this.Hide();
            }
            else if (s == "Alimentar Dinosaurio")
            {

                Feed feed = new Feed();
                feed.Show();
                this.Hide();

            }
            else if (s == "Cámaras")
            {

            }
            else if (s == "Consultar  estado alambradas")
            {

            }
            else if (s == "Reiniciar Parque")
            {

            }else if (s == "Consultar estado sistemas")
            {
                
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar una opción.", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void CerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MusicEnabled == true)
            {
                button3.Image = Properties.Resources.barra_de_musica;
                Sonido.controls.pause();
                MusicEnabled = false;
            }
            else
            {
                button3.Image = Properties.Resources.musica;
                Sonido.controls.play();
                MusicEnabled = true;
            }
        }
    }
}
