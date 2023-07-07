using System.IO.Compression;

namespace Compresion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String ArchivoOrigen;
                String ArchivoDestino;
                String nombre = txtNombre.Text;

                ArchivoOrigen = txtOrigen.Text;
                ArchivoDestino = "C:\\Users\\Bryan\\Documents\\Csharp\\Prueba\\" + nombre + ".zip";

                ZipFile.CreateFromDirectory(ArchivoOrigen, ArchivoDestino);

                MessageBox.Show("Carpeta comprimida");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo duplicado, debe cambiar de nombre");
                Console.WriteLine("Error " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String ArchivoNombre;
                String ArchivoDestino;
                String nombre = txtNombre.Text;

                ArchivoNombre = txtOrigen.Text;
                ArchivoDestino = "C:\\Users\\Bryan\\Documents\\Csharp\\prueba2\\"+nombre;

                ZipFile.ExtractToDirectory(ArchivoNombre, ArchivoDestino);

                MessageBox.Show("Carpeta Descomprimida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo duplicado, debe cambiar de nombre");
                Console.WriteLine("Error " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtNombre.Text = "";
            txtOrigen.Text = "";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogoCarpeta = new FolderBrowserDialog();
            DialogResult resultado = dialogoCarpeta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtOrigen.Text = dialogoCarpeta.SelectedPath;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoArchivo = new OpenFileDialog();
            dialogoArchivo.Filter = "Archivos ZIP (*.zip)|*.zip";
            DialogResult resultado = dialogoArchivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtOrigen.Text = dialogoArchivo.FileName;
            }
        }
    }
}