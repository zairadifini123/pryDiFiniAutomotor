namespace pryDiFiniAutomotor
{
    partial class frmAutomotor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutomotor));
            lblTitulo = new Label();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblExperiencia = new Label();
            txtExperiencia = new TextBox();
            txtAccidentes = new TextBox();
            v = new Label();
            lblLicencia = new Label();
            cmbLicencia = new ComboBox();
            lblSeguro = new Label();
            rdbBasico = new RadioButton();
            rdbIntermedio = new RadioButton();
            rdbPremium = new RadioButton();
            btnValidar = new Button();
            btnSalir = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(527, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de contol de seguro automotor";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(12, 81);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(176, 25);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad del conductor";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(200, 83);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExperiencia.Location = new Point(12, 146);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(182, 25);
            lblExperiencia.TabIndex = 3;
            lblExperiencia.Text = "Años de experiencia";
            // 
            // txtExperiencia
            // 
            txtExperiencia.Location = new Point(200, 151);
            txtExperiencia.Name = "txtExperiencia";
            txtExperiencia.Size = new Size(100, 23);
            txtExperiencia.TabIndex = 4;
            txtExperiencia.KeyPress += txtExperiencia_KeyPress;
            // 
            // txtAccidentes
            // 
            txtAccidentes.Location = new Point(226, 222);
            txtAccidentes.Name = "txtAccidentes";
            txtAccidentes.Size = new Size(100, 23);
            txtAccidentes.TabIndex = 6;
            txtAccidentes.KeyPress += txtAccidentes_KeyPress_1;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            v.Location = new Point(12, 217);
            v.Name = "v";
            v.Size = new Size(208, 25);
            v.TabIndex = 5;
            v.Text = "Cantidad de accidentes";
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicencia.Location = new Point(343, 83);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(145, 25);
            lblLicencia.TabIndex = 7;
            lblLicencia.Text = "¿Tiene licencia?";
            // 
            // cmbLicencia
            // 
            cmbLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicencia.FormattingEnabled = true;
            cmbLicencia.Items.AddRange(new object[] { "SI", "NO" });
            cmbLicencia.Location = new Point(494, 85);
            cmbLicencia.Name = "cmbLicencia";
            cmbLicencia.Size = new Size(121, 23);
            cmbLicencia.TabIndex = 8;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeguro.Location = new Point(343, 148);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(138, 25);
            lblSeguro.TabIndex = 9;
            lblSeguro.Text = "Tipo de seguro";
            // 
            // rdbBasico
            // 
            rdbBasico.AutoSize = true;
            rdbBasico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbBasico.Location = new Point(494, 146);
            rdbBasico.Name = "rdbBasico";
            rdbBasico.Size = new Size(84, 29);
            rdbBasico.TabIndex = 10;
            rdbBasico.TabStop = true;
            rdbBasico.Text = "Basico";
            rdbBasico.UseVisualStyleBackColor = true;
            // 
            // rdbIntermedio
            // 
            rdbIntermedio.AutoSize = true;
            rdbIntermedio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbIntermedio.Location = new Point(494, 181);
            rdbIntermedio.Name = "rdbIntermedio";
            rdbIntermedio.Size = new Size(122, 29);
            rdbIntermedio.TabIndex = 11;
            rdbIntermedio.TabStop = true;
            rdbIntermedio.Text = "Intermedio";
            rdbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rdbPremium
            // 
            rdbPremium.AutoSize = true;
            rdbPremium.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPremium.Location = new Point(494, 215);
            rdbPremium.Name = "rdbPremium";
            rdbPremium.Size = new Size(106, 29);
            rdbPremium.TabIndex = 12;
            rdbPremium.TabStop = true;
            rdbPremium.Text = "Premium";
            rdbPremium.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(430, 294);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(213, 23);
            btnValidar.TabIndex = 13;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 294);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(213, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(12, 349);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(631, 154);
            lstResultados.TabIndex = 15;
            // 
            // frmAutomotor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 539);
            Controls.Add(lstResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnValidar);
            Controls.Add(rdbPremium);
            Controls.Add(rdbIntermedio);
            Controls.Add(rdbBasico);
            Controls.Add(lblSeguro);
            Controls.Add(cmbLicencia);
            Controls.Add(lblLicencia);
            Controls.Add(txtAccidentes);
            Controls.Add(v);
            Controls.Add(txtExperiencia);
            Controls.Add(lblExperiencia);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAutomotor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAutomotor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblExperiencia;
        private TextBox txtExperiencia;
        private TextBox txtAccidentes;
        private Label v;
        private Label lblLicencia;
        private ComboBox cmbLicencia;
        private Label lblSeguro;
        private RadioButton rdbBasico;
        private RadioButton rdbIntermedio;
        private RadioButton rdbPremium;
        private Button btnValidar;
        private Button btnSalir;
        private ListBox lstResultados;
    }
}
