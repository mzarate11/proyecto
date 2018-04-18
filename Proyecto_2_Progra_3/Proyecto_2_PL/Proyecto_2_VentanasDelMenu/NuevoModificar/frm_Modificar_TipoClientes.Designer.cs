namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class frm_Modificar_TipoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Modificar_TipoClientes));
            this.txt_IDTipoCliente = new System.Windows.Forms.TextBox();
            this.txt_TipoCliente = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_IDEstado = new System.Windows.Forms.ComboBox();
            this.lbl_IDTipoCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IDTipoCliente
            // 
            this.txt_IDTipoCliente.Location = new System.Drawing.Point(150, 96);
            this.txt_IDTipoCliente.Name = "txt_IDTipoCliente";
            this.txt_IDTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_IDTipoCliente.TabIndex = 1;
            this.txt_IDTipoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDTipoCliente_KeyPress);
            // 
            // txt_TipoCliente
            // 
            this.txt_TipoCliente.Location = new System.Drawing.Point(424, 96);
            this.txt_TipoCliente.Name = "txt_TipoCliente";
            this.txt_TipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_TipoCliente.TabIndex = 2;
            this.txt_TipoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TipoCliente_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(150, 217);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(151, 71);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // cmb_IDEstado
            // 
            this.cmb_IDEstado.FormattingEnabled = true;
            this.cmb_IDEstado.Location = new System.Drawing.Point(415, 216);
            this.cmb_IDEstado.Name = "cmb_IDEstado";
            this.cmb_IDEstado.Size = new System.Drawing.Size(121, 21);
            this.cmb_IDEstado.TabIndex = 4;
            this.cmb_IDEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IDEstado_KeyPress);
            // 
            // lbl_IDTipoCliente
            // 
            this.lbl_IDTipoCliente.AutoSize = true;
            this.lbl_IDTipoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IDTipoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_IDTipoCliente.Location = new System.Drawing.Point(67, 96);
            this.lbl_IDTipoCliente.Name = "lbl_IDTipoCliente";
            this.lbl_IDTipoCliente.Size = new System.Drawing.Size(80, 13);
            this.lbl_IDTipoCliente.TabIndex = 5;
            this.lbl_IDTipoCliente.Text = "ID Tipo Cliente ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(331, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(331, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Estado";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripLabel4});
            this.toolStrip2.Location = new System.Drawing.Point(9, 9);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(251, 39);
            this.toolStrip2.TabIndex = 22;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(81, 36);
            this.toolStripLabel3.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 36);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(49, 36);
            this.toolStripLabel4.Text = "Salir";
            // 
            // frm_Modificar_TipoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 331);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_IDTipoCliente);
            this.Controls.Add(this.cmb_IDEstado);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_TipoCliente);
            this.Controls.Add(this.txt_IDTipoCliente);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_Modificar_TipoClientes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Tipos Clientes";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.frm_Modificar_TipoClientes_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_IDTipoCliente;
        private System.Windows.Forms.TextBox txt_TipoCliente;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cmb_IDEstado;
        private System.Windows.Forms.Label lbl_IDTipoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}