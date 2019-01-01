using DevExpress.XtraEditors;
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
    public partial class Sobre : XtraForm
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
