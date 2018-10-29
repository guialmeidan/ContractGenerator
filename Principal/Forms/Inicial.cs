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
    }
    
}
