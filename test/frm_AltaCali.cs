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
    public partial class frm_AltaCali : Form
    {
        public frm_AltaCali()
        {
            InitializeComponent();
        }

        private void frm_AltaCali_Load(object sender, EventArgs e)
        {
            GetColumnOnComboBox();
            GetColumnOnComboBox2();
            GetColumnOnComboBox3();
        }

        private void GetColumnOnComboBox()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                conn.Open();
                string str = "SELECT * FROM tb_materias";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, conn);
                testDataSet ds = new testDataSet();
                da.Fill(ds, "tb_materias");
                this.cb_alumno.DataSource = ds.Tables["tb_materias"];
                this.cb_alumno.DisplayMember = "Pk_materia";
                this.cb_alumno.ValueMember = "Pk_materia";
            }
            catch(SqlCeException ex)
            {
                conn.Close();
            }
        }

        private void GetColumnOnComboBox2()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                conn.Open();
                string str = "SELECT * FROM tb_maestro";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, conn);
                testDataSet ds = new testDataSet();
                da.Fill(ds, "tb_maestro");
                this.cb_maestro.DataSource = ds.Tables["tb_maestro"];
                this.cb_maestro.DisplayMember = "pk_maestro";
                this.cb_maestro.ValueMember = "pk_maestro";
            }
            catch (SqlCeException ex)
            {
                conn.Close();
            }
        }
        private void GetColumnOnComboBox3()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                conn.Open();
                string str = "SELECT * FROM tb_Alumno";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, conn);
                testDataSet ds = new testDataSet();
                da.Fill(ds, "tb_Alumno");
                this.cb_materias.DataSource = ds.Tables["tb_Alumno"];
                this.cb_materias.DisplayMember = "pk_alumno";
                this.cb_materias.ValueMember = "pk_alumno";
            }
            catch (SqlCeException ex)
            {
                conn.Close();
            }
        }

        private void cb_materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                Conn.Open();
                string str = "SELECT * FROM tb_materias WHERE Pk_materia ='" + cb_materias.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_materia.Text = dr["nombre_materia"].ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Conn.Close();
            }
        }

        private void cb_maestro_SelectedIndexChanged(object sender, EventArgs e)
        {
             SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
             try
             {
                 Conn.Open();
                 string str = "SELECT * FROM tb_maestro WHERE Pk_maestro ='" + cb_maestro.Text + "'";
                 SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                 SqlCeDataReader dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     txt_maestro.Text = dr["nombre"].ToString() + " " + dr["ap_paterno"].ToString() + " " + dr["ap_materno"].ToString();
                 }
             }
             catch (SqlCeException ex)
             {
                 
             }
             finally
             {
                 Conn.Close();
             }
        }

        private void cb_alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                Conn.Open();
                string str = "SELECT * FROM tb_Alumno WHERE pk_alumno ='" + cb_alumno.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_alumno.Text = dr["nombre"].ToString() + " " + dr["ap_paterno"].ToString() + " " + dr["ap_materno"].ToString();
                }
            }
            catch (SqlCeException ex)
            {
                
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_calif.Text == "")
            {
                MessageBox.Show("Error, no se capturo ninguna calificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_calif.Focus();
                if (txt_observaciones.Text == "")
                {
                    MessageBox.Show("Error, no se capturaron observaciones hacia el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_observaciones.Focus();
                }
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
                }

                string fk_maestro = cb_maestro.Text;
                string fk_alumno = cb_alumno.Text;
                string calificacion = txt_calif.Text;
                string observaciones = txt_observaciones.Text;
                string fk_materia = cb_materias.Text;

                string sqlquery=("INSERT INTO tb_calificaciones(fk_maestro, fk_alumno, calificacion, observaciones, fk_materia) VALUES (@fk_maestro, @fk_alumno, @calificacion, @observaciones, @fk_materia)");

                SqlCeCommand cmd = new SqlCeCommand(sqlquery, Conn);
                cmd.Parameters.Add("@fk_maestro", fk_maestro);
                cmd.Parameters.Add("@fk_alumno", fk_alumno);
                cmd.Parameters.Add("@calificacion", calificacion);
                cmd.Parameters.Add("@observaciones", observaciones);
                cmd.Parameters.Add("@fk_materia", fk_materia);
                try
                    {
                        int affectedrows = cmd.ExecuteNonQuery();

                        if (affectedrows > 0)
                        {
                            MessageBox.Show("La calificacion se ha guardado exitosamente", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                catch (SqlCeException u)
                {
                    MessageBox.Show(u.Message);
                    MessageBox.Show("Fallo al guardar la informacion");
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_calif.Text = "";
            txt_observaciones.Text = "";
            cb_materias.Text = "";
            cb_maestro.Text = "";
            cb_alumno.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
