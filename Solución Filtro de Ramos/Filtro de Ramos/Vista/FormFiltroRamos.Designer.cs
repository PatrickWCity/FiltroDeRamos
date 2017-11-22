namespace Filtro_de_Ramos.Vista
{
    partial class FormFiltroRamos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.B_Refrescar = new System.Windows.Forms.Button();
            this.B_BN = new System.Windows.Forms.Button();
            this.L_ZonaMensaje = new System.Windows.Forms.Label();
            this.TCB_Ramo = new System.Windows.Forms.CheckBox();
            this.TCB_Sala = new System.Windows.Forms.CheckBox();
            this.CB_Carrera = new System.Windows.Forms.ComboBox();
            this.CB_Sede = new System.Windows.Forms.ComboBox();
            this.CB_Escuela = new System.Windows.Forms.ComboBox();
            this.CB_Sala = new System.Windows.Forms.ComboBox();
            this.CB_Seccion = new System.Windows.Forms.ComboBox();
            this.CB_Semestre = new System.Windows.Forms.ComboBox();
            this.CB_Ramo = new System.Windows.Forms.ComboBox();
            this.TCB_Semestre = new System.Windows.Forms.CheckBox();
            this.TCB_Seccion = new System.Windows.Forms.CheckBox();
            this.TCB_Escuela = new System.Windows.Forms.CheckBox();
            this.TCB_Sede = new System.Windows.Forms.CheckBox();
            this.TCB_Carrera = new System.Windows.Forms.CheckBox();
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_Restablacer = new System.Windows.Forms.Button();
            this.bindingSourceCarrera = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEscuela = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRamo = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSala = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSeccion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSede = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSemestre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEscuela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // B_Refrescar
            // 
            this.B_Refrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Refrescar.AutoSize = true;
            this.B_Refrescar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Refrescar.Image = global::Filtro_de_Ramos.Properties.Resources.refresh;
            this.B_Refrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Refrescar.Location = new System.Drawing.Point(528, 152);
            this.B_Refrescar.Name = "B_Refrescar";
            this.B_Refrescar.Size = new System.Drawing.Size(141, 29);
            this.B_Refrescar.TabIndex = 4;
            this.B_Refrescar.Text = "Refrescar";
            this.B_Refrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Refrescar.UseVisualStyleBackColor = true;
            this.B_Refrescar.Click += new System.EventHandler(this.B_Refrescar_Click);
            // 
            // B_BN
            // 
            this.B_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_BN.AutoSize = true;
            this.B_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_BN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BN.Location = new System.Drawing.Point(618, 520);
            this.B_BN.Name = "B_BN";
            this.B_BN.Size = new System.Drawing.Size(51, 29);
            this.B_BN.TabIndex = 39;
            this.B_BN.Text = "B/N";
            this.B_BN.UseVisualStyleBackColor = true;
            this.B_BN.Click += new System.EventHandler(this.B_BN_Click);
            // 
            // L_ZonaMensaje
            // 
            this.L_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_ZonaMensaje.AutoSize = true;
            this.L_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ZonaMensaje.Location = new System.Drawing.Point(12, 525);
            this.L_ZonaMensaje.Name = "L_ZonaMensaje";
            this.L_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.L_ZonaMensaje.TabIndex = 53;
            this.L_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // TCB_Ramo
            // 
            this.TCB_Ramo.AutoSize = true;
            this.TCB_Ramo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Ramo.Location = new System.Drawing.Point(12, 16);
            this.TCB_Ramo.Name = "TCB_Ramo";
            this.TCB_Ramo.Size = new System.Drawing.Size(162, 23);
            this.TCB_Ramo.TabIndex = 54;
            this.TCB_Ramo.Text = "Filtrar por Ramo";
            this.TCB_Ramo.UseVisualStyleBackColor = true;
            // 
            // TCB_Sala
            // 
            this.TCB_Sala.AutoSize = true;
            this.TCB_Sala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Sala.Location = new System.Drawing.Point(12, 121);
            this.TCB_Sala.Name = "TCB_Sala";
            this.TCB_Sala.Size = new System.Drawing.Size(150, 23);
            this.TCB_Sala.TabIndex = 55;
            this.TCB_Sala.Text = "Filtrar por Sala";
            this.TCB_Sala.UseVisualStyleBackColor = true;
            // 
            // CB_Carrera
            // 
            this.CB_Carrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Carrera.FormattingEnabled = true;
            this.CB_Carrera.Location = new System.Drawing.Point(209, 224);
            this.CB_Carrera.Name = "CB_Carrera";
            this.CB_Carrera.Size = new System.Drawing.Size(313, 27);
            this.CB_Carrera.TabIndex = 62;
            // 
            // CB_Sede
            // 
            this.CB_Sede.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sede.FormattingEnabled = true;
            this.CB_Sede.Location = new System.Drawing.Point(209, 188);
            this.CB_Sede.Name = "CB_Sede";
            this.CB_Sede.Size = new System.Drawing.Size(313, 27);
            this.CB_Sede.TabIndex = 61;
            // 
            // CB_Escuela
            // 
            this.CB_Escuela.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Escuela.FormattingEnabled = true;
            this.CB_Escuela.Location = new System.Drawing.Point(209, 152);
            this.CB_Escuela.Name = "CB_Escuela";
            this.CB_Escuela.Size = new System.Drawing.Size(313, 27);
            this.CB_Escuela.TabIndex = 60;
            // 
            // CB_Sala
            // 
            this.CB_Sala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sala.FormattingEnabled = true;
            this.CB_Sala.Location = new System.Drawing.Point(209, 116);
            this.CB_Sala.Name = "CB_Sala";
            this.CB_Sala.Size = new System.Drawing.Size(313, 27);
            this.CB_Sala.TabIndex = 59;
            // 
            // CB_Seccion
            // 
            this.CB_Seccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Seccion.FormattingEnabled = true;
            this.CB_Seccion.Location = new System.Drawing.Point(209, 80);
            this.CB_Seccion.Name = "CB_Seccion";
            this.CB_Seccion.Size = new System.Drawing.Size(313, 27);
            this.CB_Seccion.TabIndex = 58;
            // 
            // CB_Semestre
            // 
            this.CB_Semestre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Semestre.FormattingEnabled = true;
            this.CB_Semestre.Location = new System.Drawing.Point(209, 44);
            this.CB_Semestre.Name = "CB_Semestre";
            this.CB_Semestre.Size = new System.Drawing.Size(313, 27);
            this.CB_Semestre.TabIndex = 57;
            // 
            // CB_Ramo
            // 
            this.CB_Ramo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ramo.FormattingEnabled = true;
            this.CB_Ramo.Location = new System.Drawing.Point(209, 8);
            this.CB_Ramo.Name = "CB_Ramo";
            this.CB_Ramo.Size = new System.Drawing.Size(313, 27);
            this.CB_Ramo.TabIndex = 56;
            // 
            // TCB_Semestre
            // 
            this.TCB_Semestre.AutoSize = true;
            this.TCB_Semestre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Semestre.Location = new System.Drawing.Point(11, 46);
            this.TCB_Semestre.Name = "TCB_Semestre";
            this.TCB_Semestre.Size = new System.Drawing.Size(192, 23);
            this.TCB_Semestre.TabIndex = 63;
            this.TCB_Semestre.Text = "Filtrar por Semestre";
            this.TCB_Semestre.UseVisualStyleBackColor = true;
            // 
            // TCB_Seccion
            // 
            this.TCB_Seccion.AutoSize = true;
            this.TCB_Seccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Seccion.Location = new System.Drawing.Point(12, 82);
            this.TCB_Seccion.Name = "TCB_Seccion";
            this.TCB_Seccion.Size = new System.Drawing.Size(176, 23);
            this.TCB_Seccion.TabIndex = 64;
            this.TCB_Seccion.Text = "Filtrar por Seccion";
            this.TCB_Seccion.UseVisualStyleBackColor = true;
            // 
            // TCB_Escuela
            // 
            this.TCB_Escuela.AutoSize = true;
            this.TCB_Escuela.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Escuela.Location = new System.Drawing.Point(12, 154);
            this.TCB_Escuela.Name = "TCB_Escuela";
            this.TCB_Escuela.Size = new System.Drawing.Size(176, 23);
            this.TCB_Escuela.TabIndex = 65;
            this.TCB_Escuela.Text = "Filtrar por Escuela";
            this.TCB_Escuela.UseVisualStyleBackColor = true;
            // 
            // TCB_Sede
            // 
            this.TCB_Sede.AutoSize = true;
            this.TCB_Sede.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Sede.Location = new System.Drawing.Point(12, 190);
            this.TCB_Sede.Name = "TCB_Sede";
            this.TCB_Sede.Size = new System.Drawing.Size(155, 23);
            this.TCB_Sede.TabIndex = 66;
            this.TCB_Sede.Text = "Filtrar por Sede";
            this.TCB_Sede.UseVisualStyleBackColor = true;
            // 
            // TCB_Carrera
            // 
            this.TCB_Carrera.AutoSize = true;
            this.TCB_Carrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCB_Carrera.Location = new System.Drawing.Point(12, 226);
            this.TCB_Carrera.Name = "TCB_Carrera";
            this.TCB_Carrera.Size = new System.Drawing.Size(177, 23);
            this.TCB_Carrera.TabIndex = 67;
            this.TCB_Carrera.Text = "Filtrar por Carrera";
            this.TCB_Carrera.UseVisualStyleBackColor = true;
            // 
            // B_Salir
            // 
            this.B_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Salir.AutoSize = true;
            this.B_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Salir.Image = global::Filtro_de_Ramos.Properties.Resources.times;
            this.B_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Salir.Location = new System.Drawing.Point(528, 221);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(141, 30);
            this.B_Salir.TabIndex = 69;
            this.B_Salir.Text = "Salir";
            this.B_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Salir.UseVisualStyleBackColor = true;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // B_Restablacer
            // 
            this.B_Restablacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Restablacer.AutoSize = true;
            this.B_Restablacer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Restablacer.Image = global::Filtro_de_Ramos.Properties.Resources.eraser;
            this.B_Restablacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Restablacer.Location = new System.Drawing.Point(528, 183);
            this.B_Restablacer.Name = "B_Restablacer";
            this.B_Restablacer.Size = new System.Drawing.Size(141, 30);
            this.B_Restablacer.TabIndex = 68;
            this.B_Restablacer.Text = "Restablecer";
            this.B_Restablacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Restablacer.UseVisualStyleBackColor = true;
            this.B_Restablacer.Click += new System.EventHandler(this.B_Restablacer_Click);
            // 
            // FormFiltroRamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 561);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Restablacer);
            this.Controls.Add(this.TCB_Carrera);
            this.Controls.Add(this.TCB_Sede);
            this.Controls.Add(this.TCB_Escuela);
            this.Controls.Add(this.TCB_Seccion);
            this.Controls.Add(this.TCB_Semestre);
            this.Controls.Add(this.CB_Carrera);
            this.Controls.Add(this.CB_Sede);
            this.Controls.Add(this.CB_Escuela);
            this.Controls.Add(this.CB_Sala);
            this.Controls.Add(this.CB_Seccion);
            this.Controls.Add(this.CB_Semestre);
            this.Controls.Add(this.CB_Ramo);
            this.Controls.Add(this.TCB_Sala);
            this.Controls.Add(this.TCB_Ramo);
            this.Controls.Add(this.L_ZonaMensaje);
            this.Controls.Add(this.B_BN);
            this.Controls.Add(this.B_Refrescar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(697, 371);
            this.Name = "FormFiltroRamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFiltroRamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEscuela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button B_Refrescar;
        private System.Windows.Forms.Button B_BN;
        private System.Windows.Forms.Label L_ZonaMensaje;
        private System.Windows.Forms.CheckBox TCB_Ramo;
        private System.Windows.Forms.CheckBox TCB_Sala;
        private System.Windows.Forms.ComboBox CB_Carrera;
        private System.Windows.Forms.ComboBox CB_Sede;
        private System.Windows.Forms.ComboBox CB_Escuela;
        private System.Windows.Forms.ComboBox CB_Sala;
        private System.Windows.Forms.ComboBox CB_Seccion;
        private System.Windows.Forms.ComboBox CB_Semestre;
        private System.Windows.Forms.ComboBox CB_Ramo;
        private System.Windows.Forms.CheckBox TCB_Semestre;
        private System.Windows.Forms.CheckBox TCB_Seccion;
        private System.Windows.Forms.CheckBox TCB_Escuela;
        private System.Windows.Forms.CheckBox TCB_Sede;
        private System.Windows.Forms.CheckBox TCB_Carrera;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Button B_Restablacer;
        private System.Windows.Forms.BindingSource bindingSourceCarrera;
        private System.Windows.Forms.BindingSource bindingSourceEscuela;
        private System.Windows.Forms.BindingSource bindingSourceRamo;
        private System.Windows.Forms.BindingSource bindingSourceSala;
        private System.Windows.Forms.BindingSource bindingSourceSeccion;
        private System.Windows.Forms.BindingSource bindingSourceSede;
        private System.Windows.Forms.BindingSource bindingSourceSemestre;
    }
}