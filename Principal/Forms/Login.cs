using DevExpress.XtraEditors;
using Newtonsoft.Json.Linq;
using Principal.Domain.Repositories;
using Principal.WinApp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Principal.Forms
{
    public partial class Login : XtraForm
    {
        private ILoginRepository _repositorioLogin;

        public Login(ILoginRepository repositorioLogin)
        {
            InitializeComponent();
            _repositorioLogin = repositorioLogin;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputLogin.Text != "AIESEC" || string.IsNullOrEmpty(inputSenha.Text))
                    throw new Exception("Informações de Login Inválidas");

                this.ExibirFormEspera();
                //validar usuario
                if (_repositorioLogin.ObterPorId(1).Senha == Conversoes.MD5Hash.CalculaHash(inputSenha.Text))
                    this._repositorioLogin.IsAuthenticated = true;
                else this._repositorioLogin.IsAuthenticated = false;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.FecharFormEspera();
                XtraMessageBox.Show(ex.Message, "Atenção!",
                MessageBoxButtons.OK);
            }
            finally
            {
                this.FecharFormEspera();
            }
        }

        private void textBoxPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoOK_Click(sender, e);
            }
        }


    }
}
