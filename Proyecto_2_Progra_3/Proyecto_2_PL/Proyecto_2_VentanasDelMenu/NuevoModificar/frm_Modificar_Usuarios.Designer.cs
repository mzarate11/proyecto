namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    partial class frm_Modificar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Modificar_Usuarios));
            this.cmb_IdEmpleado = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_IdEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lb_IdEmpleado = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_IdEmpleado
            // 
            this.cmb_IdEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdEmpleado.FormattingEnabled = true;
            this.cmb_IdEmpleado.Location = new System.Drawing.Point(540, 232);
            this.cmb_IdEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_IdEmpleado.Name = "cmb_IdEmpleado";
            this.cmb_IdEmpleado.Size = new System.Drawing.Size(194, 21);
            this.cmb_IdEmpleado.TabIndex = 2;
            this.cmb_IdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdEmpleado_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(49, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 39);
            this.toolStrip1.TabIndex = 4;
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 36);
            this.toolStripLabel1.Text = "Guardar";
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
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 36);
            this.toolStripLabel2.Text = "Salir";
            // 
            // cmb_IdEstado
            // 
            this.cmb_IdEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IdEstado.FormattingEnabled = true;
            this.cmb_IdEstado.Location = new System.Drawing.Point(540, 298);
            this.cmb_IdEstado.Name = "cmb_IdEstado";
            this.cmb_IdEstado.Size = new System.Drawing.Size(194, 21);
            this.cmb_IdEstado.TabIndex = 3;
            this.cmb_IdEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_IdEstado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(353, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Id Estado :";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(540, 179);
            this.txt_Password.MaxLength = 8;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(249, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress_1);
            // 
            // txt_Username
            // 
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Username.Enabled = false;
            this.txt_Username.Location = new System.Drawing.Point(540, 126);
            this.txt_Username.MaxLength = 15;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(125, 20);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Username_KeyPress_1);
            // 
            // lb_IdEmpleado
            // 
            this.lb_IdEmpleado.AutoSize = true;
            this.lb_IdEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lb_IdEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdEmpleado.ForeColor = System.Drawing.Color.White;
            this.lb_IdEmpleado.Location = new System.Drawing.Point(353, 230);
            this.lb_IdEmpleado.Name = "lb_IdEmpleado";
            this.lb_IdEmpleado.Size = new System.Drawing.Size(122, 23);
            this.lb_IdEmpleado.TabIndex = 52;
            this.lb_IdEmpleado.Text = "ID Empleado :";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.BackColor = System.Drawing.Color.Transparent;
            this.lb_Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.Color.White;
            this.lb_Password.Location = new System.Drawing.Point(353, 176);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(94, 23);
            this.lb_Password.TabIndex = 51;
            this.lb_Password.Text = "Password :";
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Username.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Username.ForeColor = System.Drawing.Color.White;
            this.Lb_Username.Location = new System.Drawing.Point(353, 123);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(111, 23);
            this.Lb_Username.TabIndex = 50;
            this.Lb_Username.Text = "User Name :";
            // 
            // frm_Modificar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_2_PL.Properties.Resources.Fondo_Usuarios1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 447);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_IdEmpleado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_IdEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lb_IdEmpleado);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.Lb_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Modificar_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Modificar_Usuarios";
            this.Load += new System.EventHandler(this.frm_Modificar_Usuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_IdEmpleado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox cmb_IdEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lb_IdEmpleado;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label Lb_Username;
    }
}