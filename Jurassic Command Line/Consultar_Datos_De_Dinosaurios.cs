using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Jurassic_Command_Line
{
    public partial class ConsultarDatosDeDinosaurios : Form
    {
        private int _i = Properties.Settings.Default.I;
        private int _i2 = Properties.Settings.Default.I2;

        private string[] _nublarDino;
        private string[] _sornaDino;
        private string _data;
        private string _dataDecoded;
        private string _filePath = Path.GetTempFileName();
        public static string texto;

        private Mensajes m;

        public ConsultarDatosDeDinosaurios()
        {
            InitializeComponent();

            _nublarDino = new string[_i];
            _sornaDino = new string[_i2];
        }

        public void Consultar_Datos_De_Dinosaurios_Load(object sender, EventArgs e)
        {
            AñadirElementosArrays();
            InputBox(comboBox2, label3, pictureBox2);

            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }

        public void InputBox(ComboBox comboBox, Label label, PictureBox picture)
        {
            texto = Microsoft.VisualBasic.Interaction.InputBox(
                "¿Nublar o Sorna?",
                "System Admin",
                "Nublar");

            if (texto == "Sorna")
            {
                label.Text = "SORNA ISLAND";
                picture.Image = Jurassic_Command_Line.Properties.Resources.Sorna_To_Convert_Redimensioned;

                try
                {
                    comboBox.Items.Clear();
                    _data = File.ReadAllText(@"C:\Users\Public\Documents\Jurassic Command Line\Sorna_Dinosaurs.jcl");
                    _dataDecoded = Decodificar(_data);
                    File.WriteAllText(_filePath, _dataDecoded);
                    string[] lines = File.ReadAllLines(_filePath);

                    foreach (string line in lines)
                    {
                        comboBox.Items.Add(line);
                    }

                    comboBox.Sorted = true;

                    File.Delete(_filePath);
                }
                catch (Exception ex)
                {
                    m = new Mensajes("Error: " + ex, ex.GetHashCode(), 1);
                }
            }
            else if (texto == "Nublar")
            {
                label.Text = "NUBLAR ISLAND";
                picture.Image = Jurassic_Command_Line.Properties.Resources.Nublar;

                try
                {
                    comboBox.Items.Clear();
                    _data = File.ReadAllText(@"C:\Users\Public\Documents\Jurassic Command Line\Nublar_Dinosaurs.jcl");
                    _dataDecoded = Decodificar(_data);
                    File.WriteAllText(_filePath, _dataDecoded);

                    string[] lines = File.ReadAllLines(_filePath);

                    foreach (string line in lines)
                    {
                        comboBox.Items.Add(line);
                    }

                    comboBox.Sorted = true;

                    File.Delete(_filePath);
                }
                catch (Exception ex)
                {
                    m = new Mensajes("Error: " + ex, ex.GetHashCode(), 1);
                }
            }
            else if (texto == "Menu" || texto == "Menú")
            {
                Seleccióm seleccióm = new Seleccióm();
                seleccióm.Show();
                this.Close();
            }
            else
            {
                m = new Mensajes("Error: El elemento seleccionado no existe", 002, 1);
                Seleccióm seleccióm = new Seleccióm();
                seleccióm.Show();
                this.Close();
            }
        }

        static string Decodificar(string data)
        {
            byte[] encodedDataAsBytes = Convert.FromBase64String(data);
            string returnValue = Encoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }

        private void AñadirElementosArrays()
        {
            // Add code here to add elements to the arrays
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Seleccióm seleccióm = new Seleccióm();
            seleccióm.Show();
            this.Hide();
        }

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            string selected = comboBox2.GetItemText(comboBox2.SelectedItem);

            ConsultaActivos activos = new ConsultaActivos(selected);
            activos.Show();
            this.Hide();
        }

        public void CerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Add code here for the click event of pictureBox2
        }
    }

}