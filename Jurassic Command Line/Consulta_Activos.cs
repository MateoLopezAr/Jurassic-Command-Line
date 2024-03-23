using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace Jurassic_Command_Line
{
    public partial class ConsultaActivos : Form
    {
        private WindowsMediaPlayer _objeto = Seleccióm.Sonido;
        private string _seleccionadoAnteriormente;
        private WindowsMediaPlayer _player = new WindowsMediaPlayer();
        private bool _fatalErrorOcured = false;
        private bool _isEditing = false;
        private Timer _timer = new Timer();
        private bool _hasBeenReproduced = false;
        private string _documento;
        private Mensajes mensajes;

        private ConsultarDatosDeDinosaurios _consultar = new ConsultarDatosDeDinosaurios();
        public ConsultaActivos(String seleccionadoAnteriormente)
        {
            InitializeComponent();
            this._seleccionadoAnteriormente = seleccionadoAnteriormente;

            _player.PlayStateChange += Player_PlayStateChange;
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!_hasBeenReproduced)
            {
                if (_objeto.settings.volume > 0)
                {
                    _objeto.settings.volume--;
                }
                else
                {
                    _objeto.controls.pause();
                    _timer.Stop();


                    _player.URL = @"C:\Users\Public\Documents\Jurassic Command Line\Sound\" + _seleccionadoAnteriormente +
                                 ".mp3";
                    _player.controls.play();
                    _hasBeenReproduced = true;
                }
            }
            else
            {
                if (_objeto.settings.volume < 100 && Seleccióm.MusicEnabled == true)
                {
                    _objeto.controls.play();

                    _objeto.settings.volume++;
                }
                else
                {
                    _timer.Stop();
                }
            }
        }

        public void Consulta_Activos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\Jurassic Command Line\" +
                                                   _seleccionadoAnteriormente + ".txt");
                _documento = sr.ReadToEnd();
                pictureBox1.ImageLocation = @"C:\Users\Public\Documents\Jurassic Command Line\Images\" +
                                            _seleccionadoAnteriormente + ".JPG";

                richTextBox1.Text = _documento;
                sr.Close();

                _timer.Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Código de error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _fatalErrorOcured = true;
            }

            if (_fatalErrorOcured)
            {
                Application.Exit();
            }

        }
        private void CerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _consultar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_isEditing == false)
            {

                richTextBox1.ReadOnly = false;
                button2.Text = "Guardar";
                _isEditing = true;

            }
            else if (_isEditing == true)
            {

                richTextBox1.ReadOnly = true;
                button2.Text = "Editar";
                _isEditing = false;
                File.WriteAllText(@"C:\Users\Public\Documents\Jurassic Command Line\" +
                _seleccionadoAnteriormente + ".txt", richTextBox1.Text);

            }
        }

        private void Player_PlayStateChange(int newState)
        {
            if ((WMPPlayState)newState == WMPPlayState.wmppsMediaEnded)
            {

                _timer.Start();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("¿Seguro desea eliminar esta entrada?", "System Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {

                if (File.Exists(@"C:\Users\Public\Documents\Jurassic Command Line\" + _seleccionadoAnteriormente + ".txt"))
                {

                    File.Delete(@"C:\Users\Public\Documents\Jurassic Command Line\" + _seleccionadoAnteriormente + ".txt");

                    string contenido;
                    string New;
                    contenido = File.ReadAllText(@"C:\Users\Public\Documents\Jurassic Command Line\" + ".txt");
                    contenido = Decodificar(contenido);

                    New = contenido.Replace(_seleccionadoAnteriormente, "");

                    File.WriteAllText(@"C:\Users\Public\Documents\Jurassic Command Line\" + _seleccionadoAnteriormente + ".txt", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(New)));

                }
                else
                {

                    mensajes = new Mensajes("El archivo no fue encontrado", 00001, 1);

                }

            }
        }

        static string Decodificar(string data)
        {
            byte[] encondedDataAsBytes = Convert.FromBase64String(data);
            string returnValue = Encoding.ASCII.GetString(encondedDataAsBytes);
            return returnValue;
        }
    }
}
