namespace clase_persona_herencia
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
            this.tres_opciones = new System.Windows.Forms.GroupBox();
            this.es_persona = new System.Windows.Forms.RadioButton();
            this.validar = new System.Windows.Forms.Button();
            this.es_un_docente = new System.Windows.Forms.RadioButton();
            this.es_alumno = new System.Windows.Forms.RadioButton();
            this.es_empleado = new System.Windows.Forms.RadioButton();
            this.informacion = new System.Windows.Forms.GroupBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.carrera_puesto = new System.Windows.Forms.TextBox();
            this.dni_matricula = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.fecha_de_nacimiento = new System.Windows.Forms.TextBox();
            this.nombre_completo = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.limpiarinfo = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tres_opciones.SuspendLayout();
            this.informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tres_opciones
            // 
            this.tres_opciones.Controls.Add(this.es_persona);
            this.tres_opciones.Controls.Add(this.validar);
            this.tres_opciones.Controls.Add(this.es_un_docente);
            this.tres_opciones.Controls.Add(this.es_alumno);
            this.tres_opciones.Controls.Add(this.es_empleado);
            this.tres_opciones.Location = new System.Drawing.Point(424, 15);
            this.tres_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.tres_opciones.Name = "tres_opciones";
            this.tres_opciones.Padding = new System.Windows.Forms.Padding(4);
            this.tres_opciones.Size = new System.Drawing.Size(296, 369);
            this.tres_opciones.TabIndex = 1;
            this.tres_opciones.TabStop = false;
            // 
            // es_persona
            // 
            this.es_persona.AutoSize = true;
            this.es_persona.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.es_persona.Location = new System.Drawing.Point(8, 169);
            this.es_persona.Margin = new System.Windows.Forms.Padding(4);
            this.es_persona.Name = "es_persona";
            this.es_persona.Size = new System.Drawing.Size(262, 40);
            this.es_persona.TabIndex = 4;
            this.es_persona.TabStop = true;
            this.es_persona.Text = "Soy una persona";
            this.es_persona.UseVisualStyleBackColor = true;
            // 
            // validar
            // 
            this.validar.BackColor = System.Drawing.Color.HotPink;
            this.validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar.Location = new System.Drawing.Point(69, 254);
            this.validar.Margin = new System.Windows.Forms.Padding(4);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(184, 82);
            this.validar.TabIndex = 3;
            this.validar.Text = "VALIDAR";
            this.validar.UseVisualStyleBackColor = false;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // es_un_docente
            // 
            this.es_un_docente.AutoSize = true;
            this.es_un_docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.es_un_docente.Location = new System.Drawing.Point(9, 121);
            this.es_un_docente.Margin = new System.Windows.Forms.Padding(4);
            this.es_un_docente.Name = "es_un_docente";
            this.es_un_docente.Size = new System.Drawing.Size(244, 40);
            this.es_un_docente.TabIndex = 2;
            this.es_un_docente.TabStop = true;
            this.es_un_docente.Text = "Soy un docente";
            this.es_un_docente.UseVisualStyleBackColor = true;
            this.es_un_docente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // es_alumno
            // 
            this.es_alumno.AutoSize = true;
            this.es_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.es_alumno.Location = new System.Drawing.Point(9, 73);
            this.es_alumno.Margin = new System.Windows.Forms.Padding(4);
            this.es_alumno.Name = "es_alumno";
            this.es_alumno.Size = new System.Drawing.Size(235, 40);
            this.es_alumno.TabIndex = 1;
            this.es_alumno.TabStop = true;
            this.es_alumno.Text = "Soy un alumno";
            this.es_alumno.UseVisualStyleBackColor = true;
            this.es_alumno.CheckedChanged += new System.EventHandler(this.es_alumno_CheckedChanged);
            // 
            // es_empleado
            // 
            this.es_empleado.AutoSize = true;
            this.es_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.es_empleado.Location = new System.Drawing.Point(9, 25);
            this.es_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.es_empleado.Name = "es_empleado";
            this.es_empleado.Size = new System.Drawing.Size(267, 40);
            this.es_empleado.TabIndex = 0;
            this.es_empleado.TabStop = true;
            this.es_empleado.Text = "Soy un empleado";
            this.es_empleado.UseVisualStyleBackColor = true;
            this.es_empleado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // informacion
            // 
            this.informacion.Controls.Add(this.sueldo);
            this.informacion.Controls.Add(this.carrera_puesto);
            this.informacion.Controls.Add(this.dni_matricula);
            this.informacion.Controls.Add(this.edad);
            this.informacion.Controls.Add(this.fecha_de_nacimiento);
            this.informacion.Controls.Add(this.nombre_completo);
            this.informacion.Controls.Add(this.salir);
            this.informacion.Controls.Add(this.limpiarinfo);
            this.informacion.Controls.Add(this.guardar);
            this.informacion.Controls.Add(this.label6);
            this.informacion.Controls.Add(this.label5);
            this.informacion.Controls.Add(this.label4);
            this.informacion.Controls.Add(this.label3);
            this.informacion.Controls.Add(this.label2);
            this.informacion.Controls.Add(this.label1);
            this.informacion.Location = new System.Drawing.Point(16, 405);
            this.informacion.Margin = new System.Windows.Forms.Padding(4);
            this.informacion.Name = "informacion";
            this.informacion.Padding = new System.Windows.Forms.Padding(4);
            this.informacion.Size = new System.Drawing.Size(489, 298);
            this.informacion.TabIndex = 2;
            this.informacion.TabStop = false;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(207, 192);
            this.sueldo.Margin = new System.Windows.Forms.Padding(4);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(265, 22);
            this.sueldo.TabIndex = 16;
            // 
            // carrera_puesto
            // 
            this.carrera_puesto.Location = new System.Drawing.Point(207, 160);
            this.carrera_puesto.Margin = new System.Windows.Forms.Padding(4);
            this.carrera_puesto.Name = "carrera_puesto";
            this.carrera_puesto.Size = new System.Drawing.Size(265, 22);
            this.carrera_puesto.TabIndex = 15;
            // 
            // dni_matricula
            // 
            this.dni_matricula.Location = new System.Drawing.Point(207, 128);
            this.dni_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.dni_matricula.Name = "dni_matricula";
            this.dni_matricula.Size = new System.Drawing.Size(265, 22);
            this.dni_matricula.TabIndex = 14;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(207, 96);
            this.edad.Margin = new System.Windows.Forms.Padding(4);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(265, 22);
            this.edad.TabIndex = 13;
            // 
            // fecha_de_nacimiento
            // 
            this.fecha_de_nacimiento.Location = new System.Drawing.Point(207, 64);
            this.fecha_de_nacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.fecha_de_nacimiento.Name = "fecha_de_nacimiento";
            this.fecha_de_nacimiento.Size = new System.Drawing.Size(265, 22);
            this.fecha_de_nacimiento.TabIndex = 12;
            // 
            // nombre_completo
            // 
            this.nombre_completo.Location = new System.Drawing.Point(207, 32);
            this.nombre_completo.Margin = new System.Windows.Forms.Padding(4);
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.Size = new System.Drawing.Size(265, 22);
            this.nombre_completo.TabIndex = 11;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LavenderBlush;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(335, 235);
            this.salir.Margin = new System.Windows.Forms.Padding(4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(139, 55);
            this.salir.TabIndex = 10;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiarinfo
            // 
            this.limpiarinfo.BackColor = System.Drawing.Color.LightPink;
            this.limpiarinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarinfo.Location = new System.Drawing.Point(171, 235);
            this.limpiarinfo.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarinfo.Name = "limpiarinfo";
            this.limpiarinfo.Size = new System.Drawing.Size(139, 55);
            this.limpiarinfo.TabIndex = 9;
            this.limpiarinfo.Text = "LIMPIAR";
            this.limpiarinfo.UseVisualStyleBackColor = false;
            this.limpiarinfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Thistle;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(8, 235);
            this.guardar.Margin = new System.Windows.Forms.Padding(4);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(139, 55);
            this.guardar.TabIndex = 4;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sueldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Carrera / Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI / Matrícula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::clase_persona_herencia.Properties.Resources.alumnoo;
            this.pictureBox1.InitialImage = global::clase_persona_herencia.Properties.Resources.alumnoo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 369);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(736, 746);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.tres_opciones);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tres_opciones.ResumeLayout(false);
            this.tres_opciones.PerformLayout();
            this.informacion.ResumeLayout(false);
            this.informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox tres_opciones;
        private System.Windows.Forms.RadioButton es_un_docente;
        private System.Windows.Forms.RadioButton es_alumno;
        private System.Windows.Forms.RadioButton es_empleado;
        private System.Windows.Forms.GroupBox informacion;
        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sueldo;
        private System.Windows.Forms.TextBox carrera_puesto;
        private System.Windows.Forms.TextBox dni_matricula;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox fecha_de_nacimiento;
        private System.Windows.Forms.TextBox nombre_completo;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiarinfo;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.RadioButton es_persona;
    }
}

