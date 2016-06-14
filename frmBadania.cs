using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BizzLayer;
namespace Przychodnia
{
    public partial class frmBadania : Form
    {
        public frmBadania()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = MedicalExaminationFacade.GetExaminations();
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {

        }

        private void btnWykonaj_Click(object sender, EventArgs e)
        {

        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {

        }

    }
}
