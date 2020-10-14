using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EntityFramework_alunos
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void btnINSERIR_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                tb.ObjetoAgenta.Add(new Agenda { nome = txtnome.Text, telefone = txttelefone.Text, cep=txtcep.Text });
                tb.SaveChanges();
            }
            txtnome.Clear();
            txttelefone.Clear();
            MessageBox.Show("Inlcuido com Sucesso", "inclusão");
            AtualizaGrid();

        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoAgenta.Find(Convert.ToInt32(txtid.Text));
                    objeto.nome = txtnome.Text;
                    objeto.telefone = txttelefone.Text;
                    objeto.cep = txtcep.Text;

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



        public void AtualizaGrid()
        {
            using (var tb = new Contexto ())
            {
                grid.DataSource = null;
                grid.DataSource = tb.ObjetoAgenta.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txttelefone.Text = grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                try
                {
                    var objeto = tb.ObjetoAgenta.Find(Convert.ToInt32(txtid.Text));
                    tb.ObjetoAgenta.Remove(objeto);
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

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
