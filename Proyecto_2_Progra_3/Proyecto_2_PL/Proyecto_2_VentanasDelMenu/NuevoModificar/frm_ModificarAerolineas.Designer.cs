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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ModificarAerolineas));
            this.lbl_IdAerolinea = new System.Windows.Forms.Label();
            this.lbl_NombreAerolinea = new System.Windows.Forms.Label();
            this.lbl_IdEstado = new System.Windows.Forms.Label();
            this.txt_IdAerolinea = new System.Windows.Forms.TextBox();
            this.txt_NombreAerolinea = new System.Windows.Forms.TextBox();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdAerolinea
            // 
            this.lbl_IdAerolinea.AutoSize = true;
            this.lbl_IdAerolinea.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdAerolinea.Location = new System.Drawing.Point(74, 82);
            this.lbl_IdAerolinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IdAerolinea.Name = "lbl_IdAerolinea";
            this.lbl_IdAerolinea.Size = new System.Drawing.Size(108, 23);
            this.lbl_IdAerolinea.TabIndex = 0;
            this.lbl_IdAerolinea.Text = "Id Aerolinea";
            // 
            // lbl_NombreAerolinea
            // 
            this.lbl_NombreAerolinea.AutoSize = true;
            this.lbl_NombreAerolinea.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreAerolinea.Location = new System.Drawing.Point(74, 179);
            this.lbl_NombreAerolinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreAerolinea.Name = "lbl_NombreAerolinea";
            this.lbl_NombreAerolinea.Size = new System.Drawing.Size(185, 23);
            this.lbl_NombreAerolinea.TabIndex = 1;
            this.lbl_NombreAerolinea.Text = "Nombre de Aerolinea";
            // 
            // lbl_IdEstado
            // 
            this.lbl_IdEstado.AutoSize = true;
            this.lbl_IdEstado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_IdEstado.Location = new System.Drawing.Point(74, 280);
            this.lbl_IdEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IdEstado.Name = "lbl_IdEstado";
            this.lbl_IdEstado.Size = new System.Drawing.Size(84, 23);
            this.lbl_IdEstado.TabIndex = 2;
            this.lbl_IdEstado.Text = "Id Estado";
            // 
            // txt_IdAerolinea
            // 
            this.txt_IdAerolinea.Enabled = false;
            this.txt_IdAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_IdAerolinea.Location = new System.Drawing.Point(351, 80);
            this.txt_IdAerolinea.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdAerolinea.MaxLength = 20;
            this.txt_IdAerolinea.Name = "txt_IdAerolinea";
            this.txt_IdAerolinea.ReadOnly = true;
            this.txt_IdAerolinea.Size = new System.Drawing.Size(178, 22);
            this.txt_IdAerolinea.TabIndex = 3;
            this.txt_IdAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdAerolinea_KeyPress);
            // 
            // txt_NombreAerolinea
            // 
            this.txt_NombreAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_NombreAerolinea.Location = new System.Drawing.Point(351, 177);
            this.txt_NombreAerolinea.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreAerolinea.MaxLength = 20;
            this.txt_NombreAerolinea.Name = "txt_NombreAerolinea";
            this.txt_NombreAerolinea.Size = new System.Drawing.Size(178, 22);
            this.txt_NombreAerolinea.TabIndex = 1;
            this.txt_NombreAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreAerolinea_KeyPress);
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.ItemHeight = 16;
            this.cmb_IdEstado.Location = new System.Drawing.Point(351, 278);
            this.cmb_IdEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(178, 24);
            this.cmb_IdEstado.TabIndex = 2;
            this.cmb_IdEstado.Text = "--Seleccione una opcion--";
            this.cmb_IdEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdEstado_KeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Guardar,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_Salir,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(6, 6);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(220, 39);
            this.toolStrip2.TabIndex = 37;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(36, 36);
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 36);
            this.toolStripLabel1.Text = "Guardar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_Salir
            // 
            this.btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(36, 36);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 36);
            this.toolStripLabel2.Text = "Salir";
            // 
            // frm_ModificarAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.Aviation;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cmb_IdEstado);
            this.Controls.Add(this.txt_NombreAerolinea);
            this.Controls.Add(this.txt_IdAerolinea);
            this.Controls.Add(this.lbl_IdEstado);
            this.Controls.Add(this.lbl_NombreAerolinea);
            this.Controls.Add(this.lbl_IdAerolinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ModificarAerolineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ModificarAerolineas";
            this.Load += new System.EventHandler(this.frm_ModificarAerolineas_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}