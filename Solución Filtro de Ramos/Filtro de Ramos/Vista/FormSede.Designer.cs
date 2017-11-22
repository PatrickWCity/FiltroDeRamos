namespace Filtro_de_Ramos.Vista
{
    partial class FormSede
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
            this.B_BN = new System.Windows.Forms.Button();
            this.L_ZonaMensaje = new System.Windows.Forms.Label();
            this.TB_PalabraClave = new System.Windows.Forms.TextBox();
            this.L_NombreCounter = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.DGV_Tabla = new System.Windows.Forms.DataGridView();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.L_Id = new System.Windows.Forms.Label();
            this.B_ConsultarPorUno = new System.Windows.Forms.Button();
            this.B_ConsiltarPorTodos = new System.Windows.Forms.Button();
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_Restablacer = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Actualizar = new System.Windows.Forms.Button();
            this.B_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // B_BN
            // 
            this.B_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_BN.AutoSize = true;
            this.B_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_BN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BN.Location = new System.Drawing.Point(618, 291);
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
            this.L_ZonaMensaje.Location = new System.Drawing.Point(12, 296);
            this.L_ZonaMensaje.Name = "L_ZonaMensaje";
            this.L_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.L_ZonaMensaje.TabIndex = 37;
            this.L_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // TB_PalabraClave
            // 
            this.TB_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PalabraClave.Location = new System.Drawing.Point(120, 189);
            this.TB_PalabraClave.Name = "TB_PalabraClave";
            this.TB_PalabraClave.Size = new System.Drawing.Size(280, 27);
            this.TB_PalabraClave.TabIndex = 36;
            // 
            // L_NombreCounter
            // 
            this.L_NombreCounter.AutoSize = true;
            this.L_NombreCounter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreCounter.Location = new System.Drawing.Point(464, 54);
            this.L_NombreCounter.Name = "L_NombreCounter";
            this.L_NombreCounter.Size = new System.Drawing.Size(29, 19);
            this.L_NombreCounter.TabIndex = 27;
            this.L_NombreCounter.Text = "60";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(120, 49);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(338, 27);
            this.TB_Nombre.TabIndex = 26;
            this.TB_Nombre.TextChanged += new System.EventHandler(this.TB_Nombre_TextChanged);
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nombre.Location = new System.Drawing.Point(12, 54);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(73, 19);
            this.L_Nombre.TabIndex = 24;
            this.L_Nombre.Text = "Nombre";
            // 
            // DGV_Tabla
            // 
            this.DGV_Tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tabla.Location = new System.Drawing.Point(12, 222);
            this.DGV_Tabla.Name = "DGV_Tabla";
            this.DGV_Tabla.Size = new System.Drawing.Size(657, 63);
            this.DGV_Tabla.TabIndex = 23;
            this.DGV_Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Tabla_CellClick);
            // 
            // TB_Id
            // 
            this.TB_Id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Id.Location = new System.Drawing.Point(120, 14);
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
            // B_ConsultarPorUno
            // 
            this.B_ConsultarPorUno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ConsultarPorUno.AutoSize = true;
            this.B_ConsultarPorUno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ConsultarPorUno.Image = global::Filtro_de_Ramos.Properties.Resources.search;
            this.B_ConsultarPorUno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_ConsultarPorUno.Location = new System.Drawing.Point(406, 187);
            this.B_ConsultarPorUno.Name = "B_ConsultarPorUno";
            this.B_ConsultarPorUno.Size = new System.Drawing.Size(97, 30);
            this.B_ConsultarPorUno.TabIndex = 45;
            this.B_ConsultarPorUno.Text = "Buscar";
            this.B_ConsultarPorUno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_ConsultarPorUno.UseVisualStyleBackColor = true;
            this.B_ConsultarPorUno.Click += new System.EventHandler(this.B_ConsultarPorUno_Click);
            // 
            // B_ConsiltarPorTodos
            // 
            this.B_ConsiltarPorTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ConsiltarPorTodos.AutoSize = true;
            this.B_ConsiltarPorTodos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ConsiltarPorTodos.Image = global::Filtro_de_Ramos.Properties.Resources.eye;
            this.B_ConsiltarPorTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_ConsiltarPorTodos.Location = new System.Drawing.Point(509, 187);
            this.B_ConsiltarPorTodos.Name = "B_ConsiltarPorTodos";
            this.B_ConsiltarPorTodos.Size = new System.Drawing.Size(160, 30);
            this.B_ConsiltarPorTodos.TabIndex = 44;
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
            this.B_Salir.Location = new System.Drawing.Point(509, 152);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(160, 30);
            this.B_Salir.TabIndex = 43;
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
            this.B_Restablacer.Location = new System.Drawing.Point(509, 117);
            this.B_Restablacer.Name = "B_Restablacer";
            this.B_Restablacer.Size = new System.Drawing.Size(160, 30);
            this.B_Restablacer.TabIndex = 42;
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
            this.B_Eliminar.Location = new System.Drawing.Point(509, 82);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(160, 30);
            this.B_Eliminar.TabIndex = 41;
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
            this.B_Actualizar.TabIndex = 40;
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
            this.B_Agregar.TabIndex = 39;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // FormSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 332);
            this.Controls.Add(this.B_ConsultarPorUno);
            this.Controls.Add(this.B_ConsiltarPorTodos);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Restablacer);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Actualizar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.B_BN);
            this.Controls.Add(this.L_ZonaMensaje);
            this.Controls.Add(this.TB_PalabraClave);
            this.Controls.Add(this.L_NombreCounter);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.DGV_Tabla);
            this.Controls.Add(this.TB_Id);
            this.Controls.Add(this.L_Id);
            this.MinimumSize = new System.Drawing.Size(697, 371);
            this.Name = "FormSede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Sedes";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_BN;
        private System.Windows.Forms.Label L_ZonaMensaje;
        private System.Windows.Forms.TextBox TB_PalabraClave;
        private System.Windows.Forms.Label L_NombreCounter;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.DataGridView DGV_Tabla;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.Label L_Id;
        private System.Windows.Forms.Button B_ConsultarPorUno;
        private System.Windows.Forms.Button B_ConsiltarPorTodos;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Button B_Restablacer;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Actualizar;
        private System.Windows.Forms.Button B_Agregar;
    }
}