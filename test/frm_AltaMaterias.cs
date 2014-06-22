using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace test
{
    public partial class frm_AltaMaterias : Form
    {
        public frm_AltaMaterias()
        {
            InitializeComponent();
            txt_nombre.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Error, no se capturo el nombre de la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }
            else
            {
                SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
                try
                {
                    Conn.Open();
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("Fallo la conexion a la Base de Datos");
                    MessageBox.Show(ex.Message);
                }

                string nombre_materia = txt_nombre.Text;

                string sqlquery = ("INSERT INTO tb_materias (nombre_materia) VALUES(@nombre_materia)");
                SqlCeCommand cmd = new SqlCeCommand(sqlquery, Conn);
                cmd.Parameters.Add("@nombre_materia", nombre_materia);

                try
                {
                    int affectedrows = cmd.ExecuteNonQuery();
                    if (affectedrows > 0)
                    {
                        MessageBox.Show("La materia: " + nombre_materia + " se ha guardado exitosamente");
                    }
                }
                catch(SqlCeException u)
                {
                    MessageBox.Show(u.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_nombre.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
