namespace Proyecto_2_PL.Proyecto_2_Login
{
    partial class frm_Inicio_PL
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pgb_BarraEstado = new System.Windows.Forms.ProgressBar();
            this.lbl_InicioSistema = new System.Windows.Forms.Label();
            this.tmr_Control = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_Titulo.Location = new System.Drawing.Point(257, 35);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(451, 69);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Programación 3";
            // 
            // pgb_BarraEstado
            // 
            this.pgb_BarraEstado.Location = new System.Drawing.Point(67, 430);
            this.pgb_BarraEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgb_BarraEstado.Name = "pgb_BarraEstado";
            this.pgb_BarraEstado.Size = new System.Drawing.Size(407, 28);
            this.pgb_BarraEstado.TabIndex = 1;
            // 
            // lbl_InicioSistema
            // 
            this.lbl_InicioSistema.AutoSize = true;
            this.lbl_InicioSistema.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InicioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_InicioSistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_InicioSistema.Location = new System.Drawing.Point(479, 431);
            this.lbl_InicioSistema.Name = "lbl_InicioSistema";
            this.lbl_InicioSistema.Size = new System.Drawing.Size(199, 29);
            this.lbl_InicioSistema.TabIndex = 2;
            this.lbl_InicioSistema.Text = "Inicio del sistema";
            // 
            // tmr_Control
            // 
            this.tmr_Control.Tick += new System.EventHandler(this.tmr_Control_Tick);
            // 
            // frm_Inicio_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.lbl_InicioSistema);
            this.Controls.Add(this.pgb_BarraEstado);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Inicio_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Inicio_PL";
            this.Load += new System.EventHandler(this.frm_Inicio_PL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ProgressBar pgb_BarraEstado;
        private System.Windows.Forms.Label lbl_InicioSistema;
        private System.Windows.Forms.Timer tmr_Control;
    }
}