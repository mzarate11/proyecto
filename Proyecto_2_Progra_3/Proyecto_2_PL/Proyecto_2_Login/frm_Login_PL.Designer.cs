namespace Proyecto_2_PL.Proyecto_2_Login
{
    partial class frm_Login_PL
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
            this.pcb_Login = new System.Windows.Forms.PictureBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Ingreso = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Login
            // 
            this.pcb_Login.ErrorImage = null;
            this.pcb_Login.Image = global::Proyecto_2_PL.Properties.Resources.login;
            this.pcb_Login.Location = new System.Drawing.Point(150, 96);
            this.pcb_Login.Name = "pcb_Login";
            this.pcb_Login.Size = new System.Drawing.Size(212, 222);
            this.pcb_Login.TabIndex = 0;
            this.pcb_Login.TabStop = false;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Usuario.Location = new System.Drawing.Point(62, 451);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(96, 29);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Contraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Contraseña.Location = new System.Drawing.Point(62, 557);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(136, 29);
            this.lbl_Contraseña.TabIndex = 2;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Usuario.Location = new System.Drawing.Point(281, 451);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(172, 35);
            this.txt_Usuario.TabIndex = 3;
            this.txt_Usuario.Text = "Admin";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_Contraseña.Location = new System.Drawing.Point(281, 557);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(172, 35);
            this.txt_Contraseña.TabIndex = 4;
            this.txt_Contraseña.Text = "Admin";
            this.txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // btn_Ingreso
            // 
            this.btn_Ingreso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Ingreso.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn_Ingreso.Location = new System.Drawing.Point(124, 693);
            this.btn_Ingreso.Name = "btn_Ingreso";
            this.btn_Ingreso.Size = new System.Drawing.Size(276, 58);
            this.btn_Ingreso.TabIndex = 5;
            this.btn_Ingreso.Text = "Ingreso";
            this.btn_Ingreso.UseVisualStyleBackColor = false;
            this.btn_Ingreso.Click += new System.EventHandler(this.btn_Ingreso_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn_Cancelar.Location = new System.Drawing.Point(124, 791);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(276, 58);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Login_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.login_fondo_1;
            this.ClientSize = new System.Drawing.Size(539, 915);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ingreso);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.pcb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login_PL";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Login;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_Ingreso;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}