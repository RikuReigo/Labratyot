namespace Muistipeli
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
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.restartGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconGameToolStripMenuItem,
            this.vehicleGameToolStripMenuItem,
            this.shapeGameToolStripMenuItem,
            this.sportGameToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // iconGameToolStripMenuItem
            // 
            this.iconGameToolStripMenuItem.Name = "iconGameToolStripMenuItem";
            this.iconGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iconGameToolStripMenuItem.Text = "Icon Game";
            this.iconGameToolStripMenuItem.Click += new System.EventHandler(this.iconGameToolStripMenuItem_Click);
            // 
            // vehicleGameToolStripMenuItem
            // 
            this.vehicleGameToolStripMenuItem.Name = "vehicleGameToolStripMenuItem";
            this.vehicleGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vehicleGameToolStripMenuItem.Text = "Vehicle Game";
            this.vehicleGameToolStripMenuItem.Click += new System.EventHandler(this.vehicleGameToolStripMenuItem_Click);
            // 
            // shapeGameToolStripMenuItem
            // 
            this.shapeGameToolStripMenuItem.Name = "shapeGameToolStripMenuItem";
            this.shapeGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shapeGameToolStripMenuItem.Text = "Shape Game";
            this.shapeGameToolStripMenuItem.Click += new System.EventHandler(this.shapeGameToolStripMenuItem_Click);
            // 
            // sportGameToolStripMenuItem
            // 
            this.sportGameToolStripMenuItem.Name = "sportGameToolStripMenuItem";
            this.sportGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sportGameToolStripMenuItem.Text = "Building Game";
            this.sportGameToolStripMenuItem.Click += new System.EventHandler(this.sportGameToolStripMenuItem_Click);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 502);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

