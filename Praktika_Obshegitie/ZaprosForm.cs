using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Praktika_Obshegitie
{
    public partial class ZaprosForm : Form
    {
        public ZaprosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection MyConnection = new OleDbConnection("Provider = Microsoft.Jet.OleDb.4.0; Data Source = DatabasePraktika.mdb");
            MyConnection.Open();
            string s = "";
            if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
            if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            if (radioButton4.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
            if (radioButton5.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(s, MyConnection);
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MyConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
        }
    }
}
