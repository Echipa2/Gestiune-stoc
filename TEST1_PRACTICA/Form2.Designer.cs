
namespace TEST1_PRACTICA
{
    partial class Form2
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
            this.tbProduse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvare = new System.Windows.Forms.Button();
            this.btCitire = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btBaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProduse
            // 
            this.tbProduse.Location = new System.Drawing.Point(23, 70);
            this.tbProduse.Multiline = true;
            this.tbProduse.Name = "tbProduse";
            this.tbProduse.ReadOnly = true;
            this.tbProduse.Size = new System.Drawing.Size(729, 223);
            this.tbProduse.TabIndex = 0;
            this.tbProduse.TextChanged += new System.EventHandler(this.tbProduse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adaos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cod De Bare";
            // 
            // btSalvare
            // 
            this.btSalvare.Location = new System.Drawing.Point(67, 337);
            this.btSalvare.Name = "btSalvare";
            this.btSalvare.Size = new System.Drawing.Size(94, 48);
            this.btSalvare.TabIndex = 6;
            this.btSalvare.Text = "Salvare Text";
            this.btSalvare.UseVisualStyleBackColor = true;
            this.btSalvare.Click += new System.EventHandler(this.btSalvare_Click);
            // 
            // btCitire
            // 
            this.btCitire.Location = new System.Drawing.Point(208, 337);
            this.btCitire.Name = "btCitire";
            this.btCitire.Size = new System.Drawing.Size(88, 48);
            this.btCitire.TabIndex = 7;
            this.btCitire.Text = "Citire Fisier";
            this.btCitire.UseVisualStyleBackColor = true;
            this.btCitire.Click += new System.EventHandler(this.btCitire_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // btBaza
            // 
            this.btBaza.Location = new System.Drawing.Point(515, 337);
            this.btBaza.Name = "btBaza";
            this.btBaza.Size = new System.Drawing.Size(91, 48);
            this.btBaza.TabIndex = 11;
            this.btBaza.Text = "Baza de date";
            this.btBaza.UseVisualStyleBackColor = true;
            this.btBaza.Click += new System.EventHandler(this.btBaza_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.btBaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCitire);
            this.Controls.Add(this.btSalvare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProduse);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProduse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvare;
        private System.Windows.Forms.Button btCitire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBaza;
    }
}