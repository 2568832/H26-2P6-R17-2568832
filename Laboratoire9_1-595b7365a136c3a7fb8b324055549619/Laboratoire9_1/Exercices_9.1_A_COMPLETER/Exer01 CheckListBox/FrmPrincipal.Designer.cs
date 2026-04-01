namespace Exemple_CheckListBox
{
    partial class FrmPrincipal
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
            this.clbFruitsEtLegumes = new System.Windows.Forms.CheckedListBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.lblNbItems = new System.Windows.Forms.Label();
            this.btnVisualiserItems = new System.Windows.Forms.Button();
            this.btnCocherIndexPair = new System.Windows.Forms.Button();
            this.btnDécocherTout = new System.Windows.Forms.Button();
            this.btnCocherTout = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbFruitsEtLegumes
            // 
            this.clbFruitsEtLegumes.CheckOnClick = true;
            this.clbFruitsEtLegumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbFruitsEtLegumes.FormattingEnabled = true;
            this.clbFruitsEtLegumes.Location = new System.Drawing.Point(16, 55);
            this.clbFruitsEtLegumes.Margin = new System.Windows.Forms.Padding(4);
            this.clbFruitsEtLegumes.Name = "clbFruitsEtLegumes";
            this.clbFruitsEtLegumes.Size = new System.Drawing.Size(235, 254);
            this.clbFruitsEtLegumes.TabIndex = 0;
            this.clbFruitsEtLegumes.SelectedIndexChanged += new System.EventHandler(this.ClbFruitsEtLegumes_SelectedIndexChanged);
            this.clbFruitsEtLegumes.DoubleClick += new System.EventHandler(this.ClbFruitsEtLegumes_SelectedIndexChanged);
            // 
            // txtValeur
            // 
            this.txtValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.Location = new System.Drawing.Point(188, 15);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.ReadOnly = true;
            this.txtValeur.Size = new System.Drawing.Size(53, 30);
            this.txtValeur.TabIndex = 1;
            this.txtValeur.Text = "0";
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNbItems
            // 
            this.lblNbItems.AutoSize = true;
            this.lblNbItems.Location = new System.Drawing.Point(16, 25);
            this.lblNbItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbItems.Name = "lblNbItems";
            this.lblNbItems.Size = new System.Drawing.Size(155, 16);
            this.lblNbItems.TabIndex = 2;
            this.lblNbItems.Text = "Nombre d\'items cochés :";
            // 
            // btnVisualiserItems
            // 
            this.btnVisualiserItems.Location = new System.Drawing.Point(276, 251);
            this.btnVisualiserItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualiserItems.Name = "btnVisualiserItems";
            this.btnVisualiserItems.Size = new System.Drawing.Size(471, 34);
            this.btnVisualiserItems.TabIndex = 3;
            this.btnVisualiserItems.Text = "Afficher une liste des items cochés...";
            this.btnVisualiserItems.UseVisualStyleBackColor = true;
            this.btnVisualiserItems.Click += new System.EventHandler(this.BtnVisualiserItems_Click);
            // 
            // btnCocherIndexPair
            // 
            this.btnCocherIndexPair.Location = new System.Drawing.Point(273, 153);
            this.btnCocherIndexPair.Margin = new System.Windows.Forms.Padding(4);
            this.btnCocherIndexPair.Name = "btnCocherIndexPair";
            this.btnCocherIndexPair.Size = new System.Drawing.Size(471, 34);
            this.btnCocherIndexPair.TabIndex = 4;
            this.btnCocherIndexPair.Text = "Cocher les items ayant un index pair";
            this.btnCocherIndexPair.UseVisualStyleBackColor = true;
            this.btnCocherIndexPair.Click += new System.EventHandler(this.BtnCocherIndexPair_Click);
            // 
            // btnDécocherTout
            // 
            this.btnDécocherTout.Location = new System.Drawing.Point(273, 104);
            this.btnDécocherTout.Margin = new System.Windows.Forms.Padding(4);
            this.btnDécocherTout.Name = "btnDécocherTout";
            this.btnDécocherTout.Size = new System.Drawing.Size(471, 34);
            this.btnDécocherTout.TabIndex = 6;
            this.btnDécocherTout.Text = "Décocher tout";
            this.btnDécocherTout.UseVisualStyleBackColor = true;
            this.btnDécocherTout.Click += new System.EventHandler(this.BtnDécocherTout_Click);
            // 
            // btnCocherTout
            // 
            this.btnCocherTout.Location = new System.Drawing.Point(273, 55);
            this.btnCocherTout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCocherTout.Name = "btnCocherTout";
            this.btnCocherTout.Size = new System.Drawing.Size(471, 34);
            this.btnCocherTout.TabIndex = 7;
            this.btnCocherTout.Text = "Cocher tout";
            this.btnCocherTout.UseVisualStyleBackColor = true;
            this.btnCocherTout.Click += new System.EventHandler(this.BtnCocherTout_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(276, 202);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(471, 34);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer les items cochés";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnVisualiserItems;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 336);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCocherTout);
            this.Controls.Add(this.btnDécocherTout);
            this.Controls.Add(this.btnCocherIndexPair);
            this.Controls.Add(this.btnVisualiserItems);
            this.Controls.Add(this.lblNbItems);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.clbFruitsEtLegumes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J\'aime les fruits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFruitsEtLegumes;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Label lblNbItems;
        private System.Windows.Forms.Button btnVisualiserItems;
        private System.Windows.Forms.Button btnCocherIndexPair;
        private System.Windows.Forms.Button btnDécocherTout;
        private System.Windows.Forms.Button btnCocherTout;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

