using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurassic_Command_Line
{
    public partial class Feed : Form
    {
        public String Seleccion;

        public Feed()
        {
            InitializeComponent();
        }

        private void Feed_Load(object sender, EventArgs e)
        {
            ConsultarDatosDeDinosaurios consulta = new ConsultarDatosDeDinosaurios();
            consulta.InputBox(comboBox2, label3, pictureBox2);
            this.FormClosed += new FormClosedEventHandler(consulta.CerrarForm);
        }

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            Seleccion = comboBox2.GetItemText(comboBox2.SelectedItem);
        }
    }
}
