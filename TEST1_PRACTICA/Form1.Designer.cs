
namespace TEST1_PRACTICA
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
            this.components = new System.ComponentModel.Container();
            this.btAdaugare = new System.Windows.Forms.Button();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbAdaos = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAfisare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdaugare
            // 
            this.btAdaugare.Location = new System.Drawing.Point(205, 570);
            this.btAdaugare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdaugare.Name = "btAdaugare";
            this.btAdaugare.Size = new System.Drawing.Size(151, 63);
            this.btAdaugare.TabIndex = 0;
            this.btAdaugare.Text = "Adauga";
            this.btAdaugare.UseVisualStyleBackColor = true;
            this.btAdaugare.Click += new System.EventHandler(this.btAdaugare_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(214, 41);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(244, 26);
            this.tbDenumire.TabIndex = 1;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(214, 123);
            this.tbPret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(244, 26);
            this.tbPret.TabIndex = 2;
            // 
            // tbAdaos
            // 
            this.tbAdaos.Location = new System.Drawing.Point(214, 390);
            this.tbAdaos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdaos.Name = "tbAdaos";
            this.tbAdaos.Size = new System.Drawing.Size(244, 26);
            this.tbAdaos.TabIndex = 3;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(214, 215);
            this.tbCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(244, 26);
            this.tbCod.TabIndex = 4;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(214, 301);
            this.tbCantitate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(244, 26);
            this.tbCantitate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Denumire produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cod_de_bare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adaos";
            // 
            // btAfisare
            // 
            this.btAfisare.Location = new System.Drawing.Point(1162, 570);
            this.btAfisare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAfisare.Name = "btAfisare";
            this.btAfisare.Size = new System.Drawing.Size(117, 60);
            this.btAfisare.TabIndex = 11;
            this.btAfisare.Text = "Afiseaza Lista";
            this.btAfisare.UseVisualStyleBackColor = true;
            this.btAfisare.Click += new System.EventHandler(this.btAfisare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TEST1_PRACTICA.Properties.Resources.Groceries_ThinkstockPhotos_836782690;
            this.ClientSize = new System.Drawing.Size(1383, 704);
            this.Controls.Add(this.btAfisare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbAdaos);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.btAdaugare);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdaugare;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbAdaos;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAfisare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

