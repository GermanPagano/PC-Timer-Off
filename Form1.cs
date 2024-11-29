using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Apagador
{
    public partial class Form1 : Form
    {
        private Process? shutdownProcess; // Inicializada como nula

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblEstado.Text = "Jorge";
        }

        private void BtnEstablecerApagado_Click_1(object sender, EventArgs e)
        {
            int tiempoEnMinutos = (int)numericUpDownTiempo.Value;
            if (tiempoEnMinutos <= 0)
            {
                MessageBox.Show("Por favor, ingresa un tiempo válido en minutos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("¡Hola, este es un cuadro de diálogo personalizado!", "Título del cuadro de diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Crea un proceso para apagar Windows en el tiempo especificado.
            shutdownProcess = new Process();
            shutdownProcess.StartInfo.FileName = "shutdown";
            shutdownProcess.StartInfo.Arguments = $"/s /f /t {tiempoEnMinutos * 60}";
            shutdownProcess.Start();

            lblEstado.Text = $"Apagado programado en {tiempoEnMinutos} minutos.";
        }

        private void BtnCancelarApagado_Click_1(object sender, EventArgs e)
        {
            // Cancela el apagado programado si existe.
            if (shutdownProcess != null && !shutdownProcess.HasExited)
            {
                shutdownProcess.Kill();
                lblEstado.Text = "Apagado cancelado.";
            }
        }
    }
}
