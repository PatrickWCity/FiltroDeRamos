using System;
using System.Windows.Forms;

namespace Filtro_de_Ramos.Vista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
        }
        private void CarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarrera formCarrera = new FormCarrera();
            formCarrera.Show();
        }
        private void EscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEscuela formEscuela = new FormEscuela();
            formEscuela.Show();
        }
        private void RamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRamo formRamo = new FormRamo();
            formRamo.Show();
        }
        private void SalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSala formSala = new FormSala();
            formSala.Show();
        }
        private void SeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeccion formSeccion = new FormSeccion();
            formSeccion.Show();
        }
        private void SedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSede formSede = new FormSede();
            formSede.Show();
        }
        private void SemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSemestre formSemestre = new FormSemestre();
            formSemestre.Show();
        }
        private void DetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalle formDetalle = new FormDetalle();
            formDetalle.Show();
        }
        private void RamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltroRamos formFiltroRamos = new FormFiltroRamos();
            formFiltroRamos.Show();
        }
    }
}