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
    public partial class frm_ModificarMaestros : Form
    {
        public frm_ModificarMaestros()
        {
            InitializeComponent();
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
                this.cb_Id.DisplayMember = "pk_maestro";
                this.cb_Id.ValueMember = "pk_maestro";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        

        private void frm_ModificarMaestros_Load(object sender, EventArgs e)
        {
            GetColumnOnComboBox();
        }

        private void cb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection Conn = new SqlCeConnection(@"Data Source=|DataDirectory|\test.sdf;Password=#Test2014;Persist Security Info=True");
            try
            {
                Conn.Open();
                string str = "SELECT * FROM tb_maestro WHERE pk_maestro ='" + cb_Id.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, Conn);
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_nombre.Text = dr["nombre"].ToString() + " " + dr["ap_paterno"].ToString() + " " + dr["ap_materno"].ToString();
                    dateTimePicker1.Text = dr["fecha_ingreso"].ToString();
                    txt_telefono.Text = dr["telefono"].ToString();
                    txt_matricula.Text = dr["matricula_empleado"].ToString();
                    txt_email.Text = dr["email"].ToString();
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
            string pk_maestro = cb_Id.Text;
            string matricula_empleado = txt_matricula.Text;
            string fecha_ingreso = dateTimePicker1.Value.ToString("yyyy-mm-dd hh:MM:ss");
            string email = txt_email.Text;
            string telefono = txt_telefono.Text;

            string sqlquery = ("UPDATE tb_maestro SET matricula_empleado=@matricula_empleado, fecha_ingreso=@fecha_ingreso, email=@email, telefono=@telefono WHERE pk_maestro = @pk_maestro");

            SqlCeCommand cmd = new SqlCeCommand(sqlquery, Conn);
            cmd.Parameters.Add("@pk_maestro", pk_maestro);
            cmd.Parameters.Add("@matricula_empleado", matricula_empleado);
            cmd.Parameters.Add("@fecha_ingreso", fecha_ingreso);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("telefono", telefono);
            try
                    {
                        int affectedrows = cmd.ExecuteNonQuery();

                        if (affectedrows > 0)
                        {
                            MessageBox.Show("Los datos del Maestro se actualizaron exitosamente", "Modificacion de Maestros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            catch(Exception u)
            {
                MessageBox.Show(u.Message);
                MessageBox.Show("Fallo al actualizar la informacion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_Id.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            txt_matricula.Text = "";
            txt_email.Text = "";
            dateTimePicker1.ResetText();
        }
    }
}
