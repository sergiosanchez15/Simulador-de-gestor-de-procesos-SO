// Form1.Designer.cs
namespace SimuladorProcesos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnIniciarSimulador = new System.Windows.Forms.Button();
            this.btnCrearProceso = new System.Windows.Forms.Button();
            this.btnSuspender = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.lblAlgoritmo = new System.Windows.Forms.Label();
            this.lvProcesos = new System.Windows.Forms.ListView();
            this.pbMemoria = new System.Windows.Forms.ProgressBar();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnIniciarSimulador
            this.btnIniciarSimulador.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarSimulador.Size = new System.Drawing.Size(120, 23);
            this.btnIniciarSimulador.Text = "Iniciar Simulador";
            this.btnIniciarSimulador.Click += new System.EventHandler(this.btnIniciarSimulador_Click);

            // btnCrearProceso
            this.btnCrearProceso.Location = new System.Drawing.Point(138, 12);
            this.btnCrearProceso.Size = new System.Drawing.Size(120, 23);
            this.btnCrearProceso.Text = "Crear Proceso";
            this.btnCrearProceso.Click += new System.EventHandler(this.btnCrearProceso_Click);

            // btnSuspender
            this.btnSuspender.Location = new System.Drawing.Point(264, 12);
            this.btnSuspender.Size = new System.Drawing.Size(80, 23);
            this.btnSuspender.Text = "Suspender";
            this.btnSuspender.Click += new System.EventHandler(this.btnSuspender_Click);

            // btnReanudar
            this.btnReanudar.Location = new System.Drawing.Point(350, 12);
            this.btnReanudar.Size = new System.Drawing.Size(80, 23);
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);

            // btnTerminar
            this.btnTerminar.Location = new System.Drawing.Point(436, 12);
            this.btnTerminar.Size = new System.Drawing.Size(80, 23);
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);

            // lblAlgoritmo
            this.lblAlgoritmo.Location = new System.Drawing.Point(522, -1);
            this.lblAlgoritmo.Size = new System.Drawing.Size(121, 13);
            this.lblAlgoritmo.Text = "Algoritmo";

            // cmbAlgoritmo
            this.cmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmo.Items.AddRange(new object[] {
            "Round Robin",
            "SJF"});
            this.cmbAlgoritmo.Location = new System.Drawing.Point(522, 14);
            this.cmbAlgoritmo.Size = new System.Drawing.Size(121, 21);

            // lvProcesos
            this.lvProcesos.Location = new System.Drawing.Point(12, 50);
            this.lvProcesos.Size = new System.Drawing.Size(631, 200);
            this.lvProcesos.View = System.Windows.Forms.View.Details;
            this.lvProcesos.FullRowSelect = true;
            this.lvProcesos.Columns.Add("PID", 50);
            this.lvProcesos.Columns.Add("Estado", 100);
            this.lvProcesos.Columns.Add("Prioridad", 70);
            this.lvProcesos.Columns.Add("Memoria", 80);
            this.lvProcesos.Columns.Add("CPU", 50);

            // pbMemoria
            this.pbMemoria.Location = new System.Drawing.Point(12, 260);
            this.pbMemoria.Size = new System.Drawing.Size(400, 23);
            this.pbMemoria.Maximum = 4096;

            // txtLogs
            this.txtLogs.Location = new System.Drawing.Point(12, 290);
            this.txtLogs.Multiline = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(631, 100);

            // lblCPU
            this.lblCPU.Location = new System.Drawing.Point(420, 260);
            this.lblCPU.Size = new System.Drawing.Size(223, 23);
            this.lblCPU.Text = "CPU: libre";

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(12, 400);
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // btnAcercaDe
            this.btnAcercaDe.Location = new System.Drawing.Point(93, 400);
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 440);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.pbMemoria);
            this.Controls.Add(this.lvProcesos);
            this.Controls.Add(this.lblAlgoritmo);
            this.Controls.Add(this.cmbAlgoritmo);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnSuspender);
            this.Controls.Add(this.btnCrearProceso);
            this.Controls.Add(this.btnIniciarSimulador);
            this.Name = "Form1";
            this.Text = "Simulador de Procesos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnIniciarSimulador;
        private System.Windows.Forms.Button btnCrearProceso;
        private System.Windows.Forms.Button btnSuspender;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
        private System.Windows.Forms.Label lblAlgoritmo;
        private System.Windows.Forms.ListView lvProcesos;
        private System.Windows.Forms.ProgressBar pbMemoria;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
    }
}