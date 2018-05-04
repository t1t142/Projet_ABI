namespace Projet_ABI
{
    partial class frmConsultationClient
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
            this.grpIdentification = new System.Windows.Forms.GroupBox();
            this.lblSaisieTelephone = new System.Windows.Forms.Label();
            this.lblSaisieCPVille = new System.Windows.Forms.Label();
            this.lblSaisieAdresse = new System.Windows.Forms.Label();
            this.lblSaisieRaisonSociale = new System.Windows.Forms.Label();
            this.lblSaisieNumeroClient = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCP_Ville = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.grpCaracteristique = new System.Windows.Forms.GroupBox();
            this.lblSaisieNature = new System.Windows.Forms.Label();
            this.lblSasieCA = new System.Windows.Forms.Label();
            this.lblSasieActivite = new System.Windows.Forms.Label();
            this.lblSasieEffectif = new System.Windows.Forms.Label();
            this.chkPrive = new System.Windows.Forms.CheckBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblCaracteristiques = new System.Windows.Forms.Label();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.clnDGNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDGPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpIdentification.SuspendLayout();
            this.grpCaracteristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIdentification
            // 
            this.grpIdentification.Controls.Add(this.lblSaisieTelephone);
            this.grpIdentification.Controls.Add(this.lblSaisieCPVille);
            this.grpIdentification.Controls.Add(this.lblSaisieAdresse);
            this.grpIdentification.Controls.Add(this.lblSaisieRaisonSociale);
            this.grpIdentification.Controls.Add(this.lblSaisieNumeroClient);
            this.grpIdentification.Controls.Add(this.lblTelephone);
            this.grpIdentification.Controls.Add(this.lblCP_Ville);
            this.grpIdentification.Controls.Add(this.lblAdresse);
            this.grpIdentification.Controls.Add(this.lblRaisonSociale);
            this.grpIdentification.Controls.Add(this.lblNumeroClient);
            this.grpIdentification.Controls.Add(this.lblIdentification);
            this.grpIdentification.Location = new System.Drawing.Point(8, 13);
            this.grpIdentification.Margin = new System.Windows.Forms.Padding(2);
            this.grpIdentification.Name = "grpIdentification";
            this.grpIdentification.Padding = new System.Windows.Forms.Padding(2);
            this.grpIdentification.Size = new System.Drawing.Size(461, 198);
            this.grpIdentification.TabIndex = 0;
            this.grpIdentification.TabStop = false;
            // 
            // lblSaisieTelephone
            // 
            this.lblSaisieTelephone.Location = new System.Drawing.Point(129, 168);
            this.lblSaisieTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieTelephone.Name = "lblSaisieTelephone";
            this.lblSaisieTelephone.Size = new System.Drawing.Size(316, 15);
            this.lblSaisieTelephone.TabIndex = 15;
            // 
            // lblSaisieCPVille
            // 
            this.lblSaisieCPVille.Location = new System.Drawing.Point(129, 135);
            this.lblSaisieCPVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieCPVille.Name = "lblSaisieCPVille";
            this.lblSaisieCPVille.Size = new System.Drawing.Size(316, 15);
            this.lblSaisieCPVille.TabIndex = 14;
            // 
            // lblSaisieAdresse
            // 
            this.lblSaisieAdresse.Location = new System.Drawing.Point(126, 100);
            this.lblSaisieAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieAdresse.Name = "lblSaisieAdresse";
            this.lblSaisieAdresse.Size = new System.Drawing.Size(319, 15);
            this.lblSaisieAdresse.TabIndex = 13;
            // 
            // lblSaisieRaisonSociale
            // 
            this.lblSaisieRaisonSociale.Location = new System.Drawing.Point(126, 66);
            this.lblSaisieRaisonSociale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieRaisonSociale.Name = "lblSaisieRaisonSociale";
            this.lblSaisieRaisonSociale.Size = new System.Drawing.Size(319, 15);
            this.lblSaisieRaisonSociale.TabIndex = 12;
            // 
            // lblSaisieNumeroClient
            // 
            this.lblSaisieNumeroClient.Location = new System.Drawing.Point(126, 36);
            this.lblSaisieNumeroClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieNumeroClient.Name = "lblSaisieNumeroClient";
            this.lblSaisieNumeroClient.Size = new System.Drawing.Size(319, 15);
            this.lblSaisieNumeroClient.TabIndex = 11;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(21, 170);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // lblCP_Ville
            // 
            this.lblCP_Ville.AutoSize = true;
            this.lblCP_Ville.Location = new System.Drawing.Point(21, 135);
            this.lblCP_Ville.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP_Ville.Name = "lblCP_Ville";
            this.lblCP_Ville.Size = new System.Drawing.Size(54, 13);
            this.lblCP_Ville.TabIndex = 4;
            this.lblCP_Ville.Text = "Cp && Ville:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(21, 100);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(21, 68);
            this.lblRaisonSociale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(81, 13);
            this.lblRaisonSociale.TabIndex = 2;
            this.lblRaisonSociale.Text = "Raison Sociale:";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(21, 38);
            this.lblNumeroClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroClient.TabIndex = 1;
            this.lblNumeroClient.Text = "Numéro Client :";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Location = new System.Drawing.Point(32, 0);
            this.lblIdentification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(67, 13);
            this.lblIdentification.TabIndex = 0;
            this.lblIdentification.Text = "Identification";
            // 
            // grpCaracteristique
            // 
            this.grpCaracteristique.Controls.Add(this.lblSaisieNature);
            this.grpCaracteristique.Controls.Add(this.lblSasieCA);
            this.grpCaracteristique.Controls.Add(this.lblSasieActivite);
            this.grpCaracteristique.Controls.Add(this.lblSasieEffectif);
            this.grpCaracteristique.Controls.Add(this.chkPrive);
            this.grpCaracteristique.Controls.Add(this.lblNature);
            this.grpCaracteristique.Controls.Add(this.lblCA);
            this.grpCaracteristique.Controls.Add(this.lblActivite);
            this.grpCaracteristique.Controls.Add(this.lblEffectif);
            this.grpCaracteristique.Controls.Add(this.lblCaracteristiques);
            this.grpCaracteristique.Location = new System.Drawing.Point(8, 214);
            this.grpCaracteristique.Margin = new System.Windows.Forms.Padding(2);
            this.grpCaracteristique.Name = "grpCaracteristique";
            this.grpCaracteristique.Padding = new System.Windows.Forms.Padding(2);
            this.grpCaracteristique.Size = new System.Drawing.Size(461, 136);
            this.grpCaracteristique.TabIndex = 1;
            this.grpCaracteristique.TabStop = false;
            // 
            // lblSaisieNature
            // 
            this.lblSaisieNature.Location = new System.Drawing.Point(312, 108);
            this.lblSaisieNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaisieNature.Name = "lblSaisieNature";
            this.lblSaisieNature.Size = new System.Drawing.Size(67, 15);
            this.lblSaisieNature.TabIndex = 9;
            // 
            // lblSasieCA
            // 
            this.lblSasieCA.Location = new System.Drawing.Point(309, 61);
            this.lblSasieCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSasieCA.Name = "lblSasieCA";
            this.lblSasieCA.Size = new System.Drawing.Size(67, 15);
            this.lblSasieCA.TabIndex = 8;
            // 
            // lblSasieActivite
            // 
            this.lblSasieActivite.Location = new System.Drawing.Point(119, 108);
            this.lblSasieActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSasieActivite.Name = "lblSasieActivite";
            this.lblSasieActivite.Size = new System.Drawing.Size(67, 15);
            this.lblSasieActivite.TabIndex = 7;
            // 
            // lblSasieEffectif
            // 
            this.lblSasieEffectif.Location = new System.Drawing.Point(119, 60);
            this.lblSasieEffectif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSasieEffectif.Name = "lblSasieEffectif";
            this.lblSasieEffectif.Size = new System.Drawing.Size(67, 15);
            this.lblSasieEffectif.TabIndex = 6;
            // 
            // chkPrive
            // 
            this.chkPrive.AutoSize = true;
            this.chkPrive.Location = new System.Drawing.Point(35, 28);
            this.chkPrive.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrive.Name = "chkPrive";
            this.chkPrive.Size = new System.Drawing.Size(50, 17);
            this.chkPrive.TabIndex = 5;
            this.chkPrive.Text = "Privé";
            this.chkPrive.UseVisualStyleBackColor = true;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(219, 109);
            this.lblNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(42, 13);
            this.lblNature.TabIndex = 4;
            this.lblNature.Text = "Nature:";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(225, 61);
            this.lblCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(24, 13);
            this.lblCA.TabIndex = 3;
            this.lblCA.Text = "CA:";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(32, 109);
            this.lblActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(45, 13);
            this.lblActivite.TabIndex = 2;
            this.lblActivite.Text = "Activité:";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(32, 61);
            this.lblEffectif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(43, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif:";
            // 
            // lblCaracteristiques
            // 
            this.lblCaracteristiques.AutoSize = true;
            this.lblCaracteristiques.Location = new System.Drawing.Point(16, 0);
            this.lblCaracteristiques.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaracteristiques.Name = "lblCaracteristiques";
            this.lblCaracteristiques.Size = new System.Drawing.Size(82, 13);
            this.lblCaracteristiques.TabIndex = 0;
            this.lblCaracteristiques.Text = "Caractéristiques";
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(56, 483);
            this.btnModifierClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(95, 21);
            this.btnModifierClient.TabIndex = 3;
            this.btnModifierClient.Text = "Modifier Client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(181, 483);
            this.btnNouveauContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(111, 21);
            this.btnNouveauContact.TabIndex = 4;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(329, 483);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(74, 21);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDGNom,
            this.clnDGPrenom,
            this.clnTelephone,
            this.clnEmail,
            this.clnFonction});
            this.dgvContact.Location = new System.Drawing.Point(8, 369);
            this.dgvContact.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.RowTemplate.Height = 28;
            this.dgvContact.Size = new System.Drawing.Size(523, 110);
            this.dgvContact.TabIndex = 6;
            this.dgvContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            // 
            // clnDGNom
            // 
            this.clnDGNom.HeaderText = "Nom";
            this.clnDGNom.Name = "clnDGNom";
            this.clnDGNom.Width = 78;
            // 
            // clnDGPrenom
            // 
            this.clnDGPrenom.HeaderText = "Prénom";
            this.clnDGPrenom.Name = "clnDGPrenom";
            // 
            // clnTelephone
            // 
            this.clnTelephone.HeaderText = "Téléphone";
            this.clnTelephone.Name = "clnTelephone";
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            // 
            // clnFonction
            // 
            this.clnFonction.HeaderText = "Fonction";
            this.clnFonction.Name = "clnFonction";
            // 
            // frmConsultationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.grpCaracteristique);
            this.Controls.Add(this.grpIdentification);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultationClient";
            this.Text = "Consultation Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultationClient_Load);
            this.grpIdentification.ResumeLayout(false);
            this.grpIdentification.PerformLayout();
            this.grpCaracteristique.ResumeLayout(false);
            this.grpCaracteristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentification;
        private System.Windows.Forms.Label lblSaisieNumeroClient;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCP_Ville;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.GroupBox grpCaracteristique;
        private System.Windows.Forms.CheckBox chkPrive;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblCaracteristiques;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDGNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDGPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFonction;
        private System.Windows.Forms.Label lblSaisieTelephone;
        private System.Windows.Forms.Label lblSaisieCPVille;
        private System.Windows.Forms.Label lblSaisieAdresse;
        private System.Windows.Forms.Label lblSaisieRaisonSociale;
        private System.Windows.Forms.Label lblSaisieNature;
        private System.Windows.Forms.Label lblSasieCA;
        private System.Windows.Forms.Label lblSasieActivite;
        private System.Windows.Forms.Label lblSasieEffectif;
    }
}