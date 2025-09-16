using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
