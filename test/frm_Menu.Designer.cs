namespace test
{
    partial class frm_Menu
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_altamaestro = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_consultamaestro = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_bajamaestro = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_altaalumno = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_consultaalumno = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_bajaalumno = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_altamateria = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_altamaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_consultamateria = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_altacali = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_consultacali = new System.Windows.Forms.ToolStripMenuItem();
            this.opc_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.opc_altamateria,
            this.calificacionesToolStripMenuItem,
            this.opc_salir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(519, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opc_altamaestro,
            this.opc_consultamaestro,
            this.opc_bajamaestro});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.altaToolStripMenuItem.Text = "Maestros";
            // 
            // opc_altamaestro
            // 
            this.opc_altamaestro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.opc_altamaestro.Name = "opc_altamaestro";
            this.opc_altamaestro.Size = new System.Drawing.Size(157, 22);
            this.opc_altamaestro.Text = "Alta / Modificar";
            this.opc_altamaestro.Click += new System.EventHandler(this.opc_altamaestro_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // opc_consultamaestro
            // 
            this.opc_consultamaestro.Name = "opc_consultamaestro";
            this.opc_consultamaestro.Size = new System.Drawing.Size(157, 22);
            this.opc_consultamaestro.Text = "Consulta";
            this.opc_consultamaestro.Click += new System.EventHandler(this.opc_consultamaestro_Click);
            // 
            // opc_bajamaestro
            // 
            this.opc_bajamaestro.Name = "opc_bajamaestro";
            this.opc_bajamaestro.Size = new System.Drawing.Size(157, 22);
            this.opc_bajamaestro.Text = "Baja";
            this.opc_bajamaestro.Click += new System.EventHandler(this.opc_bajamaestro_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opc_altaalumno,
            this.opc_consultaalumno,
            this.opc_bajaalumno});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.exportarToolStripMenuItem.Text = "Alumnos";
            // 
            // opc_altaalumno
            // 
            this.opc_altaalumno.Name = "opc_altaalumno";
            this.opc_altaalumno.Size = new System.Drawing.Size(121, 22);
            this.opc_altaalumno.Text = "Alta";
            this.opc_altaalumno.Click += new System.EventHandler(this.opc_altaalumno_Click);
            // 
            // opc_consultaalumno
            // 
            this.opc_consultaalumno.Name = "opc_consultaalumno";
            this.opc_consultaalumno.Size = new System.Drawing.Size(121, 22);
            this.opc_consultaalumno.Text = "Consulta";
            this.opc_consultaalumno.Click += new System.EventHandler(this.opc_consultaalumno_Click);
            // 
            // opc_bajaalumno
            // 
            this.opc_bajaalumno.Name = "opc_bajaalumno";
            this.opc_bajaalumno.Size = new System.Drawing.Size(121, 22);
            this.opc_bajaalumno.Text = "Baja";
            this.opc_bajaalumno.Click += new System.EventHandler(this.opc_bajaalumno_Click);
            // 
            // opc_altamateria
            // 
            this.opc_altamateria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opc_altamaterias,
            this.opc_consultamateria});
            this.opc_altamateria.Name = "opc_altamateria";
            this.opc_altamateria.Size = new System.Drawing.Size(64, 20);
            this.opc_altamateria.Text = "Materias";
            // 
            // opc_altamaterias
            // 
            this.opc_altamaterias.Name = "opc_altamaterias";
            this.opc_altamaterias.Size = new System.Drawing.Size(121, 22);
            this.opc_altamaterias.Text = "Alta";
            this.opc_altamaterias.Click += new System.EventHandler(this.opc_altamaterias_Click);
            // 
            // opc_consultamateria
            // 
            this.opc_consultamateria.Name = "opc_consultamateria";
            this.opc_consultamateria.Size = new System.Drawing.Size(121, 22);
            this.opc_consultamateria.Text = "Consulta";
            this.opc_consultamateria.Click += new System.EventHandler(this.opc_consultamateria_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opc_altacali,
            this.opc_consultacali});
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            // 
            // opc_altacali
            // 
            this.opc_altacali.Name = "opc_altacali";
            this.opc_altacali.Size = new System.Drawing.Size(121, 22);
            this.opc_altacali.Text = "Alta";
            this.opc_altacali.Click += new System.EventHandler(this.opc_altacali_Click);
            // 
            // opc_consultacali
            // 
            this.opc_consultacali.Name = "opc_consultacali";
            this.opc_consultacali.Size = new System.Drawing.Size(121, 22);
            this.opc_consultacali.Text = "Consulta";
            this.opc_consultacali.Click += new System.EventHandler(this.opc_consultacali_Click);
            // 
            // opc_salir
            // 
            this.opc_salir.Name = "opc_salir";
            this.opc_salir.Size = new System.Drawing.Size(41, 20);
            this.opc_salir.Text = "Salir";
            this.opc_salir.Click += new System.EventHandler(this.opc_salir_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 310);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frm_Menu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opc_altamaestro;
        private System.Windows.Forms.ToolStripMenuItem opc_consultamaestro;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opc_bajamaestro;
        private System.Windows.Forms.ToolStripMenuItem opc_altaalumno;
        private System.Windows.Forms.ToolStripMenuItem opc_consultaalumno;
        private System.Windows.Forms.ToolStripMenuItem opc_bajaalumno;
        private System.Windows.Forms.ToolStripMenuItem opc_altamateria;
        private System.Windows.Forms.ToolStripMenuItem opc_altamaterias;
        private System.Windows.Forms.ToolStripMenuItem opc_consultamateria;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opc_altacali;
        private System.Windows.Forms.ToolStripMenuItem opc_consultacali;
        private System.Windows.Forms.ToolStripMenuItem opc_salir;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}

