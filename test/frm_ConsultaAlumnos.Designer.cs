namespace test
{
    partial class frm_ConsultaAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Id = new System.Windows.Forms.ComboBox();
            this.tbAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new test.testDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.tb_AlumnoTableAdapter = new test.testDataSetTableAdapters.tb_AlumnoTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.tbAlumnotbcalificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_calificacionesTableAdapter = new test.testDataSetTableAdapters.tb_calificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlumnotbcalificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Alumno";
            // 
            // cb_Id
            // 
            this.cb_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Id.FormattingEnabled = true;
            this.cb_Id.Location = new System.Drawing.Point(121, 41);
            this.cb_Id.Name = "cb_Id";
            this.cb_Id.Size = new System.Drawing.Size(121, 21);
            this.cb_Id.TabIndex = 1;
            this.cb_Id.SelectedIndexChanged += new System.EventHandler(this.cb_Id_SelectedIndexChanged);
            // 
            // tbAlumnoBindingSource
            // 
            this.tbAlumnoBindingSource.DataMember = "tb_Alumno";
            this.tbAlumnoBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(121, 80);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(222, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(121, 117);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(222, 20);
            this.txt_fecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(121, 156);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(222, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // tb_AlumnoTableAdapter
            // 
            this.tb_AlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matricula";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(121, 189);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.ReadOnly = true;
            this.txt_matricula.Size = new System.Drawing.Size(222, 20);
            this.txt_matricula.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(121, 222);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(222, 20);
            this.txt_email.TabIndex = 12;
            // 
            // tbAlumnotbcalificacionesBindingSource
            // 
            this.tbAlumnotbcalificacionesBindingSource.DataMember = "tb_Alumno_tb_calificaciones";
            this.tbAlumnotbcalificacionesBindingSource.DataSource = this.tbAlumnoBindingSource;
            // 
            // tb_calificacionesTableAdapter
            // 
            this.tb_calificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ConsultaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 296);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Id);
            this.Controls.Add(this.label1);
            this.Name = "frm_ConsultaAlumnos";
            this.Text = "Sistema Escolar: Consulta de Alumnos";
            this.Load += new System.EventHandler(this.frm_ConsultaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlumnotbcalificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefono;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource tbAlumnoBindingSource;
        private testDataSetTableAdapters.tb_AlumnoTableAdapter tb_AlumnoTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.BindingSource tbAlumnotbcalificacionesBindingSource;
        private testDataSetTableAdapters.tb_calificacionesTableAdapter tb_calificacionesTableAdapter;
    }
}