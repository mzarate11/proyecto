﻿namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class fmr_ModificarNuevo_Vuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_ModificarNuevo_Vuelos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.labelAccion = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.comb_IdEstado = new System.Windows.Forms.Label();
            this.txt_IdVuelo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_IdDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_IdAerolinea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_IdAvion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.time_HoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.labelAccion,
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 39);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
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
            // labelAccion
            // 
            this.labelAccion.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccion.Name = "labelAccion";
            this.labelAccion.Size = new System.Drawing.Size(81, 36);
            this.labelAccion.Text = "Guardar";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 36);
            this.toolStripLabel2.Text = "Salir";
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(152, 238);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(219, 21);
            this.cmb_IdEstado.TabIndex = 38;
            // 
            // comb_IdEstado
            // 
            this.comb_IdEstado.AutoSize = true;
            this.comb_IdEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comb_IdEstado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_IdEstado.Location = new System.Drawing.Point(12, 234);
            this.comb_IdEstado.Name = "comb_IdEstado";
            this.comb_IdEstado.Size = new System.Drawing.Size(62, 23);
            this.comb_IdEstado.TabIndex = 37;
            this.comb_IdEstado.Text = "Estado";
            // 
            // txt_IdVuelo
            // 
            this.txt_IdVuelo.Enabled = false;
            this.txt_IdVuelo.Location = new System.Drawing.Point(152, 70);
            this.txt_IdVuelo.MaxLength = 5;
            this.txt_IdVuelo.Name = "txt_IdVuelo";
            this.txt_IdVuelo.Size = new System.Drawing.Size(125, 20);
            this.txt_IdVuelo.TabIndex = 40;
            this.txt_IdVuelo.TextChanged += new System.EventHandler(this.txt_IdVuelo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "Id Vuelo";
            // 
            // cmb_IdDestino
            // 
            this.cmb_IdDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdDestino.FormattingEnabled = true;
            this.cmb_IdDestino.Location = new System.Drawing.Point(152, 115);
            this.cmb_IdDestino.Name = "cmb_IdDestino";
            this.cmb_IdDestino.Size = new System.Drawing.Size(219, 21);
            this.cmb_IdDestino.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Destino";
            // 
            // cmb_IdAerolinea
            // 
            this.cmb_IdAerolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdAerolinea.FormattingEnabled = true;
            this.cmb_IdAerolinea.Location = new System.Drawing.Point(152, 154);
            this.cmb_IdAerolinea.Name = "cmb_IdAerolinea";
            this.cmb_IdAerolinea.Size = new System.Drawing.Size(219, 21);
            this.cmb_IdAerolinea.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Aerolinea";
            // 
            // cmb_IdAvion
            // 
            this.cmb_IdAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdAvion.FormattingEnabled = true;
            this.cmb_IdAvion.Location = new System.Drawing.Point(152, 190);
            this.cmb_IdAvion.Name = "cmb_IdAvion";
            this.cmb_IdAvion.Size = new System.Drawing.Size(219, 21);
            this.cmb_IdAvion.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Avión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha Llegada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Fecha/Hora Salida";
            // 
            // time_HoraSalida
            // 
            this.time_HoraSalida.Location = new System.Drawing.Point(456, 129);
            this.time_HoraSalida.Name = "time_HoraSalida";
            this.time_HoraSalida.Size = new System.Drawing.Size(153, 20);
            this.time_HoraSalida.TabIndex = 53;
            // 
            // time_HoraLlegada
            // 
            this.time_HoraLlegada.Location = new System.Drawing.Point(456, 209);
            this.time_HoraLlegada.Name = "time_HoraLlegada";
            this.time_HoraLlegada.Size = new System.Drawing.Size(153, 20);
            this.time_HoraLlegada.TabIndex = 54;
            // 
            // fmr_ModificarNuevo_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.vuelos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 337);
            this.Controls.Add(this.time_HoraLlegada);
            this.Controls.Add(this.time_HoraSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_IdAvion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_IdAerolinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_IdDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IdVuelo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmb_IdEstado);
            this.Controls.Add(this.comb_IdEstado);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmr_ModificarNuevo_Vuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_ModificarNuevo_Vuelos";
            this.Load += new System.EventHandler(this.fmr_ModificarNuevo_Vuelos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripLabel labelAccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.Label comb_IdEstado;
        private System.Windows.Forms.TextBox txt_IdVuelo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_IdDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_IdAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_IdAvion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker time_HoraSalida;
        private System.Windows.Forms.DateTimePicker time_HoraLlegada;
    }
}