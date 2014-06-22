﻿using System;
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
    public partial class frm_AltaMaestros : Form
    {
        public frm_AltaMaestros()
        {
            InitializeComponent();
        }

        private void frm_AltaMaestros_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
              if (txt_nombre.Text == "")
                {
                    MessageBox.Show("Error, no se pudo guardar debido a que no se inserto el nombre del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nombre.Focus();
                
                    if (txt_aPaterno.Text == "")
                    {
                        MessageBox.Show("Error, no se pudo guardar debido a que no se inserto el apellido paterno del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_aPaterno.Focus();
                    }
                    if (txt_aMaterno.Text == "")
                    {
                        MessageBox.Show("Error, no se pudo guardar debido a que no se inserto el apellido materno del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_aMaterno.Focus();
                    }
                    if (txt_matricula.Text == "")
                    {
                        MessageBox.Show("Error, no se pudo guardar debido a que no se inserto la matricula del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_matricula.Focus();
                    }
                    if (txt_email.Text == "")
                    {
                        MessageBox.Show("Error, no se pudo guardar debido a que no se inserto el email del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Focus();
                    }
                    if (txt_telefono.Text == "")
                    {
                        MessageBox.Show("Error, no se puede guardar debido a que no se inserto el telefono del maestro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_telefono.Focus();
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
                        MessageBox.Show(ex.Message);
                    }
                    
                    string nombre = txt_nombre.Text;
                    string ap_paterno = txt_aPaterno.Text;
                    string ap_materno = txt_aMaterno.Text;
                    string matricula_empleado = txt_matricula.Text;
                    string fecha_ingreso = dateTimePicker1.Value.ToString("yyyy-mm-dd hh:MM:ss");
                    string email = txt_email.Text;
                    string telefono = txt_telefono.Text;

                    string sqlquery = ("INSERT INTO tb_Maestro (nombre, ap_paterno, ap_materno, matricula_empleado, fecha_ingreso, email, telefono) VALUES (@nombre, @ap_paterno, @ap_materno, @matricula_empleado, @fecha_ingreso, @email, @telefono)");
                    
                    SqlCeCommand cmd = new SqlCeCommand(sqlquery, Conn);
                    cmd.Parameters.Add("@nombre", nombre);
                    cmd.Parameters.Add("@ap_paterno", ap_paterno);
                    cmd.Parameters.Add("@ap_materno", ap_materno);
                    cmd.Parameters.Add("@matricula_empleado", matricula_empleado);
                    cmd.Parameters.Add("@fecha_ingreso", dateTimePicker1.Value);
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@telefono", telefono);
                    
                    try
                    {
                        int affectedrows = cmd.ExecuteNonQuery();

                        if (affectedrows > 0)
                        {
                            MessageBox.Show("Los datos del Maestro: " + nombre + " " + ap_paterno + " " + ap_materno + " se han guardado exitosamente", "Alta de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch(Exception u)
                    {
                        MessageBox.Show(u.Message);
                        MessageBox.Show("Fallo al guardar la informacion");
                    }
                }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_aPaterno.Clear();
            txt_aMaterno.Clear();
            txt_matricula.Clear();
            txt_email.Clear();
            txt_telefono.Clear();
            dateTimePicker1.ResetText();

            txt_nombre.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
