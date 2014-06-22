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
    public partial class frm_ConsultaMaestros : Form
    {
        public frm_ConsultaMaestros()
        {
            InitializeComponent();
        }

        private void frm_ConsultaMaestros_Load(object sender, EventArgs e)
        {
            GetColumnOnComboBox();
        }
        
        private void GetColumnOnComboBox()
        {
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                conn.Open();
                string str = "SELECT * FROM tb_maestro";
                SqlCeDataAdapter da = new SqlCeDataAdapter(str, conn);
                testDataSet ds = new testDataSet();
                da.Fill(ds, "tb_maestro");
                this.cb_Id.DataSource = ds.Tables["tb_maestro"];
                this.cb_Id.DisplayMember = "Pk_maestro";
                this.cb_Id.ValueMember = "Pk_maestro";
            }
            catch (Exception ex)
            {

            }

        }

        private void cb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                Conn.Open();
                string str = "SELECT * FROM tb_maestro WHERE Pk_maestro ='" + cb_Id.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_nombre.Text = dr["nombre"].ToString() + " " + dr["ap_paterno"].ToString() + " " + dr["ap_materno"].ToString();
                    txt_fecha.Text = dr["fecha_ingreso"].ToString();
                    txt_telefono.Text = dr["telefono"].ToString();
                    txt_matricula.Text = dr["matricula_empleado"].ToString();
                    txt_email.Text = dr["email"].ToString();
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
    }
}
