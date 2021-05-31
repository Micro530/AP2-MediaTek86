
namespace AP2_MediaTek86.vue
{
    partial class FrmPersonnel
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
            this.zoneAjout = new System.Windows.Forms.GroupBox();
            this.btnZ2Annuler = new System.Windows.Forms.Button();
            this.btnZ2Enregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.zonePers = new System.Windows.Forms.GroupBox();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btsAjouter = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.zoneAjout.SuspendLayout();
            this.zonePers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // zoneAjout
            // 
            this.zoneAjout.Controls.Add(this.btnZ2Annuler);
            this.zoneAjout.Controls.Add(this.btnZ2Enregistrer);
            this.zoneAjout.Controls.Add(this.label5);
            this.zoneAjout.Controls.Add(this.label4);
            this.zoneAjout.Controls.Add(this.label3);
            this.zoneAjout.Controls.Add(this.label2);
            this.zoneAjout.Controls.Add(this.label1);
            this.zoneAjout.Controls.Add(this.comboService);
            this.zoneAjout.Controls.Add(this.txtTel);
            this.zoneAjout.Controls.Add(this.txtMail);
            this.zoneAjout.Controls.Add(this.txtPrenom);
            this.zoneAjout.Controls.Add(this.txtNom);
            this.zoneAjout.Location = new System.Drawing.Point(6, 258);
            this.zoneAjout.Name = "zoneAjout";
            this.zoneAjout.Size = new System.Drawing.Size(632, 148);
            this.zoneAjout.TabIndex = 6;
            this.zoneAjout.TabStop = false;
            this.zoneAjout.Text = "Ajouter un membre aux personnels";
            // 
            // btnZ2Annuler
            // 
            this.btnZ2Annuler.Location = new System.Drawing.Point(478, 113);
            this.btnZ2Annuler.Name = "btnZ2Annuler";
            this.btnZ2Annuler.Size = new System.Drawing.Size(75, 23);
            this.btnZ2Annuler.TabIndex = 10;
            this.btnZ2Annuler.Text = "Annuler";
            this.btnZ2Annuler.UseVisualStyleBackColor = true;
            // 
            // btnZ2Enregistrer
            // 
            this.btnZ2Enregistrer.Location = new System.Drawing.Point(383, 113);
            this.btnZ2Enregistrer.Name = "btnZ2Enregistrer";
            this.btnZ2Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnZ2Enregistrer.TabIndex = 4;
            this.btnZ2Enregistrer.Text = "Enregistrer";
            this.btnZ2Enregistrer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Service :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom :";
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(76, 115);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(151, 21);
            this.comboService.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(382, 75);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(151, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(382, 30);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 20);
            this.txtMail.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(76, 75);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(218, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(76, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(218, 20);
            this.txtNom.TabIndex = 0;
            // 
            // zonePers
            // 
            this.zonePers.Controls.Add(this.btnAbsence);
            this.zonePers.Controls.Add(this.btsAjouter);
            this.zonePers.Controls.Add(this.btnSup);
            this.zonePers.Controls.Add(this.btnModifier);
            this.zonePers.Controls.Add(this.dgvPersonnel);
            this.zonePers.Location = new System.Drawing.Point(6, 5);
            this.zonePers.Name = "zonePers";
            this.zonePers.Size = new System.Drawing.Size(632, 247);
            this.zonePers.TabIndex = 5;
            this.zonePers.TabStop = false;
            this.zonePers.Text = "Le personnel";
            this.zonePers.Enter += new System.EventHandler(this.zone1Dev_Enter);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(478, 216);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(134, 23);
            this.btnAbsence.TabIndex = 4;
            this.btnAbsence.Text = "Gestion des Absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // btsAjouter
            // 
            this.btsAjouter.Location = new System.Drawing.Point(9, 216);
            this.btsAjouter.Name = "btsAjouter";
            this.btsAjouter.Size = new System.Drawing.Size(75, 23);
            this.btsAjouter.TabIndex = 3;
            this.btsAjouter.Text = "Ajouter";
            this.btsAjouter.UseVisualStyleBackColor = true;
            this.btsAjouter.Click += new System.EventHandler(this.btsAjouter_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(199, 216);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(75, 23);
            this.btnSup.TabIndex = 2;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(104, 216);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(620, 191);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 419);
            this.Controls.Add(this.zoneAjout);
            this.Controls.Add(this.zonePers);
            this.Name = "FrmPersonnel";
            this.Text = "Form1";
            this.zoneAjout.ResumeLayout(false);
            this.zoneAjout.PerformLayout();
            this.zonePers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox zoneAjout;
        private System.Windows.Forms.Button btnZ2Annuler;
        private System.Windows.Forms.Button btnZ2Enregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox zonePers;
        private System.Windows.Forms.Button btsAjouter;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAbsence;
    }
}

