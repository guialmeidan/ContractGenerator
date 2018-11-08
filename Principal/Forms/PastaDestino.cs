using DevExpress.XtraEditors;
using Principal.Domain.Repositories;
using Principal.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Principal.Forms
{
    public partial class PastaDestino : XtraForm
    {
        private IDiretorioArmazenamentoRepositorio _repositorioDiretorioArmazenamento;
        private Domain.Entities.DiretorioArmazenamento _diretorioArmazenamento;

        public PastaDestino()
        {
            InitializeComponent();
            _repositorioDiretorioArmazenamento = AppCore.Container.Resolve<IDiretorioArmazenamentoRepositorio>();
            _diretorioArmazenamento = _repositorioDiretorioArmazenamento.ObterCaminho();
            this.inputCaminhoPasta.Text = _diretorioArmazenamento.Caminho;
        }

        private void inputCaminhoPasta_EditValueChanged(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.inputCaminhoPasta.Text = fbd.SelectedPath;
                }
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputCaminhoPasta.Text == "")
                    XtraMessageBox.Show("Selecione a pasta corretamente!\n", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (XtraMessageBox.Show("Tem certeza que deseja atualizar a pasta de destino?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _diretorioArmazenamento.Caminho = this.inputCaminhoPasta.Text;
                    _repositorioDiretorioArmazenamento.Atualizar(_diretorioArmazenamento);
                    inputCaminhoPasta.Text = _diretorioArmazenamento.Caminho;
                    XtraMessageBox.Show("Pasta de destino alterada!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao atualizar pasta de destino!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputCaminhoPasta_EditValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
