namespace Laboratoire1
{
    partial class frmSousCategorie
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
            this.lSousCategories = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.dCategories = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tSousCategorie = new System.Windows.Forms.TextBox();
            this.chkCompressible = new System.Windows.Forms.CheckBox();
            this.bAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lSousCategories
            // 
            this.lSousCategories.FormattingEnabled = true;
            this.lSousCategories.Location = new System.Drawing.Point(71, 97);
            this.lSousCategories.MultiColumn = true;
            this.lSousCategories.Name = "lSousCategories";
            this.lSousCategories.Size = new System.Drawing.Size(160, 160);
            this.lSousCategories.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sous-catégories";
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(71, 273);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bSupprimer.TabIndex = 12;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            // 
            // dCategories
            // 
            this.dCategories.AutoSize = true;
            this.dCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dCategories.Location = new System.Drawing.Point(365, 119);
            this.dCategories.Name = "dCategories";
            this.dCategories.Size = new System.Drawing.Size(76, 15);
            this.dCategories.TabIndex = 14;
            this.dCategories.Text = "Catégories";
            this.dCategories.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ajouter une sous-catégories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sous-catégories";
            // 
            // tSousCategorie
            // 
            this.tSousCategorie.Location = new System.Drawing.Point(368, 187);
            this.tSousCategorie.Name = "tSousCategorie";
            this.tSousCategorie.Size = new System.Drawing.Size(121, 20);
            this.tSousCategorie.TabIndex = 18;
            // 
            // chkCompressible
            // 
            this.chkCompressible.AutoSize = true;
            this.chkCompressible.Location = new System.Drawing.Point(368, 226);
            this.chkCompressible.Name = "chkCompressible";
            this.chkCompressible.Size = new System.Drawing.Size(88, 17);
            this.chkCompressible.TabIndex = 19;
            this.chkCompressible.Text = "Compressible";
            this.chkCompressible.UseVisualStyleBackColor = true;
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(368, 273);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 23);
            this.bAjouter.TabIndex = 20;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            // 
            // frmSousCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 374);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.chkCompressible);
            this.Controls.Add(this.tSousCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dCategories);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lSousCategories);
            this.Name = "frmSousCategorie";
            this.Text = "Gestion des sous-categories";
            this.Load += new System.EventHandler(this.frmSousCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lSousCategories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Label dCategories;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tSousCategorie;
        private System.Windows.Forms.CheckBox chkCompressible;
        private System.Windows.Forms.Button bAjouter;
    }
}