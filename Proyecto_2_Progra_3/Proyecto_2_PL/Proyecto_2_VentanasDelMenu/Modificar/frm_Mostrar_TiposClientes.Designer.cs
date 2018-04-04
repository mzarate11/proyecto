namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    partial class frm_Mostrar_TiposClientes
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
            this.txt_IDTipoCliente = new System.Windows.Forms.TextBox();
            this.txt_TipoCliente = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_IDEstado = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IDTipoCliente
            // 
            this.txt_IDTipoCliente.Location = new System.Drawing.Point(65, 50);
            this.txt_IDTipoCliente.Name = "txt_IDTipoCliente";
            this.txt_IDTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_IDTipoCliente.TabIndex = 0;
            // 
            // txt_TipoCliente
            // 
            this.txt_TipoCliente.Location = new System.Drawing.Point(65, 98);
            this.txt_TipoCliente.Name = "txt_TipoCliente";
            this.txt_TipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_TipoCliente.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(65, 140);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // cmb_IDEstado
            // 
            this.cmb_IDEstado.FormattingEnabled = true;
            this.cmb_IDEstado.Location = new System.Drawing.Point(65, 187);
            this.cmb_IDEstado.Name = "cmb_IDEstado";
            this.cmb_IDEstado.Size = new System.Drawing.Size(121, 21);
            this.cmb_IDEstado.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(101, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frm_Mostrar_TiposClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cmb_IDEstado);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_TipoCliente);
            this.Controls.Add(this.txt_IDTipoCliente);
            this.Name = "frm_Mostrar_TiposClientes";
            this.Text = "frm_Mostrar_TiposClientes";
            this.Load += new System.EventHandler(this.frm_Mostrar_TiposClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDTipoCliente;
        private System.Windows.Forms.TextBox txt_TipoCliente;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cmb_IDEstado;
        private System.Windows.Forms.Button btn1;
    }
}