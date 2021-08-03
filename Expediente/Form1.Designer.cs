namespace Expediente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageArchivo = new System.Windows.Forms.TabPage();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.richTextBoxAntecedentes = new System.Windows.Forms.RichTextBox();
            this.buttonRecargar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelAntecdentes = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.textBoxEdad2 = new System.Windows.Forms.TextBox();
            this.labelExpediente = new System.Windows.Forms.Label();
            this.textBoxExpedienteBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewArbol = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageArbol = new System.Windows.Forms.TabPage();
            this.richTextBoxArbol = new System.Windows.Forms.RichTextBox();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageArchivo.SuspendLayout();
            this.tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbol)).BeginInit();
            this.tabPageArbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageArchivo);
            this.tabControlPrincipal.Controls.Add(this.tabPageBuscar);
            this.tabControlPrincipal.Controls.Add(this.tabPageArbol);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(473, 399);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabPageArchivo
            // 
            this.tabPageArchivo.Controls.Add(this.buttonNuevo);
            this.tabPageArchivo.Controls.Add(this.richTextBoxAntecedentes);
            this.tabPageArchivo.Controls.Add(this.buttonRecargar);
            this.tabPageArchivo.Controls.Add(this.buttonAgregar);
            this.tabPageArchivo.Controls.Add(this.textBoxEdad);
            this.tabPageArchivo.Controls.Add(this.textBoxNombre);
            this.tabPageArchivo.Controls.Add(this.labelAntecdentes);
            this.tabPageArchivo.Controls.Add(this.labelEdad);
            this.tabPageArchivo.Controls.Add(this.labelNombre);
            this.tabPageArchivo.Location = new System.Drawing.Point(4, 22);
            this.tabPageArchivo.Name = "tabPageArchivo";
            this.tabPageArchivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArchivo.Size = new System.Drawing.Size(465, 373);
            this.tabPageArchivo.TabIndex = 1;
            this.tabPageArchivo.Text = "Archivo";
            this.tabPageArchivo.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(270, 339);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 9;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Visible = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // richTextBoxAntecedentes
            // 
            this.richTextBoxAntecedentes.Location = new System.Drawing.Point(17, 108);
            this.richTextBoxAntecedentes.Name = "richTextBoxAntecedentes";
            this.richTextBoxAntecedentes.Size = new System.Drawing.Size(430, 225);
            this.richTextBoxAntecedentes.TabIndex = 8;
            this.richTextBoxAntecedentes.Text = "";
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.Location = new System.Drawing.Point(108, 338);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecargar.TabIndex = 7;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = true;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(270, 338);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(90, 64);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(90, 31);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelAntecdentes
            // 
            this.labelAntecdentes.AutoSize = true;
            this.labelAntecdentes.Location = new System.Drawing.Point(5, 92);
            this.labelAntecdentes.Name = "labelAntecdentes";
            this.labelAntecdentes.Size = new System.Drawing.Size(70, 13);
            this.labelAntecdentes.TabIndex = 2;
            this.labelAntecdentes.Text = "Antecdentes:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(39, 64);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 1;
            this.labelEdad.Text = "Edad:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(27, 31);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // tabPageBuscar
            // 
            this.tabPageBuscar.Controls.Add(this.richTextBoxDes);
            this.tabPageBuscar.Controls.Add(this.label3);
            this.tabPageBuscar.Controls.Add(this.label2);
            this.tabPageBuscar.Controls.Add(this.label1);
            this.tabPageBuscar.Controls.Add(this.textBoxNombre2);
            this.tabPageBuscar.Controls.Add(this.textBoxEdad2);
            this.tabPageBuscar.Controls.Add(this.labelExpediente);
            this.tabPageBuscar.Controls.Add(this.textBoxExpedienteBuscar);
            this.tabPageBuscar.Controls.Add(this.buttonBuscar);
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscar.Size = new System.Drawing.Size(465, 373);
            this.tabPageBuscar.TabIndex = 2;
            this.tabPageBuscar.Text = "Buscar";
            this.tabPageBuscar.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Location = new System.Drawing.Point(76, 177);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.ReadOnly = true;
            this.richTextBoxDes.Size = new System.Drawing.Size(345, 171);
            this.richTextBoxDes.TabIndex = 9;
            this.richTextBoxDes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Enabled = false;
            this.textBoxNombre2.Location = new System.Drawing.Point(56, 122);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre2.TabIndex = 5;
            // 
            // textBoxEdad2
            // 
            this.textBoxEdad2.Enabled = false;
            this.textBoxEdad2.Location = new System.Drawing.Point(56, 148);
            this.textBoxEdad2.Name = "textBoxEdad2";
            this.textBoxEdad2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad2.TabIndex = 4;
            // 
            // labelExpediente
            // 
            this.labelExpediente.AutoSize = true;
            this.labelExpediente.Location = new System.Drawing.Point(25, 26);
            this.labelExpediente.Name = "labelExpediente";
            this.labelExpediente.Size = new System.Drawing.Size(117, 13);
            this.labelExpediente.TabIndex = 2;
            this.labelExpediente.Text = "Nombre del Expediente";
            // 
            // textBoxExpedienteBuscar
            // 
            this.textBoxExpedienteBuscar.Location = new System.Drawing.Point(28, 42);
            this.textBoxExpedienteBuscar.Name = "textBoxExpedienteBuscar";
            this.textBoxExpedienteBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpedienteBuscar.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(36, 68);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewArbol
            // 
            this.dataGridViewArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Valor});
            this.dataGridViewArbol.Location = new System.Drawing.Point(95, 123);
            this.dataGridViewArbol.Name = "dataGridViewArbol";
            this.dataGridViewArbol.RowHeadersVisible = false;
            this.dataGridViewArbol.Size = new System.Drawing.Size(204, 242);
            this.dataGridViewArbol.TabIndex = 1;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // tabPageArbol
            // 
            this.tabPageArbol.Controls.Add(this.dataGridViewArbol);
            this.tabPageArbol.Controls.Add(this.richTextBoxArbol);
            this.tabPageArbol.Location = new System.Drawing.Point(4, 22);
            this.tabPageArbol.Name = "tabPageArbol";
            this.tabPageArbol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArbol.Size = new System.Drawing.Size(465, 373);
            this.tabPageArbol.TabIndex = 3;
            this.tabPageArbol.Text = "Arbol";
            this.tabPageArbol.UseVisualStyleBackColor = true;
            // 
            // richTextBoxArbol
            // 
            this.richTextBoxArbol.Location = new System.Drawing.Point(8, 6);
            this.richTextBoxArbol.Name = "richTextBoxArbol";
            this.richTextBoxArbol.Size = new System.Drawing.Size(449, 111);
            this.richTextBoxArbol.TabIndex = 0;
            this.richTextBoxArbol.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 399);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageArchivo.ResumeLayout(false);
            this.tabPageArchivo.PerformLayout();
            this.tabPageBuscar.ResumeLayout(false);
            this.tabPageBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbol)).EndInit();
            this.tabPageArbol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageArchivo;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelAntecdentes;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonRecargar;
        private System.Windows.Forms.RichTextBox richTextBoxAntecedentes;
        private System.Windows.Forms.TabPage tabPageBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Label labelExpediente;
        private System.Windows.Forms.TextBox textBoxExpedienteBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.TextBox textBoxEdad2;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private System.Windows.Forms.TabPage tabPageArbol;
        private System.Windows.Forms.DataGridView dataGridViewArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.RichTextBox richTextBoxArbol;
    }
}

