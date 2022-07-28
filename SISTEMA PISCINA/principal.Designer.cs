namespace SISTEMA_PISCINA
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoMujer = new System.Windows.Forms.RadioButton();
            this.rdoVaron = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.GrpEspecifica = new System.Windows.Forms.GroupBox();
            this.txtPrecioEspecifi = new System.Windows.Forms.TextBox();
            this.txtNombreEspecifi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCandado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoEspecifica = new System.Windows.Forms.RadioButton();
            this.rdoGeneral = new System.Windows.Forms.RadioButton();
            this.rdoNiño = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalida = new System.Windows.Forms.Button();
            this.tblListaTemporal = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscaFecha = new System.Windows.Forms.TextBox();
            this.txtBuscaCandado = new System.Windows.Forms.TextBox();
            this.txtBuscaNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.LblGananciaDia = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tblListaReportes = new System.Windows.Forms.DataGridView();
            this.LblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrpEspecifica.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaTemporal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 371);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.GrpEspecifica);
            this.tabPage1.Controls.Add(this.txtObservaciones);
            this.tabPage1.Controls.Add(this.txtSaldo);
            this.tabPage1.Controls.Add(this.txtCandado);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.rdoEspecifica);
            this.tabPage1.Controls.Add(this.rdoGeneral);
            this.tabPage1.Controls.Add(this.rdoNiño);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNombres);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REGISTRAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoMujer);
            this.groupBox3.Controls.Add(this.rdoVaron);
            this.groupBox3.Location = new System.Drawing.Point(221, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 43);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.Location = new System.Drawing.Point(20, 16);
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Size = new System.Drawing.Size(68, 19);
            this.rdoMujer.TabIndex = 22;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "MUJER";
            this.rdoMujer.UseVisualStyleBackColor = true;
            // 
            // rdoVaron
            // 
            this.rdoVaron.AutoSize = true;
            this.rdoVaron.Location = new System.Drawing.Point(142, 16);
            this.rdoVaron.Name = "rdoVaron";
            this.rdoVaron.Size = new System.Drawing.Size(66, 19);
            this.rdoVaron.TabIndex = 23;
            this.rdoVaron.TabStop = true;
            this.rdoVaron.Text = "VARÓN";
            this.rdoVaron.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrpEspecifica
            // 
            this.GrpEspecifica.Controls.Add(this.txtPrecioEspecifi);
            this.GrpEspecifica.Controls.Add(this.txtNombreEspecifi);
            this.GrpEspecifica.Controls.Add(this.label17);
            this.GrpEspecifica.Controls.Add(this.label16);
            this.GrpEspecifica.Enabled = false;
            this.GrpEspecifica.Location = new System.Drawing.Point(829, 21);
            this.GrpEspecifica.Name = "GrpEspecifica";
            this.GrpEspecifica.Size = new System.Drawing.Size(200, 162);
            this.GrpEspecifica.TabIndex = 24;
            this.GrpEspecifica.TabStop = false;
            this.GrpEspecifica.Text = "ESPECIFICAR";
            // 
            // txtPrecioEspecifi
            // 
            this.txtPrecioEspecifi.Location = new System.Drawing.Point(32, 113);
            this.txtPrecioEspecifi.Name = "txtPrecioEspecifi";
            this.txtPrecioEspecifi.Size = new System.Drawing.Size(132, 21);
            this.txtPrecioEspecifi.TabIndex = 3;
            // 
            // txtNombreEspecifi
            // 
            this.txtNombreEspecifi.Location = new System.Drawing.Point(32, 48);
            this.txtNombreEspecifi.Name = "txtNombreEspecifi";
            this.txtNombreEspecifi.Size = new System.Drawing.Size(132, 21);
            this.txtNombreEspecifi.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Precio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nombre";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(149, 212);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(300, 21);
            this.txtObservaciones.TabIndex = 21;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(149, 165);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(54, 21);
            this.txtSaldo.TabIndex = 20;
            // 
            // txtCandado
            // 
            this.txtCandado.Location = new System.Drawing.Point(149, 116);
            this.txtCandado.Name = "txtCandado";
            this.txtCandado.Size = new System.Drawing.Size(54, 21);
            this.txtCandado.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Observaciones";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "Saldo(S/.)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nro Candado*";
            // 
            // rdoEspecifica
            // 
            this.rdoEspecifica.AutoSize = true;
            this.rdoEspecifica.Location = new System.Drawing.Point(363, 67);
            this.rdoEspecifica.Name = "rdoEspecifica";
            this.rdoEspecifica.Size = new System.Drawing.Size(102, 19);
            this.rdoEspecifica.TabIndex = 15;
            this.rdoEspecifica.TabStop = true;
            this.rdoEspecifica.Text = "ESPECIFICAR";
            this.rdoEspecifica.UseVisualStyleBackColor = true;
            this.rdoEspecifica.CheckedChanged += new System.EventHandler(this.rdoEspecifica_CheckedChanged);
            // 
            // rdoGeneral
            // 
            this.rdoGeneral.AutoSize = true;
            this.rdoGeneral.Location = new System.Drawing.Point(241, 67);
            this.rdoGeneral.Name = "rdoGeneral";
            this.rdoGeneral.Size = new System.Drawing.Size(82, 19);
            this.rdoGeneral.TabIndex = 14;
            this.rdoGeneral.TabStop = true;
            this.rdoGeneral.Text = "GENERAL";
            this.rdoGeneral.UseVisualStyleBackColor = true;
            // 
            // rdoNiño
            // 
            this.rdoNiño.AutoSize = true;
            this.rdoNiño.Location = new System.Drawing.Point(149, 67);
            this.rdoNiño.Name = "rdoNiño";
            this.rdoNiño.Size = new System.Drawing.Size(55, 19);
            this.rdoNiño.TabIndex = 13;
            this.rdoNiño.TabStop = true;
            this.rdoNiño.Text = "NIÑO";
            this.rdoNiño.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tipo de entrada*";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(149, 18);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(307, 21);
            this.txtNombres.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombres y apellidos*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalida);
            this.tabPage2.Controls.Add(this.tblListaTemporal);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LISTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(908, 292);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(124, 45);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "MARCAR SALIDA";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // tblListaTemporal
            // 
            this.tblListaTemporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaTemporal.Location = new System.Drawing.Point(6, 61);
            this.tblListaTemporal.Name = "tblListaTemporal";
            this.tblListaTemporal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblListaTemporal.Size = new System.Drawing.Size(1028, 180);
            this.tblListaTemporal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscaFecha);
            this.groupBox2.Controls.Add(this.txtBuscaCandado);
            this.groupBox2.Controls.Add(this.txtBuscaNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // txtBuscaFecha
            // 
            this.txtBuscaFecha.Location = new System.Drawing.Point(922, 20);
            this.txtBuscaFecha.Name = "txtBuscaFecha";
            this.txtBuscaFecha.Size = new System.Drawing.Size(100, 21);
            this.txtBuscaFecha.TabIndex = 5;
            this.txtBuscaFecha.TextChanged += new System.EventHandler(this.txtBuscaFecha_TextChanged);
            // 
            // txtBuscaCandado
            // 
            this.txtBuscaCandado.Location = new System.Drawing.Point(540, 17);
            this.txtBuscaCandado.Name = "txtBuscaCandado";
            this.txtBuscaCandado.Size = new System.Drawing.Size(100, 21);
            this.txtBuscaCandado.TabIndex = 4;
            this.txtBuscaCandado.TextChanged += new System.EventHandler(this.txtBuscaCandado_TextChanged);
            // 
            // txtBuscaNombre
            // 
            this.txtBuscaNombre.Location = new System.Drawing.Point(100, 17);
            this.txtBuscaNombre.Name = "txtBuscaNombre";
            this.txtBuscaNombre.Size = new System.Drawing.Size(180, 21);
            this.txtBuscaNombre.TabIndex = 3;
            this.txtBuscaNombre.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(841, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora y fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Candado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.LblGananciaDia);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.tblListaReportes);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1037, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "REPORTES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "S/.";
            // 
            // LblGananciaDia
            // 
            this.LblGananciaDia.AutoSize = true;
            this.LblGananciaDia.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGananciaDia.Location = new System.Drawing.Point(57, 298);
            this.LblGananciaDia.Name = "LblGananciaDia";
            this.LblGananciaDia.Size = new System.Drawing.Size(163, 27);
            this.LblGananciaDia.TabIndex = 3;
            this.LblGananciaDia.Text = "Ganancia del dia";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(893, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "GANANCIAS POR FECHA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "GANANCIAS DEL DIA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblListaReportes
            // 
            this.tblListaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaReportes.Location = new System.Drawing.Point(6, 6);
            this.tblListaReportes.Name = "tblListaReportes";
            this.tblListaReportes.Size = new System.Drawing.Size(1025, 283);
            this.tblListaReportes.TabIndex = 0;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(926, 13);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(97, 38);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "AFORO";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(851, 49);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(55, 23);
            this.LblFecha.TabIndex = 4;
            this.LblFecha.Text = "Fecha";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 484);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.principal_FormClosed_1);
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GrpEspecifica.ResumeLayout(false);
            this.GrpEspecifica.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblListaTemporal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GrpEspecifica;
        private System.Windows.Forms.TextBox txtPrecioEspecifi;
        private System.Windows.Forms.TextBox txtNombreEspecifi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdoVaron;
        private System.Windows.Forms.RadioButton rdoMujer;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCandado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoEspecifica;
        private System.Windows.Forms.RadioButton rdoGeneral;
        private System.Windows.Forms.RadioButton rdoNiño;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.DataGridView tblListaTemporal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscaFecha;
        private System.Windows.Forms.TextBox txtBuscaCandado;
        private System.Windows.Forms.TextBox txtBuscaNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tblListaReportes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblGananciaDia;
        private System.Windows.Forms.Label label5;
    }
}