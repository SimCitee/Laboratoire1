using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Laboratoire1
{
    public partial class frmBudget : Form
    {
        private Global globalRef; //Référence à la classe de variables globales
        private Dictionary<int, string> dcAjoutAnnee = new Dictionary<int, string>();
        private Dictionary<int, string> dcAnnee = new Dictionary<int, string>();
        private Dictionary<int, string> dcMois = new Dictionary<int, string>();
        private DateTime date = DateTime.Now;
        private bool componentsLoaded = false;

        public frmBudget(Global global)
        {
            InitializeComponent();

            globalRef = global;

            dcAjoutAnnee.Clear();
            dcAjoutAnnee.Add(0, "");

            for (int i = 0; i <= 10; i++)
                dcAjoutAnnee.Add(date.Year + i, (date.Year + i).ToString());

            cmbAjoutAnnee.Items.Add(dcAjoutAnnee);
            cmbAjoutAnnee.DataSource = new BindingSource(dcAjoutAnnee, null);
            cmbAjoutAnnee.DisplayMember = "Value";
            cmbAjoutAnnee.ValueMember = "Key";
           
            ChargerAnnee(globalRef.Profile.Budget);
            ChargerComboMois();
            filtrerGrille(globalRef.Profile.Budget);

            /*gridBudget.Columns[0].DataPropertyName = "Annee";
            gridBudget.Columns[1].DataPropertyName = "Mois";
            gridBudget.Columns[3].DataPropertyName = "IdSousCategorie";
            gridBudget.Columns[4].DataPropertyName = "Montant";*/

            this.componentsLoaded = true;

        }

        private void gridBudgetAddRow(RepartitionBudgetaire rep)
        {
            gridBudget.Rows.Insert(0, 1);
            gridBudget.Rows[0].Cells[0].Value = rep.Annee;
            gridBudget.Rows[0].Cells[1].Value = convertirMoisTexte(rep.Mois);

            gridBudget.Rows[0].Cells[3].Value = rep.IdSousCategorie;
            gridBudget.Rows[0].Cells[4].Value = rep.Montant;
            gridBudget.Sort(gridBudget.Columns[0], ListSortDirection.Ascending);

        }

        private void btnAjoutBudget_Click(object sender, EventArgs e)
        {
            if (validerAjoutBudget())
            {

                RepartitionBudgetaire rep = new RepartitionBudgetaire(cmbAjoutSousCategorie.SelectedIndex, int.Parse(cmbAjoutAnnee.SelectedValue.ToString()),
                                                (int)cmbAjoutMois.SelectedValue, decimal.Parse(txtMontant.Text));

                globalRef.Profile.Budget.AjouterRepartitionBudgetaire(rep);

                gridBudgetAddRow(rep);
                ChargerAnnee(globalRef.Profile.Budget);
                filtrerGrille(globalRef.Profile.Budget);

            }

        }

        private bool validerAjoutBudget()
        {
            bool valide = false;

            if (cmbAjoutAnnee.Text == "")
                MessageBox.Show("Veuillez sélectionner une année.");
            else if (cmbAjoutMois.Text == "")
                MessageBox.Show("Veuillez sélectionner un mois.");
            else if (cmbAjoutCategorie.Text == "")
                MessageBox.Show("Veuillez sélectionner une catégorie.");
            else if (cmbAjoutSousCategorie.Text == "")
                MessageBox.Show("Veuillez sélectionner une sous-catégorie.");
            else if (txtMontant.Text == "")
                MessageBox.Show("Veuillez spécifier un montant.");
            else
                valide = true;

            return valide;
        }

        private void txtMontant_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            string inText = txtMontant.Text;
            int decPointIndex = inText.IndexOf('.');
            if (decPointIndex > 0 && ((inText.Length - (decPointIndex + 1)) > 1))
                e.Handled = true;
                //txtMontant.Text = inText.Substring(0, decPointIndex + 3);

            
        }

        private void ChargerAnnee(Budget b) 
        {
            List<int> tempoAnnees = new List<int>();
            int prevAnnee;

            dcAnnee.Clear();
            dcAnnee.Add(0, "");


            // find min and max year in current budget
            foreach (RepartitionBudgetaire rep in b.Repartitions)
                tempoAnnees.Add(rep.Annee);

            tempoAnnees.Sort();

            if (tempoAnnees.Count > 0)
            {
                prevAnnee = tempoAnnees[0];
                dcAnnee.Add(prevAnnee, prevAnnee.ToString());

                foreach (int annee in tempoAnnees)
                {
                    if (prevAnnee != annee)
                        dcAnnee.Add(annee, annee.ToString());

                    prevAnnee = annee;
                }

            }

            cmbAnnee.DataSource = new BindingSource(dcAnnee, null);
            cmbAnnee.DisplayMember = "Value";
            cmbAnnee.ValueMember = "Key";
        }

        private void ChargerComboMois()
        {
            dcMois.Add(0, "");
            dcMois.Add(1, "Janvier");
            dcMois.Add(2, "Février");
            dcMois.Add(3, "Mars");
            dcMois.Add(4, "Avril");
            dcMois.Add(5, "Mai");
            dcMois.Add(6, "Juin");
            dcMois.Add(7, "Juillet");
            dcMois.Add(8, "Août");
            dcMois.Add(9, "Septembre");
            dcMois.Add(10, "Octobre");
            dcMois.Add(11, "Novembre");
            dcMois.Add(12, "Décembre");

            cmbAjoutMois.DataSource = new BindingSource(dcMois, null);
            cmbAjoutMois.DisplayMember = "Value";
            cmbAjoutMois.ValueMember = "Key";

            cmbMoisDebut.DataSource = new BindingSource(dcMois, null);
            cmbMoisDebut.DisplayMember = "Value";
            cmbMoisDebut.ValueMember = "Key";

            cmbMoisFin.DataSource = new BindingSource(dcMois, null);
            cmbMoisFin.DisplayMember = "Value";
            cmbMoisFin.ValueMember = "Key";
        }

        private void cmbAnnee_SelectedValueChanged(object sender, EventArgs e)
        {
                SelectionFiltre();
        }

        private void cmbMoisDebut_SelectedValueChanged(object sender, EventArgs e)
        {
                SelectionFiltre();
        }

        private void cmbMoisFin_SelectedValueChanged(object sender, EventArgs e)
        {
                SelectionFiltre();
        }


        // Affiche toute les répartitions budgétaire
        private void filtrerGrille(Budget b)
        {
            gridBudget.Rows.Clear();

            foreach (RepartitionBudgetaire rep in b.Repartitions)
                    gridBudgetAddRow(rep);
        }

        // Affiche toute les répartitions budgétaire d'une année
        private void filtrerGrille(Budget b, string annee)
        {
            gridBudget.Rows.Clear();

            foreach(RepartitionBudgetaire rep in b.Repartitions)
            {
                if (rep.Annee.ToString() == annee)
                {
                    gridBudgetAddRow(rep);
                }
            }
        }

        // Affiche toute les répartitions budgétaire d'une année et d'un mois de début
        private void filtrerGrille(Budget b, string annee, int mois, bool debut)
        {
            gridBudget.Rows.Clear();

            foreach (RepartitionBudgetaire rep in b.Repartitions)
            {
                if (rep.Annee.ToString() == annee && debut && rep.Mois >= mois)
                {
                    gridBudgetAddRow(rep);
                }
                else if (rep.Annee.ToString() == annee && debut == false && rep.Mois <= mois)
                {
                    gridBudgetAddRow(rep);
                }
            }
        }

        // Affiche toute les répartitions budgétaire d'une année et d'un mois de début
        private void filtrerGrille(Budget b, string annee, int moisDebut, int moisFin)
        {
            gridBudget.Rows.Clear();

            foreach (RepartitionBudgetaire rep in b.Repartitions)
            {
                if (rep.Annee.ToString() == annee && rep.Mois >= moisDebut && rep.Mois <= moisFin)
                {
                    gridBudgetAddRow(rep);
                }
            }
        }

        private void SelectionFiltre()
        {
            if (componentsLoaded && chkAfficherTous.Checked == false)
            {

                Budget b = globalRef.Profile.Budget;

                if (cmbAnnee.Text != "" &&
                    cmbMoisDebut.Text != "" &&
                    cmbMoisFin.Text != ""
                    )
                {
                    filtrerGrille(b, cmbAnnee.Text , (int)cmbMoisDebut.SelectedValue, (int)cmbMoisFin.SelectedValue);
                }
                else if (cmbAnnee.Text != "" &&
                    cmbMoisDebut.Text != "" &&
                    cmbMoisFin.Text == "")
                {
                    filtrerGrille(b, cmbAnnee.Text , (int)cmbMoisDebut.SelectedValue, true);
                }
                else if (cmbAnnee.Text != "" &&
                    cmbMoisFin.Text != "" &&
                    cmbMoisDebut.Text == "")
                {
                    filtrerGrille(b, cmbAnnee.Text , (int)cmbMoisFin.SelectedValue, false);
                } else if (cmbAnnee.Text != "" &&
                    cmbMoisDebut.Text == "" &&
                    cmbMoisFin.Text == "")
                {
                    filtrerGrille(b, cmbAnnee.Text);
                }
            }
        }

        private string convertirMoisTexte(int index)
        {
            switch (index)
            {
                case 1 : return "Janvier";
                case 2 : return "Février"; 
                case 3 : return "Mars"; 
                case 4 : return "Avril"; 
                case 5 : return "Mai"; 
                case 6 : return "Juin"; 
                case 7 : return "Juillet"; 
                case 8 : return "Août"; 
                case 9 : return "Septembre"; 
                case 10 : return "Octobre"; 
                case 11 : return "Novembre"; 
                case 12 : return "Décembre"; 
                default : return "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                filtrerGrille(globalRef.Profile.Budget);
            else
                SelectionFiltre();
        }

        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
