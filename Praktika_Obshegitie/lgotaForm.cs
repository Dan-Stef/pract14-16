using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_Obshegitie
{
    public partial class lgotaForm : Form
    {
        public lgotaForm()
        {
            InitializeComponent();
        }

        private void lgotaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasePraktikaDataSet.Lgota". При необходимости она может быть перемещена или удалена.
            this.lgotaTableAdapter.Fill(this.databasePraktikaDataSet.Lgota);

        }

        private void updateL_Click(object sender, EventArgs e)
        {
            lgotaTableAdapter.Update(databasePraktikaDataSet);
        }
    }
}
