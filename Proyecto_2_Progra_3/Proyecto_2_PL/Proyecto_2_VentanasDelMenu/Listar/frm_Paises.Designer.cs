namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    partial class frm_Paises
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
            this.MenuVentana = new System.Windows.Forms.ToolStrip();
            this.tls_btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tls_txt_Filtro = new System.Windows.Forms.ToolStripTextBox();
            this.tls_btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Paises = new System.Windows.Forms.DataGridView();
            this.MenuVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paises)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVentana
            // 
            this.MenuVentana.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.MenuVentana.AllowDrop = true;
            this.MenuVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuVentana.AutoSize = false;
            this.MenuVentana.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuVentana.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuVentana.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_btn_Refrescar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tls_btn_Nuevo,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tls_btn_Modificar,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.tls_btn_Eliminar,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.tls_txt_Filtro,
            this.tls_btn_Salir,
            this.toolStripLabel6});
            this.MenuVentana.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuVentana.Location = new System.Drawing.Point(3, 2);
            this.MenuVentana.Name = "MenuVentana";
            this.MenuVentana.Size = new System.Drawing.Size(815, 32);
            this.MenuVentana.TabIndex = 5;
            this.MenuVentana.Text = "toolStrip1";
            // 
            // tls_btn_Refrescar
            // 
            this.tls_btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Refrescar.Image = global::Proyecto_2_PL.Properties.Resources.refrescar;
            this.tls_btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Refrescar.Name = "tls_btn_Refrescar";
            this.tls_btn_Refrescar.Size = new System.Drawing.Size(28, 28);
            this.tls_btn_Refrescar.Text = "Refrescar";
            this.tls_btn_Refrescar.Click += new System.EventHandler(this.tls_btn_Refrescar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 15);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tls_btn_Nuevo
            // 
            this.tls_btn_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Nuevo.Image = global::Proyecto_2_PL.Properties.Resources.agregar;
            this.tls_btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Nuevo.Name = "tls_btn_Nuevo";
            this.tls_btn_Nuevo.Size = new System.Drawing.Size(28, 28);
            this.tls_btn_Nuevo.Text = "Nuevo";
            this.tls_btn_Nuevo.Click += new System.EventHandler(this.tls_btn_Nuevo_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 15);
            this.toolStripLabel2.Text = "Nuevo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tls_btn_Modificar
            // 
            this.tls_btn_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Modificar.Image = global::Proyecto_2_PL.Properties.Resources.modificar;
            this.tls_btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Modificar.Name = "tls_btn_Modificar";
            this.tls_btn_Modificar.Size = new System.Drawing.Size(28, 28);
            this.tls_btn_Modificar.Text = "Modificar";
            this.tls_btn_Modificar.Click += new System.EventHandler(this.tls_btn_Modificar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(58, 15);
            this.toolStripLabel3.Text = "Modificar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tls_btn_Eliminar
            // 
            this.tls_btn_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Eliminar.Image = global::Proyecto_2_PL.Properties.Resources.eliminar;
            this.tls_btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Eliminar.Name = "tls_btn_Eliminar";
            this.tls_btn_Eliminar.Size = new System.Drawing.Size(28, 28);
            this.tls_btn_Eliminar.Text = "Eliminar";
            this.tls_btn_Eliminar.Click += new System.EventHandler(this.tls_btn_Eliminar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(50, 15);
            this.toolStripLabel4.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 15);
            this.toolStripLabel5.Text = "Filtro:";
            // 
            // tls_txt_Filtro
            // 
            this.tls_txt_Filtro.Name = "tls_txt_Filtro";
            this.tls_txt_Filtro.Size = new System.Drawing.Size(100, 23);
            this.tls_txt_Filtro.TextChanged += new System.EventHandler(this.tls_txt_Filtro_TextChanged);
            // 
            // tls_btn_Salir
            // 
            this.tls_btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Salir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tls_btn_Salir.Image = global::Proyecto_2_PL.Properties.Resources.salir;
            this.tls_btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Salir.Name = "tls_btn_Salir";
            this.tls_btn_Salir.Size = new System.Drawing.Size(28, 28);
            this.tls_btn_Salir.Text = "Salir";
            this.tls_btn_Salir.Click += new System.EventHandler(this.tls_btn_Salir_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(29, 15);
            this.toolStripLabel6.Text = "Salir";
            // 
            // dgv_Paises
            // 
            this.dgv_Paises.AllowUserToAddRows = false;
            this.dgv_Paises.AllowUserToDeleteRows = false;
            this.dgv_Paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Paises.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Paises.Location = new System.Drawing.Point(2, 34);
            this.dgv_Paises.MultiSelect = false;
            this.dgv_Paises.Name = "dgv_Paises";
            this.dgv_Paises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Paises.Size = new System.Drawing.Size(815, 370);
            this.dgv_Paises.TabIndex = 6;
            // 
            // frm_Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(818, 402);
            this.Controls.Add(this.dgv_Paises);
            this.Controls.Add(this.MenuVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Paises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Paises";
            this.Load += new System.EventHandler(this.frm_Paises_Load);
            this.MenuVentana.ResumeLayout(false);
            this.MenuVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuVentana;
        private System.Windows.Forms.ToolStripButton tls_btn_Refrescar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tls_btn_Nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tls_btn_Modificar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tls_btn_Eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tls_txt_Filtro;
        private System.Windows.Forms.ToolStripButton tls_btn_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dgv_Paises;
    }
}