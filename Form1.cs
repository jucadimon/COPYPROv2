using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;//para mover la ventana con el mouse

namespace COPYPROv2
{
    public partial class FormCopypro : Form
    {
        public string ostipo = "";
        public bool SistemaOperativo, cambio;
        public StringBuilder archivoGenerado;
        //Creamos el escritor de archivos y damos la ruta, nombre del archivo y modo de creado
        FileStream archivoGeneradoA;
        string directorio1;

        public FormCopypro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //variables de inicio del formulario
        }

        /// 
        /// //para mover la ventana con el mouse inicio
        /// descargado desde la pagina:
        /// http://csharpmaniax.blogspot.com.co/2012/05/como-mover-form-sin-bordes.html
        /// 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// 
        /// //para mover la ventana con el mouse fin
        /// 
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Button bsalirSub = new Button();
            Label Titulo_SubFormulario = new Label();
            Label Informacion = new Label();
            Form Subformulario = new Form();
            //  datos del boton salir
            bsalirSub.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            bsalirSub.Location = new Point(585, 10);
            bsalirSub.Name = "bsalirSub";
            bsalirSub.Size = new System.Drawing.Size(45, 25);
            bsalirSub.Text = "X";
            bsalirSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            bsalirSub.FlatStyle = FlatStyle.Flat;
            //  datos del label titulo
            Titulo_SubFormulario.Name = "Titulo_SubFormulario";
            Titulo_SubFormulario.Text = "I N F O R M A C I O N";
            Titulo_SubFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            Titulo_SubFormulario.Size = new Size(400, 25);//Tamaño del label
            Titulo_SubFormulario.Location = new Point(320 - (Titulo_SubFormulario.Width / 2), 10);//localizacion del label en el formulario
            Titulo_SubFormulario.Font = new Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            //  datos del label Informacion
            Informacion.Name = "Informacion";
            Informacion.Text = "INSTRUCCIONES DE USO: " +
                "\nLocalice la informacion que desea escribir desde un archivo, pagina web, "
                + "u otro programa, a continuación abra el programa COPYPRO y escriba dentro de la caja de "
                + "texto y al final de clic en el boton exportar a un archivo de texto a su escritorio."
                + "\nAl presionar el boton ExportarTXT se crea un archivo de texto multiple con el historial "
                + "del contenido de la caja de texto."
                + "\n"
                + "Puede dar clic en el boton limpiar para borrar todo el contenido de la caja de texto."
                + "\nCOPYPRO: es un pequeño proyecto sobre un programa para hacer resumenes a mano, es un editor de texto minimalista "
                + "que te permite ir guardando informacion por lotes de por ej: una cancion, un resumen de una novela literaria, codigo fuente, etc; "
                + "con eL programa podrás leer y escribir al mismo tiempo... o esa es la idea."
                + "\nPuede utilizar el programa de cualquier forma que se le ocurra, por favor, si encuentra utilidad, "
                + "escribanos a nuestro correo, con asunto copypro y agregue la pagina del programa en la red social facebook: COPYPRO"
                + "\nPara donativos :v escribanos al correo."
                
