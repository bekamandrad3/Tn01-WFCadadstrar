using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroEndereco
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.NomeCompleto = txtNomeCompleto.Text;
            p1.DddTelefone = mkdTelefone.Text;
            p1.DataNascimento = dtpDataDeNascimento.Value;
            p1.Escolaridade = cbxEscolaridade.SelectedText;

            if (rdbMasculino.Checked)
            {
                p1.Sexo = 'M';

            }
            else if (rdbFeminino.Checked)
            {
                p1.Sexo = 'F';
            }
            else if (rdbNaoInformar.Checked)
            {
                p1.Sexo = 'N';
            }
            else
            {
                MessageBox.Show("O Sexo não definido! ");
                return;
            }
        }
    }
}
