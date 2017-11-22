using Filtro_de_Ramos.Controlador;
using System.Drawing;
using System.Windows.Forms;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormFiltroRamos : Form
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
        int swbn, car, esc, ram, sal, sec, sed, sem;
        public FormFiltroRamos()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

            swbn = (int)Properties.Settings.Default["FiltroRamos"];
            if (swbn == 1)
            {
                TCB_Ramo.ForeColor = DefaultBackColor;
                TCB_Carrera.ForeColor = DefaultBackColor;
                TCB_Escuela.ForeColor = DefaultBackColor;
                TCB_Sala.ForeColor = DefaultBackColor;
                TCB_Seccion.ForeColor = DefaultBackColor;
                TCB_Sede.ForeColor = DefaultBackColor;
                TCB_Semestre.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                TCB_Ramo.ForeColor = DefaultForeColor;
                TCB_Carrera.ForeColor = DefaultForeColor;
                TCB_Escuela.ForeColor = DefaultForeColor;
                TCB_Sala.ForeColor = DefaultForeColor;
                TCB_Seccion.ForeColor = DefaultForeColor;
                TCB_Sede.ForeColor = DefaultForeColor;
                TCB_Semestre.ForeColor = DefaultForeColor;
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
        private void B_Refrescar_Click(object sender, System.EventArgs e)
        {

        }
        private void B_Restablacer_Click(object sender, System.EventArgs e)
        {

        }
        private void B_Salir_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void B_BN_Click(object sender, System.EventArgs e)
        {
            if (swbn == 0)
            {
                TCB_Carrera.ForeColor = DefaultBackColor;
                TCB_Escuela.ForeColor = DefaultBackColor;
                TCB_Ramo.ForeColor = DefaultBackColor;
                TCB_Sala.ForeColor = DefaultBackColor;
                TCB_Seccion.ForeColor = DefaultBackColor;
                TCB_Sede.ForeColor = DefaultBackColor;
                TCB_Semestre.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                ActiveForm.BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                TCB_Carrera.ForeColor = DefaultForeColor;
                TCB_Escuela.ForeColor = DefaultForeColor;
                TCB_Ramo.ForeColor = DefaultForeColor;
                TCB_Sala.ForeColor = DefaultForeColor;
                TCB_Seccion.ForeColor = DefaultForeColor;
                TCB_Sede.ForeColor = DefaultForeColor;
                TCB_Semestre.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                ActiveForm.BackColor = Color.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["FiltroRamos"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}