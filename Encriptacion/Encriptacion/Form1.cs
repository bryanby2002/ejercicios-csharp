
using System.Security.Cryptography;
using System.Text;

namespace Encriptacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEncriptar_Click(object sender, EventArgs e)
        {

        }

        private void txtEncriptar_Click_1(object sender, EventArgs e)
        {
            String mensaje = txtPalabra.Text;
            txtResultado.Text = encriptar(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = txtPalabra.Text;
            txtResultado.Text = decriptar(mensaje);
        }




        /*Metodo para encriptar*/
        public String encriptar(String mensaje)
        {
            String hash = "bryancmy";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

            MD5 md5 = MD5.Create();

            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        /*Metodo para decriptar*/
        public String decriptar(String mensajeEN)
        {
            String hash = "bryancmy";
            byte[] data = Convert.FromBase64String(mensajeEN);

            MD5 md5 = MD5.Create();

            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}