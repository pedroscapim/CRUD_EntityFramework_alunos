using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EntityFramework_alunos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormAgenda = new FormAgenda();
            FormAgenda.Show();
        }

        private void salaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormSala = new FormSala();
            FormSala.Show();
        }
    }
}
