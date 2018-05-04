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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblSaisieClient = new System.Windows.Forms.Label();
            this.lblExploitation = new System.Windows.Forms.Label();
            this.lblSaisieExploitation = new System.Windows.Forms.Label();
            this.lblIdentite = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picClient = new System.Windows.Forms.PictureBox();
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
            this.grpIdentite.Location = new System.Drawing.Point(54, 116);
            this.grpIdentite.Name = "grpIdentite";
            this.grpIdentite.Size = new System.Drawing.Size(691, 300);
            this.grpIdentite.TabIndex = 0;
            this.grpIdentite.TabStop = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(50, 35);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(53, 20);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            // 
            // lblSaisieClient
            // 
            this.lblSaisieClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaisieClient.Location = new System.Drawing.Point(109, 32);
            this.lblSaisieClient.Name = "lblSaisieClient";
            this.lblSaisieClient.Size = new System.Drawing.Size(100, 23);
            this.lblSaisieClient.TabIndex = 0;
            // 
            // lblExploitation
            // 
            this.lblExploitation.AutoSize = true;
            this.lblExploitation.Location = new System.Drawing.Point(260, 32);
            this.lblExploitation.Name = "lblExploitation";
            this.lblExploitation.Size = new System.Drawing.Size(91, 20);
            this.lblExploitation.TabIndex = 2;
            this.lblExploitation.Text = "Exploitation";
            // 
            // lblSaisieExploitation
            // 
            this.lblSaisieExploitation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaisieExploitation.Location = new System.Drawing.Point(389, 35);
            this.lblSaisieExploitation.Name = "lblSaisieExploitation";
            this.lblSaisieExploitation.Size = new System.Drawing.Size(116, 23);
            this.lblSaisieExploitation.TabIndex = 3;
            // 
            // lblIdentite
            // 
            this.lblIdentite.AutoSize = true;
            this.lblIdentite.Location = new System.Drawing.Point(69, 0);
            this.lblIdentite.Name = "lblIdentite";
            this.lblIdentite.Size = new System.Drawing.Size(63, 20);
            this.lblIdentite.TabIndex = 0;
            this.lblIdentite.Text = "Identité";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(82, 448);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(75, 20);
            this.lblFonction.TabIndex = 4;
            this.lblFonction.Text = "Fonction:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(51, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(51, 115);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(44, 164);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(88, 20);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(138, 64);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(295, 26);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(138, 115);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(295, 26);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(138, 164);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(295, 26);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // picClient
            // 
            this.picClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClient.Location = new System.Drawing.Point(482, 64);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(185, 152);
            this.picClient.TabIndex = 9;
            this.picClient.TabStop = false;
            // 
            // cbxFonction
            // 
            this.cbxFonction.FormattingEnabled = true;
            this.cbxFonction.Location = new System.Drawing.Point(192, 440);
            this.cbxFonction.Name = "cbxFonction";
            this.cbxFonction.Size = new System.Drawing.Size(295, 28);
            this.cbxFonction.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(536, 491);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(639, 491);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 32);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmNouveauContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxFonction);
            this.Controls.Add(this.lblFonction);
            this.Controls.Add(this.lblSaisieExploitation);
            this.Controls.Add(this.lblExploitation);
            this.Controls.Add(this.lblSaisieClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.grpIdentite);
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
        private System.Windows.Forms.Label lblExploitation;
        private System.Windows.Forms.Label lblSaisieExploitation;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.ComboBox cbxFonction;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}