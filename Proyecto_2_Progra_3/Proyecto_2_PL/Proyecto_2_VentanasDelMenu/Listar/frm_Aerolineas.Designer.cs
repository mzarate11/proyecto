﻿namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    partial class frm_Aerolineas
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
            this.btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnt_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Aerolineas = new System.Windows.Forms.DataGridView();
            this.MenuVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolineas)).BeginInit();
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
            this.MenuVentana.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Refrescar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.bnt_Nuevo,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.btn_Modificar,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.btn_Eliminar,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.txtFiltro,
            this.btn_Salir,
            this.toolStripLabel6});
            this.MenuVentana.Location = new System.Drawing.Point(-1, 0);
            this.MenuVentana.Name = "MenuVentana";
            this.MenuVentana.Size = new System.Drawing.Size(817, 38);
            this.MenuVentana.TabIndex = 4;
            this.MenuVentana.Text = "toolStrip1";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refrescar.Image = global::Proyecto_2_PL.Properties.Resources.refrescar;
            this.btn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refrescar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(34, 34);
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 35);
            this.toolStripLabel1.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bnt_Nuevo
            // 
            this.bnt_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnt_Nuevo.Image = global::Proyecto_2_PL.Properties.Resources.bNuevo;
            this.bnt_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnt_Nuevo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.bnt_Nuevo.Name = "bnt_Nuevo";
            this.bnt_Nuevo.Size = new System.Drawing.Size(34, 34);
            this.bnt_Nuevo.Text = "Nuevo";
            this.bnt_Nuevo.Click += new System.EventHandler(this.bnt_Nuevo_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 35);
            this.toolStripLabel2.Text = "Nuevo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Modificar.Image = global::Proyecto_2_PL.Properties.Resources.modificar;
            this.btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(34, 34);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(58, 35);
            this.toolStripLabel3.Text = "Modificar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Eliminar.Image = global::Proyecto_2_PL.Properties.Resources.eliminar;
            this.btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(34, 34);
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(50, 35);
            this.toolStripLabel4.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 35);
            this.toolStripLabel5.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 38);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btn_Salir
            // 
            this.btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Image = global::Proyecto_2_PL.Properties.Resources.bSalir;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(34, 34);
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(29, 35);
            this.toolStripLabel6.Text = "Salir";
            // 
            // dgv_Aerolineas
            // 
            this.dgv_Aerolineas.AllowUserToAddRows = false;
            this.dgv_Aerolineas.AllowUserToDeleteRows = false;
            this.dgv_Aerolineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aerolineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Aerolineas.Location = new System.Drawing.Point(0, 37);
            this.dgv_Aerolineas.MultiSelect = false;
            this.dgv_Aerolineas.Name = "dgv_Aerolineas";
            this.dgv_Aerolineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Aerolineas.Size = new System.Drawing.Size(815, 370);
            this.dgv_Aerolineas.TabIndex = 6;
            this.dgv_Aerolineas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aerolineas_CellContentDoubleClick);
            // 
            // frm_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(811, 407);
            this.Controls.Add(this.dgv_Aerolineas);
            this.Controls.Add(this.MenuVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Aerolineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolineas";
            this.Load += new System.EventHandler(this.frm_Aerolineas_Load);
            this.MenuVentana.ResumeLayout(false);
            this.MenuVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuVentana;
        private System.Windows.Forms.ToolStripButton btn_Refrescar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bnt_Nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dgv_Aerolineas;
    }
}