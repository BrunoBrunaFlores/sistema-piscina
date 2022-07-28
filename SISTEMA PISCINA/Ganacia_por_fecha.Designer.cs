namespace SISTEMA_PISCINA
{
    partial class Ganacia_por_fecha
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
            this.FechaBuscada = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGanacia = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FechaBuscada
            // 
            this.FechaBuscada.Location = new System.Drawing.Point(61, 70);
            this.FechaBuscada.Name = "FechaBuscada";
            this.FechaBuscada.Size = new System.Drawing.Size(200, 20);
            this.FechaBuscada.TabIndex = 0;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(51, 29);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(210, 20);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Seleccione la fecha a ver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "S/.";
            // 
            // LblGanacia
            // 
            this.LblGanacia.AutoSize = true;
            this.LblGanacia.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGanacia.Location = new System.Drawing.Point(80, 184);
            this.LblGanacia.Name = "LblGanacia";
            this.LblGanacia.Size = new System.Drawing.Size(130, 38);
            this.LblGanacia.TabIndex = 3;
            this.LblGanacia.Text = "Ganancia";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(110, 123);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 38);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Ganacia_por_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.LblGanacia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.FechaBuscada);
            this.Name = "Ganacia_por_fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganacia_por_fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaBuscada;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGanacia;
        private System.Windows.Forms.Button btnConsultar;
    }
}