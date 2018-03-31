namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    partial class frm_Mostrar_TipoEmpleado
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
            this.txt_DescTipo = new System.Windows.Forms.TextBox();
            this.cmb_IDEstado = new System.Windows.Forms.ComboBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IDTipoEmpleado
            // 
            this.txt_IDTipoEmpleado.Location = new System.Drawing.Point(84, 34);
            this.txt_IDTipoEmpleado.Name = "txt_IDTipoEmpleado";
            this.txt_IDTipoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_IDTipoEmpleado.TabIndex = 0;
            // 
            // txt_DescTipo
            // 
            this.txt_DescTipo.Location = new System.Drawing.Point(84, 85);
            this.txt_DescTipo.Name = "txt_DescTipo";
            this.txt_DescTipo.Size = new System.Drawing.Size(100, 20);
            this.txt_DescTipo.TabIndex = 1;
            // 
            // cmb_IDEstado
            // 
            this.cmb_IDEstado.FormattingEnabled = true;
            this.cmb_IDEstado.Location = new System.Drawing.Point(84, 137);
            this.cmb_IDEstado.Name = "cmb_IDEstado";
            this.cmb_IDEstado.Size = new System.Drawing.Size(121, 21);
            this.cmb_IDEstado.TabIndex = 2;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(108, 193);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // frm_Mostrar_TipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.cmb_IDEstado);
            this.Controls.Add(this.txt_DescTipo);
            this.Controls.Add(this.txt_IDTipoEmpleado);
            this.Name = "frm_Mostrar_TipoEmpleado";
            this.Text = "frm_Mostrar_TipoEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDTipoEmpleado;
        private System.Windows.Forms.TextBox txt_DescTipo;
        private System.Windows.Forms.ComboBox cmb_IDEstado;
        private System.Windows.Forms.Button btn_1;
    }
}