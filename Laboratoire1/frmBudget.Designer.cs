namespace Laboratoire1
{
    partial class frmBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMoisFin = new System.Windows.Forms.ComboBox();
            this.cmbMoisDebut = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAfficherTous = new System.Windows.Forms.CheckBox();
            this.cmbAnnee = new System.Windows.Forms.ComboBox();
            this.gridBudget = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSousCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMontantAllouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRevenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRevenuDepense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.btnAjoutBudget = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAjoutSousCategorie = new System.Windows.Forms.ComboBox();
            this.cmbAjoutCategorie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAjoutMois = new System.Windows.Forms.ComboBox();
            this.cmbAjoutAnnee = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBudget)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMoisFin);
            this.groupBox1.Controls.Add(this.cmbMoisDebut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAfficherTous);
            this.groupBox1.Controls.Add(this.cmbAnnee);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 118);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélection date";
            // 
            // cmbMoisFin
            // 
            this.cmbMoisFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoisFin.FormattingEnabled = true;
            this.cmbMoisFin.Location = new System.Drawing.Point(368, 46);
            this.cmbMoisFin.Name = "cmbMoisFin";
            this.cmbMoisFin.Size = new System.Drawing.Size(169, 23);
            this.cmbMoisFin.TabIndex = 10;
            this.cmbMoisFin.SelectedValueChanged += new System.EventHandler(this.cmbMoisFin_SelectedValueChanged);
            // 
            // cmbMoisDebut
            // 
            this.cmbMoisDebut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoisDebut.FormattingEnabled = true;
            this.cmbMoisDebut.Location = new System.Drawing.Point(168, 46);
            this.cmbMoisDebut.Name = "cmbMoisDebut";
            this.cmbMoisDebut.Size = new System.Drawing.Size(169, 23);
            this.cmbMoisDebut.TabIndex = 9;
            this.cmbMoisDebut.SelectedValueChanged += new System.EventHandler(this.cmbMoisDebut_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "À";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "De";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Année";
            // 
            // chkAfficherTous
            // 
            this.chkAfficherTous.AutoSize = true;
            this.chkAfficherTous.Location = new System.Drawing.Point(566, 48);
            this.chkAfficherTous.Name = "chkAfficherTous";
            this.chkAfficherTous.Size = new System.Drawing.Size(158, 19);
            this.chkAfficherTous.TabIndex = 3;
            this.chkAfficherTous.Text = "Afficher tous les budgets";
            this.chkAfficherTous.UseVisualStyleBackColor = true;
            this.chkAfficherTous.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbAnnee
            // 
            this.cmbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnee.FormattingEnabled = true;
            this.cmbAnnee.Location = new System.Drawing.Point(17, 46);
            this.cmbAnnee.Name = "cmbAnnee";
            this.cmbAnnee.Size = new System.Drawing.Size(126, 23);
            this.cmbAnnee.TabIndex = 0;
            this.cmbAnnee.SelectedValueChanged += new System.EventHandler(this.cmbAnnee_SelectedValueChanged);
            // 
            // gridBudget
            // 
            this.gridBudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBudget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.clmSousCat,
            this.clmMontantAllouer,
            this.clmRevenu,
            this.clmDepense,
            this.clmRevenuDepense});
            this.gridBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBudget.Location = new System.Drawing.Point(0, 264);
            this.gridBudget.Name = "gridBudget";
            this.gridBudget.ReadOnly = true;
            this.gridBudget.Size = new System.Drawing.Size(1160, 350);
            this.gridBudget.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Annee";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mois";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Catégorie";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // clmSousCat
            // 
            this.clmSousCat.HeaderText = "Sous catégorie";
            this.clmSousCat.Name = "clmSousCat";
            this.clmSousCat.ReadOnly = true;
            // 
            // clmMontantAllouer
            // 
            this.clmMontantAllouer.HeaderText = "Montant alloué";
            this.clmMontantAllouer.Name = "clmMontantAllouer";
            this.clmMontantAllouer.ReadOnly = true;
            // 
            // clmRevenu
            // 
            this.clmRevenu.HeaderText = "Revenus";
            this.clmRevenu.Name = "clmRevenu";
            this.clmRevenu.ReadOnly = true;
            // 
            // clmDepense
            // 
            this.clmDepense.HeaderText = "Dépenses";
            this.clmDepense.Name = "clmDepense";
            this.clmDepense.ReadOnly = true;
            // 
            // clmRevenuDepense
            // 
            this.clmRevenuDepense.HeaderText = "Revenus - Dépenses";
            this.clmRevenuDepense.Name = "clmRevenuDepense";
            this.clmRevenuDepense.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetourMenu);
            this.groupBox2.Controls.Add(this.btnAjoutBudget);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMontant);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbAjoutSousCategorie);
            this.groupBox2.Controls.Add(this.cmbAjoutCategorie);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbAjoutMois);
            this.groupBox2.Controls.Add(this.cmbAjoutAnnee);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 146);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajout budget";
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.AutoSize = true;
            this.btnRetourMenu.Location = new System.Drawing.Point(1043, 19);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(105, 23);
            this.btnRetourMenu.TabIndex = 25;
            this.btnRetourMenu.Text = "&Retour au menu";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.btnRetourMenu_Click);
            // 
            // btnAjoutBudget
            // 
            this.btnAjoutBudget.Location = new System.Drawing.Point(368, 101);
            this.btnAjoutBudget.Name = "btnAjoutBudget";
            this.btnAjoutBudget.Size = new System.Drawing.Size(169, 23);
            this.btnAjoutBudget.TabIndex = 18;
            this.btnAjoutBudget.Text = "&Ajouter";
            this.btnAjoutBudget.UseVisualStyleBackColor = true;
            this.btnAjoutBudget.Click += new System.EventHandler(this.btnAjoutBudget_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(368, 51);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(169, 20);
            this.txtMontant.TabIndex = 16;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sous catégorie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Catégorie";
            // 
            // cmbAjoutSousCategorie
            // 
            this.cmbAjoutSousCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjoutSousCategorie.FormattingEnabled = true;
            this.cmbAjoutSousCategorie.Items.AddRange(new object[] {
            "SousCat1"});
            this.cmbAjoutSousCategorie.Location = new System.Drawing.Point(168, 103);
            this.cmbAjoutSousCategorie.Name = "cmbAjoutSousCategorie";
            this.cmbAjoutSousCategorie.Size = new System.Drawing.Size(169, 21);
            this.cmbAjoutSousCategorie.TabIndex = 13;
            // 
            // cmbAjoutCategorie
            // 
            this.cmbAjoutCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjoutCategorie.FormattingEnabled = true;
            this.cmbAjoutCategorie.Items.AddRange(new object[] {
            "Cat1"});
            this.cmbAjoutCategorie.Location = new System.Drawing.Point(17, 103);
            this.cmbAjoutCategorie.Name = "cmbAjoutCategorie";
            this.cmbAjoutCategorie.Size = new System.Drawing.Size(126, 21);
            this.cmbAjoutCategorie.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mois";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Année";
            // 
            // cmbAjoutMois
            // 
            this.cmbAjoutMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjoutMois.FormattingEnabled = true;
            this.cmbAjoutMois.Location = new System.Drawing.Point(168, 51);
            this.cmbAjoutMois.Name = "cmbAjoutMois";
            this.cmbAjoutMois.Size = new System.Drawing.Size(169, 21);
            this.cmbAjoutMois.TabIndex = 8;
            // 
            // cmbAjoutAnnee
            // 
            this.cmbAjoutAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjoutAnnee.FormattingEnabled = true;
            this.cmbAjoutAnnee.Location = new System.Drawing.Point(17, 51);
            this.cmbAjoutAnnee.Name = "cmbAjoutAnnee";
            this.cmbAjoutAnnee.Size = new System.Drawing.Size(126, 21);
            this.cmbAjoutAnnee.TabIndex = 7;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 614);
            this.Controls.Add(this.gridBudget);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBudget";
            this.Text = "Gestion du budget";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBudget)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAnnee;
        private System.Windows.Forms.CheckBox chkAfficherTous;
        private System.Windows.Forms.DataGridView gridBudget;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAjoutSousCategorie;
        private System.Windows.Forms.ComboBox cmbAjoutCategorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAjoutMois;
        private System.Windows.Forms.ComboBox cmbAjoutAnnee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnAjoutBudget;
        private System.Windows.Forms.ComboBox cmbMoisDebut;
        private System.Windows.Forms.ComboBox cmbMoisFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSousCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMontantAllouer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRevenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepense;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRevenuDepense;
        private System.Windows.Forms.Button btnRetourMenu;
    }
}