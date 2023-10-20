namespace laboratorio_3_A.S
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantJugador = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnIngresarCorreos = new System.Windows.Forms.Button();
            this.btnIngresarEndulzada = new System.Windows.Forms.Button();
            this.btnIngresarRegalo = new System.Windows.Forms.Button();
            this.lbInfJugador = new System.Windows.Forms.ListBox();
            this.btnInfJugador = new System.Windows.Forms.Button();
            this.btnAmigoSecreto = new System.Windows.Forms.Button();
            this.frecuencia = new System.Windows.Forms.NumericUpDown();
            this.fechaActual = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnProximaEndulzada = new System.Windows.Forms.Button();
            this.lblproxEndul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVregalo = new System.Windows.Forms.TextBox();
            this.txtVendulzada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de jugadores ";
            // 
            // txtCantJugador
            // 
            this.txtCantJugador.Location = new System.Drawing.Point(64, 45);
            this.txtCantJugador.Name = "txtCantJugador";
            this.txtCantJugador.Size = new System.Drawing.Size(100, 20);
            this.txtCantJugador.TabIndex = 1;
            this.txtCantJugador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantJugador_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(40, 80);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(140, 37);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar nombres";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnIngresarCorreos
            // 
            this.btnIngresarCorreos.Location = new System.Drawing.Point(40, 135);
            this.btnIngresarCorreos.Name = "btnIngresarCorreos";
            this.btnIngresarCorreos.Size = new System.Drawing.Size(140, 37);
            this.btnIngresarCorreos.TabIndex = 3;
            this.btnIngresarCorreos.Text = "Ingresar correos";
            this.btnIngresarCorreos.UseVisualStyleBackColor = true;
            this.btnIngresarCorreos.Click += new System.EventHandler(this.btnIngresarCorreos_Click);
            // 
            // btnIngresarEndulzada
            // 
            this.btnIngresarEndulzada.Location = new System.Drawing.Point(40, 192);
            this.btnIngresarEndulzada.Name = "btnIngresarEndulzada";
            this.btnIngresarEndulzada.Size = new System.Drawing.Size(140, 37);
            this.btnIngresarEndulzada.TabIndex = 4;
            this.btnIngresarEndulzada.Text = "Ingresar endulzada ideal";
            this.btnIngresarEndulzada.UseVisualStyleBackColor = true;
            this.btnIngresarEndulzada.Click += new System.EventHandler(this.btnIngresarEndulzada_Click);
            // 
            // btnIngresarRegalo
            // 
            this.btnIngresarRegalo.Location = new System.Drawing.Point(40, 247);
            this.btnIngresarRegalo.Name = "btnIngresarRegalo";
            this.btnIngresarRegalo.Size = new System.Drawing.Size(140, 37);
            this.btnIngresarRegalo.TabIndex = 5;
            this.btnIngresarRegalo.Text = "Ingresar regalo ideal";
            this.btnIngresarRegalo.UseVisualStyleBackColor = true;
            this.btnIngresarRegalo.Click += new System.EventHandler(this.btnIngresarRegalo_Click);
            // 
            // lbInfJugador
            // 
            this.lbInfJugador.FormattingEnabled = true;
            this.lbInfJugador.Location = new System.Drawing.Point(238, 45);
            this.lbInfJugador.Name = "lbInfJugador";
            this.lbInfJugador.Size = new System.Drawing.Size(715, 186);
            this.lbInfJugador.TabIndex = 6;
            // 
            // btnInfJugador
            // 
            this.btnInfJugador.Location = new System.Drawing.Point(349, 247);
            this.btnInfJugador.Name = "btnInfJugador";
            this.btnInfJugador.Size = new System.Drawing.Size(233, 45);
            this.btnInfJugador.TabIndex = 7;
            this.btnInfJugador.Text = "Mostrar informacion de jugadores";
            this.btnInfJugador.UseVisualStyleBackColor = true;
            this.btnInfJugador.Click += new System.EventHandler(this.btnInfJugador_Click);
            // 
            // btnAmigoSecreto
            // 
            this.btnAmigoSecreto.Location = new System.Drawing.Point(695, 247);
            this.btnAmigoSecreto.Name = "btnAmigoSecreto";
            this.btnAmigoSecreto.Size = new System.Drawing.Size(233, 45);
            this.btnAmigoSecreto.TabIndex = 8;
            this.btnAmigoSecreto.Text = "Generar amigo secreto";
            this.btnAmigoSecreto.UseVisualStyleBackColor = true;
            this.btnAmigoSecreto.Click += new System.EventHandler(this.btnAmigoSecreto_Click);
            // 
            // frecuencia
            // 
            this.frecuencia.Location = new System.Drawing.Point(576, 439);
            this.frecuencia.Name = "frecuencia";
            this.frecuencia.Size = new System.Drawing.Size(139, 20);
            this.frecuencia.TabIndex = 22;
            // 
            // fechaActual
            // 
            this.fechaActual.CustomFormat = "dd/MM/yyyy";
            this.fechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaActual.Location = new System.Drawing.Point(20, 586);
            this.fechaActual.Name = "fechaActual";
            this.fechaActual.Size = new System.Drawing.Size(200, 20);
            this.fechaActual.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 52);
            this.label2.TabIndex = 20;
            this.label2.Text = "porfavor ingrese la fecha de hoy \r\npara calcular cuantos dias faltan \r\npara la pr" +
    "oxima endulzada\r\n\r\n";
            // 
            // fechaFin
            // 
            this.fechaFin.CustomFormat = "dd/MM/yyyy";
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFin.Location = new System.Drawing.Point(258, 439);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 20);
            this.fechaFin.TabIndex = 19;
            // 
            // fechaInicio
            // 
            this.fechaInicio.CustomFormat = "dd/MM/yyyy";
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio.Location = new System.Drawing.Point(29, 439);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.fechaInicio.TabIndex = 18;
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(524, 395);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(256, 13);
            this.lblFrecuencia.TabIndex = 17;
            this.lblFrecuencia.Text = "porfavor ingrese la frecuencia de endulzadas en dias";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(255, 395);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(243, 26);
            this.lblFechaFin.TabIndex = 16;
            this.lblFechaFin.Text = "porfavor ingrese la fecha de finalizacion del juego \r\nen el formato dd/mm/yy\r\n";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(26, 395);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(212, 26);
            this.lblFechaInicio.TabIndex = 15;
            this.lblFechaInicio.Text = "porfavor ingrese la fecha de inicio del juego\r\nen el formato dd/mm/yy\r\n";
            // 
            // btnProximaEndulzada
            // 
            this.btnProximaEndulzada.Location = new System.Drawing.Point(281, 521);
            this.btnProximaEndulzada.Name = "btnProximaEndulzada";
            this.btnProximaEndulzada.Size = new System.Drawing.Size(155, 54);
            this.btnProximaEndulzada.TabIndex = 14;
            this.btnProximaEndulzada.Text = "proxima endulzada ";
            this.btnProximaEndulzada.UseVisualStyleBackColor = true;
            this.btnProximaEndulzada.Click += new System.EventHandler(this.btnProximaEndulzada_Click);
            // 
            // lblproxEndul
            // 
            this.lblproxEndul.AutoSize = true;
            this.lblproxEndul.Location = new System.Drawing.Point(498, 542);
            this.lblproxEndul.Name = "lblproxEndul";
            this.lblproxEndul.Size = new System.Drawing.Size(0, 13);
            this.lblproxEndul.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "GENERADOR DE AMIGO SECRETO\r\n";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 314);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(167, 13);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Ingrese el valor de las endulzadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ingrese el valor el regalo";
            // 
            // txtVregalo
            // 
            this.txtVregalo.Location = new System.Drawing.Point(165, 348);
            this.txtVregalo.Name = "txtVregalo";
            this.txtVregalo.Size = new System.Drawing.Size(100, 20);
            this.txtVregalo.TabIndex = 26;
            this.txtVregalo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVregalo_KeyPress);
            // 
            // txtVendulzada
            // 
            this.txtVendulzada.Location = new System.Drawing.Point(210, 311);
            this.txtVendulzada.Name = "txtVendulzada";
            this.txtVendulzada.Size = new System.Drawing.Size(100, 20);
            this.txtVendulzada.TabIndex = 27;
            this.txtVendulzada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendulzada_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 749);
            this.Controls.Add(this.txtVendulzada);
            this.Controls.Add(this.txtVregalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frecuencia);
            this.Controls.Add(this.fechaActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnProximaEndulzada);
            this.Controls.Add(this.lblproxEndul);
            this.Controls.Add(this.btnAmigoSecreto);
            this.Controls.Add(this.btnInfJugador);
            this.Controls.Add(this.lbInfJugador);
            this.Controls.Add(this.btnIngresarRegalo);
            this.Controls.Add(this.btnIngresarEndulzada);
            this.Controls.Add(this.btnIngresarCorreos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCantJugador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantJugador;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnIngresarCorreos;
        private System.Windows.Forms.Button btnIngresarEndulzada;
        private System.Windows.Forms.Button btnIngresarRegalo;
        private System.Windows.Forms.ListBox lbInfJugador;
        private System.Windows.Forms.Button btnInfJugador;
        private System.Windows.Forms.Button btnAmigoSecreto;
        private System.Windows.Forms.NumericUpDown frecuencia;
        private System.Windows.Forms.DateTimePicker fechaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnProximaEndulzada;
        private System.Windows.Forms.Label lblproxEndul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVregalo;
        private System.Windows.Forms.TextBox txtVendulzada;
    }
}

