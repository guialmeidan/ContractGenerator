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
    public partial class Token : XtraForm
    {
        private ITokenPublicoRepositorio _repositorioTokenPublico;
        private Domain.Entities.TokenPublico _tokenPublico;

        public Token()
        {
            InitializeComponent();
            _repositorioTokenPublico = AppCore.Container.Resolve<ITokenPublicoRepositorio>();
            _tokenPublico = _repositorioTokenPublico.ObterToken();
            this.inputToken.Text = _tokenPublico.Token;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (inputToken.Text == "")
                    XtraMessageBox.Show("Preencha o campo Token\n", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (XtraMessageBox.Show("Tem certeza que deseja atualizar o token? Esta operação não é reversível!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _tokenPublico.Token = inputToken.Text;
                    _repositorioTokenPublico.Atualizar(_tokenPublico);
                    inputToken.Text = _tokenPublico.Token;
                    XtraMessageBox.Show("Token Alterado!\n", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao atualizar token!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
