using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Principal.Domain;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using Principal.WinApp;
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
    public partial class SelecionarPessoa : XtraForm
    {
        public List<Pessoa> SelectedItens { get; set; }
        public Pessoa SelectedItem { get; set; }
        private IEnumerable<Pessoa> _dataList;
        private string _paramentroSearch;

        private IPessoaService _pessoaService;
        private IPessoaRepositorio _pessoaRepositorio;
        private int operacao;
        private Pessoa _pessoa;
        
        public SelecionarPessoa(IEnumerable<Pessoa> DataList)
        {
            InitializeComponent();

            _dataList = DataList;
            gridControlListaPessoas.DataSource = _dataList;
            SelectedItem = new Pessoa();
            this.Text = "Selecione uma pessoa";       
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoPesquisar_Click(sender, e);
            }
        }
        private void gridControlListaPessoas_Click(object sender, EventArgs e)
        {
            botaoSelecionar_Click(sender, e);
        }

        private void botaoSelecionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            SetSelectedItens();
            this.Close();
        }

        void SetSelectedItens()
        {
            foreach (var item in gridView1.GetSelectedRows())
            {
                SelectedItem = ((GridView)gridControlListaPessoas.MainView).GetFocusedRow() as Pessoa;
            }

        }
        
        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputNome.Text))
            {
                var search = new List<Pessoa>();

                foreach (Pessoa c in _dataList)
                {
                    var value = c.Nome + c.Sobrenome;
                    if (value != null)
                        if (value.ToString().ToUpper().Contains(inputNome.Text.ToUpper()))
                            search.Add(c);
                }
                gridControlListaPessoas.DataSource = search;
            }
            else
            {
                gridControlListaPessoas.DataSource = _dataList;
            }
        }
    }
}
