using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Jurassic_Command_Line
{

    public class Mensajes
    {
        
        public string msg { get; set; }
        public int code { get; set; }
        public int type { get; set; }

        public DialogResult ans;
        public Mensajes(string msg, int code, int type)
        {

            this.msg = msg;
            this.code = code;
            this.type = type;

            switch (this.type)
            {
                case 1:

                    error();

                    break;
                case 2:

                    info();

                    break;
                case 3:

                    ques();

                    break;
                case 4:

                    exclam();

                    break;
            } 
            
            void error()
            {
                MessageBox.Show(this.msg + ". \n Error: " + this.code, "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            void info()
            {
                MessageBox.Show(this.msg, "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            void ques()
            {
               ans = MessageBox.Show(this.msg, "System Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

            void exclam()
            {
                MessageBox.Show(this.msg, "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}