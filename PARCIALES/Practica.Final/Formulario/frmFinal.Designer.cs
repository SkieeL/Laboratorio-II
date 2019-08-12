namespace Formulario
{
    partial class frmFinal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnEspecialista = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(12, 45);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(260, 96);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Atender Médico General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnEspecialista
            // 
            this.btnEspecialista.Location = new System.Drawing.Point(12, 147);
            this.btnEspecialista.Name = "btnEspecialista";
            this.btnEspecialista.Size = new System.Drawing.Size(260, 102);
            this.btnEspecialista.TabIndex = 1;
            this.btnEspecialista.Text = "Atender Médico Especialista";
            this.btnEspecialista.UseVisualStyleBackColor = true;
            this.btnEspecialista.Click += new System.EventHandler(this.btnEspecialista_Click);
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(260, 22);
            this.txtBox.TabIndex = 2;
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnEspecialista);
            this.Controls.Add(this.btnGeneral);
            this.Name = "frmFinal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinal_FormClosing);
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnEspecialista;
        private System.Windows.Forms.TextBox txtBox;
    }
}

