using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viagens
{
    public partial class relatorios : Form
    {
        public relatorios()
        {
            InitializeComponent();
        }

        private void relatorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoDataSet1.participantes' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.Fill(this.projetoDataSet1.participantes);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
