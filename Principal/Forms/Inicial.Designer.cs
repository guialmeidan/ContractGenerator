
namespace Principal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testemunhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeApprovedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tNIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarSugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Principal.Properties.Resources.TNA_Hubble___Logo_Grande;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.emitirDocumentoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.entidadeToolStripMenuItem,
            this.testemunhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Cadastros";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.PessoaToolStripMenuItem_Click);
            // 
            // entidadeToolStripMenuItem
            // 
            this.entidadeToolStripMenuItem.Name = "entidadeToolStripMenuItem";
            this.entidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entidadeToolStripMenuItem.Text = "Escritório";
            this.entidadeToolStripMenuItem.Click += new System.EventHandler(this.entidadeToolStripMenuItem_Click);
            // 
            // testemunhaToolStripMenuItem
            // 
            this.testemunhaToolStripMenuItem.Name = "testemunhaToolStripMenuItem";
            this.testemunhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testemunhaToolStripMenuItem.Text = "Testemunha";
            this.testemunhaToolStripMenuItem.Click += new System.EventHandler(this.testemunhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Token";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.tokenToolStripMenuItem_Click);
            // 
            // emitirDocumentoToolStripMenuItem
            // 
            this.emitirDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeApprovedToolStripMenuItem});
            this.emitirDocumentoToolStripMenuItem.Name = "emitirDocumentoToolStripMenuItem";
            this.emitirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.emitirDocumentoToolStripMenuItem.Text = "Approved";
            this.emitirDocumentoToolStripMenuItem.Click += new System.EventHandler(this.emitirDocumentoToolStripMenuItem_Click);
            // 
            // registroDeApprovedToolStripMenuItem
            // 
            this.registroDeApprovedToolStripMenuItem.Name = "registroDeApprovedToolStripMenuItem";
            this.registroDeApprovedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registroDeApprovedToolStripMenuItem.Text = "Registro de Approved";
            this.registroDeApprovedToolStripMenuItem.Click += new System.EventHandler(this.registroDeApprovedToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tNIDToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // tNIDToolStripMenuItem
            // 
            this.tNIDToolStripMenuItem.Name = "tNIDToolStripMenuItem";
            this.tNIDToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.tNIDToolStripMenuItem.Text = "TN ID";
            this.tNIDToolStripMenuItem.Click += new System.EventHandler(this.tNIDToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarSugestãoToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // enviarSugestãoToolStripMenuItem
            // 
            this.enviarSugestãoToolStripMenuItem.Name = "enviarSugestãoToolStripMenuItem";
            this.enviarSugestãoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.enviarSugestãoToolStripMenuItem.Text = "Enviar Sugestão";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tutorialToolStripMenuItem.Text = "Sobre o Software";
            // 
            // Principal
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundImageStore = global::Principal.Properties.Resources.TNA_Hubble___Logo_Grande;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerador de Contratos - TNA Hubble";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testemunhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarSugestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tNIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeApprovedToolStripMenuItem;
    }
}

