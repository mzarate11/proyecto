﻿using System;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class frm_Modificar_TipoEmpleado
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
            this.txt_IDTipoEmpleado = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.cmb_IDEstado = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Sal = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IDTipoEmpleado
            // 
            this.txt_IDTipoEmpleado.Location = new System.Drawing.Point(122, 56);
            this.txt_IDTipoEmpleado.MaxLength = 10;
            this.txt_IDTipoEmpleado.Name = "txt_IDTipoEmpleado";
            this.txt_IDTipoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_IDTipoEmpleado.TabIndex = 0;
            this.txt_IDTipoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDTipoEmpleado_KeyPress);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(122, 165);
            this.txt_desc.MaxLength = 150;
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(167, 70);
            this.txt_desc.TabIndex = 1;
            this.txt_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desc_KeyPress);
            // 
            // cmb_IDEstado
            // 
            this.cmb_IDEstado.FormattingEnabled = true;
            this.cmb_IDEstado.Location = new System.Drawing.Point(361, 116);
            this.cmb_IDEstado.MaxLength = 10;
            this.cmb_IDEstado.Name = "cmb_IDEstado";
            this.cmb_IDEstado.Size = new System.Drawing.Size(121, 21);
            this.cmb_IDEstado.TabIndex = 2;
            this.cmb_IDEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IDEstado_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guardar,
            this.toolStripLabel1,
            this.Sal,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(549, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Guardar
            // 
            this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar.Image = global::Proyecto_2_PL.Properties.Resources.bGuardar;
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(23, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Guardar";
            // 
            // Sal
            // 
            this.Sal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sal.Image = global::Proyecto_2_PL.Properties.Resources.bSalir;
            this.Sal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(23, 22);
            this.Sal.Text = "Salir";
            this.Sal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sal.Click += new System.EventHandler(this.Sal_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel2.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Tipo Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(276, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Estado";
            // 
            // frm_Modificar_TipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.fondomenu;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_IDEstado);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_IDTipoEmpleado);
            this.Name = "frm_Modificar_TipoEmpleado";
            this.ShowIcon = false;
            this.Text = "Modificar Tipo Empleado";
            this.Load += new System.EventHandler(this.frm_Modificar_TipoEmpleado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDTipoEmpleado;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.ComboBox cmb_IDEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton Sal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton Guardar;
        private EventHandler SalClick;
    }
}