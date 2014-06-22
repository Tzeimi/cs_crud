using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void opc_altamaestro_Click(object sender, EventArgs e)
        {
            frm_AltaMaestros frm = new frm_AltaMaestros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_consultamaestro_Click(object sender, EventArgs e)
        {
            frm_ConsultaMaestros frm = new frm_ConsultaMaestros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_bajamaestro_Click(object sender, EventArgs e)
        {
            frm_BajaMaestros frm = new frm_BajaMaestros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_altaalumno_Click(object sender, EventArgs e)
        {
            frm_AltaAlumnos frm = new frm_AltaAlumnos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_consultaalumno_Click(object sender, EventArgs e)
        {
            frm_ConsultaAlumnos frm = new frm_ConsultaAlumnos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_bajaalumno_Click(object sender, EventArgs e)
        {
            frm_BajaAlumnos frm = new frm_BajaAlumnos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_altamaterias_Click(object sender, EventArgs e)
        {
            frm_AltaMaterias frm = new frm_AltaMaterias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_consultamateria_Click(object sender, EventArgs e)
        {
            frm_ConsultaMaterias frm = new frm_ConsultaMaterias();
            frm.MdiParent = this;
            frm.Show();
        }


        private void opc_altacali_Click(object sender, EventArgs e)
        {
            frm_AltaCali frm = new frm_AltaCali();
            frm.MdiParent = this;
            frm.Show();
        }

        private void opc_consultacali_Click(object sender, EventArgs e)
        {
            frm_ConsultaCalif frm = new frm_ConsultaCalif();
            frm.MdiParent = this;
            frm.Show();
        }
        private void opc_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ModificarMaestros frm = new frm_ModificarMaestros();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
