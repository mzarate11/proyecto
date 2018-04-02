namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class frm_ModificarAerolineas
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
            this.lbl_IdAerolinea = new System.Windows.Forms.Label();
            this.lbl_NombreAerolinea = new System.Windows.Forms.Label();
            this.lbl_IdEstado = new System.Windows.Forms.Label();
            this.txt_IdAerolinea = new System.Windows.Forms.TextBox();
            this.txt_NombreAerolinea = new System.Windows.Forms.TextBox();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Guardar = new System.Windows.Forms.ToolStripButton();
            this.tsl_Guardar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Salir = new System.Windows.Forms.ToolStripButton();
            this.tsl_Salir = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdAerolinea
            // 
            this.lbl_IdAerolinea.AutoSize = true;
            this.lbl_IdAerolinea.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdAerolinea.Location = new System.Drawing.Point(111, 126);
            this.lbl_IdAerolinea.Name = "lbl_IdAerolinea";
            this.lbl_IdAerolinea.Size = new System.Drawing.Size(164, 36);
            this.lbl_IdAerolinea.TabIndex = 0;
            this.lbl_IdAerolinea.Text = "Id Aerolinea";
            // 
            // lbl_NombreAerolinea
            // 
            this.lbl_NombreAerolinea.AutoSize = true;
            this.lbl_NombreAerolinea.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreAerolinea.Location = new System.Drawing.Point(111, 276);
            this.lbl_NombreAerolinea.Name = "lbl_NombreAerolinea";
            this.lbl_NombreAerolinea.Size = new System.Drawing.Size(278, 36);
            this.lbl_NombreAerolinea.TabIndex = 1;
            this.lbl_NombreAerolinea.Text = "Nombre de Aerolinea";
            // 
            // lbl_IdEstado
            // 
            this.lbl_IdEstado.AutoSize = true;
            this.lbl_IdEstado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdEstado.Location = new System.Drawing.Point(111, 431);
            this.lbl_IdEstado.Name = "lbl_IdEstado";
            this.lbl_IdEstado.Size = new System.Drawing.Size(129, 36);
            this.lbl_IdEstado.TabIndex = 2;
            this.lbl_IdEstado.Text = "Id Estado";
            // 
            // txt_IdAerolinea
            // 
            this.txt_IdAerolinea.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdAerolinea.Location = new System.Drawing.Point(526, 123);
            this.txt_IdAerolinea.Name = "txt_IdAerolinea";
            this.txt_IdAerolinea.Size = new System.Drawing.Size(254, 44);
            this.txt_IdAerolinea.TabIndex = 3;
            this.txt_IdAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdAerolinea_KeyPress);
            // 
            // txt_NombreAerolinea
            // 
            this.txt_NombreAerolinea.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreAerolinea.Location = new System.Drawing.Point(526, 273);
            this.txt_NombreAerolinea.Name = "txt_NombreAerolinea";
            this.txt_NombreAerolinea.Size = new System.Drawing.Size(254, 44);
            this.txt_NombreAerolinea.TabIndex = 4;
            this.txt_NombreAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreAerolinea_KeyPress);
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(526, 428);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(254, 45);
            this.cmb_IdEstado.TabIndex = 5;
            this.cmb_IdEstado.Text = "Elegir opcion";
            this.cmb_IdEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdEstado_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Guardar,
            this.tsl_Guardar,
            this.toolStripSeparator1,
            this.tsb_Salir,
            this.tsl_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Guardar
            // 
            this.tsb_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Guardar.Image = global::Proyecto_2_PL.Properties.Resources.bGuardar;
            this.tsb_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Guardar.Name = "tsb_Guardar";
            this.tsb_Guardar.Size = new System.Drawing.Size(28, 28);
            this.tsb_Guardar.Text = "Guardar";
            this.tsb_Guardar.Click += new System.EventHandler(this.tsb_Guardar_Click);
            // 
            // tsl_Guardar
            // 
            this.tsl_Guardar.Name = "tsl_Guardar";
            this.tsl_Guardar.Size = new System.Drawing.Size(75, 28);
            this.tsl_Guardar.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsb_Salir
            // 
            this.tsb_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Salir.Image = global::Proyecto_2_PL.Properties.Resources.bSalir;
            this.tsb_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Salir.Name = "tsb_Salir";
            this.tsb_Salir.Size = new System.Drawing.Size(28, 28);
            this.tsb_Salir.Text = "Salir";
            this.tsb_Salir.Click += new System.EventHandler(this.tsb_Salir_Click);
            // 
            // tsl_Salir
            // 
            this.tsl_Salir.Name = "tsl_Salir";
            this.tsl_Salir.Size = new System.Drawing.Size(45, 28);
            this.tsl_Salir.Text = "Salir";
            // 
            // frm_ModificarAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.avion_960_720;
            this.ClientSize = new System.Drawing.Size(946, 633);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_IdEstado);
            this.Controls.Add(this.txt_NombreAerolinea);
            this.Controls.Add(this.txt_IdAerolinea);
            this.Controls.Add(this.lbl_IdEstado);
            this.Controls.Add(this.lbl_NombreAerolinea);
            this.Controls.Add(this.lbl_IdAerolinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ModificarAerolineas";
            this.Text = "frm_ModificarAerolineas";
            this.Load += new System.EventHandler(this.frm_ModificarAerolineas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdAerolinea;
        private System.Windows.Forms.Label lbl_NombreAerolinea;
        private System.Windows.Forms.Label lbl_IdEstado;
        private System.Windows.Forms.TextBox txt_IdAerolinea;
        private System.Windows.Forms.TextBox txt_NombreAerolinea;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Guardar;
        private System.Windows.Forms.ToolStripLabel tsl_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Salir;
        private System.Windows.Forms.ToolStripLabel tsl_Salir;
    }
}