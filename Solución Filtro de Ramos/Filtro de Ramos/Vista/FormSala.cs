using System;
using System.Drawing;
using System.Windows.Forms;
using Filtro_de_Ramos.Modelo;
using Filtro_de_Ramos.Controlador;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormSala : Form
    {
        ControladorSala controladorSala= new ControladorSala();
        int id, swbn;
        public FormSala()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["Sala"];
            if (swbn == 1)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_SalaCounter.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_SalaCounter.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.SkyBlue;
            }
        }
        private void B_Agregar_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala { Lugar = TB_Sala.Text };
            controladorSala.Agregar(sala);
            TB_Id.Text = sala.Id.ToString();
            DGV_Tabla.DataSource = controladorSala.ConsultarPorUno(sala.Id, null);
            B_Agregar.Enabled = false;
            B_Actualizar.Enabled = true;
            B_Eliminar.Enabled = true;
        }
        private void B_Actualizar_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala { Id = int.Parse(TB_Id.Text), Lugar = TB_Sala.Text };
            controladorSala.Actualizar(sala);
        }
        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (TB_Id.TextLength == 0)
                L_ZonaMensaje.Text = "ID no puede estar vacio";
            else if (!int.TryParse(TB_Id.Text, out id))
                L_ZonaMensaje.Text = "Numero Interno invalido";
            else
                controladorSala.Eliminar(int.Parse(TB_Id.Text));
        }
        private void B_ConsultarPorUno_Click(object sender, EventArgs e)
        {
            if (TB_PalabraClave.TextLength == 0)
            {
                L_ZonaMensaje.Text = "Debe ingresar un dato a buscar";
                DGV_Tabla.DataSource = controladorSala.ConsultarPorTodos();
            }
            else
            if (!int.TryParse(TB_Id.Text, out id))
            {
                DGV_Tabla.DataSource = controladorSala.ConsultarPorUno(0, TB_PalabraClave.Text);
            }
            else
            {
                DGV_Tabla.DataSource = controladorSala.ConsultarPorUno(int.Parse(TB_PalabraClave.Text), TB_PalabraClave.Text);
            }
        }
        private void B_ConsiltarPorTodos_Click(object sender, EventArgs e)
        {
            DGV_Tabla.DataSource = controladorSala.ConsultarPorTodos();
        }
        private void B_Restablacer_Click(object sender, EventArgs e)
        {
            TB_PalabraClave.Text = string.Empty;
            TB_Id.Text = string.Empty;
            TB_Sala.Text = string.Empty;
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
                TB_Sala.Text = DGV_Tabla.Rows[e.RowIndex].Cells["sala"].Value.ToString();
            }
        }
        private void TB_Edificio_TextChanged(object sender, EventArgs e)
        {
            L_SalaCounter.Text = (60 - TB_Sala.TextLength).ToString();
            if ((60 - TB_Sala.TextLength) < 0)
                L_SalaCounter.ForeColor = Color.Red;
            else if ((60 - TB_Sala.TextLength) == 0 || (60 - TB_Sala.TextLength) < 59)
                L_SalaCounter.ForeColor = Color.Green;
            else
                if (swbn == 0)
                L_SalaCounter.ForeColor = DefaultForeColor;
            else
                L_SalaCounter.ForeColor = DefaultBackColor;
        }
        private void B_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                L_Id.ForeColor = DefaultBackColor;
                L_Sala.ForeColor = DefaultBackColor;
                L_SalaCounter.ForeColor = DefaultBackColor;
                L_ZonaMensaje.ForeColor = DefaultBackColor;
                ActiveForm.BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                L_Id.ForeColor = DefaultForeColor;
                L_Sala.ForeColor = DefaultForeColor;
                L_SalaCounter.ForeColor = DefaultForeColor;
                L_ZonaMensaje.ForeColor = DefaultForeColor;
                ActiveForm.BackColor = Color.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["Sala"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}