// Form1.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimuladorProcesos
{
    public partial class Form1 : Form
    {
        private List<Proceso> procesos = new List<Proceso>();
        private int pidCounter = 1;
        private int memoriaDisponible = 4096; // 4 GB simulada
        private string algoritmoSeleccionado = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void CrearProcesosIniciales()
        {
            for (int i = 0; i < 3; i++)
            {
                CrearProceso();
            }
        }

        private void btnIniciarSimulador_Click(object sender, EventArgs e)
        {
            algoritmoSeleccionado = cmbAlgoritmo.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(algoritmoSeleccionado))
            {
                MessageBox.Show("Selecciona un algoritmo de planificación.");
                return;
            }

            Log("Simulador iniciado con algoritmo: " + algoritmoSeleccionado);
            CrearProcesosIniciales(); // Crear 3 procesos al presionar "Iniciar"
        }

        private void btnCrearProceso_Click(object sender, EventArgs e)
        {
            CrearProceso();
        }

        private void CrearProceso()
        {
            Random rnd = new Random();
            int memoriaRequerida = rnd.Next(100, 1000);

            if (memoriaRequerida > memoriaDisponible)
            {
                Log("No hay suficiente memoria para crear el proceso.");
                return;
            }

            Proceso nuevo = new Proceso()
            {
                PID = pidCounter++,
                Estado = "Listo",
                Prioridad = rnd.Next(1, 5),
                MemoriaAsignada = memoriaRequerida,
                UsaCPU = true
            };

            procesos.Add(nuevo);
            memoriaDisponible -= memoriaRequerida;
            ActualizarListaProcesos();
            Log($"Proceso {nuevo.PID} creado. Memoria usada: {memoriaRequerida}MB");
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            if (lvProcesos.SelectedItems.Count == 0) return;

            int pid = int.Parse(lvProcesos.SelectedItems[0].SubItems[0].Text);
            var proceso = procesos.Find(p => p.PID == pid);
            if (proceso != null && proceso.Estado != "Terminado")
            {
                proceso.Estado = "Suspendido";
                ActualizarListaProcesos();
                Log($"Proceso {pid} suspendido.");
            }
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            if (lvProcesos.SelectedItems.Count == 0) return;

            int pid = int.Parse(lvProcesos.SelectedItems[0].SubItems[0].Text);
            var proceso = procesos.Find(p => p.PID == pid);
            if (proceso != null && proceso.Estado == "Suspendido")
            {
                proceso.Estado = "Listo";
                ActualizarListaProcesos();
                Log($"Proceso {pid} reanudado.");
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (lvProcesos.SelectedItems.Count == 0) return;

            int pid = int.Parse(lvProcesos.SelectedItems[0].SubItems[0].Text);
            var proceso = procesos.Find(p => p.PID == pid);
            if (proceso != null)
            {
                proceso.Estado = "Terminado";
                memoriaDisponible += proceso.MemoriaAsignada;
                ActualizarListaProcesos();
                Log($"Proceso {pid} terminado. Memoria liberada: {proceso.MemoriaAsignada}MB");
            }
        }

        private void ActualizarListaProcesos()
        {
            lvProcesos.Items.Clear();
            foreach (var p in procesos)
            {
                var item = new ListViewItem(p.PID.ToString());
                item.SubItems.Add(p.Estado);
                item.SubItems.Add(p.Prioridad.ToString());
                item.SubItems.Add(p.MemoriaAsignada.ToString());
                item.SubItems.Add(p.UsaCPU ? "Sí" : "No");
                lvProcesos.Items.Add(item);
            }
            pbMemoria.Value = Math.Min(memoriaDisponible, pbMemoria.Maximum);
            lblCPU.Text = "CPU " + (procesos.Exists(p => p.Estado == "Ejecutando") ? "ocupado" : "libre");
        }

        private void Log(string mensaje)
        {
            txtLogs.AppendText(mensaje + Environment.NewLine);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación completamente
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Simulador de Procesos\n\nDesarrollado por: \n\nSANCHEZ MORALES SERGIO ISRAEL \n\n VEGA GONZALEZ JESUS ALEJANDRO \n\n POSADAS PEREZ ISAAC SAYEG \n\n DIAZ ROSAS KEVIN JESUS",
                "Acerca del Simulador",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAlgoritmo_Click(object sender, EventArgs e)
        {

        }

        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class Proceso
    {
        public int PID { get; set; }
        public string Estado { get; set; }
        public int Prioridad { get; set; }
        public int MemoriaAsignada { get; set; }
        public bool UsaCPU { get; set; }
    }
}
