using DevExpress.XtraEditors;
using Principal.Domain;
using Principal.Domain.Entities;
using Principal.Forms;
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
using Escritorio = Principal.Forms.Escritorio;

namespace Principal
{
    public partial class Principal : XtraForm
    {
        public Principal()
        {
            InitializeComponent();
            carregarMenuLateral();
        }

        private void carregarMenuLateral()
        {
            var form = new MenuLateral(modulosToolStripMenuItem) { MdiParent = this };
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void tNIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ConsultarVaga janelaConsulta = new Forms.ConsultarVaga();
            janelaConsulta.MdiParent = this;
            janelaConsulta.Show();
        }

        private void PessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(ListaPessoas)];
            if (f != null)
                f.BringToFront();
            else
            {
                ListaPessoas listaPessoas = new ListaPessoas();
                listaPessoas.MdiParent = this;
                listaPessoas.Show();
            }    
        }

        private void entidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Escritorio)];
            if (f != null)
                f.BringToFront();
            else
            {
                Escritorio escritorio = new Escritorio();
                escritorio.MdiParent = this;
                escritorio.Show();
            }
        }

        private void testemunhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Testemunhas)];
            if (f != null)
                f.BringToFront();
            else
            {
                Testemunhas testemunhas = new Testemunhas();
                testemunhas.MdiParent = this;
                testemunhas.Show();
            }
        }

        private void emitirDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroDeApprovedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(ListaApproveds)];
            if (f != null)
                f.BringToFront();
            else
            {
                ListaApproveds listaApproveds = new ListaApproveds();
                listaApproveds.MdiParent = this;
                listaApproveds.Show();
            }
        }

        private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Token)];
            if (f != null)
                f.BringToFront();
            else
            {
                Token token = new Token();
                token.MdiParent = this;
                token.Show();
            }
        }

        private void cadastrarDiretórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(PastaDestino)];
            if (f != null)
                f.BringToFront();
            else
            {
                PastaDestino pastaDestino = new PastaDestino();
                pastaDestino.MdiParent = this;
                pastaDestino.Show();
            }
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Sobre)];
            if (f != null)
                f.BringToFront();
            else
            {
                Sobre pastaDestino = new Sobre();
                pastaDestino.MdiParent = this;
                pastaDestino.Show();
            }
        }

        private void enviarSugestãoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSeK2uRcUAM73eQso-lS0Ug7n9QgSZF1nPz2zBuDe_kf6ZJNKA/viewform?usp=sf_link");
        }

        private void escritorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(ListaApproveds)];
            if (f != null)
                f.BringToFront();
            else
            {
                ListaApproveds listaApproveds = new ListaApproveds();
                listaApproveds.MdiParent = this;
                listaApproveds.Show();
            }
        }

        private void pessoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(ListaPessoas)];
            if (f != null)
                f.BringToFront();
            else
            {
                ListaPessoas listaPessoas = new ListaPessoas();
                listaPessoas.MdiParent = this;
                listaPessoas.Show();
            }
        }

        private void diretorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(PastaDestino)];
            if (f != null)
                f.BringToFront();
            else
            {
                PastaDestino pastaDestino = new PastaDestino();
                pastaDestino.MdiParent = this;
                pastaDestino.Show();
            }
        }

        private void escritorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Escritorio)];
            if (f != null)
                f.BringToFront();
            else
            {
                Escritorio escritorio = new Escritorio();
                escritorio.MdiParent = this;
                escritorio.Show();
            }
        }

        private void testemunhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Testemunhas)];
            if (f != null)
                f.BringToFront();
            else
            {
                Testemunhas testemunhas = new Testemunhas();
                testemunhas.MdiParent = this;
                testemunhas.Show();
            }
        }

        private void tokenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(Token)];
            if (f != null)
                f.BringToFront();
            else
            {
                Token token = new Token();
                token.MdiParent = this;
                token.Show();
            }
        }

        private void tNIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[nameof(ConsultarVaga)];
            if (f != null)
                f.BringToFront();
            else
            {
                ConsultarVaga consultaTNID = new ConsultarVaga();
                consultaTNID.MdiParent = this;
                consultaTNID.Show();
            }
        }
    }
    
}
