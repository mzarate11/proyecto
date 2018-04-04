namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class frm_ModificarAviones
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
            this.lbl_IdAvion = new System.Windows.Forms.Label();
            this.lbl_NombreAvion = new System.Windows.Forms.Label();
            this.lbl_DescAvion = new System.Windows.Forms.Label();
            this.lbl_IdAerolinea = new System.Windows.Forms.Label();
            this.lbl_IdTipoAvion = new System.Windows.Forms.Label();
            this.lbl_IdEstado = new System.Windows.Forms.Label();
            this.txt_IdAvion = new System.Windows.Forms.TextBox();
            this.txt_DescAvion = new System.Windows.Forms.TextBox();
            this.txt_NomAvion = new System.Windows.Forms.TextBox();
            this.cmb_IdAerolinea = new System.Windows.Forms.ComboBox();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.cmb_IdTipoAvion = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Guardar = new System.Windows.Forms.ToolStripButton();
            this.tsl_Guardar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Salir = new System.Windows.Forms.ToolStripButton();
            this.tsl_Salir = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdAvion
            // 
            this.lbl_IdAvion.AutoSize = true;
            this.lbl_IdAvion.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdAvion.Location = new System.Drawing.Point(100, 62);
            this.lbl_IdAvion.Name = "lbl_IdAvion";
            this.lbl_IdAvion.Size = new System.Drawing.Size(116, 36);
            this.lbl_IdAvion.TabIndex = 0;
            this.lbl_IdAvion.Text = "Id Avion";
            // 
            // lbl_NombreAvion
            // 
            this.lbl_NombreAvion.AutoSize = true;
            this.lbl_NombreAvion.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreAvion.Location = new System.Drawing.Point(100, 156);
            this.lbl_NombreAvion.Name = "lbl_NombreAvion";
            this.lbl_NombreAvion.Size = new System.Drawing.Size(230, 36);
            this.lbl_NombreAvion.TabIndex = 1;
            this.lbl_NombreAvion.Text = "Nombre de Avion";
            // 
            // lbl_DescAvion
            // 
            this.lbl_DescAvion.AutoSize = true;
            this.lbl_DescAvion.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_DescAvion.Location = new System.Drawing.Point(100, 264);
            this.lbl_DescAvion.Name = "lbl_DescAvion";
            this.lbl_DescAvion.Size = new System.Drawing.Size(274, 36);
            this.lbl_DescAvion.TabIndex = 2;
            this.lbl_DescAvion.Text = "Descripcion de Avion";
            this.lbl_DescAvion.Click += new System.EventHandler(this.lbl_DescAvion_Click);
            // 
            // lbl_IdAerolinea
            // 
            this.lbl_IdAerolinea.AutoSize = true;
            this.lbl_IdAerolinea.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdAerolinea.Location = new System.Drawing.Point(100, 371);
            this.lbl_IdAerolinea.Name = "lbl_IdAerolinea";
            this.lbl_IdAerolinea.Size = new System.Drawing.Size(164, 36);
            this.lbl_IdAerolinea.TabIndex = 3;
            this.lbl_IdAerolinea.Text = "Id Aerolinea";
            // 
            // lbl_IdTipoAvion
            // 
            this.lbl_IdTipoAvion.AutoSize = true;
            this.lbl_IdTipoAvion.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdTipoAvion.Location = new System.Drawing.Point(100, 473);
            this.lbl_IdTipoAvion.Name = "lbl_IdTipoAvion";
            this.lbl_IdTipoAvion.Size = new System.Drawing.Size(213, 36);
            this.lbl_IdTipoAvion.TabIndex = 4;
            this.lbl_IdTipoAvion.Text = "Id Tipo de Avion";
            // 
            // lbl_IdEstado
            // 
            this.lbl_IdEstado.AutoSize = true;
            this.lbl_IdEstado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdEstado.Location = new System.Drawing.Point(100, 577);
            this.lbl_IdEstado.Name = "lbl_IdEstado";
            this.lbl_IdEstado.Size = new System.Drawing.Size(129, 36);
            this.lbl_IdEstado.TabIndex = 5;
            this.lbl_IdEstado.Text = "Id Estado";
            // 
            // txt_IdAvion
            // 
            this.txt_IdAvion.Font = new System.Drawing.Font("Candara", 15F);
            this.txt_IdAvion.Location = new System.Drawing.Point(562, 62);
            this.txt_IdAvion.Name = "txt_IdAvion";
            this.txt_IdAvion.Size = new System.Drawing.Size(265, 44);
            this.txt_IdAvion.TabIndex = 6;
            this.txt_IdAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdAvion_KeyPress);
            // 
            // txt_DescAvion
            // 
            this.txt_DescAvion.Font = new System.Drawing.Font("Candara", 15F);
            this.txt_DescAvion.Location = new System.Drawing.Point(562, 264);
            this.txt_DescAvion.Name = "txt_DescAvion";
            this.txt_DescAvion.Size = new System.Drawing.Size(265, 44);
            this.txt_DescAvion.TabIndex = 7;
            this.txt_DescAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescAvion_KeyPress);
            // 
            // txt_NomAvion
            // 
            this.txt_NomAvion.Font = new System.Drawing.Font("Candara", 15F);
            this.txt_NomAvion.Location = new System.Drawing.Point(562, 153);
            this.txt_NomAvion.Name = "txt_NomAvion";
            this.txt_NomAvion.Size = new System.Drawing.Size(265, 44);
            this.txt_NomAvion.TabIndex = 8;
            this.txt_NomAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomAvion_KeyPress);
            // 
            // cmb_IdAerolinea
            // 
            this.cmb_IdAerolinea.Font = new System.Drawing.Font("Candara", 15F);
            this.cmb_IdAerolinea.FormattingEnabled = true;
            this.cmb_IdAerolinea.Location = new System.Drawing.Point(562, 371);
            this.cmb_IdAerolinea.Name = "cmb_IdAerolinea";
            this.cmb_IdAerolinea.Size = new System.Drawing.Size(265, 45);
            this.cmb_IdAerolinea.TabIndex = 9;
            this.cmb_IdAerolinea.Text = "Elegir opcion";
            this.cmb_IdAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdAerolinea_KeyPress);
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.Font = new System.Drawing.Font("Candara", 15F);
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(562, 574);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(265, 45);
            this.cmb_IdEstado.TabIndex = 10;
            this.cmb_IdEstado.Text = "Elegir opcion";
            this.cmb_IdEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdEstado_KeyPress);
            // 
            // cmb_IdTipoAvion
            // 
            this.cmb_IdTipoAvion.Font = new System.Drawing.Font("Candara", 15F);
            this.cmb_IdTipoAvion.FormattingEnabled = true;
            this.cmb_IdTipoAvion.Location = new System.Drawing.Point(562, 473);
            this.cmb_IdTipoAvion.Name = "cmb_IdTipoAvion";
            this.cmb_IdTipoAvion.Size = new System.Drawing.Size(265, 45);
            this.cmb_IdTipoAvion.TabIndex = 11;
            this.cmb_IdTipoAvion.Text = "Elegir opcion";
            this.cmb_IdTipoAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdTipoAvion_KeyPress);
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
            this.toolStrip1.Size = new System.Drawing.Size(998, 31);
            this.toolStrip1.TabIndex = 12;
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
            // frm_ModificarAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.Aviation;
            this.ClientSize = new System.Drawing.Size(998, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_IdTipoAvion);
            this.Controls.Add(this.cmb_IdEstado);
            this.Controls.Add(this.cmb_IdAerolinea);
            this.Controls.Add(this.txt_NomAvion);
            this.Controls.Add(this.txt_DescAvion);
            this.Controls.Add(this.txt_IdAvion);
            this.Controls.Add(this.lbl_IdEstado);
            this.Controls.Add(this.lbl_IdTipoAvion);
            this.Controls.Add(this.lbl_IdAerolinea);
            this.Controls.Add(this.lbl_DescAvion);
            this.Controls.Add(this.lbl_NombreAvion);
            this.Controls.Add(this.lbl_IdAvion);
            this.Name = "frm_ModificarAviones";
            this.Text = "frm_ModificarAviones";
            this.Load += new System.EventHandler(this.frm_ModificarAviones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdAvion;
        private System.Windows.Forms.Label lbl_NombreAvion;
        private System.Windows.Forms.Label lbl_DescAvion;
        private System.Windows.Forms.Label lbl_IdAerolinea;
        private System.Windows.Forms.Label lbl_IdTipoAvion;
        private System.Windows.Forms.Label lbl_IdEstado;
        private System.Windows.Forms.TextBox txt_IdAvion;
        private System.Windows.Forms.TextBox txt_DescAvion;
        private System.Windows.Forms.TextBox txt_NomAvion;
        private System.Windows.Forms.ComboBox cmb_IdAerolinea;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.ComboBox cmb_IdTipoAvion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Guardar;
        private System.Windows.Forms.ToolStripLabel tsl_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Salir;
        private System.Windows.Forms.ToolStripLabel tsl_Salir;
    }
}