namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    partial class frm_Mostrar_Estados
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(157, 122);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(157, 225);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion.TabIndex = 1;
            this.txt_Descripcion.TextChanged += new System.EventHandler(this.txt_Descripcion_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Mostrar_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_ID);
            this.Name = "frm_Mostrar_Estados";
            this.Text = "frm_Mostrar_Estados";
            this.Load += new System.EventHandler(this.frm_Mostrar_Estados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button button1;
    }
}