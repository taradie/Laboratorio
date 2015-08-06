namespace Laboratorio
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmModificarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmModificarDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.mCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmModificarCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.mMuestra = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmCrearEtiqueta = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarMuestra = new System.Windows.Forms.ToolStripMenuItem();
            this.mExamenes = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarExamenes = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmConsultarExamenes = new System.Windows.Forms.ToolStripMenuItem();
            this.mCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmIngresarCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmModificarCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AseguradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.sbmConsultaMuestra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPaciente,
            this.mDoctor,
            this.mCitas,
            this.mMuestra,
            this.mExamenes,
            this.mCotizacion,
            this.reporteToolStripMenuItem,
            this.sucursalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mPaciente
            // 
            this.mPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmIngresarPaciente,
            this.sbmModificarPaciente});
            this.mPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPaciente.Image = ((System.Drawing.Image)(resources.GetObject("mPaciente.Image")));
            this.mPaciente.Name = "mPaciente";
            this.mPaciente.Size = new System.Drawing.Size(93, 23);
            this.mPaciente.Text = "Paciente";
            // 
            // sbmIngresarPaciente
            // 
            this.sbmIngresarPaciente.Name = "sbmIngresarPaciente";
            this.sbmIngresarPaciente.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarPaciente.Text = "Ingresar";
            this.sbmIngresarPaciente.Click += new System.EventHandler(this.ingresarPacienteToolStripMenuItem_Click);
            // 
            // sbmModificarPaciente
            // 
            this.sbmModificarPaciente.Name = "sbmModificarPaciente";
            this.sbmModificarPaciente.Size = new System.Drawing.Size(216, 24);
            this.sbmModificarPaciente.Text = "Modificar y Consultar";
            this.sbmModificarPaciente.Click += new System.EventHandler(this.sbmModificarPaciente_Click);
            // 
            // mDoctor
            // 
            this.mDoctor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmIngresarDoctor,
            this.sbmModificarDoctor});
            this.mDoctor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDoctor.Image = ((System.Drawing.Image)(resources.GetObject("mDoctor.Image")));
            this.mDoctor.Name = "mDoctor";
            this.mDoctor.Size = new System.Drawing.Size(80, 23);
            this.mDoctor.Text = "Doctor";
            // 
            // sbmIngresarDoctor
            // 
            this.sbmIngresarDoctor.Name = "sbmIngresarDoctor";
            this.sbmIngresarDoctor.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarDoctor.Text = "Ingresar";
            // 
            // sbmModificarDoctor
            // 
            this.sbmModificarDoctor.Name = "sbmModificarDoctor";
            this.sbmModificarDoctor.Size = new System.Drawing.Size(216, 24);
            this.sbmModificarDoctor.Text = "Modificar y Consultar";
            // 
            // mCitas
            // 
            this.mCitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmIngresarCitas,
            this.sbmModificarCitas});
            this.mCitas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCitas.Image = ((System.Drawing.Image)(resources.GetObject("mCitas.Image")));
            this.mCitas.Name = "mCitas";
            this.mCitas.Size = new System.Drawing.Size(70, 23);
            this.mCitas.Text = "Citas";
            // 
            // sbmIngresarCitas
            // 
            this.sbmIngresarCitas.Name = "sbmIngresarCitas";
            this.sbmIngresarCitas.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarCitas.Text = "Ingresar";
            this.sbmIngresarCitas.Click += new System.EventHandler(this.sbmIngresarCitas_Click);
            // 
            // sbmModificarCitas
            // 
            this.sbmModificarCitas.Name = "sbmModificarCitas";
            this.sbmModificarCitas.Size = new System.Drawing.Size(216, 24);
            this.sbmModificarCitas.Text = "Modificar y Consultar";
            this.sbmModificarCitas.Click += new System.EventHandler(this.sbmModificarCitas_Click);
            // 
            // mMuestra
            // 
            this.mMuestra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmCrearEtiqueta,
            this.sbmIngresarMuestra,
            this.sbmConsultaMuestra});
            this.mMuestra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMuestra.Image = ((System.Drawing.Image)(resources.GetObject("mMuestra.Image")));
            this.mMuestra.Name = "mMuestra";
            this.mMuestra.Size = new System.Drawing.Size(91, 23);
            this.mMuestra.Text = "Muestra";
            // 
            // sbmCrearEtiqueta
            // 
            this.sbmCrearEtiqueta.Name = "sbmCrearEtiqueta";
            this.sbmCrearEtiqueta.Size = new System.Drawing.Size(216, 24);
            this.sbmCrearEtiqueta.Text = "Crear Etiqueta";
            // 
            // sbmIngresarMuestra
            // 
            this.sbmIngresarMuestra.Name = "sbmIngresarMuestra";
            this.sbmIngresarMuestra.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarMuestra.Text = "Ingresar";
            // 
            // mExamenes
            // 
            this.mExamenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmIngresarExamenes,
            this.sbmConsultarExamenes});
            this.mExamenes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mExamenes.Image = ((System.Drawing.Image)(resources.GetObject("mExamenes.Image")));
            this.mExamenes.Name = "mExamenes";
            this.mExamenes.Size = new System.Drawing.Size(103, 23);
            this.mExamenes.Text = "Examenes";
            // 
            // sbmIngresarExamenes
            // 
            this.sbmIngresarExamenes.Name = "sbmIngresarExamenes";
            this.sbmIngresarExamenes.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarExamenes.Text = "Ingresar";
            // 
            // sbmConsultarExamenes
            // 
            this.sbmConsultarExamenes.Name = "sbmConsultarExamenes";
            this.sbmConsultarExamenes.Size = new System.Drawing.Size(216, 24);
            this.sbmConsultarExamenes.Text = "Modificar y Consultar";
            // 
            // mCotizacion
            // 
            this.mCotizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmIngresarCotizacion,
            this.sbmModificarCotizacion});
            this.mCotizacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("mCotizacion.Image")));
            this.mCotizacion.Name = "mCotizacion";
            this.mCotizacion.Size = new System.Drawing.Size(104, 23);
            this.mCotizacion.Text = "Cotizacion";
            this.mCotizacion.Click += new System.EventHandler(this.mCotizacion_Click);
            // 
            // sbmIngresarCotizacion
            // 
            this.sbmIngresarCotizacion.Name = "sbmIngresarCotizacion";
            this.sbmIngresarCotizacion.Size = new System.Drawing.Size(216, 24);
            this.sbmIngresarCotizacion.Text = "Ingresar";
            // 
            // sbmModificarCotizacion
            // 
            this.sbmModificarCotizacion.Name = "sbmModificarCotizacion";
            this.sbmModificarCotizacion.Size = new System.Drawing.Size(216, 24);
            this.sbmModificarCotizacion.Text = "Modificar y Consultar";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.AseguradoraToolStripMenuItem});
            this.sucursalToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F);
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.sucursalToolStripMenuItem.Text = "Otros";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ingresarToolStripMenuItem.Text = "Sucursal";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // AseguradoraToolStripMenuItem
            // 
            this.AseguradoraToolStripMenuItem.Name = "AseguradoraToolStripMenuItem";
            this.AseguradoraToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.AseguradoraToolStripMenuItem.Text = "Aseguradora";
            this.AseguradoraToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1228, 667);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 50);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // sbmConsultaMuestra
            // 
            this.sbmConsultaMuestra.Name = "sbmConsultaMuestra";
            this.sbmConsultaMuestra.Size = new System.Drawing.Size(216, 24);
            this.sbmConsultaMuestra.Text = "Modificar y Consultar";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mPaciente;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarPaciente;
        private System.Windows.Forms.ToolStripMenuItem sbmModificarPaciente;
        private System.Windows.Forms.ToolStripMenuItem mDoctor;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarDoctor;
        private System.Windows.Forms.ToolStripMenuItem sbmModificarDoctor;
        private System.Windows.Forms.ToolStripMenuItem mCitas;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarCitas;
        private System.Windows.Forms.ToolStripMenuItem sbmModificarCitas;
        private System.Windows.Forms.ToolStripMenuItem mMuestra;
        private System.Windows.Forms.ToolStripMenuItem sbmCrearEtiqueta;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarMuestra;
        private System.Windows.Forms.ToolStripMenuItem mExamenes;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarExamenes;
        private System.Windows.Forms.ToolStripMenuItem sbmConsultarExamenes;
        private System.Windows.Forms.ToolStripMenuItem mCotizacion;
        private System.Windows.Forms.ToolStripMenuItem sbmIngresarCotizacion;
        private System.Windows.Forms.ToolStripMenuItem sbmModificarCotizacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AseguradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sbmConsultaMuestra;
    }
}