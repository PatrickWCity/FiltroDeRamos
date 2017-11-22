using System;
using System.Drawing;
using System.Windows.Forms;
using Filtro_de_Ramos.Modelo;
using Filtro_de_Ramos.Controlador;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormSemestre : Form
    {
        ControladorSemestre controladorSemestre = new ControladorSemestre();
        int id, swbn;
        public FormSemestre()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["Semestre"];
            if (swbn == 1)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Numero.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Numero.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.SkyBlue;
            }
        }
        private void B_Agregar_Click(object sender, EventArgs e)
        {
            Semestre semestre = new Semestre { Numero = int.Parse(TB_Numero.Text) };
            controladorSemestre.Agregar(semestre);
            TB_Id.Text = semestre.Id.ToString();
            DGV_Tabla.DataSource = controladorSemestre.ConsultarPorUno(semestre.Id);
            B_Agregar.Enabled = false;
            B_Actualizar.Enabled = true;
            B_Eliminar.Enabled = true;
        }
        private void B_Actualizar_Click(object sender, EventArgs e)
        {
            Semestre semestre = new Semestre { Id = int.Parse(TB_Id.Text), Numero = int.Parse(TB_Numero.Text) };
            controladorSemestre.Actualizar(semestre);
        }
        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (TB_Id.TextLength == 0)
                L_ZonaMensaje.Text = "ID no puede estar vacio";
            else if (!int.TryParse(TB_Id.Text, out id))
                L_ZonaMensaje.Text = "Numero Interno invalido";
            else
                controladorSemestre.Eliminar(int.Parse(TB_Id.Text));
        }
        private void B_ConsultarPorUno_Click(object sender, EventArgs e)
        {
            if (TB_PalabraClave.TextLength == 0)
            {
                L_ZonaMensaje.Text = "Debe ingresar un dato a buscar";
                DGV_Tabla.DataSource = controladorSemestre.ConsultarPorTodos();
            }
            else
            if (!int.TryParse(TB_Id.Text, out id))
                DGV_Tabla.DataSource = controladorSemestre.ConsultarPorUno(0);
            else
                DGV_Tabla.DataSource = controladorSemestre.ConsultarPorUno(int.Parse(TB_PalabraClave.Text));
        }
        private void B_ConsiltarPorTodos_Click(object sender, EventArgs e)
        {
            DGV_Tabla.DataSource = controladorSemestre.ConsultarPorTodos();
        }
        private void B_Restablacer_Click(object sender, EventArgs e)
        {
            TB_PalabraClave.Text = string.Empty;
            TB_Id.Text = string.Empty;
            TB_Numero.Text = string.Empty;
            TB_Id.Focus();
        }
        private void B_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DGV_Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TB_Id.Text = DGV_Tabla.Rows[e.RowIndex].Cells["id"].Value.ToString();
                TB_Numero.Text = DGV_Tabla.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            }
        }
        private void B_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Numero.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                ActiveForm.BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Numero.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                ActiveForm.BackColor = Color.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["Semestre"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}