namespace Act15Oct
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rombiodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.polToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.rectanguloToolStripMenuItem,
            this.trianguloToolStripMenuItem,
            this.romboToolStripMenuItem,
            this.rombiodeToolStripMenuItem,
            this.trapecioToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.polToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.rectanguloToolStripMenuItem_Click);
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click);
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.romboToolStripMenuItem.Text = "Rombo";
            this.romboToolStripMenuItem.Click += new System.EventHandler(this.romboToolStripMenuItem_Click);
            // 
            // rombiodeToolStripMenuItem
            // 
            this.rombiodeToolStripMenuItem.Name = "rombiodeToolStripMenuItem";
            this.rombiodeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rombiodeToolStripMenuItem.Text = "Rombiode";
            this.rombiodeToolStripMenuItem.Click += new System.EventHandler(this.rombiodeToolStripMenuItem_Click);
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.trapecioToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // polToolStripMenuItem
            // 
            this.polToolStripMenuItem.Name = "polToolStripMenuItem";
            this.polToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.polToolStripMenuItem.Text = "Polígono";
            this.polToolStripMenuItem.Click += new System.EventHandler(this.polToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 703);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rombiodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polToolStripMenuItem;
    }
}

