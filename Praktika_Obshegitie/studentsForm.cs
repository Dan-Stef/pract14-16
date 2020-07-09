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
    public partial class studentsForm : Form
    {
        public studentsForm()
        {
            InitializeComponent();
        }

        private void studentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasePraktikaDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.databasePraktikaDataSet.Students);

        }

        private void updateS_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(databasePraktikaDataSet);
        }
    }
}
