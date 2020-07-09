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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsForm roomsForm = new roomsForm();
            roomsForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsForm studentsForm = new studentsForm();
            studentsForm.ShowDialog();
        }

        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lgotaForm lgotaForm = new lgotaForm();
            lgotaForm.ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm rasselenieForm = new RasselenieForm();
            rasselenieForm.ShowDialog();
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaprosForm zaprosForm = new ZaprosForm();
            zaprosForm.ShowDialog();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.ShowDialog();
        }
    }
}
