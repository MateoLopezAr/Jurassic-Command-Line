using System;
using System.Windows.Forms;

namespace Jurassic_Command_Line
{
    public partial class Auntenticación : Form
    {

        String _user = "Jhon Hammond", _user2 = "Jhon Arnold", _user3 = "Dennis Nedry", _invitado = "Invitado", _contraseñaUser1 = "Admin123", _contraseñaUser2 = "JhonA123", _contraseñaUser3 = "DennisN123", _contraseñaInvitado = "Invitado123", _userIngresado, _contraseñaIngresada;

        private void Auntenticación_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Auntenticación_Load(object sender, EventArgs e)
        {

        }

        private void Auntenticación_KeyDown(object sender, KeyEventArgs e)
        {
        }

        public Auntenticación()
        {
            InitializeComponent();
            this.PreviewKeyDown += Auntenticación_PreviewKeyDown;
            this.KeyPreview = true; // Habilitar la propiedad KeyPreview en el formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _userIngresado = textBox1.Text.Trim();
            _contraseñaIngresada = textBox2.Text.Trim();

            if (_userIngresado == _user && _contraseñaIngresada == _contraseñaUser1)
            {
                MessageBox.Show("Bienvenido, Jhon!", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Acá irá el codigo para mostrar la nueva ventana

                Continuar();

            }
            else if (_userIngresado == _user2 && _contraseñaIngresada == _contraseñaUser2)
            {
                MessageBox.Show("Bienvenido, Jhon Arnold!", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Acá irá el codigo para mostrar la nueva ventana

                Continuar();
            }
            else if (_userIngresado == _user3 && _contraseñaIngresada == _contraseñaUser3)
            {
                MessageBox.Show("Bienvenido, Dennis!", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Acá irá el codigo para mostrar la nueva ventana

                Continuar();
            }
            else if (_userIngresado == _invitado && _contraseñaIngresada == _contraseñaInvitado)
            {
                MessageBox.Show("Bienvenido, Invitado!", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Acá irá el codigo para mostrar la nueva ventana

                Continuar();
            }
            else if (_userIngresado == "" || _contraseñaIngresada == "")
            {
                MessageBox.Show("ERROR: Todos los campos son obligatorios", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("ERROR: Usuario y/o contraseña incorrectos", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void Continuar()
        {
            Seleccióm seleccióm = new Seleccióm();
            seleccióm.Show();
            this.Hide();
        }


        private void Auntenticación_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.T)
            {
                // Ejecutar el proceso deseado cuando se presiona Ctrl + Shift + T
                // Aquí puedes agregar el código para saltar procesos o realizar cualquier otra acción deseada
                MessageBox.Show("Se ha presionado la combinación de teclas Ctrl + Shift + T");
            }
        }

    }
}
