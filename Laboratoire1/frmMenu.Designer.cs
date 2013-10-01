namespace Laboratoire1
{
    partial class frmMenu
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
            this.bSousCategorie = new System.Windows.Forms.Button();
            this.bBudget = new System.Windows.Forms.Button();
            this.bTransaction = new System.Windows.Forms.Button();
            this.bAide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSousCategorie
            // 
            this.bSousCategorie.Location = new System.Drawing.Point(57, 50);
            this.bSousCategorie.Name = "bSousCategorie";
            this.bSousCategorie.Size = new System.Drawing.Size(112, 39);
            this.bSousCategorie.TabIndex = 0;
            this.bSousCategorie.Text = "Gestion des sous catégories";
            this.bSousCategorie.UseVisualStyleBackColor = true;
            this.bSousCategorie.Click += new System.EventHandler(this.bSousCategorie_Click);
            // 
            // bBudget
            // 
            this.bBudget.Location = new System.Drawing.Point(57, 95);
            this.bBudget.Name = "bBudget";
            this.bBudget.Size = new System.Drawing.Size(112, 39);
            this.bBudget.TabIndex = 1;
            this.bBudget.Text = "Gestion du budget";
            this.bBudget.UseVisualStyleBackColor = true;
            this.bBudget.Click += new System.EventHandler(this.bBudget_Click);
            // 
            // bTransaction
            // 
            this.bTransaction.Location = new System.Drawing.Point(57, 140);
            this.bTransaction.Name = "bTransaction";
            this.bTransaction.Size = new System.Drawing.Size(112, 39);
            this.bTransaction.TabIndex = 2;
            this.bTransaction.Text = "Gestion des transactions";
            this.bTransaction.UseVisualStyleBackColor = true;
            this.bTransaction.Click += new System.EventHandler(this.bTransaction_Click);
            // 
            // bAide
            // 
            this.bAide.Location = new System.Drawing.Point(193, 50);
            this.bAide.Name = "bAide";
            this.bAide.Size = new System.Drawing.Size(112, 39);
            this.bAide.TabIndex = 3;
            this.bAide.Text = "Aide/documentation";
            this.bAide.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.bAide);
            this.Controls.Add(this.bTransaction);
            this.Controls.Add(this.bBudget);
            this.Controls.Add(this.bSousCategorie);
            this.Name = "frmMenu";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSousCategorie;
        private System.Windows.Forms.Button bBudget;
        private System.Windows.Forms.Button bTransaction;
        private System.Windows.Forms.Button bAide;
    }
}