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
    public partial class frm_BajaAlumnos : Form
    {
        public frm_BajaAlumnos()
        {
            InitializeComponent();
        }

        private void frm_BajaAlumnos_Load(object sender, EventArgs e)
        {
            GetColumnOnComboBox();
        }

        private void GetColumnOnComboBox()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                conn.Open();
                string str = "SELECT * FROM tb_Alumno";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, conn);
                testDataSet ds = new testDataSet();
                da.Fill(ds, "tb_Alumno");
                this.cb_Id.DataSource = ds.Tables["tb_Alumno"];
                this.cb_Id.DisplayMember = "pk_alumno";
                this.cb_Id.ValueMember = "pk_alumno";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        private void cb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                Conn.Open();
                string str = "SELECT * FROM tb_Alumno WHERE pk_alumno ='" + cb_Id.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_nombre.Text = dr["nombre"].ToString() + " " + dr["ap_paterno"].ToString() + " " + dr["ap_materno"].ToString();
                }

            }
            catch(SqlCeException ex)
            {

            }
            finally
            {
                Conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            string pk_alumno = cb_Id.Text;

            string sqlquery = ("DELETE FROM tb_Alumno WHERE pk_alumno=@pk_alumno");

            SqlCeCommand cmd = new SqlCeCommand(sqlquery, Conn);

            cmd.Parameters.Add("@pk_alumno", pk_alumno);
            try
            {
                int affectedrows = cmd.ExecuteNonQuery();

                if (affectedrows > 0)
                {
                    MessageBox.Show("Los datos fuero borrados exitosamente", "Baja de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txt_nombre.Text = "";
                cb_Id.Text = "";
            }
            catch (SqlCeException u)
            {
                MessageBox.Show(u.Message);
                MessageBox.Show("Fallo al borrar la informacion");
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
