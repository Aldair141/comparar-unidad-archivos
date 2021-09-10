
namespace ExaminadorArchivos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstArchivosA = new System.Windows.Forms.ListBox();
            this.btnBuscarA = new System.Windows.Forms.Button();
            this.txtRutaA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstArchivosB = new System.Windows.Forms.ListBox();
            this.btnBuscarB = new System.Windows.Forms.Button();
            this.txtRutaB = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.fbdEstablecerRuta = new System.Windows.Forms.FolderBrowserDialog();
            this.lblArchivosEncontradosA = new System.Windows.Forms.Label();
            this.lblArchivosEncontradosB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblArchivosEncontradosA);
            this.groupBox1.Controls.Add(this.lstArchivosA);
            this.groupBox1.Controls.Add(this.btnBuscarA);
            this.groupBox1.Controls.Add(this.txtRutaA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué libros de aquí....?";
            // 
            // lstArchivosA
            // 
            this.lstArchivosA.FormattingEnabled = true;
            this.lstArchivosA.Location = new System.Drawing.Point(20, 55);
            this.lstArchivosA.Name = "lstArchivosA";
            this.lstArchivosA.Size = new System.Drawing.Size(244, 290);
            this.lstArchivosA.TabIndex = 2;
            // 
            // btnBuscarA
            // 
            this.btnBuscarA.Location = new System.Drawing.Point(212, 27);
            this.btnBuscarA.Name = "btnBuscarA";
            this.btnBuscarA.Size = new System.Drawing.Size(52, 23);
            this.btnBuscarA.TabIndex = 1;
            this.btnBuscarA.Text = "...";
            this.btnBuscarA.UseVisualStyleBackColor = true;
            this.btnBuscarA.Click += new System.EventHandler(this.btnBuscarA_Click);
            // 
            // txtRutaA
            // 
            this.txtRutaA.Location = new System.Drawing.Point(20, 29);
            this.txtRutaA.Name = "txtRutaA";
            this.txtRutaA.Size = new System.Drawing.Size(186, 20);
            this.txtRutaA.TabIndex = 0;
            this.txtRutaA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRutaA_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArchivosEncontradosB);
            this.groupBox2.Controls.Add(this.lstArchivosB);
            this.groupBox2.Controls.Add(this.btnBuscarB);
            this.groupBox2.Controls.Add(this.txtRutaB);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "¿...no tengo aquí?";
            // 
            // lstArchivosB
            // 
            this.lstArchivosB.FormattingEnabled = true;
            this.lstArchivosB.Location = new System.Drawing.Point(20, 55);
            this.lstArchivosB.Name = "lstArchivosB";
            this.lstArchivosB.Size = new System.Drawing.Size(244, 290);
            this.lstArchivosB.TabIndex = 2;
            // 
            // btnBuscarB
            // 
            this.btnBuscarB.Location = new System.Drawing.Point(212, 27);
            this.btnBuscarB.Name = "btnBuscarB";
            this.btnBuscarB.Size = new System.Drawing.Size(52, 23);
            this.btnBuscarB.TabIndex = 1;
            this.btnBuscarB.Text = "...";
            this.btnBuscarB.UseVisualStyleBackColor = true;
            this.btnBuscarB.Click += new System.EventHandler(this.btnBuscarB_Click);
            // 
            // txtRutaB
            // 
            this.txtRutaB.Location = new System.Drawing.Point(20, 29);
            this.txtRutaB.Name = "txtRutaB";
            this.txtRutaB.Size = new System.Drawing.Size(186, 20);
            this.txtRutaB.TabIndex = 0;
            this.txtRutaB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRutaB_KeyDown);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(12, 391);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(566, 23);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(12, 420);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(566, 147);
            this.lstResultado.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 573);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(12, 573);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(566, 23);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar Rutas";
            this.btnDescargar.UseVisualStyleBackColor = true;
            // 
            // lblArchivosEncontradosA
            // 
            this.lblArchivosEncontradosA.AutoSize = true;
            this.lblArchivosEncontradosA.Location = new System.Drawing.Point(20, 352);
            this.lblArchivosEncontradosA.Name = "lblArchivosEncontradosA";
            this.lblArchivosEncontradosA.Size = new System.Drawing.Size(0, 13);
            this.lblArchivosEncontradosA.TabIndex = 3;
            // 
            // lblArchivosEncontradosB
            // 
            this.lblArchivosEncontradosB.AutoSize = true;
            this.lblArchivosEncontradosB.Location = new System.Drawing.Point(17, 352);
            this.lblArchivosEncontradosB.Name = "lblArchivosEncontradosB";
            this.lblArchivosEncontradosB.Size = new System.Drawing.Size(0, 13);
            this.lblArchivosEncontradosB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 606);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstArchivosA;
        private System.Windows.Forms.Button btnBuscarA;
        private System.Windows.Forms.TextBox txtRutaA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstArchivosB;
        private System.Windows.Forms.Button btnBuscarB;
        private System.Windows.Forms.TextBox txtRutaB;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.FolderBrowserDialog fbdEstablecerRuta;
        private System.Windows.Forms.Label lblArchivosEncontradosA;
        private System.Windows.Forms.Label lblArchivosEncontradosB;
    }
}

