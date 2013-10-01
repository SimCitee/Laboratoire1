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
    public partial class frmMenu : Form
    {
        private Global globalRef; //Référence à la classe de variables globales

        public frmMenu(Global global)
        {
            InitializeComponent();

            globalRef = global;
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void bSousCategorie_Click(object sender, EventArgs e)
        {
   
            frmSousCategorie f = new frmSousCategorie(globalRef);

            f.Show();
        }

        private void bBudget_Click(object sender, EventArgs e)
        {
            ///Application.Run(new frmBudget(globalRef));
            frmBudget f = new frmBudget(globalRef);
            f.ShowDialog();
        }

        private void bTransaction_Click(object sender, EventArgs e)
        {

            frmTransactions f = new frmTransactions(globalRef);

            f.Show();
        }
    }
}
