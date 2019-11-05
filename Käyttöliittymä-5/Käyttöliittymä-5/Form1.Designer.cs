namespace Käyttöliittymä_5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.arraynluonti = new System.Windows.Forms.NumericUpDown();
            this.tallennettavanum = new System.Windows.Forms.NumericUpDown();
            this.tallennuspaik = new System.Windows.Forms.NumericUpDown();
            this.Etsintänum = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tallenna = new System.Windows.Forms.Button();
            this.Etsi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraynluonti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallennettavanum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallennuspaik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Etsintänum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(236, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taulukon Luonti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taulukon Koko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(236, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tallennus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tallennettava Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tallennuspaikan indeksi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(236, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Haku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tallennuspaikan indeksi";
            // 
            // arraynluonti
            // 
            this.arraynluonti.Location = new System.Drawing.Point(240, 125);
            this.arraynluonti.Name = "arraynluonti";
            this.arraynluonti.Size = new System.Drawing.Size(120, 26);
            this.arraynluonti.TabIndex = 8;
            // 
            // tallennettavanum
            // 
            this.tallennettavanum.Location = new System.Drawing.Point(240, 227);
            this.tallennettavanum.Name = "tallennettavanum";
            this.tallennettavanum.Size = new System.Drawing.Size(120, 26);
            this.tallennettavanum.TabIndex = 9;
            // 
            // tallennuspaik
            // 
            this.tallennuspaik.Location = new System.Drawing.Point(240, 274);
            this.tallennuspaik.Name = "tallennuspaik";
            this.tallennuspaik.Size = new System.Drawing.Size(120, 26);
            this.tallennuspaik.TabIndex = 10;
            // 
            // Etsintänum
            // 
            this.Etsintänum.Location = new System.Drawing.Point(240, 393);
            this.Etsintänum.Name = "Etsintänum";
            this.Etsintänum.Size = new System.Drawing.Size(120, 26);
            this.Etsintänum.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(240, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "Luo Taulukko";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tallenna
            // 
            this.Tallenna.Location = new System.Drawing.Point(409, 242);
            this.Tallenna.Name = "Tallenna";
            this.Tallenna.Size = new System.Drawing.Size(99, 58);
            this.Tallenna.TabIndex = 14;
            this.Tallenna.Text = "Tallenna";
            this.Tallenna.UseVisualStyleBackColor = true;
            this.Tallenna.Click += new System.EventHandler(this.Tallenna_Click);
            // 
            // Etsi
            // 
            this.Etsi.Location = new System.Drawing.Point(409, 394);
            this.Etsi.Name = "Etsi";
            this.Etsi.Size = new System.Drawing.Size(99, 58);
            this.Etsi.TabIndex = 15;
            this.Etsi.Text = "Hae";
            this.Etsi.UseVisualStyleBackColor = true;
            this.Etsi.Click += new System.EventHandler(this.Etsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 480);
            this.Controls.Add(this.Etsi);
            this.Controls.Add(this.Tallenna);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Etsintänum);
            this.Controls.Add(this.tallennuspaik);
            this.Controls.Add(this.tallennettavanum);
            this.Controls.Add(this.arraynluonti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraynluonti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallennettavanum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallennuspaik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Etsintänum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown arraynluonti;
        private System.Windows.Forms.NumericUpDown tallennettavanum;
        private System.Windows.Forms.NumericUpDown tallennuspaik;
        private System.Windows.Forms.NumericUpDown Etsintänum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Tallenna;
        private System.Windows.Forms.Button Etsi;
    }
}

