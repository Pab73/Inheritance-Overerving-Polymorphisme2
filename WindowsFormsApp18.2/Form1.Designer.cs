
namespace WindowsFormsApp18._2
{
    partial class Form1
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
            this.lblDieren = new System.Windows.Forms.Label();
            this.rbtnKat = new System.Windows.Forms.RadioButton();
            this.rbtnPapegaai = new System.Windows.Forms.RadioButton();
            this.rbtnMens = new System.Windows.Forms.RadioButton();
            this.lblGeefNaam = new System.Windows.Forms.Label();
            this.txtNaamDier = new System.Windows.Forms.TextBox();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.lbKiesZin = new System.Windows.Forms.ListBox();
            this.lblKiesZin = new System.Windows.Forms.Label();
            this.btnPraten = new System.Windows.Forms.Button();
            this.btnStrelen = new System.Windows.Forms.Button();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDieren
            // 
            this.lblDieren.AutoSize = true;
            this.lblDieren.Location = new System.Drawing.Point(12, 41);
            this.lblDieren.Name = "lblDieren";
            this.lblDieren.Size = new System.Drawing.Size(63, 21);
            this.lblDieren.TabIndex = 0;
            this.lblDieren.Text = "Dieren";
            // 
            // rbtnKat
            // 
            this.rbtnKat.AutoSize = true;
            this.rbtnKat.Location = new System.Drawing.Point(12, 65);
            this.rbtnKat.Name = "rbtnKat";
            this.rbtnKat.Size = new System.Drawing.Size(50, 21);
            this.rbtnKat.TabIndex = 1;
            this.rbtnKat.TabStop = true;
            this.rbtnKat.Text = "Kat";
            this.rbtnKat.UseVisualStyleBackColor = true;
            // 
            // rbtnPapegaai
            // 
            this.rbtnPapegaai.AutoSize = true;
            this.rbtnPapegaai.Location = new System.Drawing.Point(15, 102);
            this.rbtnPapegaai.Name = "rbtnPapegaai";
            this.rbtnPapegaai.Size = new System.Drawing.Size(89, 21);
            this.rbtnPapegaai.TabIndex = 2;
            this.rbtnPapegaai.TabStop = true;
            this.rbtnPapegaai.Text = "Papegaai";
            this.rbtnPapegaai.UseVisualStyleBackColor = true;
            // 
            // rbtnMens
            // 
            this.rbtnMens.AutoSize = true;
            this.rbtnMens.Location = new System.Drawing.Point(15, 139);
            this.rbtnMens.Name = "rbtnMens";
            this.rbtnMens.Size = new System.Drawing.Size(63, 21);
            this.rbtnMens.TabIndex = 3;
            this.rbtnMens.TabStop = true;
            this.rbtnMens.Text = "Mens";
            this.rbtnMens.UseVisualStyleBackColor = true;
            // 
            // lblGeefNaam
            // 
            this.lblGeefNaam.AutoSize = true;
            this.lblGeefNaam.Location = new System.Drawing.Point(259, 9);
            this.lblGeefNaam.Name = "lblGeefNaam";
            this.lblGeefNaam.Size = new System.Drawing.Size(204, 21);
            this.lblGeefNaam.TabIndex = 4;
            this.lblGeefNaam.Text = "Geef je \"dier\" een naam.";
            // 
            // txtNaamDier
            // 
            this.txtNaamDier.Location = new System.Drawing.Point(252, 38);
            this.txtNaamDier.Name = "txtNaamDier";
            this.txtNaamDier.Size = new System.Drawing.Size(173, 22);
            this.txtNaamDier.TabIndex = 5;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(566, 37);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(203, 71);
            this.btnAanmaken.TabIndex = 6;
            this.btnAanmaken.Text = "Anmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // lbKiesZin
            // 
            this.lbKiesZin.FormattingEnabled = true;
            this.lbKiesZin.ItemHeight = 16;
            this.lbKiesZin.Location = new System.Drawing.Point(15, 224);
            this.lbKiesZin.Name = "lbKiesZin";
            this.lbKiesZin.Size = new System.Drawing.Size(211, 84);
            this.lbKiesZin.TabIndex = 7;
            // 
            // lblKiesZin
            // 
            this.lblKiesZin.AutoSize = true;
            this.lblKiesZin.Location = new System.Drawing.Point(12, 192);
            this.lblKiesZin.Name = "lblKiesZin";
            this.lblKiesZin.Size = new System.Drawing.Size(240, 21);
            this.lblKiesZin.TabIndex = 8;
            this.lblKiesZin.Text = "Kies een zin uit om te praten:";
            // 
            // btnPraten
            // 
            this.btnPraten.Location = new System.Drawing.Point(390, 237);
            this.btnPraten.Name = "btnPraten";
            this.btnPraten.Size = new System.Drawing.Size(203, 71);
            this.btnPraten.TabIndex = 9;
            this.btnPraten.Text = "Praten";
            this.btnPraten.UseVisualStyleBackColor = true;
            this.btnPraten.Click += new System.EventHandler(this.btnPraten_Click);
            // 
            // btnStrelen
            // 
            this.btnStrelen.Location = new System.Drawing.Point(49, 392);
            this.btnStrelen.Name = "btnStrelen";
            this.btnStrelen.Size = new System.Drawing.Size(203, 71);
            this.btnStrelen.TabIndex = 10;
            this.btnStrelen.Text = "Strelen";
            this.btnStrelen.UseVisualStyleBackColor = true;
            this.btnStrelen.Click += new System.EventHandler(this.btnStrelen_Click);
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(310, 392);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(203, 71);
            this.btnEten.TabIndex = 11;
            this.btnEten.Text = "Eten";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(566, 392);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(203, 71);
            this.btnSluiten.TabIndex = 12;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.btnStrelen);
            this.Controls.Add(this.btnPraten);
            this.Controls.Add(this.lblKiesZin);
            this.Controls.Add(this.lbKiesZin);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.txtNaamDier);
            this.Controls.Add(this.lblGeefNaam);
            this.Controls.Add(this.rbtnMens);
            this.Controls.Add(this.rbtnPapegaai);
            this.Controls.Add(this.rbtnKat);
            this.Controls.Add(this.lblDieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDieren;
        private System.Windows.Forms.RadioButton rbtnKat;
        private System.Windows.Forms.RadioButton rbtnPapegaai;
        private System.Windows.Forms.RadioButton rbtnMens;
        private System.Windows.Forms.Label lblGeefNaam;
        private System.Windows.Forms.TextBox txtNaamDier;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.ListBox lbKiesZin;
        private System.Windows.Forms.Label lblKiesZin;
        private System.Windows.Forms.Button btnPraten;
        private System.Windows.Forms.Button btnStrelen;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnSluiten;
    }
}

