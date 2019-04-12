namespace VerschillendeFunctiesVan1Form
{
    partial class VerwerkingsForm
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
            this.btnActie = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.cmbSelecteren = new System.Windows.Forms.ComboBox();
            this.lblSelecteren = new System.Windows.Forms.Label();
            this.lblIngeven = new System.Windows.Forms.Label();
            this.txtIngeven = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActie
            // 
            this.btnActie.Location = new System.Drawing.Point(154, 172);
            this.btnActie.Name = "btnActie";
            this.btnActie.Size = new System.Drawing.Size(75, 23);
            this.btnActie.TabIndex = 0;
            this.btnActie.Text = "Actie";
            this.btnActie.UseVisualStyleBackColor = true;
            this.btnActie.Click += new System.EventHandler(this.btnActie_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(394, 172);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // cmbSelecteren
            // 
            this.cmbSelecteren.FormattingEnabled = true;
            this.cmbSelecteren.Location = new System.Drawing.Point(295, 32);
            this.cmbSelecteren.Name = "cmbSelecteren";
            this.cmbSelecteren.Size = new System.Drawing.Size(202, 21);
            this.cmbSelecteren.TabIndex = 2;
            // 
            // lblSelecteren
            // 
            this.lblSelecteren.AutoSize = true;
            this.lblSelecteren.Location = new System.Drawing.Point(151, 40);
            this.lblSelecteren.Name = "lblSelecteren";
            this.lblSelecteren.Size = new System.Drawing.Size(138, 13);
            this.lblSelecteren.TabIndex = 3;
            this.lblSelecteren.Text = "Als je iets moet selecteren : ";
            // 
            // lblIngeven
            // 
            this.lblIngeven.AutoSize = true;
            this.lblIngeven.Location = new System.Drawing.Point(154, 105);
            this.lblIngeven.Name = "lblIngeven";
            this.lblIngeven.Size = new System.Drawing.Size(118, 13);
            this.lblIngeven.TabIndex = 4;
            this.lblIngeven.Text = "Als je iets moet ingeven";
            // 
            // txtIngeven
            // 
            this.txtIngeven.Location = new System.Drawing.Point(295, 98);
            this.txtIngeven.Name = "txtIngeven";
            this.txtIngeven.Size = new System.Drawing.Size(202, 20);
            this.txtIngeven.TabIndex = 5;
            // 
            // VerwerkingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIngeven);
            this.Controls.Add(this.lblIngeven);
            this.Controls.Add(this.lblSelecteren);
            this.Controls.Add(this.cmbSelecteren);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnActie);
            this.Name = "VerwerkingsForm";
            this.Text = "VerwerkingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActie;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ComboBox cmbSelecteren;
        private System.Windows.Forms.Label lblSelecteren;
        private System.Windows.Forms.Label lblIngeven;
        private System.Windows.Forms.TextBox txtIngeven;
    }
}