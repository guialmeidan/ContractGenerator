using DevExpress.XtraEditors;
using Principal.Domain.Repositories;
using Principal.WinApp;
using Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms
{
    public partial class Testemunhas : XtraForm
    {
        private ITestemunhaRepositorio _repositorioTestemunha;
        private IPessoaRepositorio _repositorioPessoa;
        private Domain.Entities.Testemunha _testemunha;

        private int GV1Id;
        private string GV1Nome;
        private int GE1Id;
        private string GE1Nome;
        private int GT1Id;
        private string GT1Nome;

        private int GV2Id;
        private string GV2Nome;
        private int GE2Id;
        private string GE2Nome;
        private int GT2Id;
        private string GT2Nome;

        public Testemunhas()
        {
            InitializeComponent();
            _repositorioTestemunha = AppCore.Container.Resolve<ITestemunhaRepositorio>();
            _repositorioPessoa = AppCore.Container.Resolve<IPessoaRepositorio>();
            this.Text = "Cadastro de Testemunhas";
            popularTela();
        }

        private void popularTela()
        {
            _testemunha = _repositorioTestemunha.ObterTestemunhas();
            inputTestemunha1GV.Text = _testemunha.NomeTestemunha1GV;
            inputTestemunha2GV.Text = _testemunha.NomeTestemunha2GV;

            inputTestemunha1GE.Text = _testemunha.NomeTestemunha1GE;
            inputTestemunha2GE.Text = _testemunha.NomeTestemunha2GE;

            inputTestemunha1GT.Text = _testemunha.NomeTestemunha1GT;
            inputTestemunha2GT.Text = _testemunha.NomeTestemunha2GT;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //indica que houve alteracao de Testemunhas
                if (GV1Id > 0 && GV1Nome != null)
                {
                    _testemunha.IdTestemunha1GV = GV1Id;
                    _testemunha.NomeTestemunha1GV = inputTestemunha1GV.Text;
                }

                if (GV2Id > 0 && GV2Nome != null)
                {
                    _testemunha.IdTestemunha2GV = GV2Id;
                    _testemunha.NomeTestemunha2GV = inputTestemunha2GV.Text;
                }

                if (GE1Id > 0 && GE1Nome != null)
                {
                    _testemunha.IdTestemunha1GE = GE1Id;
                    _testemunha.NomeTestemunha1GE = inputTestemunha1GE.Text;
                }

                if (GE2Id > 0 && GE2Nome != null)
                {
                    _testemunha.IdTestemunha2GE = GE2Id;
                    _testemunha.NomeTestemunha2GE = inputTestemunha2GE.Text;
                }

                if (GT1Id > 0 && GT1Nome != null)
                {
                    _testemunha.IdTestemunha1GT = GT1Id;
                    _testemunha.NomeTestemunha1GT = inputTestemunha1GT.Text;
                }

                if (GT2Id > 0 && GT2Nome != null)
                {
                    _testemunha.IdTestemunha2GT = GT2Id;
                    _testemunha.NomeTestemunha2GT = inputTestemunha2GT.Text;
                }

                _repositorioTestemunha.Atualizar(_testemunha);

                XtraMessageBox.Show("Registro gravado!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao registrar testemunhas!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void inputGV1_EditButton(object sender, EventArgs e)
        {
            var GV = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GV1Id = form.SelectedItem.Id;
            GV1Nome = form.SelectedItem.Nome;
            if(GV1Id != 0)
                inputTestemunha1GV.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputGV2_EditButton(object sender, EventArgs e)
        {
            var GV = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GV2Id = form.SelectedItem.Id;
            GV2Nome = form.SelectedItem.Nome;
            if (GV2Id != 0)
                inputTestemunha2GV.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputGE1_EditButton(object sender, EventArgs e)
        {
            var GE = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GE1Id = form.SelectedItem.Id;
            GE1Nome = form.SelectedItem.Nome;
            if (GE1Id != 0)
                inputTestemunha1GE.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputGE2_EditButton(object sender, EventArgs e)
        {
            var GE = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GE2Id = form.SelectedItem.Id;
            GE2Nome = form.SelectedItem.Nome;
            if (GE2Id != 0)
                inputTestemunha2GE.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputGT1_EditButton(object sender, EventArgs e)
        {
            var GT = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GT1Id = form.SelectedItem.Id;
            GT1Nome = form.SelectedItem.Nome;
            if (GT1Id != 0)
                inputTestemunha1GT.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputGT2_EditButton(object sender, EventArgs e)
        {
            var GT = sender as DevExpress.XtraEditors.ButtonEdit;
            var pessoas = _repositorioPessoa.ListarTodasPessoas();
            var form = new SelecionarPessoa(pessoas);
            form.ShowDialog(MdiParent);
            GT2Id = form.SelectedItem.Id;
            GT2Nome = form.SelectedItem.Nome;
            if (GT2Id != 0)
                inputTestemunha2GT.Text = form.SelectedItem.Nome + " " + form.SelectedItem.Sobrenome;
        }

        private void inputTestemunha1GV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputTestemunha2GV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputTestemunha1GE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputTestemunha2GE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputTestemunha1GT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void inputTestemunha2GT_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
