using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire1
{
    public partial class frmTransactions : Form
    {
        private Global globalRef; //Référence à la classe de variables globales

        public frmTransactions(Global global)
        {
            InitializeComponent();

            globalRef = global;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

        }
    }
}
