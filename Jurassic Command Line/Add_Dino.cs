using Microsoft.Maps.MapControl.WPF;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WMPLib;
using Timer = System.Windows.Forms.Timer;

namespace Jurassic_Command_Line
{
    public partial class AddDino : Form
    {
        public static WindowsMediaPlayer Wmp = new WindowsMediaPlayer();

        private string _imageLocation,
            _imageDestination,
            _soundLocation,
            _soundDestination,
            _especie,
            _familia,
            _era,
            _dieta,
            _isla;
        private bool hasBeenReproduced = false;

        private float _cantidad, _seguridad, _alto, _largo;
        private string _infoAdicional = @"";
        private string _filePath = Path.GetTempFileName();
        private bool isAppearing = false;
        private Timer _timer = new Timer();
        private bool Checking_AlreadyExists = false;
        private WindowsMediaPlayer _objeto = Seleccióm.Sonido;

        public AddDino()
        {
            InitializeComponent();
        }

        private void Add_Dino_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Cerrarform);

            Wmp.PlayStateChange += Player_PlayStateChange;
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!hasBeenReproduced)
            {
                if (_objeto.settings.volume > 0)
                {
                    _objeto.settings.volume--;
                }
                else
                {
                    _objeto.controls.pause();
                    Wmp.URL = _soundDestination;
                    Wmp.controls.play();
                    _timer.Stop();
                    hasBeenReproduced = true;
                }
            }
            else
            {
                if (_objeto.settings.volume < 100 && Seleccióm.MusicEnabled == true)
                {
                    Wmp.URL = _soundDestination;
                    Wmp.controls.stop();
                    _objeto.controls.play();
                    _objeto.settings.volume++;
                }
                else
                {
                    _timer.Stop();
                    hasBeenReproduced = false;
                }
            }
        }

        private void Player_PlayStateChange(int newstate)
        {
        }

        private void Cerrarform(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de sonido (*.mp3) | *.mp3";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                _especie = TXTespecie.Text.Trim();
                _soundLocation = archivo.FileName;
                _soundDestination = Path.Combine((@"C:\Users\Public\Documents\Jurassic Command Line\Sound"), _especie + ".mp3");

                try
                {
                    File.Move(_soundLocation, _soundDestination);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error: {exception}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_selec_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            string texto = Microsoft.VisualBasic.Interaction.InputBox(
                "Especie:",
                "System Admin",
                "");
            archivo.Filter = "Archivos de imagen (*.jpeg) | *.jpeg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                _imageLocation = archivo.FileName;
                _imageDestination = Path.Combine((@"C:\Users\Public\Documents\Jurassic Command Line\Images"), texto + ".jpeg");
                try
                {
                    File.Move(_imageLocation, _imageDestination);
                    pictureBox1.Image = Image.FromFile(_imageDestination);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error: {exception}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void btn_guardar_tdo_Click(object sender, EventArgs e)
        {
            if (CMBB_ISLAND.SelectedItem != null && TXTespecie.Text != null && TXTflia.Text != null
                && TXTera.Text != null && Cantidad_Num.Text != null && Sec_Num.Text != null
                && Alto_Num.Text != null && Largo_Num.Text != null && CMBB_Dieta.SelectedItem != null
                && richTextBox1.Text != null)
            {
                _isla = CMBB_ISLAND.SelectedItem.ToString();
                _especie = TXTespecie.Text.Trim();
                _familia = TXTflia.Text.Trim();
                _era = TXTera.Text.Trim();
                _cantidad = float.Parse(Cantidad_Num.Text);
                _seguridad = float.Parse(Sec_Num.Text);
                _alto = float.Parse(Alto_Num.Text);
                _largo = float.Parse(Largo_Num.Text);
                _dieta = CMBB_Dieta.SelectedItem.ToString();
                _infoAdicional = richTextBox1.Text;

                Checking_Already_Exists();

                if (Checking_AlreadyExists == true)
                {
                    Random rnd = new Random();
                    int age = rnd.Next(60, 150);

                    File.WriteAllText(@"C:\Users\Public\Documents\Jurassic Command Line\" + _especie + ".txt",
                        _especie.ToUpper() + ":\r\n\r\nDieta: " + _dieta + "\r\nEra: " + _era + "\r\nFamilia: " + _familia +
                        "\r\nAlto: " + _alto + " m\r\nLargo: " + _largo + " m\r\nEsperanza de vida: " + age +
                        " Años\r\nNivel de seguridad: " + _seguridad + "\r\nPoblacíon actual: ¿?\r\nPoblación incial: " +
                        _cantidad + "\r\n\r\n " + _infoAdicional);

                    Seleccióm seleccióm = new Seleccióm();
                    seleccióm.Show();
                    this.Hide();

                    try
                    {
                        System.IO.File.AppendAllText(
                            @"C:\Users\Public\Documents\Jurassic Command Line\" + _isla + "_Dinosaurs.jcl",
                            System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("\n" + _especie)));
                        MessageBox.Show("Archivo guardado correctamente!", "System Admin", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Error: {exception}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                appearing();
            }
        }

        private void appearing()
        {
            label12.Visible = true;
        }

        public void Checking_Already_Exists()
        {
            _especie = TXTespecie.Text.Trim();

            if (System.IO.File.Exists(@"C:\Users\Public\Documents\Jurassic Command Line\" + _especie + ".txt"))
            {
                MessageBox.Show("Error: El archivo '" + _especie + "', ya existe en la base de datos", "System Admin",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Checking_AlreadyExists = false;
            }
            else
            {
                Checking_AlreadyExists = true;
            }
        }
    }
}
