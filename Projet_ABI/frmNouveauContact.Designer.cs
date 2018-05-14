namespace Projet_ABI
{
    partial class frmNouveauContact
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpIdentite = new System.Windows.Forms.GroupBox();
            this.picClient = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblIdentite = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblSaisieClient = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.cbxFonction = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpIdentite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIdentite
            // 
            this.grpIdentite.Controls.Add(this.picClient);
            this.grpIdentite.Controls.Add(this.txtEmail);
            this.grpIdentite.Controls.Add(this.txtTelephone);
            this.grpIdentite.Controls.Add(this.txtPrenom);
            this.grpIdentite.Controls.Add(this.txtNom);
            this.grpIdentite.Controls.Add(this.lblEmail);
            this.grpIdentite.Controls.Add(this.lblTelephone);
            this.grpIdentite.Controls.Add(this.lblPrenom);
            this.grpIdentite.Controls.Add(this.lblNom);
            this.grpIdentite.Controls.Add(this.lblIdentite);
            this.grpIdentite.Location = new System.Drawing.Point(11, 26);
            this.grpIdentite.Margin = new System.Windows.Forms.Padding(2);
            this.grpIdentite.Name = "grpIdentite";
            this.grpIdentite.Padding = new System.Windows.Forms.Padding(2);
            this.grpIdentite.Size = new System.Drawing.Size(461, 195);
            this.grpIdentite.TabIndex = 0;
            this.grpIdentite.TabStop = false;
            // 
            // picClient
            // 
            this.picClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClient.Location = new System.Drawing.Point(321, 42);
            this.picClient.Margin = new System.Windows.Forms.Padding(2);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(124, 99);
            this.picClient.TabIndex = 9;
            this.picClient.TabStop = false;
           
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(92, 107);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(198, 20);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(92, 75);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(198, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(92, 42);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(198, 20);
            this.txtNom.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 142);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(24, 110);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(39, 78);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(53, 45);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblIdentite
            // 
            this.lblIdentite.AutoSize = true;
            this.lblIdentite.Location = new System.Drawing.Point(46, 0);
            this.lblIdentite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentite.Name = "lblIdentite";
            this.lblIdentite.Size = new System.Drawing.Size(42, 13);
            this.lblIdentite.TabIndex = 0;
            this.lblIdentite.Text = "Identité";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(11, 9);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            // 
            // lblSaisieClient
            // 
            this.lblSaisieClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaisieClient.Location = new System.Drawing.Point(51, 8);
            this.lblSaisieClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieClient.Name = "lblSaisieClient";
            this.lblSaisieClient.Size = new System.Drawing.Size(198, 16);
            this.lblSaisieClient.TabIndex = 0;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(48, 233);
            this.lblFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(51, 13);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction:";
            // 
            // cbxFonction
            // 
            this.cbxFonction.FormattingEnabled = true;
            this.cbxFonction.Location = new System.Drawing.Point(103, 233);
            this.cbxFonction.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFonction.Name = "cbxFonction";
            this.cbxFonction.Size = new System.Drawing.Size(198, 21);
            this.cbxFonction.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(341, 272);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 21);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
           
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(401, 272);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(71, 21);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 307);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxFonction);
            this.Controls.Add(this.lblFonction);
            this.Controls.Add(this.lblSaisieClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.grpIdentite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNouveauContact";
            this.Text = "Saisie Nouveau Contact";
            this.grpIdentite.ResumeLayout(false);
            this.grpIdentite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentite;
        private System.Windows.Forms.PictureBox picClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblIdentite;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblSaisieClient;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.ComboBox cbxFonction;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}