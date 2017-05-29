using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Finanças
{
    public partial class Formulario : UserControl
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(("Deseja Sair  as alterções..?"), "Bic", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
            }
            else
            {
                return;
            }
        }
    }
}
