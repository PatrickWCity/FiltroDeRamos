using System;
using System.Drawing;
using System.Windows.Forms;
using Filtro_de_Ramos.Modelo;
using Filtro_de_Ramos.Controlador;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormEscuela : Form
    {
        ControladorEscuela controladorEscuela = new ControladorEscuela();
        int id, swbn;
        public FormEscuela()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["Escuela"];
            if (swbn == 1)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Nombre.ForeColor = DefaultBackColor;
                L_NombreCounter.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Nombre.ForeColor = DefaultForeColor;
                L_NombreCounter.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.SkyBlue;
            }
        }
        private void B_Agregar_Click(object sender, EventArgs e)
        {
            Escuela carrera = new Escuela { Nombre = TB_Nombre.Text };
            controladorEscuela.Agregar(carrera);
            TB_Id.Text = carrera.Id.ToString();
            DGV_Tabla.DataSource = controladorEscuela.ConsultarPorUno(carrera.Id, null);
            B_Agregar.Enabled = false;
            B_Actualizar.Enabled = true;
            B_Eliminar.Enabled = true;
        }
        private void B_Actualizar_Click(object sender, EventArgs e)
        {
            Escuela usuario = new Escuela { Id = int.Parse(TB_Id.Text), Nombre = TB_Nombre.Text };
            controladorEscuela.Actualizar(usuario);
        }
        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (TB_Id.TextLength == 0)
                L_ZonaMensaje.Text = "ID no puede estar vacio";
            else if (!int.TryParse(TB_Id.Text, out id))
                L_ZonaMensaje.Text = "Numero Interno invalido";
            else
                controladorEscuela.Eliminar(int.Parse(TB_Id.Text));
        }
        private void B_ConsultarPorUno_Click(object sender, EventArgs e)
        {
            if (TB_PalabraClave.TextLength == 0)
            {
                L_ZonaMensaje.Text = "Debe ingresar un dato a buscar";
                DGV_Tabla.DataSource = controladorEscuela.ConsultarPorTodos();
            }
            else
            if (!int.TryParse(TB_Id.Text, out id))
                DGV_Tabla.DataSource = controladorEscuela.ConsultarPorUno(0, TB_PalabraClave.Text);
            else
                DGV_Tabla.DataSource = controladorEscuela.ConsultarPorUno(int.Parse(TB_PalabraClave.Text), TB_PalabraClave.Text);
        }
        private void B_ConsiltarPorTodos_Click(object sender, EventArgs e)
        {
            DGV_Tabla.DataSource = controladorEscuela.ConsultarPorTodos();
        }
        private void B_Restablacer_Click(object sender, EventArgs e)
        {
            TB_PalabraClave.Text = string.Empty;
            TB_Id.Text = string.Empty;
            TB_Nombre.Text = string.Empty;
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
                TB_Nombre.Text = DGV_Tabla.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            }
        }
        private void TB_Nombre_TextChanged(object sender, EventArgs e)
        {
            L_NombreCounter.Text = (60 - TB_Nombre.TextLength).ToString();
            if ((60 - TB_Nombre.TextLength) < 0)
                L_NombreCounter.ForeColor = Color.Red;
            else if ((60 - TB_Nombre.TextLength) == 0 || (60 - TB_Nombre.TextLength) < 59)
                L_NombreCounter.ForeColor = Color.Green;
            else
                if (swbn == 0)
                L_NombreCounter.ForeColor = DefaultForeColor;
            else
                L_NombreCounter.ForeColor = DefaultBackColor;
        }
        private void B_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Nombre.ForeColor = DefaultBackColor;
                L_NombreCounter.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                ActiveForm.BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Nombre.ForeColor = DefaultForeColor;
                L_NombreCounter.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                ActiveForm.BackColor = Color.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["Escuela"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}