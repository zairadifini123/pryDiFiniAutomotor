namespace pryDiFiniAutomotor
{
    public partial class frmAutomotor : Form
    {
        public frmAutomotor()
        {
            InitializeComponent();
        }
        struct Conductor
        {
            public int Edad;
            public int Experiencia;
            public int Accidentes;
            public bool Licencia;
            public string Seguro;
        }

        struct Resultados
        {
            public decimal CostoBase;
            public decimal RecargosAplicados;
            public decimal DescuentosAplicados;
            public decimal CostoFinal;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Conductor c;

            c.Edad = Convert.ToInt32(txtEdad.Text);
            c.Experiencia = Convert.ToInt32(txtExperiencia.Text);
            c.Accidentes = Convert.ToInt32(txtAccidentes.Text);
            c.Licencia = cmbLicencia.SelectedIndex == 0;

            // Seguro (RadioButtons)
            if (rdbBasico.Checked)
                c.Seguro = "Basico";
            else if (rdbIntermedio.Checked)
                c.Seguro = "Intermedio";
            else if (rdbPremium.Checked)
                c.Seguro = "Premium";
            else
                c.Seguro = "No seleccionado";

            Resultados r;

            decimal CostoBase = 0;
            r.CostoBase = CostoBase;
            decimal RecargosAplicados = 0;
            r.RecargosAplicados = RecargosAplicados;
            decimal DescuentosAplicados = 0;
            r.DescuentosAplicados = DescuentosAplicados;
            decimal CostoFinal = 0;
            r.CostoFinal = CostoFinal;

            if (c.Licencia == false)
            {
                MessageBox.Show("Seguro rechazado");
                this.Close();
                return;
            }

            if (c.Accidentes < 0)
            {
                MessageBox.Show("El numero de accidentes no puede ser negativo");
                this.Close();
                return;
            }

            if (c.Edad < 18)
            {
                MessageBox.Show("Debe ser mayor de 18 años.");
                return;
            }

            if (c.Experiencia > c.Edad - 17)
            {
                MessageBox.Show("La experiencia no puede ser mayor que Edad - 17.");
                return;
            }

            if (rdbBasico.Checked)
                CostoBase = CostoBase + 15000;
            else if (rdbIntermedio.Checked)
                CostoBase = CostoBase + 25000;
            else if (rdbPremium.Checked)
                CostoBase = CostoBase + 40000;
            else
                CostoBase = 0;

            Decimal RecargosAplicadosEdad = 0;
            Decimal RecargosAplicadosExperiencia = 0;
            Decimal RecargosAplicadosAccidentes = 0;

            if (c.Edad < 25)
            {
                RecargosAplicadosEdad = RecargosAplicadosEdad + 0.20m;
            }
            if (c.Experiencia < 2)
            {
                RecargosAplicadosExperiencia = RecargosAplicadosExperiencia + 0.15m;
            }
            if (c.Accidentes > 0)
            {
                RecargosAplicadosAccidentes = RecargosAplicadosAccidentes + (0.10m * c.Accidentes);
            }
            else
            {
                RecargosAplicados = 0;
            }

            RecargosAplicados = RecargosAplicadosEdad + RecargosAplicadosAccidentes + RecargosAplicadosExperiencia;

            decimal DescuentosAplicadosExperiencia = 0;
            decimal DescuentosAplicadosEdad = 0;

            if (c.Experiencia > 10 && c.Accidentes == 0)
            {
                DescuentosAplicadosExperiencia = 0.25m;

            }
            if (c.Edad > 40)
            {
                DescuentosAplicadosEdad = 0.10m;

            }

            DescuentosAplicados = DescuentosAplicadosExperiencia + DescuentosAplicadosEdad;

            CostoFinal = CostoBase * (1 + RecargosAplicados - DescuentosAplicados);

            lstResultados.Items.Add("Costo Base $ " + CostoBase);
            lstResultados.Items.Add("Recargos Aplicados % " + RecargosAplicados);
            lstResultados.Items.Add("Descuentos Aplicados % " + DescuentosAplicados);
            lstResultados.Items.Add("Costo Final $ " + CostoFinal);

        }

        private void txtExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtAccidentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtAccidentes_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
