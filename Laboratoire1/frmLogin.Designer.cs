namespace Laboratoire1
{
    partial class frmLogin
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
            this.lUtilisateur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dDevise = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bCreerUtilisateur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUtilisateur
            // 
            this.lUtilisateur.FormattingEnabled = true;
            this.lUtilisateur.Location = new System.Drawing.Point(82, 95);
            this.lUtilisateur.Name = "lUtilisateur";
            this.lUtilisateur.Size = new System.Drawing.Size(156, 186);
            this.lUtilisateur.TabIndex = 0;
            this.lUtilisateur.SelectedIndexChanged += new System.EventHandler(this.lUtilisateur_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tNom
            // 
            this.tNom.Location = new System.Drawing.Point(301, 123);
            this.tNom.Name = "tNom";
            this.tNom.Size = new System.Drawing.Size(145, 20);
            this.tNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // tPrenom
            // 
            this.tPrenom.Location = new System.Drawing.Point(301, 171);
            this.tPrenom.Name = "tPrenom";
            this.tPrenom.Size = new System.Drawing.Size(145, 20);
            this.tPrenom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tNomUtilisateur
            // 
            this.tNomUtilisateur.Location = new System.Drawing.Point(301, 218);
            this.tNomUtilisateur.Name = "tNomUtilisateur";
            this.tNomUtilisateur.Size = new System.Drawing.Size(145, 20);
            this.tNomUtilisateur.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom d\'utilisateur";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(82, 292);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 8;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(163, 292);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bSupprimer.TabIndex = 9;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nouvel utilisateur";
            // 
            // dDevise
            // 
            this.dDevise.FormattingEnabled = true;
            this.dDevise.Location = new System.Drawing.Point(303, 265);
            this.dDevise.Name = "dDevise";
            this.dDevise.Size = new System.Drawing.Size(121, 21);
            this.dDevise.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Devise préférée";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bCreerUtilisateur
            // 
            this.bCreerUtilisateur.Location = new System.Drawing.Point(303, 292);
            this.bCreerUtilisateur.Name = "bCreerUtilisateur";
            this.bCreerUtilisateur.Size = new System.Drawing.Size(75, 23);
            this.bCreerUtilisateur.TabIndex = 13;
            this.bCreerUtilisateur.Text = "Créer";
            this.bCreerUtilisateur.UseVisualStyleBackColor = true;
            this.bCreerUtilisateur.Click += new System.EventHandler(this.bCreerUtilisateur_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "UTILISER CE LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCreerUtilisateur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dDevise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tNomUtilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lUtilisateur);
            this.Name = "frmLogin";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNomUtilisateur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dDevise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bCreerUtilisateur;
        private System.Windows.Forms.Button button1;
    }
}

