using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryDiFiniReservas
{
    public partial class frmCabañas : Form
    {
        // constantes para los cálculos
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float Cocina = 1;
        const float Heladera = 1.5f;
        const float Televisor = 2;
        const float Personas = 1;
        public frmCabañas()
        {
            InitializeComponent();
        }

        private void frmCabañas_Load(object sender, EventArgs e)
        {
            // cargar los items en el primer control combobox
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");
            // esta acción provoca el disparo del evento "SelectedIndexChanged"
            cmbTipo.SelectedIndex = 0;
            // se inicializa la cantidad de días en 1
            txtDias.Text = "1";
            // inicialzar los demás controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            // cargar los items del combo de tarjetas
            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"
            btnAceptar.Enabled = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el
            // contenido del combo de personas
            int I = 0;
            // limpiar los items de personas
            cmbPersonas.Items.Clear();
            // si es tipo de cabaña A ->> cargar los items del 1 al 4
            if (cmbTipo.SelectedIndex == 0) // o cmbTipo.SelectedItem == "Tipo A"
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            else
            { // si es tipo de cabaña B ->> cargar los items del 1 al 8
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            // establecer como preseleccionado el item 0 del combo
            cmbPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada
            cmbTarjetas.Enabled = false;
            cmbTarjetas.SelectedIndex = -1;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item
            cmbTarjetas.Enabled = true;
            cmbTarjetas.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;

            // obtener la cantidad de dìas ingresados
            Dias = int.Parse(txtDias.Text);
            // controlar el tipo de cabaña para determinar el precio base
            if (cmbTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }
            // sumar al precio base el importe extra por persona (US$ 1)
            PrecioBase = PrecioBase + (Personas * int.Parse(cmbPersonas.Text));
            // controlar los adicionales por las opciones
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + Cocina;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + Heladera;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + Televisor;
            }
            // determinar el total por la cantidad de dìas
            Total = (PrecioBase + Opcionales) * Dias;
            // controlar la forma de pago
            if (optTarjeta.Checked == true)
            {
                if (cmbTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }
            // mostrar el resultado
            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // inicialzar los controles de la interfaz

            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }
    }
    }

