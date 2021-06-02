
namespace AP2_MediaTek86.vue
{
    partial class FrmAbsences
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
            this.btnRetourPersonnel = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnZ2Annuler = new System.Windows.Forms.Button();
            this.btnZ2Enregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btsAjouter = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.comboMotif = new System.Windows.Forms.ComboBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.zoneAjout = new System.Windows.Forms.GroupBox();
            this.calendrierFin = new System.Windows.Forms.DateTimePicker();
            this.calendrierDebut = new System.Windows.Forms.DateTimePicker();
            this.zoneAbsence = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.zoneAjout.SuspendLayout();
            this.zoneAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetourPersonnel
            // 
            this.btnRetourPersonnel.Location = new System.Drawing.Point(478, 216);
            this.btnRetourPersonnel.Name = "btnRetourPersonnel";
            this.btnRetourPersonnel.Size = new System.Drawing.Size(134, 23);
            this.btnRetourPersonnel.TabIndex = 4;
            this.btnRetourPersonnel.Text = "Retour aux personnels";
            this.btnRetourPersonnel.UseVisualStyleBackColor = true;
            this.btnRetourPersonnel.Click += new System.EventHandler(this.btnRetourPersonnel_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(104, 216);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnZ2Annuler
            // 
            this.btnZ2Annuler.Location = new System.Drawing.Point(478, 98);
            this.btnZ2Annuler.Name = "btnZ2Annuler";
            this.btnZ2Annuler.Size = new System.Drawing.Size(75, 23);
            this.btnZ2Annuler.TabIndex = 10;
            this.btnZ2Annuler.Text = "Annuler";
            this.btnZ2Annuler.UseVisualStyleBackColor = true;
            this.btnZ2Annuler.Click += new System.EventHandler(this.btnZ2Annuler_Click);
            // 
            // btnZ2Enregistrer
            // 
            this.btnZ2Enregistrer.Location = new System.Drawing.Point(383, 98);
            this.btnZ2Enregistrer.Name = "btnZ2Enregistrer";
            this.btnZ2Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnZ2Enregistrer.TabIndex = 4;
            this.btnZ2Enregistrer.Text = "Enregistrer";
            this.btnZ2Enregistrer.UseVisualStyleBackColor = true;
            this.btnZ2Enregistrer.Click += new System.EventHandler(this.btnZ2Enregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motif :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date de fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date de début :";
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
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // comboMotif
            // 
            this.comboMotif.FormattingEnabled = true;
            this.comboMotif.Location = new System.Drawing.Point(97, 100);
            this.comboMotif.Name = "comboMotif";
            this.comboMotif.Size = new System.Drawing.Size(151, 21);
            this.comboMotif.TabIndex = 4;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(620, 191);
            this.dgvAbsences.TabIndex = 0;
            // 
            // zoneAjout
            // 
            this.zoneAjout.Controls.Add(this.calendrierFin);
            this.zoneAjout.Controls.Add(this.calendrierDebut);
            this.zoneAjout.Controls.Add(this.btnZ2Annuler);
            this.zoneAjout.Controls.Add(this.btnZ2Enregistrer);
            this.zoneAjout.Controls.Add(this.label5);
            this.zoneAjout.Controls.Add(this.label4);
            this.zoneAjout.Controls.Add(this.label1);
            this.zoneAjout.Controls.Add(this.comboMotif);
            this.zoneAjout.Location = new System.Drawing.Point(2, 254);
            this.zoneAjout.Name = "zoneAjout";
            this.zoneAjout.Size = new System.Drawing.Size(632, 142);
            this.zoneAjout.TabIndex = 8;
            this.zoneAjout.TabStop = false;
            this.zoneAjout.Text = "Ajouter une Absence";
            // 
            // calendrierFin
            // 
            this.calendrierFin.Location = new System.Drawing.Point(399, 48);
            this.calendrierFin.Name = "calendrierFin";
            this.calendrierFin.Size = new System.Drawing.Size(200, 20);
            this.calendrierFin.TabIndex = 13;
            // 
            // calendrierDebut
            // 
            this.calendrierDebut.Location = new System.Drawing.Point(97, 48);
            this.calendrierDebut.Name = "calendrierDebut";
            this.calendrierDebut.Size = new System.Drawing.Size(200, 20);
            this.calendrierDebut.TabIndex = 12;
            // 
            // zoneAbsence
            // 
            this.zoneAbsence.Controls.Add(this.btnRetourPersonnel);
            this.zoneAbsence.Controls.Add(this.btsAjouter);
            this.zoneAbsence.Controls.Add(this.btnSup);
            this.zoneAbsence.Controls.Add(this.btnModifier);
            this.zoneAbsence.Controls.Add(this.dgvAbsences);
            this.zoneAbsence.Location = new System.Drawing.Point(2, 1);
            this.zoneAbsence.Name = "zoneAbsence";
            this.zoneAbsence.Size = new System.Drawing.Size(632, 247);
            this.zoneAbsence.TabIndex = 7;
            this.zoneAbsence.TabStop = false;
            this.zoneAbsence.Text = "Absences du personnel";
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.Controls.Add(this.zoneAjout);
            this.Controls.Add(this.zoneAbsence);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.zoneAjout.ResumeLayout(false);
            this.zoneAjout.PerformLayout();
            this.zoneAbsence.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetourPersonnel;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnZ2Annuler;
        private System.Windows.Forms.Button btnZ2Enregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsAjouter;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.ComboBox comboMotif;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox zoneAjout;
        private System.Windows.Forms.GroupBox zoneAbsence;
        private System.Windows.Forms.DateTimePicker calendrierDebut;
        private System.Windows.Forms.DateTimePicker calendrierFin;
    }
}