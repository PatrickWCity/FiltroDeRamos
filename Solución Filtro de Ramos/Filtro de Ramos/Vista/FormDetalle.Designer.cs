namespace Filtro_de_Ramos.Vista
{
    partial class FormDetalle
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
            this.B_BN = new System.Windows.Forms.Button();
            this.L_ZonaMensaje = new System.Windows.Forms.Label();
            this.L_Semestre = new System.Windows.Forms.Label();
            this.L_Ramo = new System.Windows.Forms.Label();
            this.DGV_Tabla = new System.Windows.Forms.DataGridView();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.L_Id = new System.Windows.Forms.Label();
            this.L_Sala = new System.Windows.Forms.Label();
            this.L_Seccion = new System.Windows.Forms.Label();
            this.L_Carrera = new System.Windows.Forms.Label();
            this.L_Sede = new System.Windows.Forms.Label();
            this.L_Escuela = new System.Windows.Forms.Label();
            this.CB_Ramo = new System.Windows.Forms.ComboBox();
            this.CB_Semestre = new System.Windows.Forms.ComboBox();
            this.CB_Seccion = new System.Windows.Forms.ComboBox();
            this.CB_Sala = new System.Windows.Forms.ComboBox();
            this.CB_Escuela = new System.Windows.Forms.ComboBox();
            this.CB_Sede = new System.Windows.Forms.ComboBox();
            this.CB_Carrera = new System.Windows.Forms.ComboBox();
            this.B_ConsiltarPorTodos = new System.Windows.Forms.Button();
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_Restablacer = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Actualizar = new System.Windows.Forms.Button();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.bindingSourceCarrera = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEscuela = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRamo = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSala = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSeccion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSede = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSemestre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEscuela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // B_BN
            // 
            this.B_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_BN.AutoSize = true;
            this.B_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_BN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BN.Location = new System.Drawing.Point(618, 439);
            this.B_BN.Name = "B_BN";
            this.B_BN.Size = new System.Drawing.Size(51, 29);
            this.B_BN.TabIndex = 38;
            this.B_BN.Text = "B/N";
            this.B_BN.UseVisualStyleBackColor = true;
            this.B_BN.Click += new System.EventHandler(this.B_BN_Click);
            // 
            // L_ZonaMensaje
            // 
            this.L_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_ZonaMensaje.AutoSize = true;
            this.L_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ZonaMensaje.Location = new System.Drawing.Point(12, 444);
            this.L_ZonaMensaje.Name = "L_ZonaMensaje";
            this.L_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.L_ZonaMensaje.TabIndex = 37;
            this.L_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // L_Semestre
            // 
            this.L_Semestre.AutoSize = true;
            this.L_Semestre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Semestre.Location = new System.Drawing.Point(12, 90);
            this.L_Semestre.Name = "L_Semestre";
            this.L_Semestre.Size = new System.Drawing.Size(86, 19);
            this.L_Semestre.TabIndex = 28;
            this.L_Semestre.Text = "Semestre";
            // 
            // L_Ramo
            // 
            this.L_Ramo.AutoSize = true;
            this.L_Ramo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ramo.Location = new System.Drawing.Point(12, 54);
            this.L_Ramo.Name = "L_Ramo";
            this.L_Ramo.Size = new System.Drawing.Size(56, 19);
            this.L_Ramo.TabIndex = 24;
            this.L_Ramo.Text = "Ramo";
            // 
            // DGV_Tabla
            // 
            this.DGV_Tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tabla.Location = new System.Drawing.Point(12, 300);
            this.DGV_Tabla.Name = "DGV_Tabla";
            this.DGV_Tabla.Size = new System.Drawing.Size(657, 133);
            this.DGV_Tabla.TabIndex = 23;
            this.DGV_Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Tabla_CellClick);
            // 
            // TB_Id
            // 
            this.TB_Id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Id.Location = new System.Drawing.Point(120, 15);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(100, 27);
            this.TB_Id.TabIndex = 22;
            // 
            // L_Id
            // 
            this.L_Id.AutoSize = true;
            this.L_Id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Id.Location = new System.Drawing.Point(12, 18);
            this.L_Id.Name = "L_Id";
            this.L_Id.Size = new System.Drawing.Size(28, 19);
            this.L_Id.TabIndex = 20;
            this.L_Id.Text = "ID";
            // 
            // L_Sala
            // 
            this.L_Sala.AutoSize = true;
            this.L_Sala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Sala.Location = new System.Drawing.Point(12, 162);
            this.L_Sala.Name = "L_Sala";
            this.L_Sala.Size = new System.Drawing.Size(44, 19);
            this.L_Sala.TabIndex = 41;
            this.L_Sala.Text = "Sala";
            // 
            // L_Seccion
            // 
            this.L_Seccion.AutoSize = true;
            this.L_Seccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Seccion.Location = new System.Drawing.Point(13, 126);
            this.L_Seccion.Name = "L_Seccion";
            this.L_Seccion.Size = new System.Drawing.Size(70, 19);
            this.L_Seccion.TabIndex = 39;
            this.L_Seccion.Text = "Seccion";
            // 
            // L_Carrera
            // 
            this.L_Carrera.AutoSize = true;
            this.L_Carrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Carrera.Location = new System.Drawing.Point(12, 270);
            this.L_Carrera.Name = "L_Carrera";
            this.L_Carrera.Size = new System.Drawing.Size(71, 19);
            this.L_Carrera.TabIndex = 47;
            this.L_Carrera.Text = "Carrera";
            // 
            // L_Sede
            // 
            this.L_Sede.AutoSize = true;
            this.L_Sede.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Sede.Location = new System.Drawing.Point(12, 234);
            this.L_Sede.Name = "L_Sede";
            this.L_Sede.Size = new System.Drawing.Size(49, 19);
            this.L_Sede.TabIndex = 45;
            this.L_Sede.Text = "Sede";
            // 
            // L_Escuela
            // 
            this.L_Escuela.AutoSize = true;
            this.L_Escuela.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Escuela.Location = new System.Drawing.Point(12, 198);
            this.L_Escuela.Name = "L_Escuela";
            this.L_Escuela.Size = new System.Drawing.Size(70, 19);
            this.L_Escuela.TabIndex = 43;
            this.L_Escuela.Text = "Escuela";
            // 
            // CB_Ramo
            // 
            this.CB_Ramo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ramo.FormattingEnabled = true;
            this.CB_Ramo.Location = new System.Drawing.Point(120, 51);
            this.CB_Ramo.Name = "CB_Ramo";
            this.CB_Ramo.Size = new System.Drawing.Size(338, 27);
            this.CB_Ramo.TabIndex = 49;
            // 
            // CB_Semestre
            // 
            this.CB_Semestre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Semestre.FormattingEnabled = true;
            this.CB_Semestre.Location = new System.Drawing.Point(120, 87);
            this.CB_Semestre.Name = "CB_Semestre";
            this.CB_Semestre.Size = new System.Drawing.Size(338, 27);
            this.CB_Semestre.TabIndex = 50;
            // 
            // CB_Seccion
            // 
            this.CB_Seccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Seccion.FormattingEnabled = true;
            this.CB_Seccion.Location = new System.Drawing.Point(120, 123);
            this.CB_Seccion.Name = "CB_Seccion";
            this.CB_Seccion.Size = new System.Drawing.Size(338, 27);
            this.CB_Seccion.TabIndex = 51;
            // 
            // CB_Sala
            // 
            this.CB_Sala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sala.FormattingEnabled = true;
            this.CB_Sala.Location = new System.Drawing.Point(120, 159);
            this.CB_Sala.Name = "CB_Sala";
            this.CB_Sala.Size = new System.Drawing.Size(338, 27);
            this.CB_Sala.TabIndex = 52;
            // 
            // CB_Escuela
            // 
            this.CB_Escuela.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Escuela.FormattingEnabled = true;
            this.CB_Escuela.Location = new System.Drawing.Point(120, 195);
            this.CB_Escuela.Name = "CB_Escuela";
            this.CB_Escuela.Size = new System.Drawing.Size(338, 27);
            this.CB_Escuela.TabIndex = 53;
            // 
            // CB_Sede
            // 
            this.CB_Sede.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sede.FormattingEnabled = true;
            this.CB_Sede.Location = new System.Drawing.Point(120, 231);
            this.CB_Sede.Name = "CB_Sede";
            this.CB_Sede.Size = new System.Drawing.Size(338, 27);
            this.CB_Sede.TabIndex = 54;
            // 
            // CB_Carrera
            // 
            this.CB_Carrera.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Carrera.FormattingEnabled = true;
            this.CB_Carrera.Location = new System.Drawing.Point(120, 267);
            this.CB_Carrera.Name = "CB_Carrera";
            this.CB_Carrera.Size = new System.Drawing.Size(338, 27);
            this.CB_Carrera.TabIndex = 55;
            // 
            // B_ConsiltarPorTodos
            // 
            this.B_ConsiltarPorTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ConsiltarPorTodos.AutoSize = true;
            this.B_ConsiltarPorTodos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ConsiltarPorTodos.Image = global::Filtro_de_Ramos.Properties.Resources.eye;
            this.B_ConsiltarPorTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_ConsiltarPorTodos.Location = new System.Drawing.Point(509, 264);
            this.B_ConsiltarPorTodos.Name = "B_ConsiltarPorTodos";
            this.B_ConsiltarPorTodos.Size = new System.Drawing.Size(160, 30);
            this.B_ConsiltarPorTodos.TabIndex = 61;
            this.B_ConsiltarPorTodos.Text = "Mostrar Todos";
            this.B_ConsiltarPorTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_ConsiltarPorTodos.UseVisualStyleBackColor = true;
            this.B_ConsiltarPorTodos.Click += new System.EventHandler(this.B_ConsiltarPorTodos_Click);
            // 
            // B_Salir
            // 
            this.B_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Salir.AutoSize = true;
            this.B_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Salir.Image = global::Filtro_de_Ramos.Properties.Resources.times;
            this.B_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Salir.Location = new System.Drawing.Point(509, 156);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(160, 30);
            this.B_Salir.TabIndex = 60;
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
            this.B_Restablacer.Location = new System.Drawing.Point(509, 120);
            this.B_Restablacer.Name = "B_Restablacer";
            this.B_Restablacer.Size = new System.Drawing.Size(160, 30);
            this.B_Restablacer.TabIndex = 59;
            this.B_Restablacer.Text = "Restablecer";
            this.B_Restablacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Restablacer.UseVisualStyleBackColor = true;
            this.B_Restablacer.Click += new System.EventHandler(this.B_Restablacer_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Eliminar.AutoSize = true;
            this.B_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Eliminar.Image = global::Filtro_de_Ramos.Properties.Resources.trash;
            this.B_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Eliminar.Location = new System.Drawing.Point(509, 84);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(160, 30);
            this.B_Eliminar.TabIndex = 58;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Actualizar
            // 
            this.B_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Actualizar.AutoSize = true;
            this.B_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Actualizar.Image = global::Filtro_de_Ramos.Properties.Resources.pencil;
            this.B_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Actualizar.Location = new System.Drawing.Point(509, 48);
            this.B_Actualizar.Name = "B_Actualizar";
            this.B_Actualizar.Size = new System.Drawing.Size(160, 30);
            this.B_Actualizar.TabIndex = 57;
            this.B_Actualizar.Text = "Actualizar";
            this.B_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Actualizar.UseVisualStyleBackColor = true;
            this.B_Actualizar.Click += new System.EventHandler(this.B_Actualizar_Click);
            // 
            // B_Agregar
            // 
            this.B_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Agregar.AutoSize = true;
            this.B_Agregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Agregar.Image = global::Filtro_de_Ramos.Properties.Resources.plus;
            this.B_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Agregar.Location = new System.Drawing.Point(509, 12);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(160, 30);
            this.B_Agregar.TabIndex = 56;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 480);
            this.Controls.Add(this.B_ConsiltarPorTodos);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Restablacer);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Actualizar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.CB_Carrera);
            this.Controls.Add(this.CB_Sede);
            this.Controls.Add(this.CB_Escuela);
            this.Controls.Add(this.CB_Sala);
            this.Controls.Add(this.CB_Seccion);
            this.Controls.Add(this.CB_Semestre);
            this.Controls.Add(this.CB_Ramo);
            this.Controls.Add(this.L_Carrera);
            this.Controls.Add(this.L_Sede);
            this.Controls.Add(this.L_Escuela);
            this.Controls.Add(this.L_Sala);
            this.Controls.Add(this.L_Seccion);
            this.Controls.Add(this.B_BN);
            this.Controls.Add(this.L_ZonaMensaje);
            this.Controls.Add(this.L_Semestre);
            this.Controls.Add(this.L_Ramo);
            this.Controls.Add(this.DGV_Tabla);
            this.Controls.Add(this.TB_Id);
            this.Controls.Add(this.L_Id);
            this.MinimumSize = new System.Drawing.Size(697, 371);
            this.Name = "FormDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de  Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).EndInit();
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

        private System.Windows.Forms.Button B_BN;
        private System.Windows.Forms.Label L_ZonaMensaje;
        private System.Windows.Forms.Label L_Semestre;
        private System.Windows.Forms.Label L_Ramo;
        private System.Windows.Forms.DataGridView DGV_Tabla;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.Label L_Id;
        private System.Windows.Forms.Label L_Sala;
        private System.Windows.Forms.Label L_Seccion;
        private System.Windows.Forms.Label L_Carrera;
        private System.Windows.Forms.Label L_Sede;
        private System.Windows.Forms.Label L_Escuela;
        private System.Windows.Forms.ComboBox CB_Ramo;
        private System.Windows.Forms.ComboBox CB_Semestre;
        private System.Windows.Forms.ComboBox CB_Seccion;
        private System.Windows.Forms.ComboBox CB_Sala;
        private System.Windows.Forms.ComboBox CB_Escuela;
        private System.Windows.Forms.ComboBox CB_Sede;
        private System.Windows.Forms.ComboBox CB_Carrera;
        private System.Windows.Forms.Button B_ConsiltarPorTodos;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Button B_Restablacer;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Actualizar;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.BindingSource bindingSourceCarrera;
        private System.Windows.Forms.BindingSource bindingSourceEscuela;
        private System.Windows.Forms.BindingSource bindingSourceRamo;
        private System.Windows.Forms.BindingSource bindingSourceSala;
        private System.Windows.Forms.BindingSource bindingSourceSeccion;
        private System.Windows.Forms.BindingSource bindingSourceSede;
        private System.Windows.Forms.BindingSource bindingSourceSemestre;
    }
}