namespace test
{
    partial class frm_AltaCali
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.txt_maestro = new System.Windows.Forms.TextBox();
            this.cb_maestro = new System.Windows.Forms.ComboBox();
            this.cb_alumno = new System.Windows.Forms.ComboBox();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_calif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_materias = new System.Windows.Forms.ComboBox();
            this.tbmateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new test.testDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_materiasTableAdapter = new test.testDataSetTableAdapters.tb_materiasTableAdapter();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_alumno);
            this.groupBox1.Controls.Add(this.txt_maestro);
            this.groupBox1.Controls.Add(this.cb_maestro);
            this.groupBox1.Controls.Add(this.cb_alumno);
            this.groupBox1.Controls.Add(this.txt_observaciones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_calif);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_materia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_materias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Calificaciones";
            // 
            // txt_alumno
            // 
            this.txt_alumno.Enabled = false;
            this.txt_alumno.Location = new System.Drawing.Point(184, 116);
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.ReadOnly = true;
            this.txt_alumno.Size = new System.Drawing.Size(263, 20);
            this.txt_alumno.TabIndex = 17;
            // 
            // txt_maestro
            // 
            this.txt_maestro.Enabled = false;
            this.txt_maestro.Location = new System.Drawing.Point(184, 79);
            this.txt_maestro.Name = "txt_maestro";
            this.txt_maestro.ReadOnly = true;
            this.txt_maestro.Size = new System.Drawing.Size(263, 20);
            this.txt_maestro.TabIndex = 16;
            // 
            // cb_maestro
            // 
            this.cb_maestro.FormattingEnabled = true;
            this.cb_maestro.Location = new System.Drawing.Point(98, 79);
            this.cb_maestro.Name = "cb_maestro";
            this.cb_maestro.Size = new System.Drawing.Size(80, 21);
            this.cb_maestro.TabIndex = 15;
            this.cb_maestro.SelectedIndexChanged += new System.EventHandler(this.cb_maestro_SelectedIndexChanged);
            // 
            // cb_alumno
            // 
            this.cb_alumno.FormattingEnabled = true;
            this.cb_alumno.Location = new System.Drawing.Point(98, 116);
            this.cb_alumno.Name = "cb_alumno";
            this.cb_alumno.Size = new System.Drawing.Size(80, 21);
            this.cb_alumno.TabIndex = 14;
            this.cb_alumno.SelectedIndexChanged += new System.EventHandler(this.cb_alumno_SelectedIndexChanged);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(98, 196);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(349, 66);
            this.txt_observaciones.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Observaciones";
            // 
            // txt_calif
            // 
            this.txt_calif.Location = new System.Drawing.Point(98, 155);
            this.txt_calif.Name = "txt_calif";
            this.txt_calif.Size = new System.Drawing.Size(80, 20);
            this.txt_calif.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maestro";
            // 
            // txt_materia
            // 
            this.txt_materia.Enabled = false;
            this.txt_materia.Location = new System.Drawing.Point(263, 24);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.ReadOnly = true;
            this.txt_materia.Size = new System.Drawing.Size(184, 20);
            this.txt_materia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Materia";
            // 
            // cb_materias
            // 
            this.cb_materias.DataSource = this.tbmateriasBindingSource;
            this.cb_materias.DisplayMember = "pk_materia";
            this.cb_materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_materias.FormattingEnabled = true;
            this.cb_materias.Location = new System.Drawing.Point(98, 24);
            this.cb_materias.Name = "cb_materias";
            this.cb_materias.Size = new System.Drawing.Size(80, 21);
            this.cb_materias.TabIndex = 1;
            this.cb_materias.ValueMember = "pk_materia";
            this.cb_materias.SelectedIndexChanged += new System.EventHandler(this.cb_materias_SelectedIndexChanged);
            // 
            // tbmateriasBindingSource
            // 
            this.tbmateriasBindingSource.DataMember = "tb_materias";
            this.tbmateriasBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave Materia";
            // 
            // tb_materiasTableAdapter
            // 
            this.tb_materiasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(510, 34);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(510, 85);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(510, 142);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_AltaCali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 318);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_AltaCali";
            this.Text = "Sistema Escolar: Alta de Calificaciones";
            this.Load += new System.EventHandler(this.frm_AltaCali_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_materias;
        private System.Windows.Forms.Label label1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource tbmateriasBindingSource;
        private testDataSetTableAdapters.tb_materiasTableAdapter tb_materiasTableAdapter;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cb_maestro;
        private System.Windows.Forms.ComboBox cb_alumno;
        private System.Windows.Forms.TextBox txt_calif;
        private System.Windows.Forms.TextBox txt_maestro;
        private System.Windows.Forms.TextBox txt_alumno;
    }
}