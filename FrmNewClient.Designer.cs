namespace NouveauxClient
{
    partial class FrmNewClient
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
            this.gbxIdentification = new System.Windows.Forms.GroupBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbVille = new System.Windows.Forms.TextBox();
            this.txbCodePostal = new System.Windows.Forms.TextBox();
            this.txbAdresse2 = new System.Windows.Forms.TextBox();
            this.txbAdresse1 = new System.Windows.Forms.TextBox();
            this.txbRaisonSociale = new System.Windows.Forms.TextBox();
            this.txbNumeroClient = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCodePostalEtVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.gbxCaracteristiques = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.txbChiffreAffaire = new System.Windows.Forms.TextBox();
            this.lblChiffreAffaire = new System.Windows.Forms.Label();
            this.cbxActivite = new System.Windows.Forms.ComboBox();
            this.txbEffectif = new System.Windows.Forms.TextBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.chkbPrive = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.chkbPublic = new System.Windows.Forms.CheckBox();
            this.gbxIdentification.SuspendLayout();
            this.gbxCaracteristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIdentification
            // 
            this.gbxIdentification.Controls.Add(this.txbTelephone);
            this.gbxIdentification.Controls.Add(this.txbVille);
            this.gbxIdentification.Controls.Add(this.txbCodePostal);
            this.gbxIdentification.Controls.Add(this.txbAdresse2);
            this.gbxIdentification.Controls.Add(this.txbAdresse1);
            this.gbxIdentification.Controls.Add(this.txbRaisonSociale);
            this.gbxIdentification.Controls.Add(this.txbNumeroClient);
            this.gbxIdentification.Controls.Add(this.lblTelephone);
            this.gbxIdentification.Controls.Add(this.lblCodePostalEtVille);
            this.gbxIdentification.Controls.Add(this.lblAdresse);
            this.gbxIdentification.Controls.Add(this.lblRaisonSociale);
            this.gbxIdentification.Controls.Add(this.lblNumeroClient);
            this.gbxIdentification.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentification.Name = "gbxIdentification";
            this.gbxIdentification.Size = new System.Drawing.Size(349, 169);
            this.gbxIdentification.TabIndex = 0;
            this.gbxIdentification.TabStop = false;
            this.gbxIdentification.Text = "Identification";
            // 
            // txbTelephone
            // 
            this.txbTelephone.Location = new System.Drawing.Point(96, 142);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(101, 20);
            this.txbTelephone.TabIndex = 11;
            // 
            // txbVille
            // 
            this.txbVille.Location = new System.Drawing.Point(161, 116);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(182, 20);
            this.txbVille.TabIndex = 10;
            // 
            // txbCodePostal
            // 
            this.txbCodePostal.Location = new System.Drawing.Point(96, 116);
            this.txbCodePostal.Name = "txbCodePostal";
            this.txbCodePostal.Size = new System.Drawing.Size(59, 20);
            this.txbCodePostal.TabIndex = 9;
            // 
            // txbAdresse2
            // 
            this.txbAdresse2.Location = new System.Drawing.Point(96, 90);
            this.txbAdresse2.Name = "txbAdresse2";
            this.txbAdresse2.Size = new System.Drawing.Size(247, 20);
            this.txbAdresse2.TabIndex = 8;
            // 
            // txbAdresse1
            // 
            this.txbAdresse1.Location = new System.Drawing.Point(96, 64);
            this.txbAdresse1.Name = "txbAdresse1";
            this.txbAdresse1.Size = new System.Drawing.Size(247, 20);
            this.txbAdresse1.TabIndex = 7;
            // 
            // txbRaisonSociale
            // 
            this.txbRaisonSociale.Location = new System.Drawing.Point(96, 38);
            this.txbRaisonSociale.Name = "txbRaisonSociale";
            this.txbRaisonSociale.Size = new System.Drawing.Size(247, 20);
            this.txbRaisonSociale.TabIndex = 6;
            // 
            // txbNumeroClient
            // 
            this.txbNumeroClient.Location = new System.Drawing.Point(96, 12);
            this.txbNumeroClient.Name = "txbNumeroClient";
            this.txbNumeroClient.Size = new System.Drawing.Size(71, 20);
            this.txbNumeroClient.TabIndex = 5;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(26, 145);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCodePostalEtVille
            // 
            this.lblCodePostalEtVille.AutoSize = true;
            this.lblCodePostalEtVille.Location = new System.Drawing.Point(29, 119);
            this.lblCodePostalEtVille.Name = "lblCodePostalEtVille";
            this.lblCodePostalEtVille.Size = new System.Drawing.Size(61, 13);
            this.lblCodePostalEtVille.TabIndex = 3;
            this.lblCodePostalEtVille.Text = "CP et Ville :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(39, 67);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(6, 41);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(78, 13);
            this.lblNumeroClient.TabIndex = 0;
            this.lblNumeroClient.Text = "Numéro client :";
            // 
            // gbxCaracteristiques
            // 
            this.gbxCaracteristiques.Controls.Add(this.chkbPublic);
            this.gbxCaracteristiques.Controls.Add(this.comboBox1);
            this.gbxCaracteristiques.Controls.Add(this.lblNature);
            this.gbxCaracteristiques.Controls.Add(this.txbChiffreAffaire);
            this.gbxCaracteristiques.Controls.Add(this.lblChiffreAffaire);
            this.gbxCaracteristiques.Controls.Add(this.cbxActivite);
            this.gbxCaracteristiques.Controls.Add(this.txbEffectif);
            this.gbxCaracteristiques.Controls.Add(this.lblActivite);
            this.gbxCaracteristiques.Controls.Add(this.lblEffectif);
            this.gbxCaracteristiques.Controls.Add(this.chkbPrive);
            this.gbxCaracteristiques.Location = new System.Drawing.Point(12, 187);
            this.gbxCaracteristiques.Name = "gbxCaracteristiques";
            this.gbxCaracteristiques.Size = new System.Drawing.Size(349, 131);
            this.gbxCaracteristiques.TabIndex = 1;
            this.gbxCaracteristiques.TabStop = false;
            this.gbxCaracteristiques.Text = "Caractéristiques";
            this.gbxCaracteristiques.Enter += new System.EventHandler(this.gbxCaracteristiques_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.comboBox1.Location = new System.Drawing.Point(214, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(163, 70);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 7;
            this.lblNature.Text = "Nature :";
            // 
            // txbChiffreAffaire
            // 
            this.txbChiffreAffaire.Location = new System.Drawing.Point(184, 40);
            this.txbChiffreAffaire.Name = "txbChiffreAffaire";
            this.txbChiffreAffaire.Size = new System.Drawing.Size(100, 20);
            this.txbChiffreAffaire.TabIndex = 6;
            // 
            // lblChiffreAffaire
            // 
            this.lblChiffreAffaire.AutoSize = true;
            this.lblChiffreAffaire.Location = new System.Drawing.Point(154, 43);
            this.lblChiffreAffaire.Name = "lblChiffreAffaire";
            this.lblChiffreAffaire.Size = new System.Drawing.Size(27, 13);
            this.lblChiffreAffaire.TabIndex = 5;
            this.lblChiffreAffaire.Text = "CA :";
            // 
            // cbxActivite
            // 
            this.cbxActivite.FormattingEnabled = true;
            this.cbxActivite.Location = new System.Drawing.Point(57, 67);
            this.cbxActivite.Name = "cbxActivite";
            this.cbxActivite.Size = new System.Drawing.Size(100, 21);
            this.cbxActivite.TabIndex = 4;
            // 
            // txbEffectif
            // 
            this.txbEffectif.Location = new System.Drawing.Point(55, 40);
            this.txbEffectif.Name = "txbEffectif";
            this.txbEffectif.Size = new System.Drawing.Size(76, 20);
            this.txbEffectif.TabIndex = 3;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(3, 70);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 2;
            this.lblActivite.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(3, 43);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // chkbPrive
            // 
            this.chkbPrive.AutoSize = true;
            this.chkbPrive.Location = new System.Drawing.Point(6, 19);
            this.chkbPrive.Name = "chkbPrive";
            this.chkbPrive.Size = new System.Drawing.Size(50, 17);
            this.chkbPrive.TabIndex = 0;
            this.chkbPrive.Text = "Privé";
            this.chkbPrive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(196, 324);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(35, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(237, 324);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(58, 23);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(301, 324);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(60, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // chkbPublic
            // 
            this.chkbPublic.AutoSize = true;
            this.chkbPublic.Location = new System.Drawing.Point(87, 19);
            this.chkbPublic.Name = "chkbPublic";
            this.chkbPublic.Size = new System.Drawing.Size(55, 17);
            this.chkbPublic.TabIndex = 9;
            this.chkbPublic.Text = "Public";
            this.chkbPublic.UseVisualStyleBackColor = true;
            // 
            // FrmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 354);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxCaracteristiques);
            this.Controls.Add(this.gbxIdentification);
            this.Name = "FrmNewClient";
            this.Text = "Saisie nouveau client";
            this.gbxIdentification.ResumeLayout(false);
            this.gbxIdentification.PerformLayout();
            this.gbxCaracteristiques.ResumeLayout(false);
            this.gbxCaracteristiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentification;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbVille;
        private System.Windows.Forms.TextBox txbCodePostal;
        private System.Windows.Forms.TextBox txbAdresse2;
        private System.Windows.Forms.TextBox txbAdresse1;
        private System.Windows.Forms.TextBox txbRaisonSociale;
        private System.Windows.Forms.TextBox txbNumeroClient;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCodePostalEtVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.GroupBox gbxCaracteristiques;
        private System.Windows.Forms.TextBox txbChiffreAffaire;
        private System.Windows.Forms.Label lblChiffreAffaire;
        private System.Windows.Forms.ComboBox cbxActivite;
        private System.Windows.Forms.TextBox txbEffectif;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.CheckBox chkbPrive;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.CheckBox chkbPublic;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

