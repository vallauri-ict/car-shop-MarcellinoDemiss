﻿namespace WindowsFormsAppProject
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxVeicoli = new System.Windows.Forms.ListBox();
            this.nuovoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.eliminaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stampaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wordToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVeicoli
            // 
            this.listBoxVeicoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVeicoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVeicoli.FormattingEnabled = true;
            this.listBoxVeicoli.ItemHeight = 16;
            this.listBoxVeicoli.Location = new System.Drawing.Point(0, 25);
            this.listBoxVeicoli.Name = "listBoxVeicoli";
            this.listBoxVeicoli.Size = new System.Drawing.Size(499, 220);
            this.listBoxVeicoli.TabIndex = 0;
            // 
            // nuovoToolStripButton
            // 
            this.nuovoToolStripButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripButton.BackgroundImage")));
            this.nuovoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nuovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuovoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripButton.Image")));
            this.nuovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripButton.Name = "nuovoToolStripButton";
            this.nuovoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuovoToolStripButton.Text = "&Aggiungi veicolo";
            this.nuovoToolStripButton.Click += new System.EventHandler(this.nuovoToolStripButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripButton,
            this.eliminaToolStripButton,
            this.salvaToolStripButton,
            this.stampaToolStripButton,
            this.wordToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(499, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // eliminaToolStripButton
            // 
            this.eliminaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eliminaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminaToolStripButton.Image")));
            this.eliminaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminaToolStripButton.Name = "eliminaToolStripButton";
            this.eliminaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.eliminaToolStripButton.Text = "&Elimina veicolo";
            this.eliminaToolStripButton.Click += new System.EventHandler(this.eliminaToolStripButton_Click);
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvaToolStripButton.Text = "&Salva nel database";
            this.salvaToolStripButton.Click += new System.EventHandler(this.salvaToolStripButton_Click);
            // 
            // stampaToolStripButton
            // 
            this.stampaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stampaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripButton.Image")));
            this.stampaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripButton.Name = "stampaToolStripButton";
            this.stampaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stampaToolStripButton.Text = "&Apri il salone";
            this.stampaToolStripButton.Click += new System.EventHandler(this.stampaToolStripButton_Click);
            // 
            // wordToolStripButton
            // 
            this.wordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("wordToolStripButton.Image")));
            this.wordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wordToolStripButton.Name = "wordToolStripButton";
            this.wordToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.wordToolStripButton.Text = "toolStripButton1";
            this.wordToolStripButton.ToolTipText = "&Apri file in word";
            this.wordToolStripButton.Click += new System.EventHandler(this.wordToolStripButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 245);
            this.Controls.Add(this.listBoxVeicoli);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "SALONE VENDITA VEICOLI NUOVI E USATI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVeicoli;
        private System.Windows.Forms.ToolStripButton nuovoToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton eliminaToolStripButton;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton stampaToolStripButton;
        private System.Windows.Forms.ToolStripButton wordToolStripButton;
    }
}

