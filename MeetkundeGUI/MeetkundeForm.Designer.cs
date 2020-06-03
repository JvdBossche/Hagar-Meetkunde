namespace MeetkundeGUI
{
    partial class MeetkundeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.breedteVeld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lengteVeld = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diameterVeld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toevoegenRechthoek = new System.Windows.Forms.Button();
            this.figurenLijst = new System.Windows.Forms.ListBox();
            this.toevoegenCirkel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.naamVeld = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hoogteVeld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.basisVeld = new System.Windows.Forms.TextBox();
            this.toevoegenParallellogram = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.breedteVeld);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lengteVeld);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechthoek";
            // 
            // breedteVeld
            // 
            this.breedteVeld.Location = new System.Drawing.Point(9, 91);
            this.breedteVeld.Name = "breedteVeld";
            this.breedteVeld.Size = new System.Drawing.Size(100, 20);
            this.breedteVeld.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breedte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lengte";
            // 
            // lengteVeld
            // 
            this.lengteVeld.Location = new System.Drawing.Point(9, 39);
            this.lengteVeld.Name = "lengteVeld";
            this.lengteVeld.Size = new System.Drawing.Size(100, 20);
            this.lengteVeld.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diameterVeld);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(272, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cirkel";
            // 
            // diameterVeld
            // 
            this.diameterVeld.Location = new System.Drawing.Point(9, 39);
            this.diameterVeld.Name = "diameterVeld";
            this.diameterVeld.Size = new System.Drawing.Size(100, 20);
            this.diameterVeld.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diameter";
            // 
            // toevoegenRechthoek
            // 
            this.toevoegenRechthoek.Location = new System.Drawing.Point(12, 169);
            this.toevoegenRechthoek.Name = "toevoegenRechthoek";
            this.toevoegenRechthoek.Size = new System.Drawing.Size(124, 23);
            this.toevoegenRechthoek.TabIndex = 6;
            this.toevoegenRechthoek.Text = "Toevoegen";
            this.toevoegenRechthoek.UseVisualStyleBackColor = true;
            this.toevoegenRechthoek.Click += new System.EventHandler(this.toevoegenRechthoek_Click);
            // 
            // figurenLijst
            // 
            this.figurenLijst.FormattingEnabled = true;
            this.figurenLijst.Location = new System.Drawing.Point(11, 198);
            this.figurenLijst.Name = "figurenLijst";
            this.figurenLijst.Size = new System.Drawing.Size(385, 186);
            this.figurenLijst.TabIndex = 3;
            // 
            // toevoegenCirkel
            // 
            this.toevoegenCirkel.Location = new System.Drawing.Point(272, 169);
            this.toevoegenCirkel.Name = "toevoegenCirkel";
            this.toevoegenCirkel.Size = new System.Drawing.Size(124, 23);
            this.toevoegenCirkel.TabIndex = 8;
            this.toevoegenCirkel.Text = "Toevoegen";
            this.toevoegenCirkel.UseVisualStyleBackColor = true;
            this.toevoegenCirkel.Click += new System.EventHandler(this.toevoegenCirkel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Naam";
            // 
            // naamVeld
            // 
            this.naamVeld.Location = new System.Drawing.Point(68, 12);
            this.naamVeld.Name = "naamVeld";
            this.naamVeld.Size = new System.Drawing.Size(328, 20);
            this.naamVeld.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hoogteVeld);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.basisVeld);
            this.groupBox3.Location = new System.Drawing.Point(142, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parallellogram";
            // 
            // hoogteVeld
            // 
            this.hoogteVeld.Location = new System.Drawing.Point(9, 91);
            this.hoogteVeld.Name = "hoogteVeld";
            this.hoogteVeld.Size = new System.Drawing.Size(100, 20);
            this.hoogteVeld.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hoogte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Basis";
            // 
            // basisVeld
            // 
            this.basisVeld.Location = new System.Drawing.Point(9, 39);
            this.basisVeld.Name = "basisVeld";
            this.basisVeld.Size = new System.Drawing.Size(100, 20);
            this.basisVeld.TabIndex = 0;
            // 
            // toevoegenParallellogram
            // 
            this.toevoegenParallellogram.Location = new System.Drawing.Point(142, 169);
            this.toevoegenParallellogram.Name = "toevoegenParallellogram";
            this.toevoegenParallellogram.Size = new System.Drawing.Size(124, 23);
            this.toevoegenParallellogram.TabIndex = 7;
            this.toevoegenParallellogram.Text = "Toevoegen";
            this.toevoegenParallellogram.UseVisualStyleBackColor = true;
            this.toevoegenParallellogram.Click += new System.EventHandler(this.toevoegenParallellogram_Click);
            // 
            // MeetkundeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 403);
            this.Controls.Add(this.toevoegenParallellogram);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.naamVeld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toevoegenCirkel);
            this.Controls.Add(this.figurenLijst);
            this.Controls.Add(this.toevoegenRechthoek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MeetkundeForm";
            this.Text = "Meetkunde";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breedteVeld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengteVeld;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox diameterVeld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toevoegenRechthoek;
        private System.Windows.Forms.ListBox figurenLijst;
        private System.Windows.Forms.Button toevoegenCirkel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox naamVeld;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox hoogteVeld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox basisVeld;
        private System.Windows.Forms.Button toevoegenParallellogram;
    }
}

