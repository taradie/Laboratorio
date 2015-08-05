namespace Laboratorio
{
    partial class frmTarifaSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarifaSeguro));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblDeducible = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtDeducible = new System.Windows.Forms.TextBox();
            this.grdTarifa = new System.Windows.Forms.DataGridView();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 24);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(133, 311);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.BackColor = System.Drawing.Color.Transparent;
            this.lblTarifa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(162, 24);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(106, 19);
            this.lblTarifa.TabIndex = 11;
            this.lblTarifa.Text = "Tarifa de Pago:";
            this.lblTarifa.Click += new System.EventHandler(this.lblTarifa_Click);
            // 
            // lblDeducible
            // 
            this.lblDeducible.AutoSize = true;
            this.lblDeducible.BackColor = System.Drawing.Color.Transparent;
            this.lblDeducible.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeducible.Location = new System.Drawing.Point(162, 66);
            this.lblDeducible.Name = "lblDeducible";
            this.lblDeducible.Size = new System.Drawing.Size(78, 19);
            this.lblDeducible.TabIndex = 12;
            this.lblDeducible.Text = "Deducible:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(310, 25);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(219, 20);
            this.txtTarifa.TabIndex = 13;
            // 
            // txtDeducible
            // 
            this.txtDeducible.Location = new System.Drawing.Point(310, 67);
            this.txtDeducible.Name = "txtDeducible";
            this.txtDeducible.Size = new System.Drawing.Size(219, 20);
            this.txtDeducible.TabIndex = 14;
            // 
            // grdTarifa
            // 
            this.grdTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarifa,
            this.Deducible});
            this.grdTarifa.Location = new System.Drawing.Point(166, 101);
            this.grdTarifa.Name = "grdTarifa";
            this.grdTarifa.Size = new System.Drawing.Size(506, 234);
            this.grdTarifa.TabIndex = 15;
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            // 
            // Deducible
            // 
            this.Deducible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deducible.HeaderText = "Deducible";
            this.Deducible.Name = "Deducible";
            // 
            // frmTarifaSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 364);
            this.Controls.Add(this.grdTarifa);
            this.Controls.Add(this.txtDeducible);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lblDeducible);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTarifaSeguro";
            this.Text = "Tarifa del Seguro";
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblDeducible;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtDeducible;
        private System.Windows.Forms.DataGridView grdTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
    }
}