                + "\n\nSOFTWARE DE ESCRITURA RAPIDA"
            + "\n\nSOFTWARE CREADO POR:\nJUANCARLOS DIAZ MONTIEL\nESTUDIANTE INGENIERIA CIVIL" +
            "\nUNIVERSIDAD DE SUCRE\n2016\nCEL: 3016922644\nCORREO: jucadimon@hotmail.com\nWEB: " +
            "http://ingenieria-civil-y-pi.blogspot.com.co/ ";
            Informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//MiddleCenter/TopCenter
            Informacion.Size = new Size(580, 380);//Tamaño del label
            Informacion.Location = new Point(40, 35);//localizacion del label en el formulario
            Informacion.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            //  datos de la ventana
            Subformulario.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            Subformulario.ClientSize = new System.Drawing.Size(640, 480);
            Subformulario.Opacity = .85;
            Subformulario.BackColor = Color.MintCream;//cambia color de fondo, Black, MintCream, MediumOrchid, 
            Subformulario.ForeColor = Color.MediumOrchid;//cambia color de la fuente SlateBlue
            Subformulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//FixedDialog, None, Fixed3D
            Subformulario.Name = "Subformulario";
            Subformulario.Text = "SUB VENTANA X 1.0";
            Subformulario.CancelButton = bsalirSub;
            Subformulario.StartPosition = FormStartPosition.CenterScreen;
            //
            Subformulario.Controls.Add(bsalirSub);
            Subformulario.Controls.Add(Titulo_SubFormulario);
            Subformulario.Controls.Add(Informacion);
            //
            Subformulario.ShowDialog();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //CAMBIAMOS LA OPACIDAD DEL FORMULARIO
            this.Opacity = trackBar1.Value / 100d;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //          EXPORTAR TXT 
            ostipo = Environment.OSVersion.ToString();//saber el sistema operativo que se usa
            SistemaOperativo = ostipo.Contains("Unix");

            archivoGenerado = new StringBuilder();//Definimos un comodin estatico
            // string fecha = "";
            // fecha = DateTime.Now.ToString();    //pedimos la hora al sistema y almacenamos en fecha

            archivoGenerado.AppendLine(txtCaja.Text);//añadimos la fecha al comodin

            String reg = "";    //creamos un objeto tipo String del espacio de nombres Text
            reg = archivoGenerado.ToString();    //convertimos el comodin a texto

            if (SistemaOperativo)
            {
                directorio1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/texto.txt";
                // string directorio2 = Environment.CurrentDirectory + "/texto"+fecha+".txt";
            }
            else
            {
                directorio1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\texto.txt";
                // string directorio2 = Environment.CurrentDirectory + "\\texto"+fecha+".txt";
            }

            archivoGeneradoA = new FileStream(directorio1, FileMode.Append);
            archivoGeneradoA.Write(Encoding.GetEncoding("windows-1252").GetBytes(reg), 0, reg.Length);//escribimos dentro del archivo
            archivoGeneradoA.Close();//Cerra el archivo creado
            // Encoding.GetEncoding("windows-1252")     cambiar esta linea en los programas de exportar a txt 
            // para solucionar le problema de la stildes y de las "ñ"
            // archivoGeneradoA.Write(ASCIIEncoding.ASCII.GetBytes(reg), 0, reg.Length); Esta es la linea vieja

            MessageBox.Show("Exportación correcta! Revise el archivo en su escritorio.");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCaja.Text = "";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimized, Maximized, Normal
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
            if(cambio)
            {
                this.WindowState = FormWindowState.Normal;//Minimized, Maximized, Normal
                cambio = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;//Minimized, Maximized, Normal
                cambio = true;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//Codigo para boton salir
        }

        private void FormCopypro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();/// para mover la ventana con el mouse
            SendMessage(this.Handle, 0x112, 0xf012, 0);/// para mover la ventana con el mouse
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            this.ForeColor = Color.Snow;
            txtCaja.BackColor = Color.SteelBlue;
            txtCaja.ForeColor = Color.Snow;
        }

        private void rbGris_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.ForeColor = Color.DarkSlateGray;
            txtCaja.BackColor = Color.Gray;
            txtCaja.ForeColor = Color.DarkSlateGray;
        }

        private void rbRadar_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.DarkCyan;
            txtCaja.BackColor = Color.Black;
            txtCaja.ForeColor = Color.DarkCyan;
        }

        private void rbCereza_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.MintCream;
            this.ForeColor = Color.MediumOrchid;
            txtCaja.BackColor = Color.MintCream;
            txtCaja.ForeColor = Color.MediumOrchid;
        }

        private void rbJarvis_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.SteelBlue;
            txtCaja.BackColor = Color.Black;
            txtCaja.ForeColor = Color.SteelBlue;
        }

        private void rbIronMan_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
            this.ForeColor = Color.Gold;
            txtCaja.BackColor = Color.DarkRed;
            txtCaja.ForeColor = Color.Gold;
        }
    }
}
