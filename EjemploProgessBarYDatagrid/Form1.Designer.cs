namespace EjemploProgessBarYDatagrid
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pgbcargainicial = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblcarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbcargainicial
            // 
            this.pgbcargainicial.Location = new System.Drawing.Point(243, 404);
            this.pgbcargainicial.Name = "pgbcargainicial";
            this.pgbcargainicial.Size = new System.Drawing.Size(292, 23);
            this.pgbcargainicial.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblcarga
            // 
            this.lblcarga.AutoSize = true;
            this.lblcarga.Location = new System.Drawing.Point(359, 388);
            this.lblcarga.Name = "lblcarga";
            this.lblcarga.Size = new System.Drawing.Size(21, 13);
            this.lblcarga.TabIndex = 1;
            this.lblcarga.Text = "o%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcarga);
            this.Controls.Add(this.pgbcargainicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cargando...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbcargainicial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblcarga;
    }
}

