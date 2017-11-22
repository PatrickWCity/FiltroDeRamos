using System;
using System.Drawing;
using System.Windows.Forms;
using Filtro_de_Ramos.Modelo;
using Filtro_de_Ramos.Controlador;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormDetalle : Form
    {
        ControladorCarrera controladorCarrera = new ControladorCarrera();
        ControladorDetalleS controladorDetalleS = new ControladorDetalleS();
        ControladorDetalle controladorDetalle = new ControladorDetalle();
        ControladorEscuela controladorEscuela = new ControladorEscuela();
        ControladorRamo controladorRamo = new ControladorRamo();
        ControladorSala controladorSala = new ControladorSala();
        ControladorSeccion controladorSeccion = new ControladorSeccion();
        ControladorSede controladorSede = new ControladorSede();
        ControladorSemestre controladorSemestre = new ControladorSemestre();
        int id, swbn, car, esc, ram, sal, sec, sed, sem;
        public FormDetalle()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["Detalle"];
            if (swbn == 1)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Ramo.ForeColor = DefaultBackColor;
                L_Carrera.ForeColor = DefaultBackColor;
                L_Escuela.ForeColor = DefaultBackColor;
                L_Sala.ForeColor = DefaultBackColor;
                L_Seccion.ForeColor = DefaultBackColor;
                L_Sede.ForeColor = DefaultBackColor;
                L_Semestre.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Ramo.ForeColor = DefaultForeColor;
                L_Carrera.ForeColor = DefaultForeColor;
                L_Escuela.ForeColor = DefaultForeColor;
                L_Sala.ForeColor = DefaultForeColor;
                L_Seccion.ForeColor = DefaultForeColor;
                L_Sede.ForeColor = DefaultForeColor;
                L_Semestre.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.SkyBlue;
            }

            bindingSourceCarrera.DataSource = controladorCarrera.ConsultarPorTodos();
            CB_Carrera.DataSource = bindingSourceCarrera.DataSource;
            CB_Carrera.DisplayMember = "nombre";
            CB_Carrera.ValueMember = "id";
            car = (int)CB_Carrera.SelectedValue;

            bindingSourceEscuela.DataSource = controladorEscuela.ConsultarPorTodos();
            CB_Escuela.DataSource = bindingSourceEscuela.DataSource;
            CB_Escuela.DisplayMember = "nombre";
            CB_Escuela.ValueMember = "id";
            esc = (int)CB_Escuela.SelectedValue;

            bindingSourceRamo.DataSource = controladorRamo.ConsultarPorTodos();
            CB_Ramo.DataSource = bindingSourceRamo.DataSource;
            CB_Ramo.DisplayMember = "nombre";
            CB_Ramo.ValueMember = "id";
            ram = (int)CB_Carrera.SelectedValue;

            bindingSourceSala.DataSource = controladorSala.ConsultarPorTodos();
            CB_Sala.DataSource = bindingSourceSala.DataSource;
            CB_Sala.DisplayMember = "lugar";
            CB_Sala.ValueMember = "id";
            sal = (int)CB_Sala.SelectedValue;

            bindingSourceSeccion.DataSource = controladorSeccion.ConsultarPorTodos();
            CB_Seccion.DataSource = bindingSourceSeccion.DataSource;
            CB_Seccion.DisplayMember = "numero";
            CB_Seccion.ValueMember = "id";
            sec = (int)CB_Seccion.SelectedValue;

            bindingSourceSede.DataSource = controladorSede.ConsultarPorTodos();
            CB_Sede.DataSource = bindingSourceSede.DataSource;
            CB_Sede.DisplayMember = "nombre";
            CB_Sede.ValueMember = "id";
            sed = (int)CB_Sede.SelectedValue;

            bindingSourceSemestre.DataSource = controladorSemestre.ConsultarPorTodos();
            CB_Semestre.DataSource = bindingSourceSemestre.DataSource;
            CB_Semestre.DisplayMember = "numero";
            CB_Semestre.ValueMember = "id";
            sem = (int)CB_Semestre.SelectedValue;
        }
        private void B_Agregar_Click(object sender, EventArgs e)
        {

            // puro id
            //Detalle usuario = new Detalle { Ramo = (int)CB_Ramo.SelectedValue, Semestre = (int)CB_Semestre.SelectedValue, Seccion = (int)CB_Seccion.SelectedValue, Sala = (int)CB_Sala.SelectedValue, Escuela = (int)CB_Escuela.SelectedValue, Sede = (int)CB_Sede.SelectedValue, Carrera = (int)CB_Carrera.SelectedValue };
            //controladorDetalle.Agregar(usuario);
            //TB_Id.Text = usuario.Id.ToString();
            //DGV_Tabla.DataSource = controladorDetalle.ConsultarPorUno(usuario.Id);



            // Funciona S
            DetalleS usuarios = new DetalleS { Ramo = CB_Ramo.Text, Semestre = CB_Semestre.Text, Seccion = CB_Seccion.Text, Sala = CB_Sala.Text, Escuela = CB_Escuela.Text, Sede = CB_Sede.Text, Carrera = CB_Carrera.Text };
            controladorDetalleS.Agregar(usuarios);
            TB_Id.Text = usuarios.Id.ToString();
            DGV_Tabla.DataSource = controladorDetalleS.ConsultarPorUno(usuarios.Id);





            B_Agregar.Enabled = false;
            B_Actualizar.Enabled = true;
            B_Eliminar.Enabled = true;
        }
        private void B_Actualizar_Click(object sender, EventArgs e)
        {
            DetalleS detalleS = new DetalleS { Id = int.Parse(TB_Id.Text), Ramo = CB_Ramo.Text, Semestre = CB_Semestre.Text, Seccion = CB_Seccion.Text, Sala = CB_Sala.Text, Escuela = CB_Escuela.Text, Sede = CB_Sede.Text, Carrera = CB_Carrera.Text };
            controladorDetalleS.Actualizar(detalleS);

            //Detalle detalle = new Detalle { Id = int.Parse(TB_Id.Text), Ramo = (int)CB_Ramo.SelectedValue, Semestre = (int)CB_Semestre.SelectedValue, Seccion = (int)CB_Seccion.SelectedValue, Sala = (int)CB_Sala.SelectedValue, Escuela = (int)CB_Escuela.SelectedValue, Sede = (int)CB_Sede.SelectedValue, Carrera = (int)CB_Carrera.SelectedValue };
            //controladorDetalle.Actualizar(detalle);
        }
        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (TB_Id.TextLength == 0)
                L_ZonaMensaje.Text = "ID no puede estar vacio";
            else if (!int.TryParse(TB_Id.Text, out id))
                L_ZonaMensaje.Text = "ID invalido";
            else
                controladorDetalleS.Eliminar(int.Parse(TB_Id.Text));
        }
        private void B_Restablacer_Click(object sender, EventArgs e)
        {
            // no estoy seguro
        }
        private void B_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void B_ConsiltarPorTodos_Click(object sender, EventArgs e)
        {
            DGV_Tabla.DataSource = controladorDetalleS.ConsultarPorTodos();//controlador tiene que ser cambiado
        }
        private void DGV_Tabla_CellClick(object sender, DataGridViewCellEventArgs e)//arreglar
        {
            if (e.RowIndex != -1)
            {
                TB_Id.Text = DGV_Tabla.Rows[e.RowIndex].Cells["id"].Value.ToString();
                CB_Ramo.Text = DGV_Tabla.Rows[e.RowIndex].Cells["ramo"].Value.ToString(); // revisar
                //TB_Descripcion.Text = DGV_Tabla.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            }
        }
        private void B_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Carrera.ForeColor = DefaultForeColor;
                L_Escuela.ForeColor = DefaultForeColor;
                L_Ramo.ForeColor = DefaultForeColor;
                L_Sala.ForeColor = DefaultForeColor;
                L_Seccion.ForeColor = DefaultForeColor;
                L_Sede.ForeColor = DefaultForeColor;
                L_Semestre.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                ActiveForm.BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Carrera.ForeColor = DefaultForeColor;
                L_Escuela.ForeColor = DefaultForeColor;
                L_Ramo.ForeColor = DefaultForeColor;
                L_Sala.ForeColor = DefaultForeColor;
                L_Seccion.ForeColor = DefaultForeColor;
                L_Sede.ForeColor = DefaultForeColor;
                L_Semestre.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                ActiveForm.BackColor = Color.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["Detalle"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}