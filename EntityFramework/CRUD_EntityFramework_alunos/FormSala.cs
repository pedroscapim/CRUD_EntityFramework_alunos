using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace CRUD_EntityFramework_alunos
{
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }


        public void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                grid1.DataSource = null;
                grid1.DataSource = tb.objetosalaaula.ToList();
            }
        }


        private void btninserir_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                tb.objetosalaaula.Add(new salaaula { });
                tb.SaveChanges();
            }
            txtprof.Clear();
            txtsala.Clear();
            txtcurso.Clear();
            txtdata.Clear();
            MessageBox.Show("Inlcuido com Sucesso", "inclusão");
            AtualizaGrid();

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.objetosalaaula.Find(Convert.ToInt32(txtid.Text));
                    objeto.professor = txtprof.Text;
                    objeto.sala = txtsala.Text;
                    objeto.curso = txtcurso.Text;
                    objeto.data = txtdata.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("ALTERAÇÃO REALIZADA COM SUCESSO", "AVISO");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.objetosalaaula.Find(Convert.ToInt32(txtid.Text));
                    tb.objetosalaaula.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com Sucesso", "Aviso");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }

        private void FormSala_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtid.Text = grid1.CurrentRow.Cells[0].Value.ToString();
                txtprof.Text = grid1.CurrentRow.Cells[1].Value.ToString();
                txtsala.Text = grid1.CurrentRow.Cells[2].Value.ToString();
                txtcurso.Text = grid1.CurrentRow.Cells[3].Value.ToString();
                txtdata.Text = grid1.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
